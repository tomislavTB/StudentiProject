using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class College
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a value for Name field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a value for Address field")]
        public string Address { get; set; }


        public int CityId { get; set; }
        public City City { get; set; }

    }
}
