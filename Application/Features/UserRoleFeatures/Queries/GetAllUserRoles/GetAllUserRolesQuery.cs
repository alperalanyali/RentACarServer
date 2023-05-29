using System;
using Application.Messaging;

namespace Application.Features.UserRoleFeatures.Queries.GetAllUserRoles
{
	public sealed record GetAllUserRolesQuery(
		string search
		):IQuery<GetAllUserRolesQueryResponse>;
	
}

