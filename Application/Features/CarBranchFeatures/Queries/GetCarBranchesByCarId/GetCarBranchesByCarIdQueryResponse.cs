using System;
using Domain.Entities;

namespace Application.Features.CarBranchFeatures.Queries.GetCarBranchesByCarId
{
	public sealed record GetCarBranchesByCarIdQueryResponse(
			IList<CarBranch> Data,
			bool isSuccess = false
		);

}

