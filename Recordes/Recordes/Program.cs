namespace Recordes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pr1 = new PointRecord(50, 150);
            var pr2 = new PointRecord(50, 150);
            Console.WriteLine(pr1);
            Console.WriteLine(pr2);
            Console.WriteLine($"pr1 == pr2? {pr1 == pr2}");
            Console.WriteLine($"pr1 Equals pr2? {pr1.Equals(pr2)}");
            Console.WriteLine($"Pr1 HashCode:{pr1.GetHashCode()}");
            Console.WriteLine($"Pr2 HashCode:{pr2.GetHashCode()}");
            
            //Deconstruction
            var (x, y) = pr1;
            Console.WriteLine($"X: {x}, Y: {y}");

            // Records provide Immutability it's useful for the thread safety
            //pr1.x = 100;// Error
            // easy in object cloneing
            var pr3 = pr1 with { x = 100 };// take copy from all properties but edit on x to be 100 in the copy


            var s = new Student("Ahmed", "Ali", new Address("Cairo", "6 Of October"));
            Console.WriteLine(s);
            //s.address = null;// error
            // shalow immutability
            s.address.City = "Giza";
            Console.WriteLine(s);
        }
    }
}
