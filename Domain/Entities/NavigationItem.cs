using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class NavigationItem:Entity
	{
		public string NavigationName { get; set; }
		public string NavigationPath { get; set; }
		public Guid TopNavBarId { get; set; }
		public int Priority { get; set; }

	}
}

