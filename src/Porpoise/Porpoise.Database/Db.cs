using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Porpoise.Database
{
    public class Db : DbContext
    {
        public Db([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<ExampleTable> exampleTables { get; set; }
    }
}
