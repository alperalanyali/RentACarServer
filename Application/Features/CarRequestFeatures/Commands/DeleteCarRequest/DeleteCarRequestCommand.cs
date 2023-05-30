using System;
using Application.Messaging;

namespace Application.Features.CarRequestFeatures.Commands.DeleteCarRequest
{
	public sealed record DeleteCarRequestCommand(
		Guid Id
		):ICommand<DeleteCarRequestCommandResponse>;

}

