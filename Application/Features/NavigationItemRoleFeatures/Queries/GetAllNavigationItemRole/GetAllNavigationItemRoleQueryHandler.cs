using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemRoleFeatures.Queries.GetAllNavigationItemRole
{
	public class GetAllNavigationItemRoleQueryHandler:IQueryHandler<GetAllNavigationItemRoleQuery,GetAllNavigationItemRoleQueryResponse>
	{
        private readonly INavigationItemRoleService _navItemRoleService;
		public GetAllNavigationItemRoleQueryHandler(INavigationItemRoleService navigationItemRoleService)
		{
            _navItemRoleService = navigationItemRoleService;
		}

        public async Task<GetAllNavigationItemRoleQueryResponse> Handle(GetAllNavigationItemRoleQuery request, CancellationToken cancellationToken)
        {
            var list = await _navItemRoleService.GetAll(request.search);

            return new(list, true);
        }
    }
}

