using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.KLogRepository;
using Domain.UnitOfWork;

namespace Persistence.Services
{
    public class KLogService : IKLogService
    {
        private readonly IKLogCommandRepository _klogCommand;
        private readonly IKLogQueryRepository _kLogQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public KLogService()
        {

        }
        public Task CreateAsync(KLog klog, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<KLog> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<KLog>> GetList(string search)
        {
            throw new NotImplementedException();
        }
    }
}

