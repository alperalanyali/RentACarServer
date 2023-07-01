using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.UserCompanyRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
	public class UserCompanyService:IUserCompanyService
	{
        private readonly IUserCompanyCommandRepository _userCompanyCommand;
        private readonly IUserCompanyQueryRepository _userCompanyQuery;
        private readonly IAppUnitOfWork _unitOfWork;
		public UserCompanyService(IUserCompanyCommandRepository userCompanyCommandRepository,IUserCompanyQueryRepository userCompanyQueryRepository,IAppUnitOfWork appUnitOfWork)
		{
            _userCompanyCommand = userCompanyCommandRepository;
            _userCompanyQuery = userCompanyQueryRepository;
            _unitOfWork = appUnitOfWork;
		}

        public async Task CreateAsync(UserCompany userCompany, CancellationToken cancellationToken)
        {
            await _userCompanyCommand.AddAsync(userCompany, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<UserCompany>> GetAllList(string search)
        {
            var list = await _userCompanyQuery.GetAllAsync().ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
               list = await _userCompanyQuery.GetWhere(p => (p.Company.CompanyName.ToLower().Contains(search.ToLower())
                                                            || p.User.FullName.ToLower().Contains(search.ToLower())
                                                            || p.User.Email.ToLower().Contains(search.ToLower()

                                                            ))).Include(p => p.User).Include(p => p.Company).ToListAsync();
            }
            return list;      
        }

        public async Task<UserCompany> GetById(Guid id)
        {
            var userCompany = await _userCompanyQuery.GetById(id.ToString());
            return userCompany;
        }

        public async Task<IList<UserCompany>> GetListByUserId(Guid userId)
        {
            var list = await _userCompanyQuery.GetWhere(p => p.UserId == userId).Include(p => p.Company).Include(p => p.User).ToListAsync();
            return list;
        }

        public async Task RemoveUserCompany(Guid id, CancellationToken cancellationToken)
        {
            await _userCompanyCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(UserCompany userCompany, CancellationToken cancellationToken)
        {
            _userCompanyCommand.Update(userCompany);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

