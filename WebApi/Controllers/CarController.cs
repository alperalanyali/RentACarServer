using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.CarFeatures.Commands.CreateCar;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class CarController : ApiController
    {
        public CarController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateCar")]
        public async Task<ActionResult> CreateCar(CreateCarCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }        
    }
}

