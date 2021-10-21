using ApplicationCore.Entities;
using ApplicationCore.DTOs.Projects.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public  class CustomDtoMapper : Profile
    {
        public CustomDtoMapper()
        {
            CreateMap<CreateOrEditProjectDto, Project>().ReverseMap();
        }
    }
}
