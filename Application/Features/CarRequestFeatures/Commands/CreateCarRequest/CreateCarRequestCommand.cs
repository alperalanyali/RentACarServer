using System;
using Application.Messaging;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.CarRequestFeatures.Commands.CreateCarRequest
{
	public sealed record CreateCarRequestCommand(
		string CarId,
        string UserId,      
        DateTime BookingDate,
        DateTime RealDate    
		):ICommand<CreateCarRequestCommandResponse>;

}

