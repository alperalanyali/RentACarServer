using System;
using Domain.Entities;

namespace Application.Features.BranchFeatures.Queries.GetBranchesByCompanyId
{
	public sealed record GetBranchesByCompanyIdQueryResponse(
		
		IList<Branch> Data,

        bool isSuccess = false

        );

}

