using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.NavigationItemRoleFeatures.Commands.CreateNavigationItemRole
{
	public class CreateNavigationItemRoleCommandHandler:ICommandHandler<CreateNavigationItemRoleCommand,CreateNavigationItemRoleCommandResponse>
	{
        private readonly INavigationItemRoleService _navigationItemRoleService;
		public CreateNavigationItemRoleCommandHandler(INavigationItemRoleService navigationItemRoleService)
		{
            _navigationItemRoleService = navigationItemRoleService;
		}

        public async Task<CreateNavigationItemRoleCommandResponse> Handle(CreateNavigationItemRoleCommand request, CancellationToken cancellationToken)
        {
            var navItemRole = new NavigationItemRole(request.navigationId,request.roleId);

            await _navigationItemRoleService.Create(navItemRole, cancellationToken);
            return new();
        }
    }
}

