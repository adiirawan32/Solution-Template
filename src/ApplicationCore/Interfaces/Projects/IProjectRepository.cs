using ApplicationCore.DTOs.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Projects
{
    public interface IProjectRepository
    {
        Task<List<GetProjectDto>> GetAll();
    }
}
