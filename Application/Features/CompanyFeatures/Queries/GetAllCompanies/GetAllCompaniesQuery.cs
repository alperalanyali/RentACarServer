using System;
using Application.Messaging;

namespace Application.Features.CompanyFeatures.Queries.GetAllCompanies
{
	public class GetAllCompaniesQuery:IQuery<GetAllCompaniesQueryResponse>
	{
		public string Search { get; set; }
	}
}

