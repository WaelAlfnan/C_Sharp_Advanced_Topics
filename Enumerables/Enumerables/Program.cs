namespace Enumerables
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.AddPayItem("Basic Salary", 1000);
            employee.AddPayItem("Housing", 500);
            employee.AddPayItem("Transportation", 200);
            employee.AddPayItem("Insurance", -300);

            //var payItems = employee.GetPayItems();
            //var enumerator = employee.GetEnumerator();

            //foreach (var payItem in employee)
            //    Console.WriteLine($"{payItem.Name} = {payItem.Value}");

            //for (var i = 0; i < employee.Count(); i++)
            //    Console.WriteLine($"{employee.GetPayItem(i).Name} = {employee.GetPayItem(i).Value}");

            for (var i = 0; i < employee.Count(); i++)
                Console.WriteLine($"{employee[i].Name} = {employee[i].Value}");

            ////var test = new TestYield();
            ////foreach (var item in test)
            ////    Console.WriteLine(item);
        }
    }
}
