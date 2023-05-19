using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IQuestionService
	{
		Task CreateAsync(Question question, CancellationToken cancellationToken);
		Task UpdateAsync(Question question, CancellationToken cancellationToken);
		Task RemoveQuestion(Guid id,CancellationToken cancellationToken);
		Task<Question> GetById(Guid id);
		Task<IList<Question>> GetList(string search);
	}
	
}

