using System;
using Application.Messaging;

namespace Application.Features.BranchFeatures.Queries.GetAll
{
	public sealed record GetAllQueries(
		string search
		):IQuery<GetAllQueriesResponse>;
	
}

