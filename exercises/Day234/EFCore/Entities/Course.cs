using System.Collections.Generic;

namespace EFCore.Entities
{
    public class Course: Entity<int>
    {
        public string Name { get; set; }
        public int? ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<CourseStudent> CourseStudents { get; set; }
        public List<CourseSubject> CourseSubjects { get; set; }
    }
}