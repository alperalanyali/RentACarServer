using System;
using Application.Messaging;

namespace Application.Features.CarRequestFeatures.Queries.GetCarRequestsByCarId
{
	public sealed record GetCarRequestsByCarIdQuery(Guid carId ):IQuery<GetCarRequestsByCarIdQueryResponse>;

}

