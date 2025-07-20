using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.Models
{
    public class StudentBook
    {
        [ForeignKey("student")]
        public int studentId { get; set; }
        public virtual Student student { get; set; }

        [ForeignKey("book")]
        public int bookId { get; set; }
        public virtual Book book { get; set; }
    }
}
