using System;
using Domain.Entities;
using Domain.Repositories.CarRequestRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarRequestRepository
{
    public class CarRequestCommandRepository : AppCommandRepository<CarRequest>, ICarRequestCommandRepository
    {
        public CarRequestCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

