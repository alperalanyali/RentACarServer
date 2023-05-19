﻿using System;
using Application.Messaging;

namespace Application.Features.CarFeatures.CreateCar
{
	public sealed record CreateCarCommand(
		string LicenseNumber,
		string Model,
		DateTime ManufacturedDate,
		string Color
        ) :ICommand<CreateCarCommandResponse>;
	
}

