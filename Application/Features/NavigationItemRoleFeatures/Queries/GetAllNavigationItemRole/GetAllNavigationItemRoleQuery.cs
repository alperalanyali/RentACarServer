using System;
using Application.Messaging;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetAllNavigationItemRole
{
	public sealed record GetAllNavigationItemRoleQuery(
		string search
		):IQuery<GetAllNavigationItemRoleQueryResponse>;
	
}

