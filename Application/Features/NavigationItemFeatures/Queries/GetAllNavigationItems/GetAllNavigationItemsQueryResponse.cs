using System;
using Domain.Entities;

namespace Application.Features.NavigationItemFeatures.Queries.GetAllNavigationItems
{
	public sealed record GetAllNavigationItemsQueryResponse(
			IList<NavigationItem> data,
			bool isSuccess = false
		);
	
}

