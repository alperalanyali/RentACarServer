using System;
using Domain.Entities;
using Domain.Repositories.BranchRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.BranchRepository
{
    public class BranchQueryRepository : AppGenericQueryRepository<Branch>, IBranchQueryRepository
    {
        public BranchQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

