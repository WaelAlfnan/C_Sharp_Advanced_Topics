using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities
{
    internal class Department
    {
        [Key]
        public int Id { get; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
