using System;
using Application.Messaging;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByUserId
{
	public record GetNavigationItemRolesByUserIdQuery(
		string UserId):IQuery<GetNavigationItemRolesByUserIdQueryResponse>;
	
}

