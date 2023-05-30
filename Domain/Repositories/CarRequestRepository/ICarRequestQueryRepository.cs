using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.CarRequestRepository
{
	public interface ICarRequestQueryRepository :IAppQueryRepository<CarRequest>
	{
	}
}

