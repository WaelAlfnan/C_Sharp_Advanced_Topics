namespace DelegatesExample
{
    internal class Program
    {
        delegate bool ShouldCalculate(Employee employee);
        static void Main(string[] args)
        {
            List<Employee> employees = new();
            for(var i = 0; i < 100; i++)
            {
                employees.Add(new Employee
                {
                    Name = $"Employee #{i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deductions = Random.Shared.Next(0, 501),
                    Bonus = Random.Shared.Next(0, 1001)
                });
            }

            CalculateSalaries(employees, e => e.BasicSalary <= 2000);
            //CalculateSalaries(employees, () => e.BasicSalary <= 2000);//if delegate doesn't take any paramter
            //CalculateSalaries(employees, (a,b) => e.BasicSalary <= 2000);//if delegate doesn't take more than paramter
        }

        private static void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)// the delegate which returns bool usualy named with predicate
        {
            foreach (var employee in employees) 
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deductions;
                    Console.WriteLine($"Salary for employee `{employee.Name}` with basic salary {employee.BasicSalary} = {salary}");
                }
            }
        }
    }
}
