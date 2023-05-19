using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.BranchRepository
{
	public interface IBranchCommandRepository:IAppCommandRepository<Branch>
	{
	}
}

