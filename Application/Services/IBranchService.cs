using System;
using Application.Features.BranchFeatures.Commands.CreateBranch;
using Application.Features.BranchFeatures.Commands.UpdateBranch;
using Domain.Entities;

namespace Application.Services
{
	public interface IBranchService
	{
		Task<Branch> GetBranchDetailById(Guid id);
		Task CreateAsync(Branch branch, CancellationToken cancellationToken);
		Task UpdateAsync(Branch branch,CancellationToken cancellation);
		Task<IList<Branch>> GetList(string search);
		Task<IList<Branch>> GetListByCompanyId(Guid id);
		Task<Branch> GetById(Guid id);
		Task DeleteById(Guid id,CancellationToken cancellationToken);
		
	}
}

