using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.NavigationItemRepository
{
	public interface INavigationItemQueryRepository: IAppQueryRepository<NavigationItem>
    {
	}
}

