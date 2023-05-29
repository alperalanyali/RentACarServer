using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.BranchFeatures.Queries.GetBranchesByCompanyId
{
    public class GetBranchesByCompanyIdQueryHandler : IQueryHandler<GetBranchesByCompanyIdQuery, GetBranchesByCompanyIdQueryResponse>
    {
        private readonly IBranchService _branchService;
        public GetBranchesByCompanyIdQueryHandler(IBranchService branchService)
        {
            _branchService = branchService;
        }
        public async Task<GetBranchesByCompanyIdQueryResponse> Handle(GetBranchesByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _branchService.GetListByCompanyId(request.CompanyId);
            return new( result,true);
        }
    }
}

