using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; //Allow use of decorators
using System.Linq;
using System.Web;

namespace busiStudyGroup.Models
{
    public class StudyGroup
    {
        //add properties from table
        [DisplayName("Student Number")]
        [Required(ErrorMessage = "Student number is required")] //Decorator
        public string StudentNum { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname number is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email number is required")]
        public string Email { get; set; }
    }
}