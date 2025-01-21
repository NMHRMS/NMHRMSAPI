using Application.Dtos.Auth;
using Application.Dtos.Master;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<Company, SignUpDto>().ReverseMap();
            CreateMap<Role, SignUpDto>().ReverseMap();
            CreateMap<User, SignUpDto>()
                .ForMember(t => t.Name, (o) => o.MapFrom(s => s.FirstName))
                .ForMember(t => t.MobileNo, (o) => o.MapFrom(s => s.Login))
                .ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<Company, LoginCompanyDto>().ReverseMap();
            CreateMap<Country, CountriesDto>().ReverseMap()
                .ForMember(dest => dest.States, opt => opt.MapFrom(src => src.States));
            CreateMap<State, StatesDto>()
                .ForMember(dest => dest.Cities, opt => opt.MapFrom(src => src.Cities));
            CreateMap<City, CitiesDto>().ReverseMap();
            CreateMap<Grade, CompanyGradeDto>().ReverseMap()
                .ForMember(t => t.Grade1, (o) => o.MapFrom(s => s.Grade));
        }
    }
}
