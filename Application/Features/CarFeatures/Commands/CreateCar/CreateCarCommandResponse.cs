using System;
namespace Application.Features.CarFeatures.CreateCar
{
	public sealed record CreateCarCommandResponse(
		string Message = "Başarılı şekilde araç eklenmiştir.");

}

