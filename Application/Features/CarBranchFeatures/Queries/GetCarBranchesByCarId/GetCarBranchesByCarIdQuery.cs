using System;
using Application.Messaging;

namespace Application.Features.CarBranchFeatures.Queries.GetCarBranchesByCarId
{
	public class GetCarBranchesByCarIdQuery:IQuery<GetCarBranchesByCarIdQueryResponse>
	{
		public Guid CarId { get; set; }
	}
}

