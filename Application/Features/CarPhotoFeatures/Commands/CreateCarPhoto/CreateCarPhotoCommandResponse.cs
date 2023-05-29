using System;
namespace Application.Features.CarPhotoFeatures.Commands.CreateCarPhoto
{
	public sealed record CreateCarPhotoCommandResponse(
		bool isSuccess = false,
		string Message = "İşlem başarılı"
		);
	
}

