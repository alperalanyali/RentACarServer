using System;
using Application.Features.CarFeatures.Commands.CreateCar;
using Domain.Entities;

namespace Application.Services
{
	public interface ICarService
	{
		Task CreateCarAsync(CreateCarCommand request, CancellationToken cancellationToken);
		Task UpdateCarAsync(Car car, CancellationToken cancellationToken);
		Task<Car> GetById(Guid id);
		Task<IList<Car>> GetList(string search);
		Task DeleteById(Guid id, CancellationToken cancellationToken);
	}
}

