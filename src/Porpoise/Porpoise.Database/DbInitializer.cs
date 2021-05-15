using System;
using System.Linq;

namespace Porpoise.Database
{
    public static class DbInitializer
    {
        public static void Initialize(Db context)
        {
            context.Database.EnsureCreated();

            if (context.exampleTables.Any())
            {
                return;
            }

            context.exampleTables.Add(new ExampleTable()
            {
                Name = "test"
            });

            context.SaveChanges();
        }
    }
}