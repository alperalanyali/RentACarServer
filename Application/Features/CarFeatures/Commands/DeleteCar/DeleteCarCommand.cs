using System;
using Application.Features.CarFeatures.Commands.DeleteCar;
using Application.Messaging;

namespace Application.Features.CarFeatures.Commands.DeleteCar
{
	public sealed class DeleteCarCommand:ICommand<DeleteCarCommandResponse>
	{
		public Guid Id { get; set; }
	}
}

