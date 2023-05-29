using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.BranchFeatures.Commands.CreateBranch
{
    public sealed class CreateBranchCommandHandler : ICommandHandler<CreateBranchCommand, CreateBranchCommandResponse>
    {
        private IBranchService _branchService;
        public CreateBranchCommandHandler(IBranchService branchService)
        {
            _branchService = branchService;
        }
        public async Task<CreateBranchCommandResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = new Branch(request.BranchName,request.TaxNumber,request.Address1,request.Address2,request.City,request.Country,request.CompanyId);
            await _branchService.CreateAsync(branch
                , cancellationToken);
            return new();
        }
    }
}

