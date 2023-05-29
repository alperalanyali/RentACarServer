using System;
using Domain.Entities;

namespace Application.Features.RoleFeatures.Queries.GetAll
{
	public sealed record GetAllQueryResponse(
		
		IList<Role> Data,
        bool isSuccess = false

        );
	
}

