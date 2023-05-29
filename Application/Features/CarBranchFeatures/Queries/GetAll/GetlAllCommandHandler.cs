using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.CarBranchFeatures.Queries.GetAll
{
    public class GetlAllCommandHandler : ICommandHandler<GetlAllCommand, GetlAllCommandResponse>
    {

        private readonly ICarBranchService _carBranchService;
        public GetlAllCommandHandler(ICarBranchService carBranchService)
        {
            _carBranchService = carBranchService;
        }
        public async Task<GetlAllCommandResponse> Handle(GetlAllCommand request, CancellationToken cancellationToken)
        {
            var result = await _carBranchService.GetAll(request.search);
            return new(result,true);
        }
    }


}

