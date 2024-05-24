using System.ComponentModel.DataAnnotations;

namespace Curlz.Models
{
    public class Registration
    {
        [Key]
        public int Reg_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.-]+@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Id")]
        public string Email_Id { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("Password", ErrorMessage = "The new password and confirmation password do not match.")]
        public string Confirm_Password { get; set; }


        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Invalid characters detected. Please enter only numbers.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public long Phone_No { get; set; }

        public string Role { get; }
    }


}

