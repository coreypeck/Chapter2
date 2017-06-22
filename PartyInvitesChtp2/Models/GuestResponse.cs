using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitesChtp2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name {get; set;}
        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify if you will attend or not")]
        public bool? WillAttend { get; set; }
    }
}