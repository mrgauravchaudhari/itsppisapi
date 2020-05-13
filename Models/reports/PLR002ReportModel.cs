using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
	public class PLR002ReportModel
	{
		public string NS_L_TRANS_DATE { get; set; }
		public decimal NS_L_TANK_A_TEMP { get; set; }
		public int NS_TANK1 { get; set; }
		public decimal NS_L_TANK_A_DENSITY { get; set; }
		public decimal NS_L_TANK_A_DENSITY15 { get; set; }
		public decimal NS_L_TANK_B_TEMP { get; set; }
		public int NS_TANK2 { get; set; }
		public decimal NS_L_TANK_B_DENSITY { get; set; }
		public decimal NS_L_TANK_B_DENSITY15 { get; set; }
		public decimal NS_L_TANK_C_TEMP { get; set; }
		public int NS_TANK3 { get; set; }
		public decimal NS_L_TANK_C_DENSITY { get; set; }
		public decimal NS_L_TANK_C_DENSITY15 { get; set; }
		public decimal NS_L_TANK_D_TEMP { get; set; }
		public int NS_TANK4 { get; set; }
		public decimal NS_L_SNT_TEMP { get; set; }
		public int NS_TANK5 { get; set; }
		public decimal NS_L_SNT_DENSITY { get; set; }
		public decimal NS_L_SNT_DENSITY15 { get; set; }
		public decimal NS_L_TANK_D_DENSITY { get; set; }
		public decimal NS_L_TANK_D_DENSITY15 { get; set; }
		public string NR_L_TRANS_DATE { get; set; }
		public string NR_L_TIME { get; set; }
		public string NR_L_UNIT_ID { get; set; }
		public string NR_L_RAKE_NO { get; set; }
		public decimal NR_L_TEMP { get; set; }
		public decimal NR_L_DENSITY { get; set; }
		public decimal NR_L_BR_NO { get; set; }
		public decimal NR_L_OLEFINES { get; set; }
		public decimal NR_L_AROMATICS { get; set; }
		public decimal NR_L_IBP { get; set; }
		public decimal NR_L_NRA_50 { get; set; }
		public decimal NR_L_NRA_95 { get; set; }
		public decimal NR_L_FBP { get; set; }
		public decimal NR_L_CH_RATIO { get; set; }
		public decimal NR_L_NAP_NET_CV { get; set; }
		public decimal NR_L_NAP_GROSS_CV { get; set; }
		public string NG_L_TIME { get; set; }
		public string NG_L_UNIT_ID { get; set; }
		public decimal NG_L_N2 { get; set; }
		public decimal NG_L_CH4 { get; set; }
		public decimal NG_L_C2H6 { get; set; }
		public decimal NG_L_CO2 { get; set; }
		public decimal NG_L_C3H8 { get; set; }
		public decimal NG_L_NC4H10 { get; set; }
		public decimal NG_L_IC4H10 { get; set; }
		public decimal NG_L_NG_GROSS_CV { get; set; }
		public decimal NG_L_NG_NET_CV { get; set; }
		public string NG_L_H2S { get; set; }
		public string NG_L_ZNO_BED { get; set; }
		public decimal NG_L_MOL_WT { get; set; }
	}
}
