using System;
using Domain.Entities;

namespace Application.Features.UserRoleFeatures.Queries.GetUserRolesByUserId
{
	public sealed record GetUserRolesByUserIdQueryResponse(
		
		IList<UserRole> Data,
        bool isSuccess = false

        );
	
}

