using System;
using Application.Messaging;

namespace Application.Features.UserCompanyFeatures.Commands.CreateUserCompany
{
	public sealed record CreateUserCompanyCommand(
		Guid UserId,Guid CompanyId
		): ICommand<CreateUserCompanyCommandResponse>;

}

