using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.UserRoleFeatures.Queries.GetAllUserRoles
{
	public class GetAllUserRolesQueryHandler:IQueryHandler<GetAllUserRolesQuery,GetAllUserRolesQueryResponse>
	{

        private readonly IUserRoleService _userRoleService;
		public GetAllUserRolesQueryHandler(IUserRoleService userRoleService)
		{
            _userRoleService = userRoleService;
		}

        public async Task<GetAllUserRolesQueryResponse> Handle(GetAllUserRolesQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRoleService.GetList(request.search);
            return new( result,true);
        }
    }
}

