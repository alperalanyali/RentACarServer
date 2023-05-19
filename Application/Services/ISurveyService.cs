using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ISurveyService
	{
		Task CreateAsync(Survey survey, CancellationToken cancellationToken);
		Task UpdateAsync(Survey survey, CancellationToken cancellationToken);
		Task RemoveSurvey(Guid id, CancellationToken cancellationToken);
		Task<Survey> GetById(Guid id);
		Task<IList<Survey>> GetList(string search);
	}
}

