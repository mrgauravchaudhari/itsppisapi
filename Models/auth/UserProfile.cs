using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
  [Table("PPM_GL_MST_USERS", Schema = "PPIS")]
  public class UserProfile
  {
    [Key]
    public int USER_ID { get; set; }
    public string USER_NAME { get; set; }
    public string USER_DESC { get; set; }
    public int USER_LEVEL { get; set; }
    public string USER_DEPT { get; set; }
    public string STATUS { get; set; }
    public int EPR_NO { get; set; }
    public string USER_EMAIL { get; set; }
  }
}
