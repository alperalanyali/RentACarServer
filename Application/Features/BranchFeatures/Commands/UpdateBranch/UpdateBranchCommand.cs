using System;
using Application.Messaging;

namespace Application.Features.BranchFeatures.Commands.UpdateBranch
{
	public sealed record UpdateBranchCommand(
         Guid Id,
         string BranchName,
         string TaxNumber,
         string Address1,
         string Address2,
         string City,
         string Country,
         Guid CompanyId
        ) :ICommand<UpdateBranchCommandResponse>;

}

