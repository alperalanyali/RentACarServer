using System;
using Application.Messaging;

namespace Application.Features.UserRoleFeatures.Commands.CreateUserRole
{
	public sealed record CreateUserRoleCommand(
		Guid UserId,
		Guid RoleId
		):ICommand<CreateUserRoleCommandResponse>;

}

