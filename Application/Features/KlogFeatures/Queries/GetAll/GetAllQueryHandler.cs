using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.KlogFeatures.Queries.GetAll
{
	public class GetAllQueryHandler:IQueryHandler<GetAllQuery,GetAllQueryResponse>
	{
		private readonly IKLogService _klogService;
		public GetAllQueryHandler(IKLogService kLogService)
		{
			_klogService = kLogService;
		}

        public async Task<GetAllQueryResponse> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
			var result = await _klogService.GetList(request.search);
			return new( result,true);
        }
    }
}

