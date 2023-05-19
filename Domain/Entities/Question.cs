using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Question:Entity
	{
		public Guid Id { get; set; }
		public string QuestionContent { get; set; }
	}
}

