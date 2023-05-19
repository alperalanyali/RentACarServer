using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ISurveyQuestionService
	{
		Task CreateAsync(SurveyQuestion surveyQuestion, CancellationToken cancellationToken);
		Task UpdateAsync(SurveyQuestion surveyQuestion, CancellationToken cancellationToken);
		Task RemoveSurveyQuestion(Guid id, CancellationToken cancellationToken);
		Task<IList<SurveyQuestion>> GetList(string search);
		Task<SurveyQuestion> GetById(Guid id);
		Task<IList<SurveyQuestion>> GetListBySurveyId(Guid surveyId);
	}
}

