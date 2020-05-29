using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itsppisapi.Models
{
    public class PGS012Model
    {
        public decimal ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_DESC { get; set; }
        public decimal USER_ID { get; set; }
        public string ACTIVE_FLG { get; set; }
    }
}
