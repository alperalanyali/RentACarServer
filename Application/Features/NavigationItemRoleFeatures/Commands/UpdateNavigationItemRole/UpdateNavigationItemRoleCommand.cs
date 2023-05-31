using System;
using Application.Messaging;

namespace Application.Features.NavigationItemRoleFeatures.Commands.UpdateNavigationItemRole
{
	public class UpdateNavigationItemRoleCommand:ICommand<UpdateNavigationItemRoleCommandResponse>
	{
		public Guid Id { get; set; }
		public Guid NavigationItemId { get; set; }
		public Guid RoleId { get; set; }

	}
}

