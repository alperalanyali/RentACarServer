using System;
using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
	public class Car: Entity
	{		
		public string LicenseNumber { get; set; }
		public string Model { get; set; }
		public DateTime ManufacturedDate { get; set; }
		public string Color { get; set; }	

	}
}

