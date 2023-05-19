using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.QuestionRepository
{
	public interface IQuestionCommandRepository:IAppCommandRepository<Question>
	{
	
	}
}

