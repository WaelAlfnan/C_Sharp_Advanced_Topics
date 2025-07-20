namespace Delegates
{
    internal class Program
    {
        delegate int CalculateDelegate(int x, int y);
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;

            CalculateDelegate dlg = new CalculateDelegate(Add);
            CalculateWithDelegate(num1, num2, Add);
            Console.WriteLine("-------------------");

            CalculateDelegate dlg2 = Subtract;
            CalculateWithDelegate(num1, num2, dlg2);
            Console.WriteLine("-------------------");

            dlg2 = Multiplication;
            dlg2 += Division;// Multicast Delegate
            dlg2 -= Multiplication;
            //dlg2 -= Division;//Null Reference Exception
            CalculateWithDelegate(num1, num2, dlg2);
            Console.WriteLine("-------------------");

            CalculateWithDelegate(num1, num2, Division);
            Console.WriteLine("-------------------");

            CalculateWithDelegate(num1, num2, delegate (int x, int y) { return x % y; });// using anonymos delegate
            CalculateWithDelegate(num1, num2, (int x, int y)  => x % y );// Lampda Expression
            CalculateWithDelegate(num1, num2, (x, y) => x % y);// Lampda Expression
        }
        
        static void CalculateWithDelegate(int num1, int num2, CalculateDelegate dlg)
        {
            int result = dlg(num1, num2);
            Console.WriteLine($"result = {result}");
        }

        public static int Add(int x, int y)
        {
            Console.WriteLine("Add");
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            Console.WriteLine("Subtract");
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            Console.WriteLine("Multiplication");
            return x * y;
        }
        public static int Division(int x, int y)
        {
            Console.WriteLine("Division");
            return x / y;
        }
    }
}
