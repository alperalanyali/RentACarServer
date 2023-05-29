using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.CarPhotoFeatures.Commands.CreateCarPhoto
{
    public class CreateCarPhotoCommandHandler : ICommandHandler<CreateCarPhotoCommand, CreateCarPhotoCommandResponse>
    {

        private readonly ICarPhotoService _carPhotoService;
        public CreateCarPhotoCommandHandler(ICarPhotoService carPhotoService)
        {
            _carPhotoService = carPhotoService;
        }
        public async Task<CreateCarPhotoCommandResponse> Handle(CreateCarPhotoCommand request, CancellationToken cancellationToken)
        {
            var base64String = Helpers.FileService.ConvertIFormFileToBase64("jpg",request.photo);
            var newCarPhoto = new CarPhoto(request.CarId,base64String);

            await _carPhotoService.CreateAsync(newCarPhoto, cancellationToken);
            return new(true, "İşlem Başarılı");
        }
    }
}

