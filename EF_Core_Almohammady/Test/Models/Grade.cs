using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    internal class Grade
    {
        [Key]
        public int Id { get; }
        public decimal Physics { get; set; }
        public decimal Chemistry { get; set; }
        public decimal Programming { get; set; }

        [ForeignKey("student")]
        public int studentId { get; }

        public Student student { get; set; }

    }
}
