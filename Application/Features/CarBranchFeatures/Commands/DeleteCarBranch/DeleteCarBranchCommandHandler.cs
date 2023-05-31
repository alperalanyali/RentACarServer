using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarBranchFeatures.Commands.DeleteCarBranch
{
	public class DeleteCarBranchCommandHandler:ICommandHandler<DeleteCarBranchCommand,DeleteCarBranchCommandResponse>
	{
        private readonly ICarBranchService _carBranchService;
		public DeleteCarBranchCommandHandler(ICarBranchService carBranchService)
		{
            _carBranchService = carBranchService;
		}

        public async Task<DeleteCarBranchCommandResponse> Handle(DeleteCarBranchCommand request, CancellationToken cancellationToken)
        {
            var response = new DeleteCarBranchCommandResponse();
            var carBranch = await _carBranchService.GetById(request.Id);
            if(carBranch != null)
            {
                await _carBranchService.DeleteById(request.Id, cancellationToken);
            }else
            {
                response = new DeleteCarBranchCommandResponse("Böyle bir kayır yoktur");
            }

            return response;
        }
    }
}

