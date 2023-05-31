using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.CompanyRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyCommandRepository _companyCommand;
        private readonly ICompanyQueryRepository _companyQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public CompanyService(ICompanyCommandRepository companyCommandRepository, ICompanyQueryRepository companyQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _companyCommand = companyCommandRepository;
            _companyQuery = companyQueryRepository;
            _unitOfWork = appUnitOfWork;
        }


        public async Task CreateAsync(Company company, CancellationToken cancellationToken)
        {
            await _companyCommand.AddAsync(company, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Company> GetById(Guid id,bool isTracking= true)
        {
            return await _companyQuery.GetById(id.ToString(),isTracking);
        }

        public async Task<IList<Company>> GetList(string search)
        {
            var list = await _companyQuery.GetAllAsync().ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _companyQuery.GetWhere(p => (!string.IsNullOrEmpty(search)) && (
                p.CompanyName.ToLower().Contains(search.ToLower())
            )).ToListAsync();
            }            
            return list;
        }

        public async Task UpdateAsync(Company company, CancellationToken cancellationToken)
        {
            _companyCommand.Update(company);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

