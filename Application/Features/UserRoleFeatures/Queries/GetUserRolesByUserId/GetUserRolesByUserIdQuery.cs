using System;
using Application.Messaging;

namespace Application.Features.UserRoleFeatures.Queries.GetUserRolesByUserId
{
	public sealed record GetUserRolesByUserIdQuery(Guid UserId):IQuery<GetUserRolesByUserIdQueryResponse>;
	
}

