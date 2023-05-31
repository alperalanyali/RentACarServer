using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarBranchFeatures.Commands.UpdateCarBranch
{
	public class UpdateCarBranchCommandHandler:ICommandHandler<UpdateCarBranchCommand,UpdateCarBranchCommandResponse>
	{
        private readonly ICarBranchService _carBranchService;
		public UpdateCarBranchCommandHandler(ICarBranchService carBranchService)
		{
            _carBranchService = carBranchService;
		}

        public async Task<UpdateCarBranchCommandResponse> Handle(UpdateCarBranchCommand request, CancellationToken cancellationToken)
        {
            var carBranch = await _carBranchService.GetById(request.Id);
            carBranch.CarId = request.CarId;
            carBranch.BranchId = request.BranchId;
            await _carBranchService.UpdateAsync(carBranch, cancellationToken);
            return new();
        }
    }
}

