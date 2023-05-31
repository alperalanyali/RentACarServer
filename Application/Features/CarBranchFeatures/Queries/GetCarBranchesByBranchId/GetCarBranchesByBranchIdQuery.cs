using System;
using Application.Messaging;

namespace Application.Features.CarBranchFeatures.Queries.GetCarBranchesByBranchId
{
	public sealed record GetCarBranchesByBranchIdQuery(
			Guid BranchId,
			string Search
		):IQuery<GetCarBranchesByBranchIdQueryResponse>;
	
}

