using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.UserRoleRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class UserRoleService : IUserRoleService
    {

        private readonly IUserRoleCommandRepository _userRoleCommandRepository;
        private readonly IUserRoleQueryRepository _userRoleQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public UserRoleService(IUserRoleCommandRepository userRoleCommandRepository, IUserRoleQueryRepository userRoleQueryRepository, IAppUnitOfWork appUnitOfWork )
        {
            _userRoleCommandRepository = userRoleCommandRepository;
            _userRoleQuery = userRoleQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateAsync(UserRole userRole, CancellationToken cancellationToken)
        {
            await _userRoleCommandRepository.AddAsync(userRole, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<UserRole> GetById(Guid id)
        {
            var userRole = await _userRoleQuery.GetById(id.ToString());
            return userRole;
        }

        public async Task<IList<UserRole>> GetList(string search)
        {
            var list = await _userRoleQuery.GetAllAsync().Include(p => p.User).Include(p => p.Role).ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _userRoleQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (
                    (p.User.UserName.ToLower().Contains(search.ToLower()) )
                    || (p.User.FullName.ToLower().Contains(search.ToLower()))
                    || (p.Role.Name.ToLower().Contains(search.ToLower()))
                )).Include(p => p.User).Include(p => p.Role).ToListAsync();
            }
            return list;
        }

        public async Task<IList<UserRole>> GetListByUserId(Guid userId)
        {
            return await _userRoleQuery.GetWhere(p => p.UserId == userId).Include(p => p.User).Include(p => p.Role).ToListAsync();
        }

        public async Task RemoveAsync(Guid id, CancellationToken cancellationToken)
        {
            await _userRoleCommandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(UserRole userRole, CancellationToken cancellationToken)
        {
             _userRoleCommandRepository.Update(userRole);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }
    }
}

