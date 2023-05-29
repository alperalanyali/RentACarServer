using System;
namespace WebApi.Configurations
{
	public interface IServiceInstaller
	{
        void Install(IServiceCollection services, IConfiguration configuration);
    }
}

