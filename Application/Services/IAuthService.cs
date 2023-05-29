using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IAuthService
	{
		Task<User> GetByEmailorUsername(string emailOrUsername);
        Task<bool> CheckPasswordAsync(User user, string password);
    }
}

