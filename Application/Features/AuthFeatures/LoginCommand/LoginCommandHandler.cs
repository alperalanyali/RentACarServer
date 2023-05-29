using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AuthFeatures.LoginCommand
{
	public class LoginCommandHandler:ICommandHandler<LoginCommand,LoginCommandResponse>
	{
        private readonly IAuthService _authService;
		public LoginCommandHandler(IAuthService authService)
		{
            _authService = authService;
		}

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User user = await _authService.GetByEmailorUsername(request.emailOrUserName);
            if (user == null)
                throw new Exception("Kullanıcı bulunamadı");
            var checkUserPass = await _authService.CheckPasswordAsync(user, request.password);
            if (!checkUserPass)
                throw new Exception("Şifreniz yanlış");


            return new();
        }
    }
}

