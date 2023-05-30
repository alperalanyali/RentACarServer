using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.RoleFeatures.Queries.GetAll
{
	public class GetAllQueryHandler:IQueryHandler<GetAllRolesQuery, GetAllQueryResponse>
	{
        private readonly IRoleService _roleService;
		public GetAllQueryHandler(IRoleService roleService)
		{
            _roleService = roleService;
		}

        public async Task<GetAllQueryResponse> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var result = await _roleService.GetList(request.search);
            return new(result,true);
        }
    }
}

