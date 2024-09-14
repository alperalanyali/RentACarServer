using System;
using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
	public class CarRequest: Entity
	{
		public Guid Id { get; set; }

		public Guid UserId { get; set; }
		public User User { get; set; }

		public Guid CarId { get; set; }
		public Car Car { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int Duration { get; set; }

		public decimal TotalPrice { get; set; }

		
		public RentalStatus RentalStatus { get; set; }

		public PaymentStatus PaymentStatus { get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public CarRequest()
		{

		}
		public CarRequest(string userId,string carId,DateTime startDate,DateTime endDate,int duration,decimal totalPrice,PaymentStatus paymentStatus,RentalStatus rentalStatus)
		{
			Id = Guid.NewGuid();
			CarId = new Guid(carId);
			UserId = new Guid(userId);
			StartDate = startDate;
			EndDate = endDate;
			Duration = duration;
			TotalPrice = totalPrice;
			PaymentStatus = paymentStatus;
			RentalStatus = rentalStatus;
		

		}

		
	}
}

