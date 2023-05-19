using System;
using Domain.Entities;
using Domain.Repositories.SurveyRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.SurveyRepository
{
    public class SurveyQueryRepository : AppGenericQueryRepository<Survey>, ISurveyQueryRepository
    {
        public SurveyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

