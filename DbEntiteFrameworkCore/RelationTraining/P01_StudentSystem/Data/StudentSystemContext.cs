using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;


namespace P01_StudentSystem.Data
{
    class StudentSystemContext : DbContext
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
        public DbSet<StudentCourse> StudentsCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(80);

                entity.Property(e => e.Description)
                .IsUnicode()
                .IsRequired(false);

            });

            builder.Entity<Homework>(entity =>
            {
                entity.HasKey(e => e.HomeworkId);

                entity.Property(e => e.Content)
                .IsUnicode(false);

                entity.HasOne(e => e.Course)
                .WithMany(e => e.HomeworkSubmissions)
                .HasForeignKey(e => e.CourseId);

                entity.HasOne(e => e.Student)
                .WithMany(e => e.HomeworkSubmissions)
                .HasForeignKey(e => e.StudentId);

            });

            builder.Entity<Resource>(en =>
            {
                en.HasKey(e => e.ResourceId);

                en.Property(e => e.Name)
                .IsUnicode()
                .HasMaxLength(50);

                en.Property(e => e.Url)
                .IsUnicode(false);

                en.HasOne(e => e.Course)
                .WithMany(e => e.Resources)
                .HasForeignKey(e => e.CourseId);
            });

            builder.Entity<Student>(en =>
            {
                en.HasKey(e => e.StudentId);

                en.Property(e => e.Name)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(100);

                en.Property(e => e.PhoneNumber)
                .IsRequired(false)
                .IsUnicode(false)
                .HasColumnType("CHAR(10)");

            });

            builder.Entity<StudentCourse>(en =>
            {
                en.HasKey(e => new { e.CourseId, e.StudentId });

                en.HasOne(e => e.Student)
                .WithMany(e => e.CourseEnrollments)
                .HasForeignKey(e => e.StudentId);

                en.HasOne(e => e.Course)
                .WithMany(e => e.StudentsEnrolled)
                .HasForeignKey(e => e.CourseId);
                
            });
        }

    }
}
