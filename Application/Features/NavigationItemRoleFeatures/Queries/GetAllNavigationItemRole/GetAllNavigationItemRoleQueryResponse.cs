using System;
using Domain.Entities;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetAllNavigationItemRole
{
	public sealed record GetAllNavigationItemRoleQueryResponse(
		 IList<NavigationItemRole> data,
		 bool isSuccess = false
		);
	
}

