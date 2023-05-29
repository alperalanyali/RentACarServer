using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class CarPhoto:Entity
	{
		

		public Guid CarId { get; set; }
		public Car Car { get; set; }

		public string PhotoBase64 { get; set; }

		public CarPhoto()
		{

		}

		public CarPhoto(string carId,string photoBase64)
		{
			Id = Guid.NewGuid();
			CarId = new Guid(carId);
			PhotoBase64 = photoBase64;
		}
	}
}

