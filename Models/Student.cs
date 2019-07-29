using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class Student
    {

        [Required(ErrorMessage = "Please provide a value for FirstName field")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide a value for LastName field")]
        public string LastName { get; set; }


        public int CityId { get; set; }
        public City City { get; set; }
        public int  DivisionId { get; set; }
        public Division Division { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}