using System;
namespace Application.Features.UserCompanyFeatures.Commands.UpdateUserCompany
{
	public sealed record UpdateUserCompanyCommandResponse(
		string Message = "Kayıt başarılı şekilde güncellenmiştir"
		);
	
}

