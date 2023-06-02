using System;
namespace Domain.Dtos
{
	public record NavigationItemDto(
        string Id,
        string NavigationName,
        string NavigationPath,
        string TopNavBarId,
        int Priority,
        List<NavigationItemDto> SubMenus);
	
}

