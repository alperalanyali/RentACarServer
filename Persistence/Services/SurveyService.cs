using System;
using Application.Services;
using Domain.Entities;

namespace Persistence.Services
{
    public class SurveyService : ISurveyService
    {
        public Task CreateAsync(Survey survey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Survey> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Survey>> GetList(string search)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSurvey(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Survey survey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

