using System;
using Domain.Entities;

namespace Application.Features.CarFeatures.Quries.GetAllCars
{
	public class GetAllCarsQueryResponse
	{
		public IList<Car> Data { get; set; }

	}
}

