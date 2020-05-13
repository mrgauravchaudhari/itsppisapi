using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace cfclapi.Models
{
  public class PLS203Model
  {
    public string MINDT { get; set; }
    public string MAXDT { get; set; }
    public string L_TIME { get; set; }
    public string L_SHIFT { get; set; }
    public string L_TEMP { get; set; }
    public string L_DENSITY { get; set; }
    public string L_DENSITY_15C { get; set; }
    public string L_BR_NO { get; set; }
    public string L_OLEFINES { get; set; }
    public string L_AROMATICS { get; set; }
    public string L_IBP { get; set; }
    public string L_SULPHUR { get; set; }
    public string L_SULPHUR_OUTLET { get; set; }

  }
}
