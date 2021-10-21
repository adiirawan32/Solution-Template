using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.DTOs.Projects
{
    public class CreateOrEditProjectDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
