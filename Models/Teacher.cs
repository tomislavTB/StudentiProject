using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class Teacher
    {

        [Required(ErrorMessage = "Please provide a value for FirstName field")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide a value for LastName field")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide a value for Address field")]
        public string Address { get; set; }

        
        public int CityId { get; set; }
        public City City { get; set; }


        public ICollection<Executor> Executors { get; set; }
    }
}