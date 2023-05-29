using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserRoleFeatures.Queries.GetUserRolesByUserId
{
	public class GetUserRolesByUserIdQueryHandler:IQueryHandler<GetUserRolesByUserIdQuery,GetUserRolesByUserIdQueryResponse>
	{
        private readonly IUserRoleService _userRoleService;
		public GetUserRolesByUserIdQueryHandler(IUserRoleService userRoleService)
		{
            _userRoleService = userRoleService;
		}

        public async Task<GetUserRolesByUserIdQueryResponse> Handle(GetUserRolesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRoleService.GetListByUserId(request.UserId);
            return new( result,true);
        }
    }
}

