using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.UserCompanyRepository
{
	public interface IUserCompanyQueryRepository: IAppQueryRepository<UserCompany>
    {
	}
}

