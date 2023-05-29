using System;
using Application.Services;
using Domain.Entities;

namespace Persistence.Services
{
    public class SurveyQuestionService : ISurveyQuestionService
    {
        public Task CreateAsync(SurveyQuestion surveyQuestion, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<SurveyQuestion> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<SurveyQuestion>> GetList(string search)
        {
            throw new NotImplementedException();
        }

        public Task<IList<SurveyQuestion>> GetListBySurveyId(Guid surveyId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSurveyQuestion(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SurveyQuestion surveyQuestion, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

