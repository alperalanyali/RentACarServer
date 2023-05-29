using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Branch: Entity
	{

		public Branch()
		{

		}
		public Branch(string branchName,string taxNumber,string address1,string address2,string city,string country,Guid companyId)
		{
			Id = Guid.NewGuid();
			BranchName = branchName;
			TaxNumber = taxNumber;
			Address1 = address1;
			Address2 = address2;
			City = city;
			Country = country;
			CompanyId = companyId;
		}
		public string BranchName { get; set; }
		public string TaxNumber { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public Guid CompanyId { get; set; }
		public Company Company { get; set; }

	}
}

