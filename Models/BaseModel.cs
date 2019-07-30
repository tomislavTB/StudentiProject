using StudentiProject.Models.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        // modified in ApplicationContext
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Inherited from SoftDeletable
        public bool IsDeleted { get; internal set; }
    }
}


