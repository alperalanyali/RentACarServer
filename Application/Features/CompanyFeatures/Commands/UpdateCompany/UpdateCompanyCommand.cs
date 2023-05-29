using System;
using Application.Messaging;

namespace Application.Features.CompanyFeatures.Commands.UpdateCompany
{
	public sealed record UpdateCompanyCommand(
		    string Id,
            string CompanyName,
            string Address1,
            string Address2,
            string TaxNumber,
            string City,
            string Country,
            IFormFile Logo
        ) :ICommand<UpdateCompanyCommandResponse>;
	
}

