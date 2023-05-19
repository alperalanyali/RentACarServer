using System;
using Domain.Enums;

namespace Domain.Entities
{
	public class CarRequest
	{
		public Guid Id { get; set; }

		public Guid UserId { get; set; }
		public User User { get; set; }

		public Guid CarId { get; set; }
		public Car Car { get; set; }

		public DateTime BookingDate { get; set; }

		public DateTime RealDate { get; set; }

		public Status Status { get; set; }
	}
}

