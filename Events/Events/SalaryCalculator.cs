using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class SalaryCalculator // named publisher
    {
        public delegate bool ShouldCalculate(Employee employee);
        
        public event EmployeeSalaryCalculatedEventHandler EmployeeSalaryCalculated;
        
        public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);// void because that the events usually don't return any data
        public void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deductions;

                    //if (EmployeeSalaryCalculated != null) 
                    //    EmployeeSalaryCalculated(employee, salary);

                    //if (EmployeeSalaryCalculated is not null) 
                    //    EmployeeSalaryCalculated(employee, salary);

                    //( raise | triger | fire ) event
                    EmployeeSalaryCalculated?.Invoke(employee, salary);// this way used with any object


                }
            }
        }
    }
}
