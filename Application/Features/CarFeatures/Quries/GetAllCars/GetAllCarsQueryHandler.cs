using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarFeatures.Quries.GetAllCars
{
	public class GetAllCarsQueryHandler:IQueryHandler<GetAllCarsQuery,GetAllCarsQueryResponse>
	{
        private readonly ICarService _carService;
		public GetAllCarsQueryHandler(ICarService carService)
		{
            _carService = carService;
		}

        public async Task<GetAllCarsQueryResponse> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            var response = new GetAllCarsQueryResponse();
            response.Data = await _carService.GetList(request.Search);
            return response;
        }
    }
}

