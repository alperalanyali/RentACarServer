using System;
using Domain.Abstractions;
using Domain.Repositories.GenericRepositories;

namespace Domain.Repositories.AppDbContext
{
	public interface IAppCommandRepository<T>:IGenericCommandRepository<T>,IRepository<T> where T:Entity
	{
		
	}
}

