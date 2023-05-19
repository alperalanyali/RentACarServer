using System;
using Domain.Entities;
using Domain.Repositories.CarBranchRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarBrancRepository
{
    public class CarBranchQueryRepository : AppGenericQueryRepository<CarBranch>, ICarBranchQueryRepository
    {
        public CarBranchQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

