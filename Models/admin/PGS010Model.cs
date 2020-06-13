using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itsppisapi.Models
{
    public class PGS010Model
    {
        public decimal USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_DESC { get; set; }
        public decimal USER_LEVEL { get; set; }
        public string USER_DEPT { get; set; }
        public decimal USER_EPR_NO { get; set; }
        public string USER_PHONE_NO { get; set; }
        public string USER_EMAIL { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public byte[] PASSWORD_HASH { get; set; }
        public byte[] PASSWORD_SALT { get; set; }
    }
}
