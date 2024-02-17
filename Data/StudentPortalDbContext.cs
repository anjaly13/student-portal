using Microsoft.EntityFrameworkCore;
using student_portal.Data.Entities;

namespace student_portal.Data
{
    public class StudentPortalDbContext : DbContext
    {
        public StudentPortalDbContext(DbContextOptions<StudentPortalDbContext> context):base(context) { 
        }

        // register the classes
        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }


    }
}

/*
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Address>()
               .HasOne(_ => _.Student)
               .WithMany(_ => _.Address)
               .HasForeignKey(_ =>_.StudentId);
       }
       */
