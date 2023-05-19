using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Company:Entity
	{
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string Logo { get; set; }
		public string CompanyName { get; set; }
		public string TaxNumber { get; set; }

	}
}

