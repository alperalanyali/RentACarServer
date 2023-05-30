using System;
namespace Application.Features.CarRequestFeatures.Commands.CreateCarRequest
{
	public sealed record CreateCarRequestCommandResponse(
		string Message = "Kayıt başarılı şekilde oluşturuldu"
		);
	
}

