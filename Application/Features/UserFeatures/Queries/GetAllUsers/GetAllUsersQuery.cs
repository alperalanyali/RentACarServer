using System;
using Application.Messaging;

namespace Application.Features.UserFeatures.Queries.GetAllUsers
{
	public sealed record GetAllUsersQuery():IQuery<GetAllUsersQueryResponse>;
	
}

