using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarBranchFeatures.Queries.GetCarBranchesByBranchId
{
	public class GetCarBranchesByBranchIdQueryHandler:IQueryHandler<GetCarBranchesByBranchIdQuery,GetCarBranchesByBranchIdQueryResponse>
	{

        private readonly ICarBranchService _carBranchService;
		public GetCarBranchesByBranchIdQueryHandler(ICarBranchService carBranchService)
		{
            _carBranchService = carBranchService;
		}

        public async Task<GetCarBranchesByBranchIdQueryResponse> Handle(GetCarBranchesByBranchIdQuery request, CancellationToken cancellationToken)
        {
            var list = await _carBranchService.GetCarBranchesByBranchId(request.BranchId);
            return new(list, true);
        }
    }
}

