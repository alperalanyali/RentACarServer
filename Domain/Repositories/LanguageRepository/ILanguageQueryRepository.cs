using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.LanguageRepository
{
	public interface ILanguageQueryRepository: IAppQueryRepository<Language>
    {
		
	}
}

