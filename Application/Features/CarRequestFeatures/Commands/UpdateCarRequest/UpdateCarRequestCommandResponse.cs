using System;
namespace Application.Features.CarRequestFeatures.Commands.UpdateCarRequest
{
	public sealed record UpdateCarRequestCommandResponse(
		string Message = "Güncelleme başarılı şekilde gerçekleşmiştir."
		);
	
}

