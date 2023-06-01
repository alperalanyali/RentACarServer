using System;
using Domain.Entities;

namespace Application.Services
{
	public interface ILanguageService
	{
		Task CreateAsync(Language language,CancellationToken cancellationToken);
		Task Delete(Guid id, CancellationToken cancellationToken);
		Task UpdateASync(Language language, CancellationToken cancellationToken);
		Task<Language> GetById(Guid id);
		Task<IList<Language>> GetList(string search);
	}
}

