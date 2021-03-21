using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using SampleDI.Services.MathUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDI.WebApi
{
    public static class StartupMiddlewares
    {
        public static void AddMiddlewares(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
           {
               var timer = Stopwatch.StartNew();
               await next();

               Console.WriteLine("Runtime: " + timer.ElapsedMilliseconds + "ms");
           });
        }
    }
}
