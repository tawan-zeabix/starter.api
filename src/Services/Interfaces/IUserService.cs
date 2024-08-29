using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.DTOs.Request;
using Starter.API.Models;

namespace Starter.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsers();
        Task CreateUser(CreateUserDto model);
        Task UpdateUser(int id, CreateUserDto model);
        Task DeleteUser(int id);
        Task<UserModel> GetUserById(int id);
    }
}