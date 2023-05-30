using System;
namespace Application.Features.NavigationItemFeatures.Commands.CreateNavigationItem
{
	public sealed record CreateNavigationItemCommandResponse(
		string Message = "Kayıt başarılı şekilde oluşturulmuştur."
		);

}

