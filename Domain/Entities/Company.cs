using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Company:Entity
	{
		public Company()
		{

		}
		public Company(string companyName,string address1,string address2,string city,string country,string taxNumber,string logo)
		{
			CompanyName = companyName;
			Address1 = address1;
			Address2 = address2;
			City = city;
			Country = country;
			TaxNumber = taxNumber;
			Logo = logo;
		}
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string Logo { get; set; }
		public string CompanyName { get; set; }
		public string TaxNumber { get; set; }

	}
}

