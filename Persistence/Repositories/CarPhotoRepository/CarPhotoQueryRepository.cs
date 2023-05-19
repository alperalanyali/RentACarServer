using System;
using Domain.Entities;
using Domain.Repositories.CarPhotoRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.CarPhotoRepository
{
    public class CarPhotoQueryRepository : AppGenericQueryRepository<CarPhoto>, ICarPhotoQueryRepository
    {
        public CarPhotoQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

