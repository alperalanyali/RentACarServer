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

        public async Task DeleteById(Guid id, CancellationToken cancellationToken)
        {
            _branchCommandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Branch> GetBranchDetailById(Guid id)
        {
            return await _branchQueryRepository.GetById(id.ToString());
        }

        public async Task<Branch> GetById(Guid id)
        {
            var branch = await _branchQueryRepository.GetById(id.ToString());
            return branch;
        }

        public async Task<IList<Branch>> GetList(string search)
        {
            var list = await _branchQueryRepository.GetAllAsync().Include(p => p.Company).ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _branchQueryRepository.GetWhere(p => (!string.IsNullOrEmpty(search)) && (
                p.Company.CompanyName.ToLower().Contains(search.ToLower()) || p.BranchName.ToLower().Contains(search.ToLower())
                )).Include(p => p.Company).ToListAsync();
            }
            return list;
        }

        public async Task<IList<Branch>> GetListByCompanyId(Guid id)
        {
            var branches = await _branchQueryRepository.GetWhere(p => p.CompanyId == id).ToListAsync();
            return branches;
        }

        public async Task UpdateAsync(Branch branch, CancellationToken cancellation)
        {
            _branchCommandRepository.Update(branch);
            await _unitOfWork.SaveChangesAsync(cancellation);
        }
    }
}

