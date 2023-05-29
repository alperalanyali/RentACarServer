using System;
using Application.Messaging;

namespace Application.Features.BranchFeatures.Queries.GetBranchesByCompanyId
{
	public sealed record GetBranchesByCompanyIdQuery(
		Guid CompanyId
		):IQuery<GetBranchesByCompanyIdQueryResponse>;
	
}

