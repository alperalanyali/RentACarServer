using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.RoleFeatures.Commands.CreateRole
{
	public class CreateRoleCommandHandler:ICommandHandler<CreateRoleCommand,CreateRoleCommandResponse>
	{
        private readonly IRoleService _roleService;
		public CreateRoleCommandHandler(IRoleService roleService)
		{
            _roleService = roleService;
		}

        public async Task<CreateRoleCommandResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var newRole = new Role(request.Name);
            await _roleService.CreateAsync(newRole, cancellationToken);
            return new(true, "İşlem başarılı");
        }
    }
}

