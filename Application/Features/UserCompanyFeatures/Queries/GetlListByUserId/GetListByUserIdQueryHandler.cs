using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserCompanyFeatures.Queries.GetlListByUserId
{
	public class GetListByUserIdQueryHandler:IQueryHandler<GetListByUserIdQuery,GetListByUserIdQueryResponse>
	{
        private readonly IUserCompanyService _userCompanyService;
		public GetListByUserIdQueryHandler(IUserCompanyService userCompanyService)
		{
            _userCompanyService = userCompanyService;
		}

        public async Task<GetListByUserIdQueryResponse> Handle(GetListByUserIdQuery request, CancellationToken cancellationToken)
        {
            var list = await _userCompanyService.GetListByUserId(request.UserId);

            return new(list.Count(), list);
        }
    }
}

