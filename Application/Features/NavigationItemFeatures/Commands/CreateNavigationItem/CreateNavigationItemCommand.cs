using System;
using Application.Messaging;

namespace Application.Features.NavigationItemFeatures.Commands.CreateNavigationItem
{
	public sealed record CreateNavigationItemCommand(
		string navigationName,
		string navigationPath,
		string navigationComponentName,
		string topNavBarId,
		int Priority

		):ICommand<CreateNavigationItemCommandResponse>;
	
}

