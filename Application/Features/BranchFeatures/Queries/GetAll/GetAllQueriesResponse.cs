using System;
using Domain.Entities;

namespace Application.Features.BranchFeatures.Queries.GetAll
{
	public sealed record GetAllQueriesResponse(
		bool isSuccess,
		IList<Branch> Data);
	
}

