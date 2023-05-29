using System;
using Application;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Configurations
{
    public class ApplicationInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfr => cfr.RegisterServicesFromAssembly(typeof(AssemblyReference).Assembly));
        }
    }
}

