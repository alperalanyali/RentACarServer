using System;
using Domain.Entities;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByRoleIdAndTopNavbarId
{
	public sealed record GetNavigationItemRolesByRoleIdAndTopNavbarIdQueryResponse(
		IList<NavigationItemRole> data
		);
	
}

