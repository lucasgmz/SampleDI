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
            // MathUtilsService is being used just to make a reference
            // Basically, this code says: Hey DOT.NET, scan all classes from that assembly and register them on each scope
            // With their public interfaces
            // =)
            services.RegisterAssemblyPublicNonGenericClasses(typeof(MathUtilsService).Assembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsPublicImplementedInterfaces(ServiceLifetime.Scoped);
        }
    }
}
