using System;
using Domain.Enums;

namespace Domain.Abstractions
{
	public class Entity
	{
		public Guid Id { get; set; }
		public Status  Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}

