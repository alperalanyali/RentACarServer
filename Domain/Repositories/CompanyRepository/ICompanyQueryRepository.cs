using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.CompanyRepository
{
	public interface ICompanyQueryRepository:IAppQueryRepository<Company>
	{
	}
}

