using System;
using Domain.Entities;
using Domain.Repositories.NavigationItemRoleRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.NavigationItemRoleRepository
{
    public class NavigationItemRoleCommandRepository : AppCommandRepository<NavigationItemRole>, INavigationItemRoleCommandRepository
    {
        public NavigationItemRoleCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

