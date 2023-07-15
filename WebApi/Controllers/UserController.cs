using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.UserFeatures.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsers() {
            var request = new GetAllUsersQuery();
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}

