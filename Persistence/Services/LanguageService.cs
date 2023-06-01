using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.LanguageRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageCommandRepository _languageCommand;
        private readonly ILanguageQueryRepository _languageQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public LanguageService(ILanguageCommandRepository languageCommandRepository, ILanguageQueryRepository languageQuery, IAppUnitOfWork appUnitOfWork)
        {
            _languageCommand = languageCommandRepository;
            _languageQuery = languageQuery;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateAsync(Language language, CancellationToken cancellationToken)
        {
            await _languageCommand.AddAsync(language, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            _languageCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Language> GetById(Guid id)
        {
            var language = await _languageQuery.GetById(id.ToString());
            return language;
        }

        public async Task<IList<Language>> GetList(string search)
        {
            var list = await _languageQuery.GetAllAsync().ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _languageQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (
                p.LanguageCode.ToLower().Contains(search.ToLower())
                || p.LanguageName.ToLower().Contains(search.ToLower())
                )).ToListAsync();
            }

            return list;
        }

        public async Task UpdateASync(Language language, CancellationToken cancellationToken)
        {
            _languageCommand.Update(language);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

