using System;
using Domain.Entities;
using Domain.Repositories.KLogRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.KLogRepository
{
    public class KLogCommandRepository : AppCommandRepository<KLog>, IKLogCommandRepository
    {
        public KLogCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

