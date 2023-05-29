using System;
using Application.Messaging;

namespace Application.Features.BranchFeatures.Commands.CreateBranch
{
	public sealed record CreateBranchCommand(
        string BranchName,
         string TaxNumber,
         string Address1, 
         string Address2 ,
         string City ,
         string Country,
         Guid CompanyId
		):ICommand<CreateBranchCommandResponse>;
	
}

