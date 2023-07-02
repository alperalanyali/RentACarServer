using System;
using Domain.Entities;

namespace Application.Features.NavigationItemFeatures.Queries.GetNavItemsByTopNavId
{
	public sealed record GetNavItemsByTopNavIdCommandResponse(
			int results,
			IList<NavigationItem> data
		);

}

