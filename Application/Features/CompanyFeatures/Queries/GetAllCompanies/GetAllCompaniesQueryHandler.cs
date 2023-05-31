using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CompanyFeatures.Queries.GetAllCompanies
{
	public class GetAllCompaniesQueryHandler:IQueryHandler<GetAllCompaniesQuery,GetAllCompaniesQueryResponse>
	{
        private readonly ICompanyService _companyService;
		public GetAllCompaniesQueryHandler(ICompanyService companyService)
		{
            _companyService = companyService;
		}

        public async Task<GetAllCompaniesQueryResponse> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            var response =new GetAllCompaniesQueryResponse(){
                Data = await _companyService.GetList(request.Search)
            };
            return response;
        }
    }
}

