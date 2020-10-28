using System.ComponentModel.DataAnnotations;

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
