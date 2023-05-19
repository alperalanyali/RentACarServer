using System;
using Domain.Entities;
using Domain.Repositories.SurveyRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.SurveyRepository
{
    public class SurveyCommandRepository : AppCommandRepository<Survey>, ISurveyCommandRepository
    {
        public SurveyCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

