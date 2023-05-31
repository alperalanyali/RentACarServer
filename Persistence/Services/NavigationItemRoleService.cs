using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.NavigationItemRoleRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class NavigationItemRoleService : INavigationItemRoleService
    {

        private readonly INavigationItemRoleCommandRepository _navigationItemRoleCommand;
        private readonly INavigationItemRoleQueryRepository _navigationItemRoleQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public NavigationItemRoleService(INavigationItemRoleCommandRepository navigationItemRoleCommandRepository, INavigationItemRoleQueryRepository navigationItemRoleQuery, IAppUnitOfWork appUnitOfWork)
        {
            _navigationItemRoleCommand = navigationItemRoleCommandRepository;
            _navigationItemRoleQuery = navigationItemRoleQuery;
            _unitOfWork = appUnitOfWork;
        }

        public async Task Create(NavigationItemRole navigationItemRole, CancellationToken cancellationToken)
        {
            await _navigationItemRoleCommand.AddAsync(navigationItemRole, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Guid id,CancellationToken cancellationToken)
        {
            await _navigationItemRoleCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<NavigationItemRole>> GetAll(string search)
        {
            var list = await _navigationItemRoleQuery.GetAllAsync().Include(p => p.NavigationItem).Include(p => p.Role).ToListAsync();
            if (!String.IsNullOrEmpty(search))
            {
                list = await _navigationItemRoleQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (
                p.NavigationItem.NavigationName.ToLower().Contains(search.ToLower())
                || p.Role.Name.ToLower().Contains(search.ToLower())
            )).Include(p => p.Role).Include(p => p.NavigationItem).ToListAsync();

            }

            return list;
        }

        public async Task<NavigationItemRole> GetById(Guid id)
        {
            var navItemRole = await _navigationItemRoleQuery.GetById(id.ToString());
            return navItemRole;
        }

        public async Task<IList<NavigationItemRole>> GetNavigationItemRoleByRoleId(Guid roleId,string search)
        {
            var list = await _navigationItemRoleQuery.GetAllAsync().Include(p => p.NavigationItem).Include(p => p.Role).ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _navigationItemRoleQuery.GetWhere(p => p.RoleId == roleId && (
                 !string.IsNullOrEmpty(search) && (
                    p.NavigationItem.NavigationName.ToLower().Contains(search.ToLower())
                    || p.NavigationItem.NavigationPath.ToLower().Contains(search.ToLower())
                 )
                )).Include(p => p.Role).Include(p => p.NavigationItem).ToListAsync();
            }
            
            return list;
        }

        public async Task Update(NavigationItemRole navigationItem, CancellationToken cancellationToken)
        {
            _navigationItemRoleCommand.Update(navigationItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

