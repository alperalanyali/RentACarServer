using System;
using Domain.Entities;
using Domain.Repositories.NavigationItemRoleRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.NavigationItemRoleRepository
{
    public class NavigationItemRoleQueryRepository : AppGenericQueryRepository<NavigationItemRole>, INavigationItemRoleQueryRepository
    {
        public NavigationItemRoleQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

