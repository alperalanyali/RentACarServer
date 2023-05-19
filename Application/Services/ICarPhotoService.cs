using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ICarPhotoService
	{
		Task CreateAsync(CarPhoto carPhoto, CancellationToken cancellationToken);
		Task UpdateAsync(CarPhoto carPhoto, CancellationToken cancellationToken);
		Task<CarPhoto> GetById(Guid id);
		Task<IList<CarPhoto>> GetCarPhotosByCarId(Guid carPhotoId);

	}
}

