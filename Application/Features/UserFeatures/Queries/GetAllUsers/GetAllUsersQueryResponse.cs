using System;
using Domain.Entities;

namespace Application.Features.UserFeatures.Queries.GetAllUsers
{
	public sealed record GetAllUsersQueryResponse(
		int count,
		IList<User> data
		);
	
}

