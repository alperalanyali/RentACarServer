using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IUserCompanyService
	{
		Task CreateAsync(UserCompany userCompany, CancellationToken cancellationToken);
		Task UpdateAsync(UserCompany userCompany, CancellationToken cancellationToken);
		Task RemoveUserCompany(Guid id, CancellationToken cancellationToken);
		Task<IList<UserCompany>> GetAllList(string search);
		Task<UserCompany> GetById(Guid id);
		Task<IList<UserCompany>> GetListByUserId(Guid userId);
	}
}

