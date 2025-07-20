namespace Events
{
    internal class Program //subscriber
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new();
            for (var i = 0; i < 100; i++)
            {
                employees.Add(new Employee
                {
                    Name = $"Employee #{i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deductions = Random.Shared.Next(0, 501),
                    Bonus = Random.Shared.Next(0, 1001)
                });
            }

            var calculator = new SalaryCalculator();
            calculator.EmployeeSalaryCalculated += LogEmployeeSalary;
            calculator.EmployeeSalaryCalculated += (employee, salary) =>
            Console.WriteLine($"Payslip sent to employee `{employee.Name}`");
            calculator.CalculateSalaries(employees, e => e.BasicSalary <= 2000);
            
        }

        private static void LogEmployeeSalary(Employee employee, int salary)
        {
            Console.WriteLine($"Salary for Employee {employee.Name} = {salary}");
        }
    }
}
