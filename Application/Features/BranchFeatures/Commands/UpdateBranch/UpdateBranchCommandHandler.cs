using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.BranchFeatures.Commands.UpdateBranch
{
	public class UpdateBranchCommandHandler:ICommandHandler<UpdateBranchCommand,UpdateBranchCommandResponse>
	{
		private readonly IBranchService _branchService;
		public UpdateBranchCommandHandler(IBranchService branchService)
		{
		}

        public async Task<UpdateBranchCommandResponse> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
			var branch = await _branchService.GetBranchDetailById(request.Id);
			branch.BranchName = request.BranchName;
			branch.TaxNumber = request.TaxNumber;
			branch.Address1 = request.Address1;
			branch.Address2 = request.Address2;
			branch.City = request.City;
			branch.Country = request.Country;
			branch.CompanyId = request.CompanyId;
			await _branchService.UpdateAsync(branch, cancellationToken);
			return new();
        }
    }
}

