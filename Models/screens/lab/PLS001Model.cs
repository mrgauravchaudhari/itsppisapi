using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cfclapi.Models
{
  public class PLS001Model
  {
    public string L_REPORT_NAME { get; set; }
    public string L_REP_UNIT { get; set; }
    public decimal L_REP_PRINT_SEQ { get; set; }
    public string L_REPORT_DESC { get; set; }
    public string L_ACTIVE_FLG { get; set; }
    public string L_TIME { get; set; }
    public string DEPT_NAME { get; set; }
    public string L_DEPT_CODE { get; set; }
    //public List<PLS001Model> TIME { get; set; }
    //public List<string> L_TIME { get; set; }
    //  public PLS001Model()
    //     {
    //         TIME = new List<PLS001Model>();
    //     }
    //public string L_DEPT_CODE { get; set; }


  }
}
