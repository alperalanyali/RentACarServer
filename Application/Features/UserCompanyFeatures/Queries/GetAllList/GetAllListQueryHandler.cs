using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserCompanyFeatures.Queries.GetAllList
{
	public class GetAllListQueryHandler:IQueryHandler<GetAllListQuery,GetAllListQueryResponse>
	{
        private readonly IUserCompanyService _userCompanyService;
		public GetAllListQueryHandler(IUserCompanyService userCompanyService)
		{
            _userCompanyService = userCompanyService;
		}

        public async Task<GetAllListQueryResponse> Handle(GetAllListQuery request, CancellationToken cancellationToken)
        {
            var list = await _userCompanyService.GetAllList(request.search);
            return new(list.Count(), list);
        }
    }
}

