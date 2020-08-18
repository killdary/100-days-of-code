using System.Collections.Generic;

namespace EFCore.Entities
{
    public class Subject: Entity<long>
    {
        public string Name { get; set; }
        public int NumberStudents { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<CourseSubject> CourseSubjects { get; set; }
        public List<Class> Classes { get; set; }
    }
}