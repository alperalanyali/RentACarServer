using System;
using Application.Messaging;

namespace Application.Features.NavigationItemFeatures.Queries.GetNavItemsByTopNavId
{
	public sealed record GetNavItemsByTopNavIdCommand(
		string TopNavId
		):ICommand<GetNavItemsByTopNavIdCommandResponse>;
	
}

