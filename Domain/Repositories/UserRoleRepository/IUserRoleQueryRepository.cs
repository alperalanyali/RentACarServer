using System;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.UserRoleRepository
{
	public interface IUserRoleQueryRepository:IAppQueryRepository<UserRole>
	{
	}
}

