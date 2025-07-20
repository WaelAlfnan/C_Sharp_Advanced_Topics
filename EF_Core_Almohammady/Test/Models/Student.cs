using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public DateTime BirthDate { get; set; }
        public Grade grade { get; set; }

    }
}
