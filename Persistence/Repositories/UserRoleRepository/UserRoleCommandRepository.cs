using System;
using Domain.Entities;
using Domain.Repositories.UserRoleRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.UserRoleRepository
{
    public class UserRoleCommandRepository : AppCommandRepository<UserRole>, IUserRoleCommandRepository
    {
        public UserRoleCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

