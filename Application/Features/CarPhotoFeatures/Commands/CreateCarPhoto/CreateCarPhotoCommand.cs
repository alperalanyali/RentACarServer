using System;
using Application.Messaging;

namespace Application.Features.CarPhotoFeatures.Commands.CreateCarPhoto
{
	public sealed record CreateCarPhotoCommand(
		string CarId,
		IFormFile photo
		):ICommand<CreateCarPhotoCommandResponse>;
	
}

