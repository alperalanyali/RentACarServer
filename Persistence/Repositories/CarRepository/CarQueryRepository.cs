using System;
using Domain.Entities;
using Domain.Repositories.CarRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarRepository
{
    public class CarQueryRepository : AppGenericQueryRepository<Car>, ICarQueryRepository
    {
        public CarQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

