using System;
using Domain.Entities;
using Domain.Repositories.QuestionRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.QuestionRepository
{
    public class QuestionCommandRepository : AppCommandRepository<Question>, IQuestionCommandRepository
    {
        public QuestionCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

