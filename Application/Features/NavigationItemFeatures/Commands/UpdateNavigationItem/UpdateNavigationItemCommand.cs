using System;
using Application.Messaging;

namespace Application.Features.NavigationItemFeatures.Commands.UpdateNavigationItem
{
	public class UpdateNavigationItemCommand:ICommand<UpdateNavigationItemCommandResponse>
	{
		public Guid Id { get; set; }
        public string NavigationName { get; set; }
        public string NavigationPath { get; set; }
        public Guid TopNavBarId { get; set; }
        public int Priority { get; set; }
    }
}

