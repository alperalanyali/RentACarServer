using System;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
	public class Role:IdentityRole<Guid>
	{
		public bool isDeleted { get; set; } = false;		
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }

		public Role()
		{

		}
		public Role(string name)
		{
			Id = Guid.NewGuid();
			Name = name;
			CreatedDate = DateTime.Now;
			isDeleted = false;

		}
	}
}

