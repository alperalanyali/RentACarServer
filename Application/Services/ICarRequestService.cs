using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ICarRequestService
	{
		Task CreateCarRequest(CarRequest carRequest, CancellationToken cancellationToken);
		Task UpdateCarRequest(CarRequest carRequest, CancellationToken cancellationToken);
		Task DeleteCarRequest(Guid id,CancellationToken cancellationToken);
		Task<IList<CarRequest>> GetAll(string search);
		Task<IList<CarRequest>> GetCarRequestsByCarId(Guid carId);
		Task<CarRequest> GetById(Guid id);

		Task<IList<CarRequest>> GetCarRequestsByUserId(Guid userId,int currentPage,int pageSize,CancellationToken cancellationToken);
	}
}

