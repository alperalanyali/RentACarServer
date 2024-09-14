using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.BranchFeatures.Commands.CreateBranch;
using Application.Features.BranchFeatures.Commands.RemoveBranch;
using Application.Features.BranchFeatures.Commands.UpdateBranch;
using Application.Features.BranchFeatures.Queries.GetAll;
using Application.Features.BranchFeatures.Queries.GetBranchesByCompanyId;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class BranchController : ApiController
    {
        public BranchController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateBranch")]
        public async Task<ActionResult> CreateBranch(CreateBranchCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request,cancellationToken);
            return Ok(response);
        }

        [HttpPost("UpdateBranch")]
        public async Task<ActionResult> UpdateBranch(UpdateBranchCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("DeleteBranch")]
        public async Task<ActionResult> DeleteBranch(RemoveBranchCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("GetAllBranchByCompanyId")]
        public async Task<ActionResult> GetAllBranchByCompanyId(GetBranchesByCompanyIdQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("GetAllBranches")]
        public async Task<ActionResult> GetAllBranches(GetAllQueries request, CancellationToken cancellationToken) {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

