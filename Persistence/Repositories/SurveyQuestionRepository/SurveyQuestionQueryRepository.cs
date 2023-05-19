using System;
using Domain.Entities;
using Domain.Repositories.SurveyQuestionRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.SurveyQuestionRepository
{
    public class SurveyQuestionQueryRepository : AppGenericQueryRepository<SurveyQuestion>, ISurveyQuestionQueryRepository
    {
        public SurveyQuestionQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

