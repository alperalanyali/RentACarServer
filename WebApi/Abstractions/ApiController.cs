using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Abstractions
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class ApiController:ControllerBase
	{
		protected readonly IMediator _mediator;
		public ApiController(IMediator mediator)
		{
			_mediator = mediator;
		}
	}
}

