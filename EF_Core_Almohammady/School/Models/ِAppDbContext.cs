using Microsoft.EntityFrameworkCore;
using School;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connections.sqlConStr);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentBook> studentBook { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Define primary keys explicitly
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Grade>().HasKey(g => g.Id);
            modelBuilder.Entity<Department>().HasKey(d => d.Id);
            modelBuilder.Entity<Book>().HasKey(b => b.Id);
            modelBuilder.Entity<StudentBook>().HasKey(sb => new { sb.studentId, sb.bookId });


            //// Configure relationships

            //modelBuilder.Entity<Grade>()
            //    .HasOne(g => g.student)
            //    .WithOne(s => s.grade)
            //    .HasForeignKey<Grade>(g => g.studentId);


            //modelBuilder.Entity<Student>()
            //    .HasOne(s => s.department)
            //    .WithMany(d => d.students)
            //    .HasForeignKey(s => s.DepartmentId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
