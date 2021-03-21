using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDI.WebApi
{
    public static class StartupMapping
    {
        public static void AddMappings(this IApplicationBuilder app)
        {
            // Map route example
            app.Map("/today", a => a.Run(async context =>
            {
                await context.Response.WriteAsync("Today is: " + DateTime.Now.ToString());
            }));

            app.MapWhen(context => context.Request.Path.ToString().Contains("HelloWorld"), e =>
            {
                e.Run(async context =>
                {
                    await context.Response.WriteAsync("There is a Hello World in this route!");
                });
            });
        }
    }
}
