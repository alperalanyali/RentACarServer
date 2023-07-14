using System;
using Application.Messaging;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByRoleIdAndTopNavbarId
{
	public record GetNavigationItemRolesByRoleIdAndTopNavbarIdQuery(
		Guid RoleId,
		string TopNavBarId
		):IQuery<GetNavigationItemRolesByRoleIdAndTopNavbarIdQueryResponse>;
	
}

