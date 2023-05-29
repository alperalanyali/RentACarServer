using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.UserRoleFeatures.Commands.CreateUserRole
{
	public class CreateUserRoleCommandHandler:ICommandHandler<CreateUserRoleCommand,CreateUserRoleCommandResponse>
	{
        private readonly IUserRoleService _userRoleService;
		public CreateUserRoleCommandHandler(IUserRoleService userRoleService)
		{
            _userRoleService = userRoleService;
		}

        public async Task<CreateUserRoleCommandResponse> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var newUserRole = new UserRole(request.UserId, request.RoleId);
            await _userRoleService.CreateAsync(newUserRole, cancellationToken);
            return new(true, "İşlem Başarılı");
        }
    }
}

