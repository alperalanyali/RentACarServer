using System;

namespace WebApi.Configurations
{
	public class WebApiServiceInstaller:IServiceInstaller
	{
	

        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddCors(options => options.AddDefaultPolicy(
                options =>
                {
                    options.AllowAnyHeader().AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(options => true);
                }
                ));

            services.AddEndpointsApiExplorer();
        }
    }
}

