using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarFeatures.Commands.UpdateCar
{
	public class UpdateCarCommandHandler:ICommandHandler<UpdateCarCommand,UpdateCarCommandResponse>
	{
        private readonly ICarService _carService;
		public UpdateCarCommandHandler(ICarService carService)
		{
            _carService = carService;
		}

        public async Task<UpdateCarCommandResponse> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var car = await _carService.GetById(request.Id);
            var response = new UpdateCarCommandResponse();
            if(car != null)
            {
                car.LicenseNumber = request.LicenseNumber;
                car.Color = request.Color;
                car.ManufacturedDate = request.ManufacturedDate;
                car.Model = request.Model;
                await _carService.UpdateCarAsync(car, cancellationToken);

                response.Message = "Kayıt başarılı şekilde güncellenmiştir";
            }else
            {
                response.Message = "Böyle bir kayıt yoktur";
            }

            return response;

        }
    }
}

