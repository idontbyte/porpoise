using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Porpoise.Web.Services;
using Porpoise.Web.Services.Interfaces;

namespace Porpoise.Web.Middleware
{
    public static class PorpoiseDataLoader
    {
        public static IApplicationBuilder UsePorpoiseDataLoader(this IApplicationBuilder app, IPorpoiseDataReader dataReader)
        {
            // load pages data
            var pages = dataReader.Pages();

            // store in memory
            PorpoiseMemoryCache.Pages = pages.ToList();

            return app;
        }
    }
}
