using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class ControlController : ApiController
    {
        public ControlController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("Control")]
        public async Task<ActionResult> Check()
        {
            return Ok("OK");
        }
    }
}

