using System;
using Domain.Entities;
using Domain.Repositories.CarPhotoRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarPhotoRepository
{
    public class CarPhotoCommandRepository : AppCommandRepository<CarPhoto>, ICarPhotoCommandRepository
    {
        public CarPhotoCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

