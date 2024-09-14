using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarRequestFeatures.Queries.GetCarRequestsByUserId
{
    public class GetCarRequestsByUserIdQueryHandler : IQueryHandler<GetCarRequestsByUserIdQuery, GetCarRequestsByUserIdResponse>
    {
        private readonly ICarRequestService _carRequestService;

        public GetCarRequestsByUserIdQueryHandler(ICarRequestService carRequestService)
        {
            _carRequestService = carRequestService;
        }
        public async Task<GetCarRequestsByUserIdResponse> Handle(GetCarRequestsByUserIdQuery request, CancellationToken cancellationToken)
        {
            
            var carRequests = await _carRequestService.GetCarRequestsByUserId(request.UserId,request.CurrentPage,request.PageSize,cancellationToken);
            
            return new GetCarRequestsByUserIdResponse(carRequests,true,carRequests.Count);

        }
    }
}