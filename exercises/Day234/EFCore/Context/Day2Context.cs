using System.Reflection;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Context
{
    public class Day2Context : DbContext
    {

        public Day2Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=EfCoreStudy.db");
            
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelbuilder.Entity<Course>()
                .HasOne(c => c.Professor)
                .WithOne(p => p.Course)
                .HasForeignKey<Professor>(c => c.CourseId);
                
            modelbuilder.Entity<Professor>()
                .HasOne(c => c.Course)
                .WithOne(p => p.Professor)
                .HasForeignKey<Course>(c => c.ProfessorId);              

            modelbuilder.Entity<Class>()
                .HasOne( c => c.Subject)
                .WithMany(s => s.Classes)
                .HasForeignKey(c => c.SubjectId);  
                
            modelbuilder.Entity<CourseStudent>()
                .HasKey(c => new { c.CourseId, c.StudentId });
                
            modelbuilder.Entity<CourseStudent>()
                .HasOne( c => c.Course)
                .WithMany( c => c.CourseStudents)
                .HasForeignKey( c => c.CourseId);

            modelbuilder.Entity<CourseStudent>()
                .HasOne( c => c.Student)
                .WithMany( c => c.CourseStudents)
                .HasForeignKey( c => c.StudentId);
                
            modelbuilder.Entity<CourseSubject>()
                .HasKey(c => new { c.CourseId, c.SubjectId });                
                
            modelbuilder.Entity<CourseSubject>()
                .HasOne( c => c.Course)
                .WithMany( c => c.CourseSubjects)
                .HasForeignKey( c => c.CourseId);

            modelbuilder.Entity<CourseSubject>()
                .HasOne( c => c.Subject)
                .WithMany( c => c.CourseSubjects)
                .HasForeignKey( c => c.SubjectId);

            modelbuilder.Entity<ClassStudent>()
                .HasKey(c => new { c.ClassId, c.StudentId });
                
            modelbuilder.Entity<ClassStudent>()
                .HasOne( c => c.Class)
                .WithMany( c => c.ClassStudents)
                .HasForeignKey( c => c.ClassId);

            modelbuilder.Entity<ClassStudent>()
                .HasOne( c => c.Student)
                .WithMany( c => c.ClassStudents)
                .HasForeignKey( c => c.StudentId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassStudent> ClassStudents { get; set; }
    }
}