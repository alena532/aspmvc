using System;
using System.ComponentModel.DataAnnotations;
namespace Party.Models
{
    public class GetResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public  string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you are attend")]
        public bool? WillAttend { get; set; }
        
        public GetResponse()
        {
        }
    }
}
