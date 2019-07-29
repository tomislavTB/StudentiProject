using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentiProject.Models
{
    public class Division : BaseModel
    {

        [Required(ErrorMessage = "Please provide a value for Name field")]
        public string Name { get; set; }


        public int  CollegeId { get; set; }
        public College College { get; set; }

    }
}