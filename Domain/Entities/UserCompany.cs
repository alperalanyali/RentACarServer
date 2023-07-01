using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class UserCompany:Entity
	{
		public Guid UserId { get; set; }
		public User User { get; set; }

		public Guid CompanyId { get; set; }
		public Company Company { get; set; }

		public UserCompany()
		{

		}

		public UserCompany(Guid userId,Guid companyId)
		{
			Id = Guid.NewGuid();
			UserId = userId;
			CompanyId = companyId;
		}
	}
}

