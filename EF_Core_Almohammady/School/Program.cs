using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            using var db = new AppDbContext();

            // Insert
            var department = new Department()
            {
                Name = "Ahmed"
            };
            db.Departments.Add(department);
            //db.SaveChanges();//Error, because the des property is required

            //department = db.Departments.Where(d => d.Name == "Ahmed").FirstOrDefault();

            if (department != null)
            {
                Console.WriteLine(department.Name);

                //Edit
                department.Name = "Class 1";
                db.SaveChanges();

                //Delete 
                //db.Departments.Remove(department);
                //db.SaveChanges();
            }
            else
            {
                Console.WriteLine("nothing");
            }*/

           /* //Data Annotation validation
            using var db = new AppDbContext();

            // Insert
            var department = new Department()
            {
                //Name = "Ahmed 02",
                des = "123456"
            };
            var context = new ValidationContext(department);
            var errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(department, context, errors, true))
            {
                foreach (var validationResult in errors)
                {
                    Console.WriteLine(validationResult);
                }
            }
            else
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }*/
        }
    }
}
