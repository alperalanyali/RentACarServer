using System;
using Domain.Abstractions;
using Domain.Repositories.GenericRepositories;

namespace Domain.Repositories.AppDbContext
{
	public interface IAppQueryRepository<T>:IGenericQueryRepository<T>,IRepository<T> where T:Entity
	{
	}
}

