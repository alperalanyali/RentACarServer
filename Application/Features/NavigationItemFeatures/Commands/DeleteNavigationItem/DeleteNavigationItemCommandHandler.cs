using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemFeatures.Commands.DeleteNavigationItem
{
	public class DeleteNavigationItemCommandHandler:ICommandHandler<DeleteNavigationItemCommand,DeleteNavigationItemResponse>
	{
        private readonly INavigationItemService _navItemService;
		public DeleteNavigationItemCommandHandler(INavigationItemService navigationItemService)
		{
            _navItemService = navigationItemService;
		}

        public async Task<DeleteNavigationItemResponse> Handle(DeleteNavigationItemCommand request, CancellationToken cancellationToken)
        {
            var navItem = await _navItemService.GetById(request.Id);
            var response = new DeleteNavigationItemResponse();
            if(navItem != null)
            {
                await _navItemService.Delete(request.Id, cancellationToken);
            }else
            {
                response = new DeleteNavigationItemResponse("Böyle bir kayıt yoktur.");
            }
            return response;
        }
    }
}

