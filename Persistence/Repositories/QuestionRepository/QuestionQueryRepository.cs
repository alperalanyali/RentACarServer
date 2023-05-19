using System;
using Domain.Entities;
using Domain.Repositories.QuestionRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.QuestionRepository
{
    public class QuestionQueryRepository : AppGenericQueryRepository<Question>, IQuestionQueryRepository
    {
        public QuestionQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

