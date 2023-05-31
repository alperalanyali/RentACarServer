using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarPhotoFeatures.Commands.DeleteCarPhoto
{
	public class DeleteCarPhotoCommandHandler:ICommandHandler<DeleteCarPhotoCommand,DeleteCarPhotoCommandResponse>
	{
        private readonly ICarPhotoService _carPhotoService;
		public DeleteCarPhotoCommandHandler(ICarPhotoService carPhotoService)
		{
            _carPhotoService = carPhotoService;
		}

        public async Task<DeleteCarPhotoCommandResponse> Handle(DeleteCarPhotoCommand request, CancellationToken cancellationToken)
        {
            var response = new DeleteCarPhotoCommandResponse();
            var carPhoto = await _carPhotoService.GetById(request.Id);
            if(carPhoto != null)
            {
                await _carPhotoService.DeleteById(request.Id, cancellationToken);
                response.Message = "Kayıt başarılı şekilde silinmiştir.";
            }else
            {
                response.Message = "Böyle bir kayıt yoktur.";
            }
            return response;
        }
    }
}

