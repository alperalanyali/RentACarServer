using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarRequestFeatures.Commands.UpdateCarRequest
{
	public class UpdateCarRequestCommandHandler:ICommandHandler<UpdateCarRequestCommand,UpdateCarRequestCommandResponse>
	{
        private readonly ICarRequestService _carRequestService;
		public UpdateCarRequestCommandHandler(ICarRequestService carRequestService)
		{
            _carRequestService = carRequestService;
		}

        public async Task<UpdateCarRequestCommandResponse> Handle(UpdateCarRequestCommand request, CancellationToken cancellationToken)
        {
            var carRequest = await _carRequestService.GetById(request.Id);
            var response = new UpdateCarRequestCommandResponse();
            if (carRequest != null)
            {
                carRequest.CarId = request.CarId;
                carRequest.UserId = request.UserId;
           

                await _carRequestService.UpdateCarRequest(carRequest, cancellationToken);
            }else
            {
                response = new UpdateCarRequestCommandResponse("Böyle bir kayıt bulunamadı");
            }

            return response;
        }
    }
}

