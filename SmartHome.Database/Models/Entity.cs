using System;
using System.ComponentModel.DataAnnotations;

namespace SmartHome.Database.Models
{
    public class Entity
    {
        [Key] 
        public Guid Id { set; get; } = Guid.NewGuid();
    }
}