using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication99.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage ="Name Field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name Field is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Name Field is required")]
        public string Email { get; set; }
    }
}
