using System;
using Application.Messaging;

namespace Application.Features.UserCompanyFeatures.Commands.UpdateUserCompany
{
	public sealed record UpdateUserCompanyCommand(
			Guid Id,
			Guid UserId,
			Guid CompanyId

		):ICommand<UpdateUserCompanyCommandResponse>;
	
}

