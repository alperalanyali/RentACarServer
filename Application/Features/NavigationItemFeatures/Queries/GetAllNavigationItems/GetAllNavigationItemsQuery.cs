using System;
using Application.Messaging;

namespace Application.Features.NavigationItemFeatures.Queries.GetAllNavigationItems
{
	public sealed record GetAllNavigationItemsQuery(
		string search
		):IQuery<GetAllNavigationItemsQueryResponse>;
	
}

