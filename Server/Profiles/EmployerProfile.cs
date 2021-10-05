using AutoMapper;
using Softline.DTO;
using Softline.Models;

namespace Softline.Profiles
{
    public class EmployerProfile : Profile
    {
        public EmployerProfile()
        {
            //откуда -> куда
            CreateMap<Employer, EmployerReadDto>();
            CreateMap<EmployerCreateDto, Employer>();
            CreateMap<EmployerUpdateDto, Employer>();
            CreateMap<Employer, EmployerUpdateDto>();
        }
    }

}