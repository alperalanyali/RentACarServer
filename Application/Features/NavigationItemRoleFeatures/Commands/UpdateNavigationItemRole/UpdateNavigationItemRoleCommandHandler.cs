using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemRoleFeatures.Commands.UpdateNavigationItemRole
{
	public class UpdateNavigationItemRoleCommandHandler:ICommandHandler<UpdateNavigationItemRoleCommand,UpdateNavigationItemRoleCommandResponse>
	{
        private readonly INavigationItemRoleService _navItemRoleService;
		public UpdateNavigationItemRoleCommandHandler(INavigationItemRoleService navigationItemRoleService)
		{
            _navItemRoleService = navigationItemRoleService;
		}


        public async Task<UpdateNavigationItemRoleCommandResponse> Handle(UpdateNavigationItemRoleCommand request, CancellationToken cancellationToken)
        {
            var navItemRole = await _navItemRoleService.GetById(request.Id);
            var response = new UpdateNavigationItemRoleCommandResponse();
            if(navItemRole != null)
            {
                navItemRole.NavigationItemId = request.NavigationItemId;
                navItemRole.RoleId = request.RoleId;

                await _navItemRoleService.Update(navItemRole, cancellationToken);
            }
            return response;
        }
    }
}

