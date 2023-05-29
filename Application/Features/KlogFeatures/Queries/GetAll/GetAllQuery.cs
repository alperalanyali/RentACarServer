using System;
using Application.Messaging;

namespace Application.Features.KlogFeatures.Queries.GetAll
{
	public sealed record GetAllQuery(
		string search
		):IQuery<GetAllQueryResponse>;
	
}

