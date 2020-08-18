namespace EFCore.Entities
{
    public class CourseSubject
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public long SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}