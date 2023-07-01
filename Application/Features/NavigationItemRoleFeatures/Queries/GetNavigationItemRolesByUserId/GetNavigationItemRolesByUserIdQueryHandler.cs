using System;
using System.Linq;
using Application.Messaging;
using Application.Services;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByUserId
{
	public class GetNavigationItemRolesByUserIdQueryHandler:IQueryHandler<GetNavigationItemRolesByUserIdQuery,GetNavigationItemRolesByUserIdQueryResponse>
	{
        private readonly INavigationItemRoleService _navItemRoleService;
        private readonly INavigationItemService _navItemService;
        private readonly IUserRoleService _userRoleService;
		public GetNavigationItemRolesByUserIdQueryHandler(INavigationItemRoleService navigationItemRoleService, IUserRoleService userRoleService,INavigationItemService navigationItemService)
		{
            _navItemRoleService = navigationItemRoleService;
            _userRoleService = userRoleService;
            _navItemService = navigationItemService;
		}

        public async Task<GetNavigationItemRolesByUserIdQueryResponse> Handle(GetNavigationItemRolesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var userRoles = await _userRoleService.GetListByUserId(new Guid(request.UserId));
            List<NavigationItemDto> dtos = new List<NavigationItemDto>();
            foreach (var userRole in userRoles)
            {
                var navItemRoles = await _navItemRoleService.GetNavigationItemRoleByUserId(userRole.RoleId);
                foreach (var navItemRole in navItemRoles.OrderBy(p => p.NavigationItem.Priority))
                {
                    bool alreadExist = dtos.Any(item => item.NavigationName == navItemRole.NavigationItem.NavigationName);
                    if (!alreadExist)
                    {
                        if (navItemRole.NavigationItem.TopNavBarId == "")
                        {
                            List<NavigationItem> list = new List<NavigationItem>();
                            list = await _navItemService.GetNavigationItemsByTopBarId(navItemRole.NavigationItem.Id.ToString());
                            var subMenuDto = list.Select(p => new NavigationItemDto(p.Id.ToString(), p.NavigationName, p.NavigationPath,p.NavigationComponentName,p.NavigationPathMobile, p.TopNavBarId, p.Priority, null)).ToList();
                            dtos.Add(new NavigationItemDto(navItemRole.NavigationItem.Id.ToString(), navItemRole.NavigationItem.NavigationName, navItemRole.NavigationItem.NavigationPath,navItemRole.NavigationItem.NavigationComponentName,navItemRole.NavigationItem.NavigationPathMobile, navItemRole.NavigationItem.TopNavBarId, navItemRole.NavigationItem.Priority, subMenuDto));
                        }
                    }

                }
            }
            

            return new(dtos, dtos.Count);
        }

        private static IOrderedEnumerable<NavigationItemDto> NewMethod(List<NavigationItemDto> dtos)
        {
            return dtos.OrderBy(p => p.Priority);
        }
    }
}

