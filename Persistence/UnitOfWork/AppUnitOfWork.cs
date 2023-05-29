using System;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.UnitOfWork
{
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public AppUnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
        {
            int count = await _appDbContext.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}

