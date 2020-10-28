using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itsppisapi.Models
{
    [Table("PPM_GL_MST_USERS", Schema = "PPIS")]
    public class PPM_GL_MST_USERS
    {
        [Key]
        public decimal USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_DESC { get; set; }
        public decimal USER_LEVEL { get; set; }
        public string USER_DEPT { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public decimal USER_EPR_NO { get; set; }
        public string USER_PHONE_NO { get; set; }
        public string USER_EMAIL { get; set; }
        public decimal ENTERED_BY { get; set; }
        public decimal MODIFIED_BY { get; set; }
        public byte[] PASSWORD_HASH { get; set; }
        public byte[] PASSWORD_SALT { get; set; }
        public string PASSWORD_FLAG { get; set; }
        public DateTime USER_VALIDITY_DT { get; set; }
    }
}