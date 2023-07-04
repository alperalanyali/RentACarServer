
using System;
using Application.Messaging;

namespace Application.Features.RoleFeatures.Commands.DeleteRoleById
{
	public sealed record DeleteRoleByIdCommand(Guid Id):ICommand<DeleteRoleByIdCommandResponse>;
	
}

