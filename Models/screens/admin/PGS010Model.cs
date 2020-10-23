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
        public string USER_VALIDITY_DT { get; set; }
        public decimal ENTERED_BY { get; set; }
        public decimal MODIFIED_BY { get; set; }
        public byte[] PASSWORD_HASH { get; set; }
        public byte[] PASSWORD_SALT { get; set; }
    }
    public class PGS010Model2
    {
        public decimal EMAIL_STATUS { get; set; }
    }
}