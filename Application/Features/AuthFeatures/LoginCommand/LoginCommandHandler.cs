using System;
using Application.Abstractions;
using Application.Messaging;
using Application.Services;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Features.AuthFeatures.LoginCommand
{
	public class LoginCommandHandler:ICommandHandler<LoginCommand,LoginCommandResponse>
	{
        private readonly IAuthService _authService;
        private readonly IJwtProvider _jwtProvider;
        public LoginCommandHandler(IAuthService authService, IJwtProvider jwtProvider)
		{
            _authService = authService;
            _jwtProvider = jwtProvider;
		}

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User user = await _authService.GetByEmailorUsername(request.emailOrUserName);
            if (user == null)
                return new LoginCommandResponse(null, "", "", "",null, "Kullanıcı bulunamadi");
            var checkUserPass = await _authService.CheckPasswordAsync(user, request.password);
            if (!checkUserPass)                
                return new LoginCommandResponse(null, "", "", "",null ,"Şifreniz yanlış");
            List<RoleDto> roleDtos = new List<RoleDto>();
            foreach(var role in user.UserRoles)
            {
                var roleDto = new RoleDto(role.RoleId,role.Role.Name);
                roleDtos.Add(roleDto);
            }
            LoginCommandResponse response = new LoginCommandResponse(Token: await _jwtProvider.CreateToken(user), Email: user.Email, UserId: user.Id.ToString(), FullName: user.FullName,roleDtos);
            return response;

            
        }
    }
}

