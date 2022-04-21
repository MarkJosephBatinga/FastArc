using FastArc.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastArc.Client.Service.UserService
{
    interface IUserService
    {
        Task<List<User>> RegisterUser(User user);

        Task<User> LoginUser(LoginUser exisitingUser);
    }
}
