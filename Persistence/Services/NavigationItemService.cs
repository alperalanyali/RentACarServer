using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.NavigationItemRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class NavigationItemService : INavigationItemService
    {
        private readonly INavigationItemCommandRepository _navigationItemCommand;
        private readonly INavigationItemQueryRepository _navigationItemQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public NavigationItemService(INavigationItemCommandRepository navigationItemCommandRepository, INavigationItemQueryRepository navigationItemQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _navigationItemCommand = navigationItemCommandRepository;
            _navigationItemQuery = navigationItemQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateAsync(NavigationItem navigationItem, CancellationToken cancellationToken)
        {
            await _navigationItemCommand.AddAsync(navigationItem, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Guid id,CancellationToken cancellationToken)
        {
            await _navigationItemCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            
        }

        public async Task<IList<NavigationItem>> GetAll(string search)
        {
            var list = await _navigationItemQuery.GetAllAsync().ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _navigationItemQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (p.NavigationName.ToLower().Contains(search.ToLower())
               || (p.NavigationPath.ToLower().Contains(search.ToLower()))
               )).ToListAsync();
            }
            return list;
        }

        public async Task<NavigationItem> GetById(Guid id)
        {
            var navItem = await _navigationItemQuery.GetById(id.ToString());
            return navItem;
        }

        public async Task<List<NavigationItem>> GetNavigationItemsByTopBarId(string topNavBarId)
        {
            return await _navigationItemQuery.GetWhere(p => p.TopNavBarId == topNavBarId).ToListAsync();
        }

        public async Task Update(NavigationItem navigationItem, CancellationToken cancellationToken)
        {
             _navigationItemCommand.Update(navigationItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

