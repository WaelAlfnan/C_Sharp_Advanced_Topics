using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; }
        public string? Name { get; set; }
    }
}
