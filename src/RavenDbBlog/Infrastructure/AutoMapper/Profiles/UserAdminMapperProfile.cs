﻿using AutoMapper;
using RavenDbBlog.Core.Models;
using RavenDbBlog.ViewModels;

namespace RavenDbBlog.Infrastructure.AutoMapper.Profiles
{
    public class UserAdminMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<User, UserSummeryViewModel>();
        }
    }
}