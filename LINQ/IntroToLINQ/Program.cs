namespace IntroToLINQ
{
    internal class Program
    {
        /*Topics
         * Introduction
         * Projection & Feltering (select, where, OfType)
         * Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
         * Quantifiers (All, Any, Contains)
         * Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
         * Set Operations (Distinct, Except, Intersect, Union, DistinctBy, ExceptBy, IntersectBy, UnionBy)
         */

        static void Main(string[] args)
        {
            #region Intro
            /*
            var numbers = new List<int> { 2, 1, 7, 4, 8, 6, 3, 5, 9, 10 };
            // LINQ Query expression (name as Syntax Suger and compiled to the second way) 
            //var result = (from number in numbers orderby number descending where number > 2 select number).ToList();//Defender Excution : Excute when we read from it in loop to change this behaviour we add .To(AnyThing like list , ...)
            //var result = (from number in numbers where number > 2 orderby number descending select number);
            //var result = (from number in numbers.ToList() where number > 2 select number).ToList();// compine between the two ways
            //var result = numbers.OrderByDescending(x => x > 2).Where(x => x > 2);
            var result = numbers.Where(x => x > 2).OrderByDescending(x => x > 2);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("------------");

            numbers.AddRange(new int[] { 12, 13, 14, 15, 16 });
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            */
            #endregion

            var departments = new List<Department>
            {
                new(1, "HR"),
                new(2, "IT"),
                new(3, "Development")
            };
            var employees = new List<Employee>
            {
                new("Mohamed Tarek", 38, 3000, 1),
                new("Ahmed Sami", 38, 3000, 1),
                new("Mahmoud Hassan", 38, 3000, 1),
                new("Ayman", 35, 7000, 4),
                new("Sayed", 35, 7000, 4),
                new("Ibrahim", 35, 7000, 4),
                new("Ahmed Adel", 35, 6000, 2),
                new("Moustafa", 35, 6000, 2),
                new("Ahmed Alayat", 30, 4000, 3),
                new("Salah", 30, 4000, 3),
                /*new CEO ("Hossam", 30, 4000),
                new Contractor ("Mahmoud", 21, 4000),
                new Contractor ("Khaled", 24, 4000)*/
            };

            /*Video 2
             * var query = employees.OfType<Contractor>().OrderBy(x => x.Name).ThenBy(x => x.Age).ThenBy(x => x.Salary).Reverse()
                //transformation for the data
                .Select(x => new { EmployeeName = x.Name, x.Age, x.Salary });// we cann't apply Reverse with query expression syntax must use this way named method syntax

            //var query = employees.Where(x => x is Contractor).OrderBy(x => x.Name).ThenBy(x => x.Age).ThenBy(x => x.Salary).Reverse()
            //    .Select(x => new { EmployeeName = x.Name, x.Age, x.Salary });

            // var query = employees.OrderBy(x => x.Name).OrderBy(x => x.Age).ThenBy(x => x.Salary);// this will do the same but this isn't the best practice

            //var query = from employee in employees orderby employee.Name, employee.Age, employee.Salary select employee;
            foreach (var employee in query)
            {
                //Console.WriteLine($"Name = {employee.Name}, Age = {employee.Age}, Salary = {employee.Salary}");
                Console.WriteLine($"Name = {employee.EmployeeName}, Age = {employee.Age}, Salary = {employee.Salary}");
            }*/

            /*Quantifiers Methods
        var numbers = new List<int> { 2, 1, 7, 4, 8, 6, 3, 5, 9, 10 };
        //var result = numbers.All(x => x > 2);// if all items are greater than 2 return true
        //var result = numbers.Any(x => x > 2);// if any item is greater than 2 return true
        //var result = numbers.Any();// if the list has items return true else if empty return false 
        var result = numbers.Contains(2);
        Console.WriteLine(result);
        */

            //Partitioning(Skip, SkipWhile, Take, TakeWhile, Chunk)
            var numbers = new List<int> { -1, 0, 2, 1, 8, 4, 7, 6, 3, 5, 9, 10 };
            // there is TakeLast(4) and SkipLast(4)
            var result = numbers.Skip(6).Take(4);
            //var result = numbers.TakeWhile(x => x <= 7);
            //var result = numbers.SkipWhile(x => x <= 7);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*****************");
            var chunks = numbers.Chunk(3);
            foreach (var chunk in chunks)
            {
                foreach (var item in chunk)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------");
            }


            /*Set Operations (Distinct, Except, Intersect, Union, DistinctBy, ExceptBy, IntersectBy, UnionBy)
             

            //DistinctBy or any methodBy used when we want to filter with the property inside the object
            var numbers = new List<int> { -1, 2, 5, 7, 1, 0, 2, 1, 8, 4, 7, 6, 3, 5, 9, 10 };
            var SecondList = new List<int> { -1, 0, 1, 2, 3, 4, 5, 40, 50 };

            Console.WriteLine("Except");
            var query = numbers.Distinct().Except(SecondList).OrderBy(x => x);
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Intersect");
            query = numbers.Distinct().Intersect(SecondList).OrderBy(x => x);
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Union");
            query = numbers.Union(SecondList).OrderBy(x => x);// union = two lists - redundencies
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
            */

            /*Joins

            //var query = from employee in employees
            //            join department in departments on employee.DepartmentId equals department.Id
            //            select new { EmployeeName = employee.Name, DepartmentName = department.Name };

            var query = employees.Join(departments, x => x.DepartmentId, x => x.Id,
                (e , d) => new { EmployeeName = e.Name, DepartmentName = d.Name });


            foreach (var record in query)
            {
                Console.WriteLine($"{record.EmployeeName}@{record.DepartmentName}");
            }
            */

            /*Grouping
             
            //var query = from employee in employees group employee by employee.DepartmentId;
            var query = from employee in employees
                        join department in departments on employee.DepartmentId equals department.Id
                        group employee by department.Name;
            foreach(var group in query)
            {
                string EmployeeNames = string.Join(", ", group.Select(x => x.Name));
                Console.WriteLine($"Group #{group.Key}: {EmployeeNames}");
            }
            */
        }
    }
}
