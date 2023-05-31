using System;
namespace Application.Features.CarBranchFeatures.Commands.DeleteCarBranch
{
	public sealed record DeleteCarBranchCommandResponse(
		string Message = "Kayıt başarılı şekilde silinmiştir"
		);
	
}

