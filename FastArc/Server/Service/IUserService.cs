using FastArc.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastArc.Server.Service
{
    public interface IUserService
    {
        Task<List<User>> AddUser(User newUser);

        Task<User> GetUser(LoginUser exisitingUser);
    }
}
