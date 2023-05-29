using System;
using Application.Messaging;

namespace Application.Features.CarBranchFeatures.Queries.GetAll
{
	public sealed record GetlAllCommand(
		string search 
		):ICommand<GetlAllCommandResponse>;

}

