using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.CarPhotoRepository
{
	public interface ICarPhotoCommandRepository:IAppCommandRepository<CarPhoto>
	{
	}
}

