using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserRoleFeatures.Commands.UpdateUserRole
{
	public class UpdateUserRoleCommandHandler:ICommandHandler<UpdateUserRoleCommand,UpdateUserRoleCommandResponse>
	{
        private readonly IUserRoleService _userRoleService;
		public UpdateUserRoleCommandHandler(IUserRoleService userRoleService)
		{
            _userRoleService = userRoleService;
		}

        public async Task<UpdateUserRoleCommandResponse> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var userRole = await _userRoleService.GetById(request.Id);
            var response = new UpdateUserRoleCommandResponse();
            if(userRole != null)
            {
                userRole.UserId = request.UserId;
                userRole.RoleId = request.RoleId;

                await _userRoleService.UpdateAsync(userRole, cancellationToken);
            }
            return response;
        }
    }
}

