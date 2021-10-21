using ApplicationCore.DTOs.Projects.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Projects
{
    public interface IProjectService
    {
        Task Create(CreateOrEditProjectDto input);
    }
}
