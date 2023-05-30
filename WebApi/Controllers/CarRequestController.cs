using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.CarRequestFeatures.Commands.CreateCarRequest;
using Application.Features.CarRequestFeatures.Queries.GetAllCarRequest;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class CarRequestController : ApiController
    {
        public CarRequestController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateCarRequest")]
        public async Task<ActionResult> CreateCarRequest(CreateCarRequestCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllCarRequests")]
        public async Task<ActionResult> GetAllCarRequests(GetAllCarRequestQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

