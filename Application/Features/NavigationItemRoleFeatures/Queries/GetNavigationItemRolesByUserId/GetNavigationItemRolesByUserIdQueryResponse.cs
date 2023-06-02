using System;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByUserId
{
	public sealed record GetNavigationItemRolesByUserIdQueryResponse(
		IList<NavigationItemDto> Data,
		int Results
		);
	
}

