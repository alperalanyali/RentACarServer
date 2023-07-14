using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByRoleIdAndTopNavbarId
{
    public class GetNavigationItemRolesByRoleIdandTopNavbarIdQueryHandler : IQueryHandler<GetNavigationItemRolesByRoleIdAndTopNavbarIdQuery, GetNavigationItemRolesByRoleIdAndTopNavbarIdQueryResponse>
	{
        private readonly INavigationItemRoleService _navRoles;
        public GetNavigationItemRolesByRoleIdandTopNavbarIdQueryHandler(INavigationItemRoleService navigationItemRoleService)
        {
            _navRoles = navigationItemRoleService;
        }

        public async Task<GetNavigationItemRolesByRoleIdAndTopNavbarIdQueryResponse> Handle(GetNavigationItemRolesByRoleIdAndTopNavbarIdQuery request, CancellationToken cancellationToken)
        {
            var navItemRoles = await _navRoles.GetNavigationItemRolesByRoleIdandTopNavbarId(request.RoleId, request.TopNavBarId);
            return new(navItemRoles);

        }
    }
}

