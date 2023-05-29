using System;
using Domain.Entities;

namespace Application.Features.KlogFeatures.Queries.GetAll
{
	public sealed record GetAllQueryResponse(
		
		IList<KLog> Data,
        bool isSuccess = false


        );
	
}

