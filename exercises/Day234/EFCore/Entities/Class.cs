using System.Collections.Generic;

namespace EFCore.Entities
{
    public class Class : Entity<int>
    {
        public long SubjectId { get; set; }
        public Subject Subject { get; set; }
        public float MinimunGrade { get; set; }
        public List<ClassStudent> ClassStudents { get; set; }

    }
}