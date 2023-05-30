using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.NavigationItemFeatures.Commands.CreateNavigationItem;
using Application.Features.NavigationItemFeatures.Queries.GetAllNavigationItems;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class NavigationItemController : ApiController
    {
        public NavigationItemController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateNavigationItem")]
        public async Task<ActionResult> CreateNavigationItem(CreateNavigationItemCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllNavigationItems")]
        public async Task<ActionResult> GetAllNavigationItems(GetAllNavigationItemsQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

