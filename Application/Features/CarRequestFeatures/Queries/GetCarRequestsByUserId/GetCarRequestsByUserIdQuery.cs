using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Messaging;

namespace Application.Features.CarRequestFeatures.Queries.GetCarRequestsByUserId
{
    public sealed record GetCarRequestsByUserIdQuery(Guid UserId,int CurrentPage=1,int PageSize=10): IQuery<GetCarRequestsByUserIdResponse>;
   
}