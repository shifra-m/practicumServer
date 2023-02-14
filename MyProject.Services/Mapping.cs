using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
           
            CreateMap<User, UserDTO>().ForMember(dest=>dest.HMO,opt=>opt.MapFrom(src=>src.HMO))
                .ForMember(dest=>dest.Gender,opt=>opt.MapFrom(src=>src.Gender)).ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();


        }
    }
}
