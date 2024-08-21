using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentPortalWeb.Models.Entities;

namespace StudentPortalWeb.Data
{
    public class ApplicationDbContext: IdentityDbContext<Student>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {
            
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrolment> Enrolment{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the relationship between Enrolment and Student
            modelBuilder.Entity<Enrolment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrolments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define the relationship between Enrolment and Course
            modelBuilder.Entity<Enrolment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrolments)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
