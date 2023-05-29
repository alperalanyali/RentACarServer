using System;
namespace Application.Features.BranchFeatures.Commands.UpdateBranch
{
	public sealed record UpdateBranchCommandResponse(
		string Message = "Başarılı şekilde güncellenmiştir"
		);
	
}

