using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itsppisapi.Models
{
    public class PGS012Model
    {
        public decimal GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_DESC { get; set; }
        public string ACTIVE_FLAG { get; set; }
    }
    public class PGS012Model2
    {
        public decimal GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_DESC { get; set; }
        public decimal USER_BY { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public string GROUP_MODULES { get; set; }
    }
    public class ListGroupNameModel
    {
        public string GROUP_NAME { get; set; }
    }
}
