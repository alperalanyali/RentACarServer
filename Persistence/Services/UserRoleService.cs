using System;
using Application.Services;
using Domain.Entities;

namespace Persistence.Services
{
    public class UserRoleService : IUserRoleService
    {
        public Task CreateAsync(UserRole userRole, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserRole>> GetList(string search)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserRole>> GetListByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserRole userRole, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

