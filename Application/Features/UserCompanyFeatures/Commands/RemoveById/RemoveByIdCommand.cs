using System;
using Application.Messaging;

namespace Application.Features.UserCompanyFeatures.Commands.RemoveById
{
	public sealed record RemoveByIdCommand(Guid Id):ICommand<RemoveByIdCommandResponse>;

}

