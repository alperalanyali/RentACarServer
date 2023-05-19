using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IBranchService
	{
		Task<Branch> GetBranchDetailById(Guid id);
	}
}

