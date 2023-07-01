using System;
using Domain.Entities;
using Domain.Repositories.UserCompanyRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.UserCompanyRepository
{
    public class UserCompanyQueryRepository : AppGenericQueryRepository<UserCompany>, IUserCompanyQueryRepository
    {
        public UserCompanyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

