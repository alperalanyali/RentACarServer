using System;
using Application.Messaging;

namespace Application.Features.CarFeatures.Quries.GetAllCars
{
	public class GetAllCarsQuery:IQuery<GetAllCarsQueryResponse>
	{
		public string Search { get; set; }
	}
}

