using ApplicationCore;
using ApplicationCore.DTOs.Projects;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Projects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Projects
{
    public class ProjectRepository : EfRepository<Project>, IProjectRepository
    {        
        private readonly IMapper _mapper;
        public ProjectRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {         
            _mapper = mapper;
        }

        public async Task<List<GetProjectDto>> GetAll()
        {
            var project = (from o in _dbContext.Projects
                          select new GetProjectDto()
                          {
                              Id = o.Id,
                              Name = o.Name,
                              Description = o.Description
                          }).ToListAsync();

            return await project;

        }

        public async Task<PaginatedListResponse<GetAllProjectForViewDto>> GetAllWithPaging(GetAllProjectInput input)
        {
            var filteredProject = _dbContext.Projects
                                  .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Name.Contains(input.Filter) || e.Description.Contains(input.Filter));

            var project = from o in filteredProject

                          select new GetAllProjectForViewDto
                          {
                              Project = new ProjectDto
                              {
                                  Id = o.Id,
                                  Name = o.Name,
                                  Description = o.Description,
                              }
                          };


            var result = await project.ToPaginatedListAsync(input.PageNumber, input.PageSize);

            return result.ToPaginatedListResponse();

        }
    }
}
