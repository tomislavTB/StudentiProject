using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class Grade
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please provide with exam time")]
        public string ExamTime { get; set; }

        [Required(ErrorMessage = "Please provide with exam Evaluation")]
        public int Evaluation { get; set; }


        public int CourceId { get; set; }
        public Course Course { get; set; }


        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}