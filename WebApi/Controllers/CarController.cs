using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.CarFeatures.Commands.CreateCar;
using Application.Features.CarFeatures.Commands.DeleteCar;
using Application.Features.CarFeatures.Commands.UpdateCar;
using Application.Features.CarFeatures.Quries.GetAllCars;
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
        [HttpPost("UpdateCar")]
        public async Task<ActionResult> UpdateCar([FromForm] UpdateCarCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("DeleteCar")]
        public async Task<ActionResult> DeleteCar(DeleteCarCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllCars")]
        public async Task<ActionResult> GetAllCars(GetAllCarsQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request,cancellationToken);
            return Ok(response);
        }
    }
}

