using System;
using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
	public class Car: Entity
	{
		public Car()
		{

		}
		public Car(string licenseNumber,string model,DateTime manufacturedDate,string color)
		{
			Id = Guid.NewGuid();
			LicenseNumber = licenseNumber;
			Model = model;
			ManufacturedDate = manufacturedDate;
			Color = color;
		}
		public string LicenseNumber { get; set; }
		public string Model { get; set; }
		public DateTime ManufacturedDate { get; set; }
		public string Color { get; set; }	

	}
}

