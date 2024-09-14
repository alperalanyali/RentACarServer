using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Features.CarRequestFeatures.Queries.GetCarRequestsByUserId
{
    public sealed record GetCarRequestsByUserIdResponse(IList<CarRequest> Data, bool IsSuccess, int TotalRecords);

}