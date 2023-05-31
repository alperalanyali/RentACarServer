using System;
using Application.Messaging;

namespace Application.Features.CarPhotoFeatures.Commands.DeleteCarPhoto
{
	public class DeleteCarPhotoCommand:ICommand<DeleteCarPhotoCommandResponse>
	{
		public Guid Id { get; set; }
	}
}

