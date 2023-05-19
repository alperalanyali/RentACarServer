using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IUserRoleService
	{
		Task CreateAsync(UserRole userRole, CancellationToken cancellationToken);
		Task UpdateAsync(UserRole userRole, CancellationToken cancellationToken);
		Task RemoveAsync(Guid id, CancellationToken cancellationToken);
		Task GetById(Guid id);
		Task<IList<UserRole>> GetList(string search);
		Task<IList<UserRole>> GetListByUserId(Guid userId);
	}
}

