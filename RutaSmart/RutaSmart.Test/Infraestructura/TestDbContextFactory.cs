using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutaSmart.Test.Infraestructura
{
    public class TestDbContextFactory
    {
        public static string NewDatabase() => $"RutaSmart_{Guid.NewGuid()}";


    }
}

