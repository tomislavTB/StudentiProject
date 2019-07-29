using System;

namespace StudentiProject.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        // modified in ApplicationContext
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
