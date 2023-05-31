using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemRoleFeatures.Commands.DeleteNavigationItemRole
{
	public class DeleteNavigationItemRoleCommandHandler:ICommandHandler<DeleteNavigationItemRoleCommand,DeleteNavigationItemRoleCommandResponse>
	{
        private readonly INavigationItemRoleService _navItemRoleService;
		public DeleteNavigationItemRoleCommandHandler(INavigationItemRoleService navigationItemRoleService)
		{
            _navItemRoleService = navigationItemRoleService;
		}

        public async Task<DeleteNavigationItemRoleCommandResponse> Handle(DeleteNavigationItemRoleCommand request, CancellationToken cancellationToken)
        {
            var response = new DeleteNavigationItemRoleCommandResponse();
            var navItemRole = await _navItemRoleService.GetById(request.Id);
            if(navItemRole != null)
            {
                await _navItemRoleService.Delete(request.Id, cancellationToken);

            }else
            {
                response = new DeleteNavigationItemRoleCommandResponse("Böyle bir kayıt yoktur");
            }

            return response;
        }
    }
}

