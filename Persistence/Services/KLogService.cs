using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.KLogRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class KLogService : IKLogService
    {
        private readonly IKLogCommandRepository _klogCommand;
        private readonly IKLogQueryRepository _kLogQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public KLogService(IKLogCommandRepository kLogCommandRepository, IKLogQueryRepository kLogQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _klogCommand = kLogCommandRepository;
            _kLogQuery = kLogQueryRepository;
            _unitOfWork = appUnitOfWork;
        }
        public async Task CreateAsync(KLog klog, CancellationToken cancellationToken)
        {
            await _klogCommand.AddAsync(klog, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<KLog> GetById(Guid id)
        {
            var klog = await _kLogQuery.GetById(id.ToString());
            return klog;
        }

        public async Task<IList<KLog>> GetList(string search)
        {
            var list = await _kLogQuery.GetAllAsync().ToListAsync();

            return list;
        }
    }
}

