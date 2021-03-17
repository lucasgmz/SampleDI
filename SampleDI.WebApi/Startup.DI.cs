using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using SampleDI.Services.MathUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDI.WebApi
{
    public static class StartupDI
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.RegisterAssemblyPublicNonGenericClasses(typeof(MathUtilsService).Assembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsPublicImplementedInterfaces(ServiceLifetime.Scoped);
        }
    }
}
