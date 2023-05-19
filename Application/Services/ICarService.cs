using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ICarService
	{
		Task CreateCarAsync(Car car, CancellationToken cancellationToken);
		Task UpdateCarAsync(Car car, CancellationToken cancellationToken);
		Task<Car> GetById(Guid id);
	}
}

