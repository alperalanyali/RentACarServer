
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.CarPhotoFeatures.Commands.CreateCarPhoto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class CarPhotoController : ApiController
    {
        public CarPhotoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateCarPhoto")]
        public async Task<ActionResult> CreateCarPhoto(CreateCarPhotoCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}


