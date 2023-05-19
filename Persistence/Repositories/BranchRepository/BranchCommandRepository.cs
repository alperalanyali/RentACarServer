using System;
using Domain.Entities;
using Domain.Repositories.BranchRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.BranchRepository
{
    public class BranchCommandRepository : AppCommandRepository<Branch>,IBranchCommandRepository
    {
        public BranchCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

