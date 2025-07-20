using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ
{
    internal class Employee
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; }

        public Employee(string name, int age, int salary, int departmentId)
        {
            Name = name;
            Age = age;
            Salary = salary;
            DepartmentId = departmentId;
        }
    }
}
