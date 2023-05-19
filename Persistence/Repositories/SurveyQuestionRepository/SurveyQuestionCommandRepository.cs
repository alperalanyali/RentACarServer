using System;
using Domain.Entities;
using Domain.Repositories.SurveyQuestionRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.SurveyQuestionRepository
{
    public class SurveyQuestionCommandRepository : AppCommandRepository<SurveyQuestion>, ISurveyQuestionCommandRepository
    {
        public SurveyQuestionCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

