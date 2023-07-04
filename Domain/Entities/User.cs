using System;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
	public class User:IdentityUser<Guid>
	{
		public string FullName { get; set; }
		public string RefreshToken { get; set; }
		public DateTime RefreshTokenExpires { get; set; }
		public bool isDeleted { get; set; } = false;
		public DateTime  CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }


		public ICollection<UserRole> UserRoles { get; set; }
	}
}

