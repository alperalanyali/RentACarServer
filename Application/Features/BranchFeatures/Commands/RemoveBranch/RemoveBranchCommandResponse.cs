using System;
namespace Application.Features.BranchFeatures.Commands.RemoveBranch
{
	public sealed record RemoveBranchCommandResponse(
		string Message="Şube başarılı şekilde silinmiştir"
		);
	
}

