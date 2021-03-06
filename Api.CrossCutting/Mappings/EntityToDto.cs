﻿using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<UserDtoCreate, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>()
                .ReverseMap();
        }
    }
}
