using System;
using Domain.Entities;
using Domain.Repositories.UserCompanyRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.UserCompanyRepository
{
    public class UserCompanyCommandRepository : AppCommandRepository<UserCompany>, IUserCompanyCommandRepository
    {
        public UserCompanyCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

