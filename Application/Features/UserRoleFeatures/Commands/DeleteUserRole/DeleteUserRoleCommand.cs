using System;
using Application.Messaging;

namespace Application.Features.UserRoleFeatures.Commands.DeleteUserRole
{
	public class DeleteUserRoleCommand:ICommand<DeleteUserRoleCommandResponse>
	{
		public Guid Id { get; set; }
	}
}

