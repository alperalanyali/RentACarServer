using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class CarPhoto:Entity
	{
		

		public Guid CarId { get; set; }
		public Car Car { get; set; }

		public string PhotoBase64 { get; set; }

	}
}

