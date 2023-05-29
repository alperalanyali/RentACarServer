using System;
namespace Application.Features.CompanyFeatures.Commands.UpdateCompany
{
	public sealed record UpdateCompanyCommandResponse(
		 bool IsSuccess = false,
		 string Message = "Şirket başarılı şekilde güncellenmiştir"
		);

}

