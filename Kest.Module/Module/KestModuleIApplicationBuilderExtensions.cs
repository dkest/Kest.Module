using System;
using Microsoft.Extensions.DependencyInjection;

namespace Kest.Module
{
    public static class KestModuleIApplicationBuilderExtensions
    {
        public static IServiceProvider UseKestModule(this IServiceProvider serviceProvider)
        {
            var moduleManager = serviceProvider.GetService<IModuleManager>();

            return moduleManager.ApplicationInitialization(serviceProvider);
        }
    }
}