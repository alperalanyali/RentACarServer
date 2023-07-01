using System;
using Application.Messaging;

namespace Application.Features.UserCompanyFeatures.Queries.GetlListByUserId
{
	public sealed record GetListByUserIdQuery(
			Guid UserId
		):IQuery<GetListByUserIdQueryResponse>;
	
}

