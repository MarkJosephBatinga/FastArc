using FastArc.Server.Data;
using FastArc.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastArc.Server.Service
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        List<User> Users = new List<User>();

        public async Task<List<User>> AddUser(User newUser)
        {
            await _dataContext.Users.AddAsync(newUser);
            await _dataContext.SaveChangesAsync();
            Users = await _dataContext.Users.ToListAsync();
            return Users;
        }

        public async Task<User> GetUser(LoginUser exisitingUser)
        {
            User dbuser = await _dataContext.Users.FirstOrDefaultAsync(u => u.EmailAddress == exisitingUser.EmailAddress && u.Password == exisitingUser.Password);
            var dbnotfound = new User();
            if (dbuser == null)
                return dbnotfound;
            return dbuser;
        }
    }
}
