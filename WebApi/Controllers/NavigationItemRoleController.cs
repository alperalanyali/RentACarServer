using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.NavigationItemRoleFeatures.Commands.CreateNavigationItemRole;
using Application.Features.NavigationItemRoleFeatures.Queries.GetAllNavigationItemRole;
using Application.Features.NavigationItemRoleFeatures.Queries.GetNavigationItemRolesByUserId;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class NavigationItemRoleController : ApiController
    {
        public NavigationItemRoleController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateNavItemRole")]
        public async Task<ActionResult> CreateNavItemRole(CreateNavigationItemRoleCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllNavigationItemRoles")]
        public async Task<ActionResult> GetAllNavigationItemRoles(GetAllNavigationItemRoleQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("GetNavigationItemRolesByUserId")]
        public async Task<ActionResult> GetNavigationItemRolesByUserId(string userId)
        {
            var request = new GetNavigationItemRolesByUserIdQuery(userId);
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

