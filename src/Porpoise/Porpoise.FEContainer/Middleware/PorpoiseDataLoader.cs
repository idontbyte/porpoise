using System;
using Microsoft.AspNetCore.Builder;
using Porpoise.FEContainer.Services.Interfaces;

namespace Porpoise.FEContainer.Middleware
{
    public static class PorpoiseDataLoader
    {
        public static IApplicationBuilder UsePorpoiseDataLoader(this IApplicationBuilder app, IPorpoiseDataReader dataReader)
        {
            // load pages data
            var pages = dataReader.Pages();

            // store in memory


            return app;
        }
    }
}
