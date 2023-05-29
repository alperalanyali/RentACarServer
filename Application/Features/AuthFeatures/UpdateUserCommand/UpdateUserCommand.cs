using System;
using Application.Messaging;

namespace Application.Features.AuthFeatures.UpdateUserCommand
{
	public sealed record UpdateUserCommand(
			Guid Id,
			string Username,
			string FullName,
			string Password,
			string Email):ICommand<UpdateUserCommandResponse>;
	
}

