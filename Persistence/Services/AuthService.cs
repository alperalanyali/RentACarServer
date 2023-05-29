using System;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        public AuthService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            var result = await _userManager.CheckPasswordAsync(user, password);
            return result;
        }

        public async Task<User> GetByEmailorUsername(string emailOrUsername)
        {
            var user = await _userManager.Users.Where(p => p.Email == emailOrUsername || p.UserName == emailOrUsername).FirstOrDefaultAsync();
            return user;
        }
    }
}

