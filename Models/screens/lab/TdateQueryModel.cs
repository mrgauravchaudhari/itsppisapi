using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Models
{
  public class TdateQueryModel
  {
    public string TDATE { get; set; }
    public string IN_DATE { get; set; }
    public string L_SHIFT { get; set; }
    public string L_SHIFT_NO { get; set; }
    public string L_TIME { get; set; }
    public string L_RAKE_NO { get; set; }
    public string L_UNIT_ID { get; set; }
    public string L_REPORT_ID { get; set; }
    public string L_REPORT_NAME { get; set; }
  }
}
