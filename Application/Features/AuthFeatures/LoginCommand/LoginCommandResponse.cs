using System;
namespace Application.Features.AuthFeatures.LoginCommand
{
	public sealed record LoginCommandResponse(
		string Message = "İşlem Başarılı"
		);
	
}

