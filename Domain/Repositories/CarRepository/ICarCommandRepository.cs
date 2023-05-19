using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.CarRepository
{
	public interface ICarCommandRepository:IAppCommandRepository<Car>
	{
	}
}

