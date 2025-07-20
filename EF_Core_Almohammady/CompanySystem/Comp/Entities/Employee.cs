using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities
{
    internal class Employee
    {
        [Key]
        public int Id { get; }
        [Required]
        [MaxLength(500)]
        public string name { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Employee? Manager { get; set; }
        public virtual ICollection<Employee> Subordinates { get; set; } = new List<Employee>();
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
