using System;
using Domain.Entities;

namespace Application.Features.CarPhotoFeatures.Queries.GetAllCarPhotos
{
	public class GetAllCarPhotosQueryResponse
	{
		public IList<CarPhoto> Data { get; set; }

	}
}

