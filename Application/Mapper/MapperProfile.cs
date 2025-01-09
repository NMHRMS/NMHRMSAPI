using Application.Dtos.Auth;
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
            CreateMap<Domain.Models.Profile, SignUpDto>().ReverseMap();
            CreateMap<User, SignUpDto>()
                .ForMember(t=> t.Name, (o) => o.MapFrom(s=> s.FirstName))
                .ForMember(t=> t.MobileNo, (o) => o.MapFrom(s=> s.Login))
                .ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Domain.Models.Profile, ProfileDto>().ReverseMap();
        }
    }
}
