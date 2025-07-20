namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1,2);
            var p2 = new Point(2,3);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

           /* var p3 = p1 + p2 + p1 + p2;
            Console.WriteLine($"x = {p3.X}, y = {p3.Y}");

            var p4 = p2 - p1;
            Console.WriteLine($"x = {p4.X}, y = {p4.Y}");

            Console.WriteLine($"p1 < p2? {p1 < p2}");
            Console.WriteLine($"p1 > p2? {p1 > p2}");

            p1 = new(1,2);
            p2 = new(1,2);
            Console.WriteLine($"p1 == p2? {p1 == p2}");//Compare the references
            Console.WriteLine($"p1 Equals p2? {p1.Equals(p2)}");

            Console.WriteLine($"P1.X HashCode: {p1.X.GetHashCode()}");
            Console.WriteLine($"P2.Y HashCode: {p2.Y.GetHashCode()}");


            Console.WriteLine($"P1 HashCode: {p1.GetHashCode()}");
            Console.WriteLine($"P2 HashCode: {p2.GetHashCode()}");

            //The Dictionary is Categoriezed under Hash Based Collections which Compare the key of type object using  hash code
            var dic = new Dictionary<Point, string>();
            dic.Add(p1, "Point 1");
            dic.Add(p2, "Point 2");
            Console.WriteLine($"Dict Count: {dic.Count}");

            Point p = (Point)5;
            Console.WriteLine($"X = {p.X}, Y = {p.Y}");

            int x = p;
            Console.WriteLine($"p.x = {x}");*/
        }
    }
}
