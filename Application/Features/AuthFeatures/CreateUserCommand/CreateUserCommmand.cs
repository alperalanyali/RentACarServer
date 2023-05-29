using System;
using Application.Messaging;

namespace Application.Features.AuthFeatures.CreateUserCommand
{
	public sealed record CreateUserCommmand(
		string UserName,
		string FullName,
		string Email,
		string Password
		):ICommand<CreateUserCommmandResponse>;

}

