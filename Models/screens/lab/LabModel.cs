using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
  public class LabModel
  {
    // GP-I Fields

    public string mindt { get; set; }
    public string maxdt { get; set; }

    public string GP1_L_TRANS_DATE { get; set; }
    public string GP1_L_TIME { get; set; }
    public string GP1_L_UNIT_ID { get; set; }
    public decimal GP1_L_USER_ID { get; set; }
    public string GP1_L_DATE_MOD { get; set; }
    public decimal GP1_L_N2 { get; set; }
    public decimal GP1_L_CH4 { get; set; }
    public decimal GP1_L_C2H6 { get; set; }
    public decimal GP1_L_CO2 { get; set; }
    public decimal GP1_L_C3H8 { get; set; }
    public decimal GP1_L_NC4H10 { get; set; }
    public decimal GP1_L_IC4H10 { get; set; }
    public decimal GP1_L_NG_GROSS_CV { get; set; }
    public decimal GP1_L_NG_NET_CV { get; set; }
    public string GP1_L_H2S { get; set; }
    public string GP1_L_ZNO_BED { get; set; }
    public decimal GP1_L_MOL_WT { get; set; }
    public string GP1_L_FREEZE_FLG { get; set; }
    public string GP1_L_FREEZE_TIME { get; set; }
    public string GP1_L_PLANT_ID { get; set; }

    public string PRV_GP1_L_TRANS_DATE { get; set; }
    public string PRV_GP1_L_TIME { get; set; }
    public string PRV_GP1_L_UNIT_ID { get; set; }
    public decimal PRV_GP1_L_USER_ID { get; set; }
    public string PRV_GP1_L_DATE_MOD { get; set; }
    public decimal PRV_GP1_L_N2 { get; set; }
    public decimal PRV_GP1_L_CH4 { get; set; }
    public decimal PRV_GP1_L_C2H6 { get; set; }
    public decimal PRV_GP1_L_CO2 { get; set; }
    public decimal PRV_GP1_L_C3H8 { get; set; }
    public decimal PRV_GP1_L_NC4H10 { get; set; }
    public decimal PRV_GP1_L_IC4H10 { get; set; }
    public decimal PRV_GP1_L_NG_GROSS_CV { get; set; }
    public decimal PRV_GP1_L_NG_NET_CV { get; set; }
    public string PRV_GP1_L_H2S { get; set; }
    public string PRV_GP1_L_ZNO_BED { get; set; }
    public decimal PRV_GP1_L_MOL_WT { get; set; }
    public string PRV_GP1_L_FREEZE_FLG { get; set; }
    public string PRV_GP1_L_FREEZE_TIME { get; set; }
    public string PRV_GP1_L_PLANT_ID { get; set; }

    // GP-II Fields
    public string GP2_L_TRANS_DATE { get; set; }
    public string GP2_L_TIME { get; set; }
    public string GP2_L_UNIT_ID { get; set; }
    public decimal GP2_L_USER_ID { get; set; }
    public string GP2_L_DATE_MOD { get; set; }
    public decimal GP2_L_N2 { get; set; }
    public decimal GP2_L_CH4 { get; set; }
    public decimal GP2_L_C2H6 { get; set; }
    public decimal GP2_L_CO2 { get; set; }
    public decimal GP2_L_C3H8 { get; set; }
    public decimal GP2_L_NC4H10 { get; set; }
    public decimal GP2_L_IC4H10 { get; set; }
    public decimal GP2_L_NG_GROSS_CV { get; set; }
    public decimal GP2_L_NG_NET_CV { get; set; }
    public string GP2_L_H2S { get; set; }
    public string GP2_L_ZNO_BED { get; set; }
    public decimal GP2_L_MOL_WT { get; set; }
    public string GP2_L_FREEZE_FLG { get; set; }
    public string GP2_L_FREEZE_TIME { get; set; }
    public string GP2_L_PLANT_ID { get; set; }

    public string PRV_GP2_L_TRANS_DATE { get; set; }
    public string PRV_GP2_L_TIME { get; set; }
    public string PRV_GP2_L_UNIT_ID { get; set; }
    public decimal PRV_GP2_L_USER_ID { get; set; }
    public string PRV_GP2_L_DATE_MOD { get; set; }
    public decimal PRV_GP2_L_N2 { get; set; }
    public decimal PRV_GP2_L_CH4 { get; set; }
    public decimal PRV_GP2_L_C2H6 { get; set; }
    public decimal PRV_GP2_L_CO2 { get; set; }
    public decimal PRV_GP2_L_C3H8 { get; set; }
    public decimal PRV_GP2_L_NC4H10 { get; set; }
    public decimal PRV_GP2_L_IC4H10 { get; set; }
    public decimal PRV_GP2_L_NG_GROSS_CV { get; set; }
    public decimal PRV_GP2_L_NG_NET_CV { get; set; }
    public string PRV_GP2_L_H2S { get; set; }
    public string PRV_GP2_L_ZNO_BED { get; set; }
    public decimal PRV_GP2_L_MOL_WT { get; set; }
    public string PRV_GP2_L_FREEZE_FLG { get; set; }
    public string PRV_GP2_L_FREEZE_TIME { get; set; }
    public string PRV_GP2_L_PLANT_ID { get; set; }

    // GP-III Fields
    public string GP3_L_TRANS_DATE { get; set; }
    public string GP3_L_TIME { get; set; }
    public string GP3_L_UNIT_ID { get; set; }
    public decimal GP3_L_USER_ID { get; set; }
    public string GP3_L_DATE_MOD { get; set; }
    public decimal GP3_L_N2 { get; set; }
    public decimal GP3_L_CH4 { get; set; }
    public decimal GP3_L_C2H6 { get; set; }
    public decimal GP3_L_CO2 { get; set; }
    public decimal GP3_L_C3H8 { get; set; }
    public decimal GP3_L_NC4H10 { get; set; }
    public decimal GP3_L_IC4H10 { get; set; }
    public decimal GP3_L_NG_GROSS_CV { get; set; }
    public decimal GP3_L_NG_NET_CV { get; set; }
    public string GP3_L_H2S { get; set; }
    public string GP3_L_ZNO_BED { get; set; }
    public decimal GP3_L_MOL_WT { get; set; }
    public string GP3_L_FREEZE_FLG { get; set; }
    public string GP3_L_FREEZE_TIME { get; set; }
    public string GP3_L_PLANT_ID { get; set; }

    public string PRV_GP3_L_TRANS_DATE { get; set; }
    public string PRV_GP3_L_TIME { get; set; }
    public string PRV_GP3_L_UNIT_ID { get; set; }
    public decimal PRV_GP3_L_USER_ID { get; set; }
    public string PRV_GP3_L_DATE_MOD { get; set; }
    public decimal PRV_GP3_L_N2 { get; set; }
    public decimal PRV_GP3_L_CH4 { get; set; }
    public decimal PRV_GP3_L_C2H6 { get; set; }
    public decimal PRV_GP3_L_CO2 { get; set; }
    public decimal PRV_GP3_L_C3H8 { get; set; }
    public decimal PRV_GP3_L_NC4H10 { get; set; }
    public decimal PRV_GP3_L_IC4H10 { get; set; }
    public decimal PRV_GP3_L_NG_GROSS_CV { get; set; }
    public decimal PRV_GP3_L_NG_NET_CV { get; set; }
    public string PRV_GP3_L_H2S { get; set; }
    public string PRV_GP3_L_ZNO_BED { get; set; }
    public decimal PRV_GP3_L_MOL_WT { get; set; }
    public string PRV_GP3_L_FREEZE_FLG { get; set; }
    public string PRV_GP3_L_FREEZE_TIME { get; set; }
    public string PRV_GP3_L_PLANT_ID { get; set; }
  }
}
