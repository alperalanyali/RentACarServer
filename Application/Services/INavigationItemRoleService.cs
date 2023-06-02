using System;
using Domain.Entities;

namespace Application.Services
{
	public interface INavigationItemRoleService
	{
		Task Create(NavigationItemRole navigationItemRole, CancellationToken cancellationToken);
		Task Update(NavigationItemRole navigationItem, CancellationToken cancellationToken);
		Task Delete(Guid id,CancellationToken cancellationToken);
		Task<IList<NavigationItemRole>> GetAll(string search);
		Task<NavigationItemRole> GetById(Guid id);
		Task<IList<NavigationItemRole>> GetNavigationItemRoleByRoleId(Guid roleId,string search);
		Task<IList<NavigationItemRole>> GetNavigationItemRoleByUserId(Guid roleId);
		
	}
}

