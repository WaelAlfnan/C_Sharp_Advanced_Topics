using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X || p1.Y > p2.Y;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X || p1.Y < p2.Y;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X || p1.Y == p2.Y;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator Point(int x)
        {
            return new Point(x, x);
        }
        /*public static implicit operator int(Point p)
        {
            return p.X;
        }*/

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var other = (Point)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            /*var hash = 17;
            hash = hash * 23 + X.GetHashCode();
            hash = hash * 23 + Y.GetHashCode();
            return hash;*/
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
