using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        [Key]
        public int Id { get; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public int Grade { get; set; }
        public DateTime BirthDate { get; set; }



        public virtual Grade grade { get; set; }

        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        
        public virtual Department department { get; set; }

        public virtual ICollection<StudentBook> books { get; set; }

    }
}
