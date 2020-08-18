using System;

namespace EFCore.Entities
{
    public abstract class Entity<TId> 
    {
        public TId Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}