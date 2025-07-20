using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Company.Entities
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // استبدل سلسلة الاتصال هذه بسلسلة الاتصال الخاصة بك
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CompanyDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // تكوين العلاقة بين الموظفين والأقسام
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            // تكوين علاقة المدير والموظفين (علاقة ذاتية)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany(e => e.Subordinates)
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict); // يمنع حذف المدير في حالة وجود مرؤوسين

            // تكوين خصائص إضافية
            modelBuilder.Entity<Department>()
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Employee>()
                .Property(e => e.name)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}