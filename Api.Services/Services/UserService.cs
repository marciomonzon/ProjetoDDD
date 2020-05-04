using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);

            return _mapper.Map<UserDto>(entity) ?? new UserDto(); 
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var lstEntity = await _repository.SelectAsync();

            return _mapper.Map<IEnumerable<UserDto>>(lstEntity) ?? new List<UserDto>();
        }

        public async Task<UserDtoCreateResult> Post(UserDtoCreate user)
        {
            // exemplo de regra de negocio
            if (user.Nome == "TESTE")
                return null;

            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model); 

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserDtoCreateResult>(result);
        }

        public async Task<UserDtoUpdateResult> Put(UserDtoUpdate user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);

            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<UserDtoUpdateResult>(result);
        }
    }
}
