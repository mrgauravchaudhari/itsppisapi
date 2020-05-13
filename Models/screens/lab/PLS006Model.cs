using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
  public class PLS006Model
  {
    public string MINDT { get; set; }
    public string MAXDT { get; set; }
    public string L_RAKE_NO { get; set; }
    public string L_TIME { get; set; }
    public string L_TEMP { get; set; }
    public string L_DENSITY { get; set; }
    public string L_DENSITY_15C { get; set; }
    public string L_BR_NO { get; set; }
    public string L_OLEFINES { get; set; }
    public string L_AROMATICS { get; set; }
    public string L_IBP { get; set; }
    public string L_NRA_50 { get; set; }
    public string L_NRA_95 { get; set; }
    public string L_FBP { get; set; }
    public string L_CH_RATIO { get; set; }
    public string L_NAP_NET_CV { get; set; }
    public string L_NAP_GROSS_CV { get; set; }

  }
}
