using System;
using System.Text.Json.Serialization;

namespace WebApi.Configurations
{
	public class WebApiServiceInstaller:IServiceInstaller
	{
	

        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); ;
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

