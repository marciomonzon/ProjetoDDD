using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModel : Profile
    {
        public DtoToModel()
        {
            // faz model para dto e o inverso
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
        }
    }
}
