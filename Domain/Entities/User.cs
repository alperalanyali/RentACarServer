using System;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
	public class User:IdentityUser<Guid>
	{
		public string FullName { get; set; }
		public Status Statu { get; set; }
	}
}

