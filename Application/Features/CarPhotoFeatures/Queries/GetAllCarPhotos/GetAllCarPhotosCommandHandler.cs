using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.CarPhotoFeatures.Queries.GetAllCarPhotos
{
	public class GetAllCarPhotosQueryHandler:IQueryHandler<GetAllCarPhotosQuery,GetAllCarPhotosQueryResponse>
	{
        private readonly ICarPhotoService _carPhotoService;
        public GetAllCarPhotosQueryHandler(ICarPhotoService carPhotoService)
        {
            _carPhotoService = carPhotoService;
        }

        public async Task<GetAllCarPhotosQueryResponse> Handle(GetAllCarPhotosQuery request, CancellationToken cancellationToken)
        {
            var list = await _carPhotoService.GetAllCarPhotos(request.Search);
            var response = new GetAllCarPhotosQueryResponse()
            {
                Data= await _carPhotoService.GetAllCarPhotos(request.Search)
        };
            return response;

        }
    }
}

