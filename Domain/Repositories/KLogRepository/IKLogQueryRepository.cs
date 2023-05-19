using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.KLogRepository
{
	public interface IKLogQueryRepository:IAppQueryRepository<KLog>
	{
	}
}

