using System;
using Application.Messaging;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.CarRequestFeatures.Commands.UpdateCarRequest
{
	public sealed record UpdateCarRequestCommand(

        Guid Id,

        Guid UserId,

        Guid CarId,

        DateTime BookingDate,

        DateTime RealDate ,

        Status Status

		):ICommand<UpdateCarRequestCommandResponse>;

}

