using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.CarBranchFeatures.Commands.CreateCarBranch;
using Application.Features.CarBranchFeatures.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class CarBranchController : ApiController
    {
        public CarBranchController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateCarBranch")]
        public async Task<ActionResult> CreateCarBranch(CreateCarBranchCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllCarBranch")]
        public async Task<ActionResult> GetAllCarBranch(GetlAllCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

