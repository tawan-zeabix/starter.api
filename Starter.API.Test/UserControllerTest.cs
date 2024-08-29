using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Starter.API.Controllers;
using Starter.API.Models;
using Starter.API.Services.Interfaces;

namespace Starter.API.Test
{
    public class UserControllerTest
    {
        private Mock<IUserService> userServiceMock;

        public UserControllerTest()
        {
            userServiceMock = new Mock<IUserService>();
        }

        [Fact]
        public async Task GetAll_User_Success()
        {
            List<UserModel> users = new List<UserModel>()
            {
                new UserModel{Id = 1, Username="John"},
                new UserModel{Id = 2, Username="Sara"},
            };

            userServiceMock.Setup(i => i.GetAllUsers()).ReturnsAsync(users);

            UserController userController = new UserController(userServiceMock.Object);

            var userListResponse = userController.GetUsers();

            Assert.IsType<List<UserModel>>(userListResponse);

        }
    }
}