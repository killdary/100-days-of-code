using System;
using EFCore.Enums;

namespace EFCore.Entities
{
    public class Professor: Entity<int>
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime WorkStartDate { get; set; }
        public ELevelDegree Degree { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}