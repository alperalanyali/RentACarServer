using System;
using Application.Messaging;

namespace Application.Features.CarRequestFeatures.Queries.GetAllCarRequest
{
	public sealed record GetAllCarRequestQuery(
		string search
		):IQuery<GetAllCarRequestQueryResponse>;

}

