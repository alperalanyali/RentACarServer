using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ICompanyService
	{
		Task CreateAsync(Company company, CancellationToken cancellationToken);
		Task UpdateAsync(Company company, CancellationToken cancellationToken);
		Task<Company> GetById(Guid id);
		Task<IList<Company>> GetList(string search);
	}
}

