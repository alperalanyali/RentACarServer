using System;
using Domain.Abstractions;


namespace Domain.Repositories.GenericRepositories
{
	public interface IGenericCommandRepository<T> : IRepository<T> where T : Entity
    {
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsnyc(IEnumerable<T> entities, CancellationToken cancellationToken);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task RemoveById(Guid id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

