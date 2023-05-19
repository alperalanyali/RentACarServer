using System;
using Domain.Entities;
using Domain.Repositories.KLogRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.KLogRepository
{
    public class KLogQueryRepository : AppGenericQueryRepository<KLog>, IKLogQueryRepository
    {
        public KLogQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

