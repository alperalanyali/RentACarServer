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

        public Task<RemoveBranchCommandResponse> Handle(RemoveBranchCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

