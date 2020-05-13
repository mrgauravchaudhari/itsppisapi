using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
    public class ResetPasswordModel
    {
        public string USER_NAME { get; set; }
        public string PASSWORD_TEMP { get; set; }
        public string NEW_PASSWORD { get; set; }
    }
}
