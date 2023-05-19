using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IRoleService
	{
		Task CreateAsync(Role role, CancellationToken cancellationToken);
		Task UpdateAsync(Role role, CancellationToken cancellationToken);
		Task DeleteRole(Guid id, CancellationToken cancellationToken);
		Task<IList<Role>> GetList(string search);
		Task<Role> GetById(Guid id);
	}
}

