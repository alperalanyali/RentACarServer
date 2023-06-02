﻿using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class NavigationItem:Entity
	{
		public string NavigationName { get; set; }
		public string NavigationPath { get; set; }
		public string TopNavBarId { get; set; }
		public int Priority { get; set; }


		public NavigationItem()
		{

		}
		public NavigationItem(string navigationName,string navigationPath,string topNavbarId,int priority)
		{
			Id = Guid.NewGuid();
			NavigationName = navigationName;
			NavigationPath = navigationPath;
			TopNavBarId = topNavbarId;
			Priority = priority;
		}
	}
}

