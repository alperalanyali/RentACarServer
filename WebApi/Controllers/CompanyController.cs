using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.CompanyFeatures.Commands.CreateCompanyCommand;
using Application.Features.CompanyFeatures.Commands.UpdateCompany;
using Application.Features.CompanyFeatures.Queries.GetAllCompanies;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class CompanyController : ApiController
    {
        public CompanyController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateCompany")]
        public async Task<IActionResult> CreateCompany([FromForm]CreateCompanyCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("UpdateCompany")]
        public async Task<IActionResult> UpdateCompany([FromForm]UpdateCompanyCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);

        }

        [HttpPost("GetList")]
        public async Task<ActionResult> GetAll(GetAllCompaniesQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

