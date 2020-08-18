using System;
using EFCore.Enums;

namespace EFCore.Entities
{
    public class Person: Entity<int>
    {
        public string Name { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime Birthday { get; set; }
        public ESex Sex { get; set; }
    }
}