using Microsoft.EntityFrameworkCore;
using RutaSmart.Data.Data; 
using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace RutaSmart.Test.Infraestructura
{
    public class TestDbContextFactory
    {
        public static string NewDatabase() => $"RutaSmart_{Guid.NewGuid()}";

        public static RutaSmartContext CreateContext(string databaseName)
        {
            var options = new DbContextOptionsBuilder<RutaSmartContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;

            return new InMemoryRutaSmartContext(options);
        }

        private sealed class InMemoryRutaSmartContext : RutaSmartContext
        {
            public InMemoryRutaSmartContext(DbContextOptions<RutaSmartContext> options)
                : base(options)
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                
            }
        }
    }
}
