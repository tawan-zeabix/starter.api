using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using src.DTOs.Request;
using src.Repositories.Interfaces;
using Starter.API.Models;
using Starter.API.Services.Interfaces;

namespace Starter.API.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task CreateUser(CreateUserDto model)
        {
            try
            {
                UserModel user = _mapper.Map<UserModel>(model);
                await _userRepository.AddAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteUser(int id)
        {
            UserModel user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                throw new Exception($"User not found id: {id}");
            }
            try
            {
                await _userRepository.DeleteAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            List<UserModel> users = await _userRepository.GetAllAsync();
            return users;
        }

        public async Task<UserModel> GetUserById(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task UpdateUser(int id, CreateUserDto model)
        {
            UserModel user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                throw new Exception($"User not found id: {id}");
            }
            try
            {
                UserModel userMapped = _mapper.Map<UserModel>(model);
                await _userRepository.UpdateAsync(userMapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}