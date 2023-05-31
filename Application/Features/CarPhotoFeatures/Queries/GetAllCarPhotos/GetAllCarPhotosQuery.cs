using System;
using Application.Messaging;

namespace Application.Features.CarPhotoFeatures.Queries.GetAllCarPhotos
{
	public class GetAllCarPhotosQuery:IQuery<GetAllCarPhotosQueryResponse>
	{
		public string Search { get; set; }

	}
}

