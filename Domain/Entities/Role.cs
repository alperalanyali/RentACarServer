using System;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
	public class Role:IdentityRole<Guid>
	{
		public Status Status { get; set; }

	}
}

