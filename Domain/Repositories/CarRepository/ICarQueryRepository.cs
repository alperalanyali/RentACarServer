using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.CarRepository
{
	public interface ICarQueryRepository:IAppQueryRepository<Car>
	{
	}
}

