using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ApplicationCore.Interfaces.Projects;
using ApplicationCore.DTOs.Projects.Dto;
using ApplicationCore.DTOs.Projects;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
    }
}
