using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal static class Conections
    {
        // this syntax of conection string used with the provider of sql server
        public const string sqlConStr = """
                Server=DESKTOP-L96MTC7;
                Database=School;
                User Id=sa;
                Password=421578;
                TrustServerCertificate=True;

            """;
    }
}
