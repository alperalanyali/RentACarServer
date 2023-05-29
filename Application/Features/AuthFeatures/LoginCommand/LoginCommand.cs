using System;
using Application.Messaging;

namespace Application.Features.AuthFeatures.LoginCommand
{
	public sealed record LoginCommand(
		string emailOrUserName,
		string password
		):ICommand<LoginCommandResponse>;
	
}

