using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarBranchFeatures.Queries.GetCarBranchesByCarId
{
	public class GetCarBranchesByCarIdQueryHandler:IQueryHandler<GetCarBranchesByCarIdQuery,GetCarBranchesByCarIdQueryResponse>
	{
        private readonly ICarBranchService _carBranchService;
		public GetCarBranchesByCarIdQueryHandler(ICarBranchService carBranchService)
		{
            _carBranchService = carBranchService;
		}

        public async Task<GetCarBranchesByCarIdQueryResponse> Handle(GetCarBranchesByCarIdQuery request, CancellationToken cancellationToken)
        {
            var list = await _carBranchService.GetCarBranchesByCarId(request.CarId);
            return new(list, true);
        }
    }
}

