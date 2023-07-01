using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.NavigationItemFeatures.Commands.CreateNavigationItem
{
	public class CreateNavigationItemCommandHandler:ICommandHandler<CreateNavigationItemCommand,CreateNavigationItemCommandResponse>
	{
        private readonly INavigationItemService _navigationItemService;
		public CreateNavigationItemCommandHandler(INavigationItemService navigationItemService)
		{
            _navigationItemService = navigationItemService;
		}

        public async Task<CreateNavigationItemCommandResponse> Handle(CreateNavigationItemCommand request, CancellationToken cancellationToken)
        {

            var navigationItem = new NavigationItem(request.navigationName,request.navigationPath,request.navigationComponentName, request.topNavBarId, request.Priority);

            await _navigationItemService.CreateAsync(navigationItem, cancellationToken);
            return new();
        }
    }
}

