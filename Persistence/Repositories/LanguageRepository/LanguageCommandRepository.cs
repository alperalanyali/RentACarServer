using System;
using Domain.Entities;
using Domain.Repositories.LanguageRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.LanguageRepository
{
    public class LanguageCommandRepository : AppCommandRepository<Language>, ILanguageCommandRepository
    {
        public LanguageCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

