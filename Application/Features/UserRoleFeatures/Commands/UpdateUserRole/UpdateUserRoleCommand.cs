using System;
using Application.Messaging;

namespace Application.Features.UserRoleFeatures.Commands.UpdateUserRole
{
	public class UpdateUserRoleCommand:ICommand<UpdateUserRoleCommandResponse>
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public Guid RoleId { get; set; }

	}
}

