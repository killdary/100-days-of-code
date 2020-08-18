namespace EFCore.Entities
{
    public class ClassStudent
    {
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public float Grade1 { get; set; }
        public float Grade2 { get; set; }
        public float Grade3 { get; set; }
        public float AverageGrades { get; set; }
    }
}