using ChatHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Services.Interfaces
{
    public interface IUserService
    {
        public Task<string> GetOrCreateUser(LoginModel userName);
    }
}
