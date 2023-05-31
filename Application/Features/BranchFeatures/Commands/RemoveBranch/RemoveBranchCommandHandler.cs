using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.BranchFeatures.Commands.RemoveBranch
{
	public class RemoveBranchCommandHandler:ICommandHandler<RemoveBranchCommand,RemoveBranchCommandResponse>
	{

        private readonly IBranchService _branchService;
		public RemoveBranchCommandHandler(IBranchService branchService)
		{
            _branchService = branchService;
		}

        public async Task<RemoveBranchCommandResponse> Handle(RemoveBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = _branchService.GetById(request.id);
            var response = new RemoveBranchCommandResponse();
            if(branch != null)
            {
                await _branchService.DeleteById(request.id, cancellationToken);
            }else
            {
                response = new RemoveBranchCommandResponse("Böyle bir kayıt yoktur");
            }

            return response;
        }
    }
}

