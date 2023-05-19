using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class SurveyQuestion:Entity
	{
		

		public Guid QuestionId { get; set; }
		public Question Question { get; set; }

		public string Answer { get; set; }

		public Guid SurveyId { get; set; }
		public Survey Survey { get; set; }


	}
}

