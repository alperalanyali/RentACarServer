using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarFeatures.Commands.CreateCar
{
	public class CreateCarCommandHandler:ICommandHandler<CreateCarCommand,CreateCarCommandResponse>
	{
        private readonly ICarService _carService;
		public CreateCarCommandHandler(ICarService carService)
		{
            _carService = carService;
		}

        public async Task<CreateCarCommandResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _carService.CreateCarAsync(request, cancellationToken);
            var response = new CreateCarCommandResponse();
            return response;
        }
    }
}

