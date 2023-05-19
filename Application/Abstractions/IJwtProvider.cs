using System;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Abstractions
{
	public interface IJwtProvider
	{
		Task<TokenRefreshTokenDto> CreateToken(User user);
	}
}

