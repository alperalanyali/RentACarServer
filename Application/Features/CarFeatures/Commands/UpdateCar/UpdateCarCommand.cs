using System;
using Application.Messaging;

namespace Application.Features.CarFeatures.Commands.UpdateCar
{
	public class UpdateCarCommand:ICommand<UpdateCarCommandResponse>
    {
        public Guid Id { get; set; }
        public string LicenseNumber { get; set; }
        public string Model { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public string Color { get; set; }
    }
}

