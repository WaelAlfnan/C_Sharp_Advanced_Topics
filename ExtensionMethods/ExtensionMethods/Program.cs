namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value: ");
            var input = Console.ReadLine();
            Console.WriteLine(input.RemoveWhiteSpaces().Reverse1());//Method Chaining
        }
    }
}
