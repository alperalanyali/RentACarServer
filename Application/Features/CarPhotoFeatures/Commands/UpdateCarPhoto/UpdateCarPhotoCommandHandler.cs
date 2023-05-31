using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarPhotoFeatures.Commands.UpdateCarPhoto
{
	public class UpdateCarPhotoHandler:ICommandHandler<UpdateCarPhotoCommand,UpdateCarPhotoCommandResponse>
	{
        private readonly ICarPhotoService _carPhotoService;
		public UpdateCarPhotoHandler(ICarPhotoService carPhotoService)
		{
            _carPhotoService = carPhotoService;
		}

        public async Task<UpdateCarPhotoCommandResponse> Handle(UpdateCarPhotoCommand request, CancellationToken cancellationToken)
        {
            var response = new UpdateCarPhotoCommandResponse();
            var carPhoto = await _carPhotoService.GetById(request.Id);
           
            if(carPhoto != null)
            {
                carPhoto.CarId = request.CarId;
                var base64 = Helpers.FileService.ConvertIFormFileToBase64("jpg", request.Photo);
                carPhoto.PhotoBase64 = base64;
                await _carPhotoService.UpdateAsync(carPhoto, cancellationToken);
                
            }else
            {
                response.Message = "Böyle bir kayıt yoktur";
            }
            return response;
        }
    }
}

