using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ICarBranchService
	{
		Task CreateCarBranch(CarBranch carBranch, CancellationToken cancellationToken);
		Task UpdateAsync(CarBranch carBranch, CancellationToken cancellationToken);
		Task<CarBranch> GetById(Guid id);
	}
}

