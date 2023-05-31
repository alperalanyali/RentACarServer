using System;
using Application.Messaging;

namespace Application.Features.CarBranchFeatures.Commands.DeleteCarBranch
{
	public sealed record DeleteCarBranchCommand(
			Guid Id

		):ICommand<DeleteCarBranchCommandResponse>;
	
}

