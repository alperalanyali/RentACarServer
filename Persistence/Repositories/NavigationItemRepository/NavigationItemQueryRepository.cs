using System;
using Domain.Entities;
using Domain.Repositories.NavigationItemRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.NavigationItemRepository
{
    public class NavigationItemQueryRepository : AppGenericQueryRepository<NavigationItem>, INavigationItemQueryRepository
    {
        public NavigationItemQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

