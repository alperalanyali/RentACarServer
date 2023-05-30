using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.NavigationItemFeatures.Queries.GetAllNavigationItems
{
    public class GetAllNavigationItemsQueryHandler : IQueryHandler<GetAllNavigationItemsQuery, GetAllNavigationItemsQueryResponse>
    {
        private readonly INavigationItemService _navItemService;
        public GetAllNavigationItemsQueryHandler(INavigationItemService navigationItemService)
        {
            _navItemService = navigationItemService;
        }
        public async Task<GetAllNavigationItemsQueryResponse> Handle(GetAllNavigationItemsQuery request, CancellationToken cancellationToken)
        {
            var list = await _navItemService.GetAll(request.search);
            return new(list, true);
        }
    }

}

