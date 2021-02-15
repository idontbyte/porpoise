using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Porpoise.FEContainer.Services;

namespace Porpoise.FEContainer.Middleware
{
    public static class PorpoiseRouter
    {
        public static IApplicationBuilder UsePorpoiseRouter(this IApplicationBuilder app, IViewRenderService viewRenderService)
        {
            var routeBuilder = new RouteBuilder(app);

            foreach (var page in PorpoiseMemoryCache.Pages)
            {
                routeBuilder.MapGet((string)page.Route,  context =>
                {
                    return viewRenderService.WriteViewAsync(context, (string)page.View, page);
                });
            }

            var routes = routeBuilder.Build();
            app.UseRouter(routes);
            return app;
        }
    }
}
