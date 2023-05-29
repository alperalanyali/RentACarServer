using System;
using Application.Messaging;

namespace Application.Features.CarBranchFeatures.Commands.CreateCarBranch
{
	public sealed record CreateCarBranchCommand(
		string CarId,
		string BranchId
		):ICommand<CreateCarBranchCommandResponse>;

}

