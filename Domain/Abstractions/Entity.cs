using System;
using Domain.Enums;

namespace Domain.Abstractions
{
	public class Entity
	{
		public Guid Id { get; set; }
		public bool IsDeleted { get; set; } = false;
		public bool IsUpdated { get; set; } = false;
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime? UpdatedDate { get; set; }
	}
}

