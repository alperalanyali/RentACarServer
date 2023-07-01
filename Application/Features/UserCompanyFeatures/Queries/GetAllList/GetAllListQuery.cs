using System;
using Application.Messaging;

namespace Application.Features.UserCompanyFeatures.Queries.GetAllList
{
	public sealed record GetAllListQuery(
		string search
		):IQuery<GetAllListQueryResponse>;

}

