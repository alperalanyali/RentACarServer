using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using WebApi.OptionsSetup;

namespace WebApi.Configurations
{
	public class AuthencationAndAuthorizationServiceInstaller:IServiceInstaller
	{


        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionsSetup>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
        }
    }
}

