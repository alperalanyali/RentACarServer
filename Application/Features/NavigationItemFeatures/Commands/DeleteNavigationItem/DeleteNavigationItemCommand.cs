using System;
using Application.Messaging;

namespace Application.Features.NavigationItemFeatures.Commands.DeleteNavigationItem
{
	public class DeleteNavigationItemCommand:ICommand<DeleteNavigationItemResponse>
	{
		public Guid Id { get; set; }

	}
}

