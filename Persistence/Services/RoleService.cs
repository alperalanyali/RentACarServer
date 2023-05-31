using System;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;
        public RoleService(RoleManager<Role>  roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task CreateAsync(Role role, CancellationToken cancellationToken)
        {
            await _roleManager.CreateAsync(role);
        }

        public async Task DeleteRole(Guid id, CancellationToken cancellationToken)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(role);
        }

        public async Task<Role> GetById(Guid id)
        {
            var role = await _roleManager.Roles.Where(p => p.Id == id).FirstOrDefaultAsync();
            return role;
        }

        public async Task<IList<Role>> GetList(string search)
        {
            var list = await _roleManager.Roles.ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _roleManager.Roles.Where(p => !string.IsNullOrEmpty(search) && (
                       p.Name.ToLower().Contains(search.ToLower())
                )).ToListAsync();
            }
            return (IList<Role>)list;
        }

        public async Task UpdateAsync(Role role, CancellationToken cancellationToken)
        {
            await _roleManager.UpdateAsync(role);
        }
    }
}

