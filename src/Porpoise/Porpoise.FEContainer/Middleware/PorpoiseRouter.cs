using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Porpoise.FEContainer.Middleware
{
    public static class PorpoiseRouter
    {
        public static IApplicationBuilder UsePorpoiseRouter(this IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);

            routeBuilder.MapGet("/", context =>
            {
                return context.Response.WriteAsync($"Homepage");
            });

            var routes = routeBuilder.Build();
            app.UseRouter(routes);
            return app;
        }
    }
}
