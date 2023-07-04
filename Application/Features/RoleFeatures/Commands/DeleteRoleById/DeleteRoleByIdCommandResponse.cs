using System;
namespace Application.Features.RoleFeatures.Commands.DeleteRoleById
{
	public sealed record DeleteRoleByIdCommandResponse(
		string Message = "İşlem başarılı şekilde gerçekleştirilmiştir."
		);

}

