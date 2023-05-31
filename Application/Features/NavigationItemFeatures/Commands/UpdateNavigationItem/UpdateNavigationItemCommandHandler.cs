using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemFeatures.Commands.UpdateNavigationItem
{
	public class UpdateNavigationItemCommandHandler:ICommandHandler<UpdateNavigationItemCommand,UpdateNavigationItemCommandResponse>
	{
        private readonly INavigationItemService _navItemService;
		public UpdateNavigationItemCommandHandler(INavigationItemService navigationItemService)
		{
            _navItemService = navigationItemService;
		}

        public async Task<UpdateNavigationItemCommandResponse> Handle(UpdateNavigationItemCommand request, CancellationToken cancellationToken)
        {
            var response = new UpdateNavigationItemCommandResponse();
            var navItem = await _navItemService.GetById(request.Id);
            if(navItem != null)
            {
                navItem.NavigationName = request.NavigationName;
                navItem.NavigationPath = request.NavigationPath;
                navItem.TopNavBarId = request.TopNavBarId;
                navItem.Priority = request.Priority;

                await _navItemService.Update(navItem, cancellationToken);
            }else
            {
                response.Message = "Böyle bir kayıt yoktur";
            }
       
            return response;
        }
    }
}

