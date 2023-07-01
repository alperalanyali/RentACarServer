using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.UserCompanyFeatures.Commands.CreateUserCompany;
using Application.Features.UserCompanyFeatures.Commands.RemoveById;
using Application.Features.UserCompanyFeatures.Commands.UpdateUserCompany;
using Application.Features.UserCompanyFeatures.Queries.GetAllList;
using Application.Features.UserCompanyFeatures.Queries.GetlListByUserId;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class UserCompanyController : ApiController
    {
        public UserCompanyController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("CreateUserCompany")]
        public async Task<ActionResult> Create(CreateUserCompanyCommand request,CancellationToken cancellation)
        {
            var response = await _mediator.Send(request, cancellation);
            return Ok(response);
        }
        [HttpPost("UpdateUserCompany")]
        public async Task<ActionResult> Update(UpdateUserCompanyCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("DeleteUserCompany")]
        public async Task<ActionResult> Delete(RemoveByIdCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAll")]
        public async Task<ActionResult> GetAllList(GetAllListQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("GetListByUserId")]
        public async Task<ActionResult> GetListByUserId(GetListByUserIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

