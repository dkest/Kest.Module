using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kest.Module
{
    public class ServiceConfigurationContext
    {
        public IServiceCollection Services { get; protected set; }

        public IConfiguration Configuration { get; protected set; }


        public ServiceConfigurationContext(IServiceCollection services, IConfiguration configuration)
        {
            Services = services;
            Configuration = configuration;
        }

    }
}
