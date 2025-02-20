﻿using AutoMapper;
using HiBoard.Domain.DTOs;
using HiBoard.Domain.Models;

namespace HiBoard.Application.Mapping;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();

        CreateMap<Activity, ActivityDto>();
        CreateMap<ActivityDto, Activity>();

        CreateMap<Company, CompanyDto>();
        CreateMap<CompanyDto, Company>();

        CreateMap<UserActivity, UserActivityDto>();
        CreateMap<UserActivityDto, UserActivity>();

        CreateMap<Template, TemplateDto>();
        CreateMap<TemplateDto, Template>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForMember(x => x.CompanyId, opt => opt.Ignore())
            .ForMember(x => x.Department, opt => opt.Ignore());

        
    }
}