using System;
using Application.Messaging;

namespace Application.Features.RoleFeatures.Commands.CreateRole
{
	public sealed record CreateRoleCommand(
		string Name
		):ICommand<CreateRoleCommandResponse>;

}

