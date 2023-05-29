using System;
namespace Application.Features.UserRoleFeatures.Commands.CreateUserRole
{
	public sealed record CreateUserRoleCommandResponse(
			bool isSuccess = false,
			string Message = "İşlem başarılı"
		);

}

