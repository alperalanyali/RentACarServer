using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.CarBranchFeatures.Queries.GetAll
{
	public sealed record GetlAllCommandResponse(
		
		IList<CarBranch> Data,

        bool isSuccess = false

        );
}

