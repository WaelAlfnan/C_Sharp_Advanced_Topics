using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recordes
{
    //Positional Record x, y acuallly will transformed to public init readonly properties
    public record PointRecord(int x, int y);
    /*public record PointRecord
    {
        public PointRecord(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X {  get; set; }
        public int Y { get; set; }
    }*/
}
