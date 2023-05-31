using System;
using Domain.Entities;

namespace Application.Features.CarBranchFeatures.Queries.GetCarBranchesByBranchId
{
	public sealed record GetCarBranchesByBranchIdQueryResponse(
			IList<CarBranch> Data,
			bool isSuccess = false
		);

}

