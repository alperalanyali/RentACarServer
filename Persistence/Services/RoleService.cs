using System;
using Application.Services;
using Domain.Entities;

namespace Persistence.Services
{
    public class RoleService : IRoleService
    {
        public Task CreateAsync(Role role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRole(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Role>> GetList(string search)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Role role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

