using System;
using Domain.Entities;

namespace Application.Features.CarRequestFeatures.Queries.GetCarRequestsByCarId
{
	public sealed record GetCarRequestsByCarIdQueryResponse(
		IList<CarRequest> data,
		bool isSuccess = false
		);
	
}

