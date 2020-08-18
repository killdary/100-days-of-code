using System;
using System.Collections.Generic;

namespace EFCore.Entities
{
    public class Student : Entity<int>   
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime DateIngress { get; set; }
        public string RegistrationCodeStudent { get; set; }
        public List<CourseStudent> CourseStudents { get; set; }
        public List<ClassStudent> ClassStudents { get; set; }
    }
}