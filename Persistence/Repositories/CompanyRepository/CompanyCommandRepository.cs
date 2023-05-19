using System;
using Domain.Entities;
using Domain.Repositories.CompanyRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CompanyRepository
{
    public class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

