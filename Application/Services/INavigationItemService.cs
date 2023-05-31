using System;
using Domain.Entities;

namespace Application.Services
{
	public interface INavigationItemService
	{

		Task CreateAsync(NavigationItem navigationItem, CancellationToken cancellationToken);
		Task Update(NavigationItem navigationItem, CancellationToken cancellationToken);
		Task Delete(Guid id,CancellationToken cancellationToken);
		Task<IList<NavigationItem>> GetAll(string search);
		Task<NavigationItem> GetById(Guid id);
	}
}

