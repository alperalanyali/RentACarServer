using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.UserRoleFeatures.Commands.CreateUserRole;
using Application.Features.UserRoleFeatures.Queries.GetAllUserRoles;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class UserRoleController : ApiController
    {
        public UserRoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateUserRole")]
        public async Task<ActionResult> CreateUserRole(CreateUserRoleCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllUserRoles")]
        public async Task<ActionResult> GetAllUserRoles(GetAllUserRolesQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetUserRolesByUserId")]
        public async Task<ActionResult> GetAllUserRoleByUserId(GetAllUserRolesQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

