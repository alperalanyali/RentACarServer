using System;
using Application.Messaging;

namespace Application.Features.RoleFeatures.Queries.GetAll
{
	public sealed record GetAllRolesQuery(string search) : IQuery<GetAllQueryResponse>;
	
}

