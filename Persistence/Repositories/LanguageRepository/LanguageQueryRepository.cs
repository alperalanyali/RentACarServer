using System;
using Domain.Entities;
using Domain.Repositories.LanguageRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.LanguageRepository
{
    public class LanguageQueryRepository : AppGenericQueryRepository<Language>,ILanguageQueryRepository
    {
        public LanguageQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

