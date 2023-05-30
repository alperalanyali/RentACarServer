using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarRequestFeatures.Commands.DeleteCarRequest
{
	public class DeleteCarRequestCommandHandler:ICommandHandler<DeleteCarRequestCommand,DeleteCarRequestCommandResponse>
	{
        private readonly ICarRequestService _carRequestService;
		public DeleteCarRequestCommandHandler(ICarRequestService carRequestService)
		{
            _carRequestService = carRequestService;
		}

        public async Task<DeleteCarRequestCommandResponse> Handle(DeleteCarRequestCommand request, CancellationToken cancellationToken)
        {
            var carRequest = await _carRequestService.GetById(request.Id);
            var response = new DeleteCarRequestCommandResponse();
            if(carRequest != null)
            {
                await _carRequestService.DeleteCarRequest(request.Id,cancellationToken);

            }else
            {
                response = new DeleteCarRequestCommandResponse("Böyle bir kayıt bulunmamıştır.");
            }

            return response;
        }
    }
}

