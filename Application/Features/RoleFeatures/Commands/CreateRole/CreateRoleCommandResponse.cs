using System;
namespace Application.Features.RoleFeatures.Commands.CreateRole
{
	public sealed record CreateRoleCommandResponse(
		bool isSuccess = false,
		string Message = "İşlem başarılı"
		);
	
}

