using ApplicationCore.DTOs.Projects;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Projects
{
    public class ProjectService : IProjectService
    {
        private IAsyncRepository<Project> _projectService;
        private readonly IMapper _mapper;
        public ProjectService(IAsyncRepository<Project> projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        public async Task Create(CreateOrEditProjectDto input)
        {
            var project = _mapper.Map<Project>(input);
            await _projectService.AddAsync(project);
        }
    }
}
