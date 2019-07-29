using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class Executor
    {

        [Required(ErrorMessage = "Please provide a value for Description field")]
        public string Description { get; set; }


        public int CourseId { get; set; }
        public Course Course { get; set; }


        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}