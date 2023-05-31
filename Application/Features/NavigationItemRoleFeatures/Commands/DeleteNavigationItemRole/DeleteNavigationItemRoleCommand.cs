using System;
using Application.Messaging;

namespace Application.Features.NavigationItemRoleFeatures.Commands.DeleteNavigationItemRole
{
	public class DeleteNavigationItemRoleCommand:ICommand<DeleteNavigationItemRoleCommandResponse>
	{
		public Guid Id { get; set; }
	}
}

