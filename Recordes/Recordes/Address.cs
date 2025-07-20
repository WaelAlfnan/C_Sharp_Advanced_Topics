using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recordes
{
    public class Address(string city, string streetName)
    {
        public string City { get; set; } = city;
        public string StreetName { get; set; } = streetName;
        public override string ToString() => $"City: {City}, StreetName: {StreetName}";
    }
}
