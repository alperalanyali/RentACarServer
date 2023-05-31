using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserRoleFeatures.Commands.DeleteUserRole
{
	public class DeleteUserRoleCommandHandler:ICommandHandler<DeleteUserRoleCommand,DeleteUserRoleCommandResponse>
	{
        private readonly IUserRoleService _userRoleService;

		public DeleteUserRoleCommandHandler(IUserRoleService userRoleService)
		{
            _userRoleService = userRoleService;
		}

        public async Task<DeleteUserRoleCommandResponse> Handle(DeleteUserRoleCommand request, CancellationToken cancellationToken)
        {
            var userRole = await _userRoleService.GetById(request.Id);
            var response = new DeleteUserRoleCommandResponse();
            if(userRole != null)
            {
                await _userRoleService.RemoveAsync(request.Id, cancellationToken);
            }else
            {
                response = new DeleteUserRoleCommandResponse("Böyle bir kayıt yoktur");
            }
            return response;
        }
    }
}

