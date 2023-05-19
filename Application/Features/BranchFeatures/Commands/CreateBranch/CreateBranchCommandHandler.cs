using System;
using Application.Messaging;

namespace Application.Features.BranchFeatures.Commands.CreateBranch
{
    public sealed class CreateBranchCommandHandler : ICommandHandler<CreateBranchCommand, CreateBranchCommandResponse>
    {
        
        public CreateBranchCommandHandler()
        {

        }
        public Task<CreateBranchCommandResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

