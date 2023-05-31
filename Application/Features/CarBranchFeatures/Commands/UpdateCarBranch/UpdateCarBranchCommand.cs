using System;
using Application.Messaging;

namespace Application.Features.CarBranchFeatures.Commands.UpdateCarBranch
{
	public sealed record UpdateCarBranchCommand(
		Guid Id,
		Guid CarId,
		Guid BranchId
		):ICommand<UpdateCarBranchCommandResponse>;
	
}

