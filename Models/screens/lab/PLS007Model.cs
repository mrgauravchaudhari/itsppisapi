using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Models
{
  public class PLS007Model
  {
    public string MINDT { get; set; }
    public string MAXDT { get; set; }
    public string L_TANK_A_TEMP { get; set; }
    public string L_TANK_A_DENSITY { get; set; }
    public string L_TANK_A_DENSITY15 { get; set; }
    public string L_TANK_B_TEMP { get; set; }
    public string L_TANK_B_DENSITY { get; set; }
    public string L_TANK_B_DENSITY16 { get; set; }
    public string L_TANK_C_TEMP { get; set; }
    public string L_TANK_C_DENSITY { get; set; }
    public string L_TANK_C_DENSITY17 { get; set; }
    public string L_TANK_D_TEMP { get; set; }
    public string L_TANK_D_DENSITY { get; set; }
    public string L_TANK_D_DENSITY18 { get; set; }
    public string L_SNT_TEMP { get; set; }
    public string L_SNT_DENSITY { get; set; }
    public string L_SNT_DENSITY19 { get; set; }
  }
}
