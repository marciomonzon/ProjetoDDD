using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();
        }
    }
}
