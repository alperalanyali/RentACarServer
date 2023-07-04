using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.RoleFeatures.Commands.CreateRole;
using Application.Features.RoleFeatures.Commands.DeleteRoleById;
using Application.Features.RoleFeatures.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class RoleController : ApiController
    {
        public RoleController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateRole")]
        public async Task<ActionResult> CreateRole(CreateRoleCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllRoles")]
        public async Task<ActionResult> GetAllRoles(GetAllRolesQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("DeleteRoleById")]
        public async Task<ActionResult> DeleteRoleById(DeleteRoleByIdCommand request,CancellationToken cancellationToken) {

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        
    }
}

