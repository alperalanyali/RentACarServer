using System;
using Domain.Entities;

namespace Application.Features.UserCompanyFeatures.Queries.GetlListByUserId
{
	public sealed record GetListByUserIdQueryResponse(
		int results,
		IList<UserCompany> Data
		);

}

