using System.ComponentModel.DataAnnotations;

namespace formSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Your First Name:")]
        public string FirstName {get; set;}

        [MinLength(3)]
        [Required]
        [Display(Name = "Your Last Name:")]
        public string LastName {get; set;} 

        [Required]
        [Range(13, 110)]
        [Display(Name = "Your Age:")]
        public int Age {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email Address:")]
        public string Email {get; set;} 

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Your Password:")]
        public string Password {get; set;} 
    }
}