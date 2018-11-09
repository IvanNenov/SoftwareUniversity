using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;


namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {
        }

        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> HomeworkSubmissions { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-GG1QI3R\SQLEXPRESS;Database=StudentSystem;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Course>(e =>
            {
                e.HasKey(c => c.CourseId);

                e.Property(c => c.Name)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(80);

                e.Property(c => c.Description)
                .IsRequired(false)
                .IsUnicode();

                e.Property(c => c.StartDate)
                    .IsRequired();

                e.Property(c => c.EndDate)
                    .IsRequired();

                e.Property(c => c.Price)
                    .IsRequired();
            });


            mb.Entity<Homework>(e =>
            {
                e.HasKey(h => h.HomeworkId);

                e.Property(h => h.Content)
                .IsUnicode(false)
                .IsRequired();

                e.Property(j => j.SubmissionTime)
                   .IsRequired();

                e.HasOne(s => s.Student)
                .WithMany(h => h.HomeworkSubmissions)
                .HasForeignKey(s => s.StudentId);

                e.HasOne(h => h.Course)
                   .WithMany(c => c.HomeworkSubmissions)
                   .HasForeignKey(h => h.CourseId);
            });

            mb.Entity<Resource>(e =>
            {
                e.HasKey(r => r.ResourceId);

                e.Property(r => r.Name)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(50);

                e.Property(r => r.Url)
                .IsRequired()
                .IsUnicode(false);

                e.Property(c => c.ResourceType)
                    .IsRequired();

                e.HasOne(r => r.Course)
                .WithMany(r => r.Resources)
                .HasForeignKey(r => r.CourseId);
            });

            mb.Entity<Student>(e =>
            {
                e.HasKey(s => s.StudentId);

                e.Property(s => s.Name)
                .IsUnicode().
                IsRequired().
                HasMaxLength(100);

                e.Property(s => s.PhoneNumber)
                .IsRequired(false)
                .IsUnicode(false)
                .HasColumnType("CHAR(10)");

                e.Property(s => s.Birthday)
                .IsRequired(false);

                e.Property(se => se.RegisteredOn)
                   .IsRequired();
            });
            

            mb.Entity<StudentCourse>( e=>
            {
                e.HasKey(sc => new { sc.CourseId, sc.StudentId });

                e.HasOne(s => s.Student)
                    .WithMany(s => s.CourseEnrollments)
                    .HasForeignKey(s => s.StudentId);

                e.HasOne(s => s.Course)
                    .WithMany(c => c.StudentsEnrolled)
                    .HasForeignKey(s => s.CourseId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }


    }
}
