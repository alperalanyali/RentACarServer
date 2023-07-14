using System;
using Application.Messaging;

namespace Application.Features.CompanyFeatures.Commands.CreateCompanyCommand
{
	public sealed record CreateCompanyCommand(
		string CompanyName,
		string Address1,
		string Address2,
		string TaxNumber,
		string City,
		string Country,
		string Logo,
		IFormFile? LogoForm

		):ICommand<CreateCompanyCommandResponse>;
	
}

