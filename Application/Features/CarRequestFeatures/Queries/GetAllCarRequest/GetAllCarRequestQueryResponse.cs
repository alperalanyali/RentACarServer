using System;
using Domain.Entities;

namespace Application.Features.CarRequestFeatures.Queries.GetAllCarRequest
{
	public sealed record GetAllCarRequestQueryResponse(
			IList<CarRequest> Data,
			bool isSuccess = false
		);
	
}

