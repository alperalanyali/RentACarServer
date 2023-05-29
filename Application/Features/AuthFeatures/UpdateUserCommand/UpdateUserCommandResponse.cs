using System;
namespace Application.Features.AuthFeatures.UpdateUserCommand
{
	public sealed record UpdateUserCommandResponse(
		bool IsSuccess = false,
		string Message = "Kullanıcı başarılı şekilde güncellenmiştir"
		);
	
}

