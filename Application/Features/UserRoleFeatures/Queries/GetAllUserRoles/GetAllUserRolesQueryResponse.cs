using System;
using Domain.Entities;

namespace Application.Features.UserRoleFeatures.Queries.GetAllUserRoles
{
	public sealed record GetAllUserRolesQueryResponse(
		
		IList<UserRole> Data,
        bool isSuccess = false

        );

}

