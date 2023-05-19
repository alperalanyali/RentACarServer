using System;
using Domain.Entities;
using Domain.Repositories.CarBranchRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarBrancRepository
{
    public class CarBranchCommandRepository : AppCommandRepository<CarBranch>,ICarBranchCommandRepository
    {
        public CarBranchCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

