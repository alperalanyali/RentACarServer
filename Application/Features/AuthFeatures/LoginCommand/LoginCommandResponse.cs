using System;
using Domain.Dtos;

namespace Application.Features.AuthFeatures.LoginCommand
{
	public sealed record LoginCommandResponse(
            TokenRefreshTokenDto Token,
            string Email,
            string UserId,
            string FullName,
            IList<RoleDto> RoleDtos,
            string Error=""

        );
	
}

