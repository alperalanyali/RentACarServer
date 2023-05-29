using System;
namespace Application.Features.CarBranchFeatures.Commands.CreateCarBranch
{
	public sealed record CreateCarBranchCommandResponse(
		bool isSuccess = false,
		string Message = "Kayıt eklenmemiştir."
		);

}

