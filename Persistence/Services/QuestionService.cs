using System;
using Application.Services;
using Domain.Entities;

namespace Persistence.Services
{
	public class QuestionService:IQuestionService
	{
	
        public Task CreateAsync(Question question, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Question>> GetList(string search)
        {
            throw new NotImplementedException();
        }

        public Task RemoveQuestion(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Question question, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

