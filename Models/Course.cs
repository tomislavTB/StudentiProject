using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class Course : BaseModel
    {

        [Required(ErrorMessage = "Please provide a value for Name field")]
        public string Name { get; set; }


        public string Description { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }


        public ICollection<Executor> Executors { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
