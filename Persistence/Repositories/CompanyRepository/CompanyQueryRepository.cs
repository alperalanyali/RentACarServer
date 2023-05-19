using System;
using Domain.Entities;
using Domain.Repositories.CompanyRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CompanyRepository
{
    public class CompanyQueryRepository : AppGenericQueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

