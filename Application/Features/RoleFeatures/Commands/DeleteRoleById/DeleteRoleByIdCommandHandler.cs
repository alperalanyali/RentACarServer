using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.RoleFeatures.Commands.DeleteRoleById
{
	public class DeleteRoleByIdCommandHandler:ICommandHandler<DeleteRoleByIdCommand,DeleteRoleByIdCommandResponse>
	{
        private readonly IRoleService _roleService;
		public DeleteRoleByIdCommandHandler(IRoleService roleService)
		{
            _roleService = roleService;
		}

        public async Task<DeleteRoleByIdCommandResponse> Handle(DeleteRoleByIdCommand request, CancellationToken cancellationToken)
        {
            var role = await _roleService.GetById(request.Id);
            role.isDeleted = !role.isDeleted;
            role.UpdatedDate = DateTime.Now;
            await _roleService.UpdateAsync(role, cancellationToken);

            return new();
        }
    }
}

