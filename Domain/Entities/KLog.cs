using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class KLog:Entity
	{
		public Guid Id { get; set; }
        public string FunctionName { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string InnerException { get; set; }
		public string InnerExceptionMessage { get; set; }
		public DateTime CreateAt { get; set; }

	}
}

