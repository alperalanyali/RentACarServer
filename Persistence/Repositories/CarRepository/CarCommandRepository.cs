using System;
using Domain.Entities;
using Domain.Repositories.CarRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarRepository
{
    public class CarCommandRepository : AppCommandRepository<Car>,ICarCommandRepository

    {
        public CarCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

