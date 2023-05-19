using System;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Persistence.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        public AuthService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public Task<User> GetByEmailorUsername(string emailOrUsername)
        {
            throw new NotImplementedException();
        }
    }
}

