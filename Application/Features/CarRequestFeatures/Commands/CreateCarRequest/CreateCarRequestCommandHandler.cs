using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.CarRequestFeatures.Commands.CreateCarRequest
{
	public class CreateCarRequestCommandHandler:ICommandHandler<CreateCarRequestCommand,CreateCarRequestCommandResponse>
	{

        private readonly ICarRequestService _carRequestService;
		public CreateCarRequestCommandHandler(ICarRequestService carRequestService)
		{
            _carRequestService = carRequestService;
		}

        public async Task<CreateCarRequestCommandResponse> Handle(CreateCarRequestCommand request, CancellationToken cancellationToken)
        {
            var carRequest = new CarRequest(request.UserId,request.CarId,request.BookingDate);
            await _carRequestService.CreateCarRequest(carRequest, cancellationToken);
            return new();
        }
    }
}

