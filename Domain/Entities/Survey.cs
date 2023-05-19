using System;
using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
	public class Survey:Entity
	{
		

		public Guid CarRequestId { get; set; }
		public CarRequest CarRequest { get; set; }

		
	}
}

