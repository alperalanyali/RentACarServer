using System;
namespace Application.Features.CarFeatures.Commands.CreateCar
{
	public sealed record CreateCarCommandResponse(
		string Message = "Başarılı şekilde araç eklenmiştir.");

}

