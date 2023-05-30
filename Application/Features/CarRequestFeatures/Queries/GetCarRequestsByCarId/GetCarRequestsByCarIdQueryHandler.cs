using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarRequestFeatures.Queries.GetCarRequestsByCarId
{
	public class GetCarRequestsByCarIdQueryHandler:IQueryHandler<GetCarRequestsByCarIdQuery,GetCarRequestsByCarIdQueryResponse>
	{
        private readonly ICarRequestService _carRequestService;
		public GetCarRequestsByCarIdQueryHandler(ICarRequestService carRequestService)
		{
            _carRequestService = carRequestService;
		}

        public async Task<GetCarRequestsByCarIdQueryResponse> Handle(GetCarRequestsByCarIdQuery request, CancellationToken cancellationToken)
        {
            var list = await _carRequestService.GetCarRequestsByCarId(request.carId);

            return new(list, true);
        }
    }
}

