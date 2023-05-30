
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.KlogFeatures.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class KLogController : ApiController
    {
        public KLogController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("GetAllKLog")]
        public async Task<ActionResult> GetAll(GetAllKLogQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}


