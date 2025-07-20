using System.Numerics;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<Employee>();



            //list.Add();
            //list.Add(2);
            //list.Add(3);
            //list.Remove(1);
            //var count = list.Count;

            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(5, 6.5));
            Console.WriteLine(Add(5.56, 6));
        }
        public static T Add<T>(T num1, T num2) where T : INumber<T>
        {
            return num1 + num2;
        }

    }
}
