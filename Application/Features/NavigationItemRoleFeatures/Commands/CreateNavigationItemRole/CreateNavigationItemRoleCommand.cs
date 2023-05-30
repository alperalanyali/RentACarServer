using System;
using Application.Messaging;

namespace Application.Features.NavigationItemRoleFeatures.Commands.CreateNavigationItemRole
{
	public sealed record CreateNavigationItemRoleCommand(
			Guid navigationId,
			Guid roleId
		):ICommand<CreateNavigationItemRoleCommandResponse>;

}

