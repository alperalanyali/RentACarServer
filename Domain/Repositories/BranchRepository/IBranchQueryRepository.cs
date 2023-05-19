using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.BranchRepository
{
	public interface IBranchQueryRepository:IAppQueryRepository<Branch>
	{
	}
}

