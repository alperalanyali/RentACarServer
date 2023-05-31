using System;
using Domain.Entities;

namespace Application.Features.CompanyFeatures.Queries.GetAllCompanies
{
	public class GetAllCompaniesQueryResponse
	{
		public IList<Company> Data { get; set; }	
	}
}

