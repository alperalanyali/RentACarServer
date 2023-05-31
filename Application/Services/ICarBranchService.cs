using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ICarBranchService
	{
		Task CreateCarBranch(CarBranch carBranch, CancellationToken cancellationToken);
		Task UpdateAsync(CarBranch carBranch, CancellationToken cancellationToken);
		Task<CarBranch> GetById(Guid id);
		Task<IList<CarBranch>> GetAll(string search);
		Task DeleteById(Guid id,CancellationToken cancellationToken);
		Task<IList<CarBranch>> GetCarBranchesByBranchId(Guid branchId);
		Task<IList<CarBranch>> GetCarBranchesByCarId(Guid carId);
	}
}

