using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarRequestFeatures.Queries.GetAllCarRequest
{
	public class GetAllCarRequestQueryHandler:IQueryHandler<GetAllCarRequestQuery,GetAllCarRequestQueryResponse>
	{
        private readonly ICarRequestService _carRequestService;
		public GetAllCarRequestQueryHandler(ICarRequestService carRequestService)
		{
            _carRequestService = carRequestService;
		}

        public async Task<GetAllCarRequestQueryResponse> Handle(GetAllCarRequestQuery request, CancellationToken cancellationToken)
        {
            var list = await _carRequestService.GetAll(request.search);

            return new(list, true);
        }
    }
}

