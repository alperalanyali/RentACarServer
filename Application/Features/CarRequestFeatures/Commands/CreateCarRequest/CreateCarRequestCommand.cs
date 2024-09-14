using System;
using Application.Messaging;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.CarRequestFeatures.Commands.CreateCarRequest
{
	public sealed record CreateCarRequestCommand(
		string CarId,
        string UserId,      
        DateTime StartDate,
        DateTime EndDate,
        int Duration,
        PaymentStatus PaymentStatus,
        RentalStatus rentalStatus,
        decimal TotalPrice  
		):ICommand<CreateCarRequestCommandResponse>;

}

