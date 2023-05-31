using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarFeatures.Commands.DeleteCar
{
	public class DeleteCarCommandHandler:ICommandHandler<DeleteCarCommand,DeleteCarCommandResponse>
	{
        private readonly ICarService _carService;
		public DeleteCarCommandHandler(ICarService carService)
		{
            _carService = carService;
		}

        public async Task<DeleteCarCommandResponse> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var car = await _carService.GetById(request.Id);
            var response = new DeleteCarCommandResponse();
            if(car != null)
            {
                await _carService.DeleteById(request.Id, cancellationToken);
            }else
            {
                response = new DeleteCarCommandResponse("Böyle bir kayıt yoktur");
            }

            return response;
        }
    }
}

