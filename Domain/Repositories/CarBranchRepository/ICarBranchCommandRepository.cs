using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.CarBranchRepository
{
	public interface ICarBranchCommandRepository:IAppCommandRepository<CarBranch>
	{
	}
}

