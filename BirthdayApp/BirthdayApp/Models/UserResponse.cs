using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public class UserResponse
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [EmailAddress(ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public bool? WillAttend { get; set; }

    }
}