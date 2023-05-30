using System;
using Domain.Entities;
using Domain.Repositories.CarRequestRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarRequestRepository
{
    public class CarRequestQueryRepository : AppGenericQueryRepository<CarRequest>, ICarRequestQueryRepository
    {
        public CarRequestQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

