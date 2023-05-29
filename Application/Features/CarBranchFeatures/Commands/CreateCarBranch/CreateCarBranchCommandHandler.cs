using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.CarBranchFeatures.Commands.CreateCarBranch
{
	public class CreateCarBranchCommandHandler:ICommandHandler<CreateCarBranchCommand,CreateCarBranchCommandResponse>
	{
        private readonly ICarBranchService _carBranchService;
		public CreateCarBranchCommandHandler(ICarBranchService carBranchService)
		{
            _carBranchService = carBranchService;
		}

        public async Task<CreateCarBranchCommandResponse> Handle(CreateCarBranchCommand request, CancellationToken cancellationToken)
        {
            var newCarBranch = new CarBranch(request.BranchId, request.CarId);
            await _carBranchService.CreateCarBranch(newCarBranch, cancellationToken);
            return new(true,"Kayıt başarılı şekilde oluşturuldu");
        }
    }
}

