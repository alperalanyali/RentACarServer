using System;
using Application.Messaging;

namespace Application.Features.KlogFeatures.Queries.GetAll
{
	public sealed record GetAllKLogQuery(
		string search
		):IQuery<GetAllQueryResponse>;
	
}

