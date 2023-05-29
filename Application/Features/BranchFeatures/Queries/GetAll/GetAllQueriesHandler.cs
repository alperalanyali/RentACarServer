using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.BranchFeatures.Queries.GetAll
{
    public class GetAllQueriesHandler : IQueryHandler<GetAllQueries, GetAllQueriesResponse>
    {
        private readonly IBranchService _branchService;
        public GetAllQueriesHandler(IBranchService branchService)
        {
            _branchService = branchService;
        }
        public async Task<GetAllQueriesResponse> Handle(GetAllQueries request, CancellationToken cancellationToken)
        {
            var result = await _branchService.GetList(request.search);
            return new(true, result);
        }
    }
}

