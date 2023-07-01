using System;
using Domain.Entities;

namespace Application.Features.UserCompanyFeatures.Queries.GetAllList
{
	public sealed record GetAllListQueryResponse(
			int resutls,
			IList<UserCompany> Data
		);
	
}

