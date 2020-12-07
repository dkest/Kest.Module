using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;

namespace Kest.Module
{
    public class ApplicationInitializationContext
    {
        public IServiceProvider ServiceProvider { get; }

        public IConfiguration Configuration { get; }

        public ApplicationInitializationContext([NotNull] IServiceProvider serviceProvider, [NotNull] IConfiguration configuration)
        {
            ServiceProvider = serviceProvider;
            Configuration = configuration;
        }
    }
}
