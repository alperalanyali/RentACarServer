using System;
using Domain.Entities;
using Domain.Repositories.UserRoleRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.UserRoleRepository
{
    public class UserRoleQueryRepository : AppGenericQueryRepository<UserRole>, IUserRoleQueryRepository
    {
        public UserRoleQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

