using System;
using Application.Messaging;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.UserFeatures.Queries.GetAllUsers
{
	public class GetAllUsersQueryHandler:IQueryHandler<GetAllUsersQuery,GetAllUsersQueryResponse>
	{
        private readonly UserManager<User> _userManager;
        public GetAllUsersQueryHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GetAllUsersQueryResponse> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userManager.Users.ToListAsync();

            return new(users.Count(), users);
                
        }
    }
}

