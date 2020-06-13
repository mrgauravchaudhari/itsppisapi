using System.ComponentModel.DataAnnotations;
using System;

namespace itsppisapi.Dtos
{
  public class UserForLoginDto
  {
    [Required]
    public string USER_NAME { get; set; }

    [Required]
    public string PASSWORD { get; set; }
  }
}
