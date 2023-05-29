using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace WebApi.Configurations
{
    public class PersistenceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
            });
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<AppDbContext>();

            services.AddAutoMapper(typeof(Persistence.AssemblyReference).Assembly);
        }
    }
}

