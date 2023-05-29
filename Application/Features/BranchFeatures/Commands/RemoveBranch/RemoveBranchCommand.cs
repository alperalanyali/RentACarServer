using System;
using Application.Messaging;

namespace Application.Features.BranchFeatures.Commands.RemoveBranch
{
	public sealed record RemoveBranchCommand(
			Guid id
		):ICommand<RemoveBranchCommandResponse>;
	
}

