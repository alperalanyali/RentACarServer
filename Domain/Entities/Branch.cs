using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Branch: Entity
	{
		public string TaxNumber { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public Guid CompanyId { get; set; }
		public Company Company { get; set; }

	}
}

