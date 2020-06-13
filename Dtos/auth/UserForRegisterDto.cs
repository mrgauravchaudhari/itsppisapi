using System.ComponentModel.DataAnnotations;

namespace itsppisapi.Dtos
{
  public class UserForRegisterDto
  {
    public string USER_NAME { get; set; }
    public string USER_DESC { get; set; }
    public string USER_DEPT { get; set; }
    public decimal USER_EPR_NO { get; set; }   
    public string USER_PHONE_NO { get; set; }
    public string USER_EMAIL { get; set; }
    public string PASSWORD { get; set; }
  }
}
