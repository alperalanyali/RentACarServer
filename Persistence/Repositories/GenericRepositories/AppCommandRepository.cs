using System;
using Domain.Abstractions;
using Domain.Repositories.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories.GenericRepositories
{
	public class AppCommandRepository<T> :IAppCommandRepository<T> where T:Entity
    {
        private static readonly Func<Context.AppDbContext, Guid, Task<T>> GetById =
        EF.CompileAsyncQuery((Context.AppDbContext context, Guid id) => context.Set<T>().FirstOrDefault(p => p.Id == id));

        private readonly AppDbContext _dbContext;

        public AppCommandRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Entity = _dbContext.Set<T>();
        }
        public DbSet<T> Entity { get; set; }


        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Entity.AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsnyc(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await Entity.AddRangeAsync(entities, cancellationToken);
        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(Guid id)
        {
            var entity = await GetById(_dbContext, id);
            Entity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}

