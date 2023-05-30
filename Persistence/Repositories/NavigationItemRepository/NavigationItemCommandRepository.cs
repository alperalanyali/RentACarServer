using System;
using Domain.Entities;
using Domain.Repositories.NavigationItemRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.NavigationItemRepository
{
    public class NavigationItemCommandRepository : AppCommandRepository<NavigationItem>, INavigationItemCommandRepository
    {
        public NavigationItemCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

