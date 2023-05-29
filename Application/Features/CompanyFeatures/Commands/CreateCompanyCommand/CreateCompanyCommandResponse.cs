using System;
namespace Application.Features.CompanyFeatures.Commands.CreateCompanyCommand
{
	public sealed record CreateCompanyCommandResponse(
		bool IsSuccess = false,
		string Message = "Şirket başarılı şekilde oluşturulmuştur."
		);

}

