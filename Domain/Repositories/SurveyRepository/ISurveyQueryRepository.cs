using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.SurveyRepository
{
	public interface ISurveyQueryRepository:IAppQueryRepository<Survey>
	{
	}
}

