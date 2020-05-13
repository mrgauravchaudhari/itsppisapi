using System.ComponentModel.DataAnnotations;

namespace itsppisapi.Dtos
{
  public class UserForRegisterDto
  {
    [Required]
    [StringLength(100, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 4)]
    public string USER_NAME { get; set; }

    public string USER_DESC { get; set; }

    [Required]
    public string USER_DEPT { get; set; }

    public int EPR_NO { get; set; }

    [Required]
    [EmailAddress]
    public string USER_EMAIL { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
    [Display(Name = "Password")]
    [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
    public string PASSWORD { get; set; }
  }
}
