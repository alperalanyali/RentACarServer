using System;
using Application.Features.BranchFeatures.Commands.CreateBranch;
using Application.Features.BranchFeatures.Commands.UpdateBranch;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.BranchRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchCommandRepository _branchCommandRepository;
        private readonly IBranchQueryRepository _branchQueryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public BranchService(IBranchCommandRepository branchCommandRepository, IBranchQueryRepository branchQueryRepository, IAppUnitOfWork unitOfWork )
        {
            _branchCommandRepository = branchCommandRepository;
            _branchQueryRepository = branchQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Branch branch, CancellationToken cancellationToken)
        {
           
            await _branchCommandRepository.AddAsync(branch, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Branch> GetBranchDetailById(Guid id)
        {
            return await _branchQueryRepository.GetById(id.ToString());
        }

        public async Task<IList<Branch>> GetList(string search)
        {
            return await _branchQueryRepository.GetWhere(p =>(!string.IsNullOrEmpty(search)) &&(
                p.Company.CompanyName.ToLower().Contains(search.ToLower()) || p.BranchName.ToLower().Contains(search.ToLower())
                )).ToListAsync();
        }

        public async Task<IList<Branch>> GetListByCompanyId(Guid id)
        {
            return await _branchQueryRepository.GetWhere(p => p.CompanyId == id).ToListAsync();
        }

        public async Task UpdateAsync(Branch branch, CancellationToken cancellation)
        {
            _branchCommandRepository.Update(branch);
            await _unitOfWork.SaveChangesAsync(cancellation);
        }
    }
}

