using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Models
{
  public class UserProfile
  {
    public decimal USER_ID { get; set; }
    public string USER_NAME { get; set; }
    public string ACTIVE_FLAG { get; set; }
    public byte[] PASSWORD_HASH { get; set; }
    public byte[] PASSWORD_SALT { get; set; }
  }
}
