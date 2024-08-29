using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using src.DTOs.Response;
using Starter.API.Models;

namespace src.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, UserResponseDto>()
                .ForMember(dst => dst.Fullname, src => src.MapFrom(i => $"{i.Firstname} {i.Lastname}"));
        }
    }
}