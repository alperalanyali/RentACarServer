using System;
using System.Collections.Generic;
using Application.Messaging;
using Application.Services;
using Domain.Dtos;

namespace Application.Features.NavigationItemFeatures.Queries.GetNavItemsByTopNavId
{
	public class GetNavItemsByTopNavIdCommandHandler:ICommandHandler<GetNavItemsByTopNavIdCommand,GetNavItemsByTopNavIdCommandResponse>
	{
        private readonly INavigationItemService _navItemService;
		public GetNavItemsByTopNavIdCommandHandler(INavigationItemService navigationItemService)
		{
            _navItemService = navigationItemService;
		}

        public async Task<GetNavItemsByTopNavIdCommandResponse> Handle(GetNavItemsByTopNavIdCommand request, CancellationToken cancellationToken)
        {
            var navItems = await _navItemService.GetNavigationItemsByTopBarId(request.TopNavId);
            //var navigationItemDtos =  navItems.Select(p => new NavigationItemDto(p.Id.ToString(), p.NavigationName, p.NavigationPath, p.NavigationComponentName, p.NavigationPathMobile, p.TopNavBarId, p.Priority, null)).ToList();


            return new (navItems.Count(), navItems);
        }
    }
}

