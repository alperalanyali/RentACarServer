using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class NavigationItemRole:Entity
	{
		public Guid NavigationItemId { get; set; }
		public NavigationItem NavigationItem { get; set; }

		public Guid RoleId { get; set; }
		public Role Role { get; set; }

		public NavigationItemRole()
		{

		}

		public NavigationItemRole(Guid navigationItemId,Guid roleId)
		{
			Id = Guid.NewGuid();
			NavigationItemId = navigationItemId;
			RoleId = roleId;

		}
	}
}

