using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IKLogService
	{
		Task CreateAsync(KLog klog, CancellationToken cancellationToken);
		Task<IList<KLog>> GetList(string search);
		Task<KLog> GetById(Guid id);
	}
}

