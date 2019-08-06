using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class ContactInfo
    {
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
        public string LinkedinProfile { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birthday { get; set; }

        public string BirthdayString { get; set; }

        public ContactInfo()
        {

        }
    }
}