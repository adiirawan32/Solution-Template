using ApplicationCore.Interfaces.Projects;
using ApplicationCore.DTOs.Projects.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Services.Projects;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IProjectService _projectService;
        public ProjectController(IProjectRepository projectRepository, IProjectService projectService)
        {
            _projectRepository = projectRepository;
            _projectService = projectService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrEditProjectDto input)
        {                      
            await _projectService.Create(input);
            return Ok();

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _projectRepository.GetAll();
            return Ok(result);

        }
    }
}
