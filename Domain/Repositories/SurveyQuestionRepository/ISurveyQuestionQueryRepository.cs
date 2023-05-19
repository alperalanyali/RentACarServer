using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.SurveyQuestionRepository
{
	public interface ISurveyQuestionQueryRepository: IAppQueryRepository<SurveyQuestion>
	{
	}
}

