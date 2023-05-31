using System;
using Application.Messaging;
using Domain.Entities;

namespace Application.Features.CarPhotoFeatures.Commands.UpdateCarPhoto
{
	public class UpdateCarPhotoCommand:ICommand<UpdateCarPhotoCommandResponse>
	{
        public Guid Id { get; set; }
        public Guid CarId { get; set; }        
        public IFormFile Photo { get; set; }
    }
}

