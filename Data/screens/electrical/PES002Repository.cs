using Microsoft.Extensions.Configuration;
using itsppisapi.Dtos;
using itsppisapi.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
  public class PES002Repository
  {
    private readonly string _connectionString;
    public PES002Repository(IConfiguration configuration)
    {
      _connectionString = configuration.GetConnectionString("DBConnection");
    }

    private PES002Model MapToValue(SqlDataReader reader)
    {
      return new PES002Model()
      {
        MINDT = reader["MINDT"].ToString(),
        MAXDT = reader["MAXDT"].ToString(),
        E1_TRANS_DATE = reader["E1_TRANS_DATE"].ToString(),
        E1_UNIT_ID = reader["E1_UNIT_ID"].ToString(),
        E1_DMY_FLG = reader["E1_DMY_FLG"].ToString(),
        E1_USER_ID = reader["E1_USER_ID"].ToString(),
        E1_DATE_MOD = reader["E1_DATE_MOD"].ToString(),
        E1_FREEZE_FLG = reader["E1_FREEZE_FLG"].ToString(),
        E1_GT1_INT = (decimal)reader["E1_GT1_INT"],
        E1_GT1_PROD = (decimal)reader["E1_GT1_PROD"],
        E1_GT2_INT = (decimal)reader["E1_GT2_INT"],
        E1_GT2_PROD = (decimal)reader["E1_GT2_PROD"],
        E1_RSEB_INT = (decimal)reader["E1_RSEB_INT"],
        E1_RSEB_PURCHASED = (decimal)reader["E1_RSEB_PURCHASED"],
        E1_LOSS_GEN = (decimal)reader["E1_LOSS_GEN"],
        E1_LOSS_RSEB = (decimal)reader["E1_LOSS_RSEB"],
        E1_AMM_INT = (decimal)reader["E1_AMM_INT"],
        E1_AMM_CONSP = (decimal)reader["E1_AMM_CONSP"],
        E1_U11_INT = (decimal)reader["E1_U11_INT"],
        E1_U11_CONSP = (decimal)reader["E1_U11_CONSP"],
        E1_U21_INT = (decimal)reader["E1_U21_INT"],
        E1_U21_CONSP = (decimal)reader["E1_U21_CONSP"],
        E1_SPG_INT = (decimal)reader["E1_SPG_INT"],
        E1_SPG_CONSP = (decimal)reader["E1_SPG_CONSP"],
        E1_SPG_COND_ID = (decimal)reader["E1_SPG_COND_ID"],
        E1_SPG_SUB_COND_ID = (decimal)reader["E1_SPG_SUB_COND_ID"],
        E1_OFFSITE_INT = (decimal)reader["E1_OFFSITE_INT"],
        E1_OFFSITE_CONSP = (decimal)reader["E1_OFFSITE_CONSP"],
        E1_OFFSITE_COND_ID = (decimal)reader["E1_OFFSITE_COND_ID"],
        E1_OFFSITE_SUB_COND_ID = (decimal)reader["E1_OFFSITE_SUB_COND_ID"],
        E1_AMM_STORAGE_INT = (decimal)reader["E1_AMM_STORAGE_INT"],
        E1_AMM_STORAGE_CONSP = (decimal)reader["E1_AMM_STORAGE_CONSP"],
        E1_UPHS_INT = (decimal)reader["E1_UPHS_INT"],
        E1_UPHS_CONSP = (decimal)reader["E1_UPHS_CONSP"],
        E1_RW_INT = (decimal)reader["E1_RW_INT"],
        E1_RW_CONSP = (decimal)reader["E1_RW_CONSP"],
        E1_TFR_TO_NEBUS_INT = (decimal)reader["E1_TFR_TO_NEBUS_INT"],
        E1_TFR_TO_NEBUS = (decimal)reader["E1_TFR_TO_NEBUS"],
        E1_UNIT2_FDR1_INT = (decimal)reader["E1_UNIT2_FDR1_INT"],
        E1_UNIT2_FDR1_CONSP = (decimal)reader["E1_UNIT2_FDR1_CONSP"],
        E1_UNIT2_FDR2_INT = (decimal)reader["E1_UNIT2_FDR2_INT"],
        E1_UNIT2_FDR2_CONSP = (decimal)reader["E1_UNIT2_FDR2_CONSP"],
        E1_UNIT2_BAGG_INT = (decimal)reader["E1_UNIT2_BAGG_INT"],
        E1_UNIT2_BAGG_CONSP = (decimal)reader["E1_UNIT2_BAGG_CONSP"],
        E1_REMARKS = reader["E1_REMARKS"].ToString(),
        E1_AB_CONSP = (decimal)reader["E1_AB_CONSP"],
        E1_CPP_CONSP = (decimal)reader["E1_CPP_CONSP"],
        E1_IAC_SPG_CONSP = (decimal)reader["E1_IAC_SPG_CONSP"],
        E1_IAC_OFFSITE_CONSP = (decimal)reader["E1_IAC_OFFSITE_CONSP"],
        E1_ACT_CONSP = (decimal)reader["E1_ACT_CONSP"],
        E1_UCT_CONSP = (decimal)reader["E1_UCT_CONSP"],
        E1_WPT_CONSP = (decimal)reader["E1_WPT_CONSP"],
        E1_DMP_CONSP = (decimal)reader["E1_DMP_CONSP"],
        E1_ETP_CONSP = (decimal)reader["E1_ETP_CONSP"],
        E1_FIRE_CONSP = (decimal)reader["E1_FIRE_CONSP"],
        E1_CIVIL_BLDG_INT = (decimal)reader["E1_CIVIL_BLDG_INT"],
        E1_CIVIL_BLDG_CONSP = (decimal)reader["E1_CIVIL_BLDG_CONSP"],
        E1_CONST_POWER_UNIT2_INT = (decimal)reader["E1_CONST_POWER_UNIT2_INT"],
        E1_CONST_POWER_UNIT2_CONSP = (decimal)reader["E1_CONST_POWER_UNIT2_CONSP"],
        E1_HOUSE_COL_INT = (decimal)reader["E1_HOUSE_COL_INT"],
        E1_HOUSE_COL_CONSP = (decimal)reader["E1_HOUSE_COL_CONSP"],
        E1_KSR_INT = (decimal)reader["E1_KSR_INT"],
        E1_KSR_CONSP = (decimal)reader["E1_KSR_CONSP"],
        E1_TFR_TO_EBUS_INT = (decimal)reader["E1_TFR_TO_EBUS_INT"],
        E1_TFR_TO_EBUS = (decimal)reader["E1_TFR_TO_EBUS"],
        E1_WS_FENCELIGHT_INT = (decimal)reader["E1_WS_FENCELIGHT_INT"],
        E1_WS_FENCELIGHT_CONSP = (decimal)reader["E1_WS_FENCELIGHT_CONSP"],
        E1_FREEZE_TIME = reader["E1_FREEZE_TIME"].ToString(),
        E1_TOT_GT_GEN = (decimal)reader["E1_TOT_GT_GEN"],
        E1_TOT_EBUS_CONSP = (decimal)reader["E1_TOT_EBUS_CONSP"],
        E1_TOT_NEBUS_CONSP = (decimal)reader["E1_TOT_NEBUS_CONSP"],
        E1_UNIT2_OFFSITE_INT = (decimal)reader["E1_UNIT2_OFFSITE_INT"],
        E1_UNIT2_OFFSITE_CONSP = (decimal)reader["E1_UNIT2_OFFSITE_CONSP"],
        E1_PUR_PWR_UNIT2_INT = (decimal)reader["E1_PUR_PWR_UNIT2_INT"],
        E1_PUR_PWR_UNIT2_CONSP = (decimal)reader["E1_PUR_PWR_UNIT2_CONSP"],
        E1_NAP_STORAGE_INT = (decimal)reader["E1_NAP_STORAGE_INT"],
        E1_HOLDING_POND_INT = (decimal)reader["E1_HOLDING_POND_INT"],
        E1_NAP_STORAGE_CONSP = (decimal)reader["E1_NAP_STORAGE_CONSP"],
        E1_HOLDING_POND_CONSP = (decimal)reader["E1_HOLDING_POND_CONSP"],
        E1_HOLDING_POND_INT2 = (decimal)reader["E1_HOLDING_POND_INT2"],
        E1_HOLDING_POND_CONSP2 = (decimal)reader["E1_HOLDING_POND_CONSP2"],
        E1_OFFSITE_15MVA_INT = (decimal)reader["E1_OFFSITE_15MVA_INT"],
        E1_OFFSITE_15MVA_CONSP = (decimal)reader["E1_OFFSITE_15MVA_CONSP"],
        E1_OFFSITE_3MVA_INT = (decimal)reader["E1_OFFSITE_3MVA_INT"],
        E1_OFFSITE_3MVA_CONSP = (decimal)reader["E1_OFFSITE_3MVA_CONSP"],
        E1_GEN_PWR_KSR_INT = (decimal)reader["E1_GEN_PWR_KSR_INT"],
        E1_GEN_PWR_KSR_CONSP = (decimal)reader["E1_GEN_PWR_KSR_CONSP"],
        E1_GEN_PWR_HOUSE_COL_INT = (decimal)reader["E1_GEN_PWR_HOUSE_COL_INT"],
        E1_GEN_PWR_HOUSE_COL_CONSP = (decimal)reader["E1_GEN_PWR_HOUSE_COL_CONSP"],
        E1_GEN_PWR_CIVIL_BLDG_INT = (decimal)reader["E1_GEN_PWR_CIVIL_BLDG_INT"],
        E1_GEN_PWR_CIVIL_BLDG_CONSP = (decimal)reader["E1_GEN_PWR_CIVIL_BLDG_CONSP"],
        E1_GEN_PWR_WS_FENCELIGHT_INT = (decimal)reader["E1_GEN_PWR_WS_FENCELIGHT_INT"],
        E1_GEN_PWR_WS_FENCELIGHT_CONSP = (decimal)reader["E1_GEN_PWR_WS_FENCELIGHT_CONSP"],
        E1_PUR_PWR_UPHS1_INT = (decimal)reader["E1_PUR_PWR_UPHS1_INT"],
        E1_PUR_PWR_UPHS1_CONSP = (decimal)reader["E1_PUR_PWR_UPHS1_CONSP"],
        E1_PUR_PWR_RW_INT = (decimal)reader["E1_PUR_PWR_RW_INT"],
        E1_PUR_PWR_RW_CONSP = (decimal)reader["E1_PUR_PWR_RW_CONSP"],
        E1_PUR_PWR_UPHS2_INT = (decimal)reader["E1_PUR_PWR_UPHS2_INT"],
        E1_PUR_PWR_UPHS2_CONSP = (decimal)reader["E1_PUR_PWR_UPHS2_CONSP"],
        E1_PUR_PWR_3MVA_INT = (decimal)reader["E1_PUR_PWR_3MVA_INT"],
        E1_PUR_PWR_3MVA_CONSP = (decimal)reader["E1_PUR_PWR_3MVA_CONSP"],
        E1_PUR_PWR_OTHER_INT = (decimal)reader["E1_PUR_PWR_OTHER_INT"],
        E1_PUR_PWR_OTHER_CONSP = (decimal)reader["E1_PUR_PWR_OTHER_CONSP"],
        E1_PUR_PWR_WPT_CONSP = (decimal)reader["E1_PUR_PWR_WPT_CONSP"],
        E1_PUR_PWR_DMP_CONSP = (decimal)reader["E1_PUR_PWR_DMP_CONSP"],
        E1_PUR_PWR_ETP_CONSP = (decimal)reader["E1_PUR_PWR_ETP_CONSP"],
        E1_PUR_PWR_ACT_CONSP = (decimal)reader["E1_PUR_PWR_ACT_CONSP"],
        E1_PUR_PWR_UCT_CONSP = (decimal)reader["E1_PUR_PWR_UCT_CONSP"],
        E1_PUR_PWR_IAC_CONSP = (decimal)reader["E1_PUR_PWR_IAC_CONSP"],
        E1_3MVA_COND_ID = (decimal)reader["E1_3MVA_COND_ID"],
        E1_3MVA_SUB_COND_ID = (decimal)reader["E1_3MVA_SUB_COND_ID"],
        E1_PUR_PWR_RATE = (decimal)reader["E1_PUR_PWR_RATE"],
        E1_PUR_PWR_NAPSTRG_INT = (decimal)reader["E1_PUR_PWR_NAPSTRG_INT"],
        E1_PUR_PWR_NAPSTRG_CONSP = (decimal)reader["E1_PUR_PWR_NAPSTRG_CONSP"],
        E1_PWR_CONSP_E_LOAD = (decimal)reader["E1_PWR_CONSP_E_LOAD"],
        E1_PWR_CONSP_NE_LOAD = (decimal)reader["E1_PWR_CONSP_NE_LOAD"],
        E1_CIVIL_BLDG_CONSP_RATE = (decimal)reader["E1_CIVIL_BLDG_CONSP_RATE"],
        E1_HOUSE_COL_CONSP_RATE = (decimal)reader["E1_HOUSE_COL_CONSP_RATE"],
        E1_KSR_CONSP_RATE = (decimal)reader["E1_KSR_CONSP_RATE"],
        E1_WS_FENCELIGHT_CONSP_RATE = (decimal)reader["E1_WS_FENCELIGHT_CONSP_RATE"],
        E1_PUR_PWR_UPHS1_CONSP_RATE = (decimal)reader["E1_PUR_PWR_UPHS1_CONSP_RATE"],
        E1_PUR_PWR_RW_CONSP_RATE = (decimal)reader["E1_PUR_PWR_RW_CONSP_RATE"],
        E1_PUR_PWR_3MVA_CONSP_RATE = (decimal)reader["E1_PUR_PWR_3MVA_CONSP_RATE"],
        E1_PUR_PWR_OTHER_CONSP_RATE = (decimal)reader["E1_PUR_PWR_OTHER_CONSP_RATE"],
        E1_PUR_PWR_CONSP_COND = reader["E1_PUR_PWR_CONSP_COND"].ToString(),
        E1_PUR_PWR_IND_LOAD = (decimal)reader["E1_PUR_PWR_IND_LOAD"],
        E1_PUR_PWR_HOUSE_LOAD = (decimal)reader["E1_PUR_PWR_HOUSE_LOAD"],
        E1_PUR_PWR_HOUSE_RDG_CORR = (decimal)reader["E1_PUR_PWR_HOUSE_RDG_CORR"],
        E1_PUR_PWR_MAX_DEMAND = (decimal)reader["E1_PUR_PWR_MAX_DEMAND"],
        E1_PUR_PWR_UPSH2_CONSP_RATE = (decimal)reader["E1_PUR_PWR_UPSH2_CONSP_RATE"],
        E1_PUR_PWR_NAPSTRG_CONSP_RATE = (decimal)reader["E1_PUR_PWR_NAPSTRG_CONSP_RATE"],
        E1_PUR_PWR_AVL_BAL_LOAD = (decimal)reader["E1_PUR_PWR_AVL_BAL_LOAD"],
        E1_REVAMP_CONSP_UNIT1 = (decimal)reader["E1_REVAMP_CONSP_UNIT1"],
        E1_PUR_PWR_SSP_INT = (decimal)reader["E1_PUR_PWR_SSP_INT"],
        E1_PUR_PWR_CONSP_SSP = (decimal)reader["E1_PUR_PWR_CONSP_SSP"],
        E1_PUR_PWR_SSP_CONSP_RATE = (decimal)reader["E1_PUR_PWR_SSP_CONSP_RATE"],
        E1_IEX_PURCHASED = (decimal)reader["E1_IEX_PURCHASED"],
        E1_PUR_POWER_TOTAL = (decimal)reader["E1_PUR_POWER_TOTAL"],
        E1_PUR_PWR_GP3_CONSP = (decimal)reader["E1_PUR_PWR_GP3_CONSP"],
        E1_PUR_PWR_GP3_CONSP_RATE = (decimal)reader["E1_PUR_PWR_GP3_CONSP_RATE"],
        E1_RECEIPT_UPH2_GP3 = (decimal)reader["E1_RECEIPT_UPH2_GP3"],
        E1_PUR_PWR_GP3_INT = (decimal)reader["E1_PUR_PWR_GP3_INT"],
        E1_GT2_EXPORT_GP3_ID = (decimal)reader["E1_GT2_EXPORT_GP3_ID"],
        E1_RECEIPT_UPH12_TOTAL = (decimal)reader["E1_RECEIPT_UPH12_TOTAL"],
        E1_GT1_EXPORT_GP3_ID = (decimal)reader["E1_GT1_EXPORT_GP3_ID"],
        E1_RECEIPT_UPH1_GP3 = (decimal)reader["E1_RECEIPT_UPH1_GP3"],
        E1_GT1_EXPORT_GP3 = (decimal)reader["E1_GT1_EXPORT_GP3"],
        E1_GT2_EXPORT_GP3 = (decimal)reader["E1_GT2_EXPORT_GP3"],
        TXT_TOT_OFFSITE_CONSP = (decimal)reader["TXT_TOT_OFFSITE_CONSP"],

        //PRV
        PRV_E1_TRANS_DATE = reader["PRV_E1_TRANS_DATE"].ToString(),
        PRV_E1_UNIT_ID = reader["PRV_E1_UNIT_ID"].ToString(),
        PRV_E1_DMY_FLG = reader["PRV_E1_DMY_FLG"].ToString(),
        PRV_E1_USER_ID = reader["PRV_E1_USER_ID"].ToString(),
        PRV_E1_DATE_MOD = reader["PRV_E1_DATE_MOD"].ToString(),
        PRV_E1_FREEZE_FLG = reader["PRV_E1_FREEZE_FLG"].ToString(),
        PRV_E1_GT1_INT = (decimal)reader["PRV_E1_GT1_INT"],
        PRV_E1_GT1_PROD = (decimal)reader["PRV_E1_GT1_PROD"],
        PRV_E1_GT2_INT = (decimal)reader["PRV_E1_GT2_INT"],
        PRV_E1_GT2_PROD = (decimal)reader["PRV_E1_GT2_PROD"],
        PRV_E1_RSEB_INT = (decimal)reader["PRV_E1_RSEB_INT"],
        PRV_E1_RSEB_PURCHASED = (decimal)reader["PRV_E1_RSEB_PURCHASED"],
        PRV_E1_LOSS_GEN = (decimal)reader["PRV_E1_LOSS_GEN"],
        PRV_E1_LOSS_RSEB = (decimal)reader["PRV_E1_LOSS_RSEB"],
        PRV_E1_AMM_INT = (decimal)reader["PRV_E1_AMM_INT"],
        PRV_E1_AMM_CONSP = (decimal)reader["PRV_E1_AMM_CONSP"],
        PRV_E1_U11_INT = (decimal)reader["PRV_E1_U11_INT"],
        PRV_E1_U11_CONSP = (decimal)reader["PRV_E1_U11_CONSP"],
        PRV_E1_U21_INT = (decimal)reader["PRV_E1_U21_INT"],
        PRV_E1_U21_CONSP = (decimal)reader["PRV_E1_U21_CONSP"],
        PRV_E1_SPG_INT = (decimal)reader["PRV_E1_SPG_INT"],
        PRV_E1_SPG_CONSP = (decimal)reader["PRV_E1_SPG_CONSP"],
        PRV_E1_SPG_COND_ID = (decimal)reader["PRV_E1_SPG_COND_ID"],
        PRV_E1_SPG_SUB_COND_ID = (decimal)reader["PRV_E1_SPG_SUB_COND_ID"],
        PRV_E1_OFFSITE_INT = (decimal)reader["PRV_E1_OFFSITE_INT"],
        PRV_E1_OFFSITE_CONSP = (decimal)reader["PRV_E1_OFFSITE_CONSP"],
        PRV_E1_OFFSITE_COND_ID = (decimal)reader["PRV_E1_OFFSITE_COND_ID"],
        PRV_E1_OFFSITE_SUB_COND_ID = (decimal)reader["PRV_E1_OFFSITE_SUB_COND_ID"],
        PRV_E1_AMM_STORAGE_INT = (decimal)reader["PRV_E1_AMM_STORAGE_INT"],
        PRV_E1_AMM_STORAGE_CONSP = (decimal)reader["PRV_E1_AMM_STORAGE_CONSP"],
        PRV_E1_UPHS_INT = (decimal)reader["PRV_E1_UPHS_INT"],
        PRV_E1_UPHS_CONSP = (decimal)reader["PRV_E1_UPHS_CONSP"],
        PRV_E1_RW_INT = (decimal)reader["PRV_E1_RW_INT"],
        PRV_E1_RW_CONSP = (decimal)reader["PRV_E1_RW_CONSP"],
        PRV_E1_TFR_TO_NEBUS_INT = (decimal)reader["PRV_E1_TFR_TO_NEBUS_INT"],
        PRV_E1_TFR_TO_NEBUS = (decimal)reader["PRV_E1_TFR_TO_NEBUS"],
        PRV_E1_UNIT2_FDR1_INT = (decimal)reader["PRV_E1_UNIT2_FDR1_INT"],
        PRV_E1_UNIT2_FDR1_CONSP = (decimal)reader["PRV_E1_UNIT2_FDR1_CONSP"],
        PRV_E1_UNIT2_FDR2_INT = (decimal)reader["PRV_E1_UNIT2_FDR2_INT"],
        PRV_E1_UNIT2_FDR2_CONSP = (decimal)reader["PRV_E1_UNIT2_FDR2_CONSP"],
        PRV_E1_UNIT2_BAGG_INT = (decimal)reader["PRV_E1_UNIT2_BAGG_INT"],
        PRV_E1_UNIT2_BAGG_CONSP = (decimal)reader["PRV_E1_UNIT2_BAGG_CONSP"],
        PRV_E1_REMARKS = reader["PRV_E1_REMARKS"].ToString(),
        PRV_E1_AB_CONSP = (decimal)reader["PRV_E1_AB_CONSP"],
        PRV_E1_CPP_CONSP = (decimal)reader["PRV_E1_CPP_CONSP"],
        PRV_E1_IAC_SPG_CONSP = (decimal)reader["PRV_E1_IAC_SPG_CONSP"],
        PRV_E1_IAC_OFFSITE_CONSP = (decimal)reader["PRV_E1_IAC_OFFSITE_CONSP"],
        PRV_E1_ACT_CONSP = (decimal)reader["PRV_E1_ACT_CONSP"],
        PRV_E1_UCT_CONSP = (decimal)reader["PRV_E1_UCT_CONSP"],
        PRV_E1_WPT_CONSP = (decimal)reader["PRV_E1_WPT_CONSP"],
        PRV_E1_DMP_CONSP = (decimal)reader["PRV_E1_DMP_CONSP"],
        PRV_E1_ETP_CONSP = (decimal)reader["PRV_E1_ETP_CONSP"],
        PRV_E1_FIRE_CONSP = (decimal)reader["PRV_E1_FIRE_CONSP"],
        PRV_E1_CIVIL_BLDG_INT = (decimal)reader["PRV_E1_CIVIL_BLDG_INT"],
        PRV_E1_CIVIL_BLDG_CONSP = (decimal)reader["PRV_E1_CIVIL_BLDG_CONSP"],
        PRV_E1_CONST_POWER_UNIT2_INT = (decimal)reader["PRV_E1_CONST_POWER_UNIT2_INT"],
        PRV_E1_CONST_POWER_UNIT2_CONSP = (decimal)reader["PRV_E1_CONST_POWER_UNIT2_CONSP"],
        PRV_E1_HOUSE_COL_INT = (decimal)reader["PRV_E1_HOUSE_COL_INT"],
        PRV_E1_HOUSE_COL_CONSP = (decimal)reader["PRV_E1_HOUSE_COL_CONSP"],
        PRV_E1_KSR_INT = (decimal)reader["PRV_E1_KSR_INT"],
        PRV_E1_KSR_CONSP = (decimal)reader["PRV_E1_KSR_CONSP"],
        PRV_E1_TFR_TO_EBUS_INT = (decimal)reader["PRV_E1_TFR_TO_EBUS_INT"],
        PRV_E1_TFR_TO_EBUS = (decimal)reader["PRV_E1_TFR_TO_EBUS"],
        PRV_E1_WS_FENCELIGHT_INT = (decimal)reader["PRV_E1_WS_FENCELIGHT_INT"],
        PRV_E1_WS_FENCELIGHT_CONSP = (decimal)reader["PRV_E1_WS_FENCELIGHT_CONSP"],
        PRV_E1_FREEZE_TIME = reader["PRV_E1_FREEZE_TIME"].ToString(),
        PRV_E1_TOT_GT_GEN = (decimal)reader["PRV_E1_TOT_GT_GEN"],
        PRV_E1_TOT_EBUS_CONSP = (decimal)reader["PRV_E1_TOT_EBUS_CONSP"],
        PRV_E1_TOT_NEBUS_CONSP = (decimal)reader["PRV_E1_TOT_NEBUS_CONSP"],
        PRV_E1_UNIT2_OFFSITE_INT = (decimal)reader["PRV_E1_UNIT2_OFFSITE_INT"],
        PRV_E1_UNIT2_OFFSITE_CONSP = (decimal)reader["PRV_E1_UNIT2_OFFSITE_CONSP"],
        PRV_E1_PUR_PWR_UNIT2_INT = (decimal)reader["PRV_E1_PUR_PWR_UNIT2_INT"],
        PRV_E1_PUR_PWR_UNIT2_CONSP = (decimal)reader["PRV_E1_PUR_PWR_UNIT2_CONSP"],
        PRV_E1_NAP_STORAGE_INT = (decimal)reader["PRV_E1_NAP_STORAGE_INT"],
        PRV_E1_HOLDING_POND_INT = (decimal)reader["PRV_E1_HOLDING_POND_INT"],
        PRV_E1_NAP_STORAGE_CONSP = (decimal)reader["PRV_E1_NAP_STORAGE_CONSP"],
        PRV_E1_HOLDING_POND_CONSP = (decimal)reader["PRV_E1_HOLDING_POND_CONSP"],
        PRV_E1_HOLDING_POND_INT2 = (decimal)reader["PRV_E1_HOLDING_POND_INT2"],
        PRV_E1_HOLDING_POND_CONSP2 = (decimal)reader["PRV_E1_HOLDING_POND_CONSP2"],
        PRV_E1_OFFSITE_15MVA_INT = (decimal)reader["PRV_E1_OFFSITE_15MVA_INT"],
        PRV_E1_OFFSITE_15MVA_CONSP = (decimal)reader["PRV_E1_OFFSITE_15MVA_CONSP"],
        PRV_E1_OFFSITE_3MVA_INT = (decimal)reader["PRV_E1_OFFSITE_3MVA_INT"],
        PRV_E1_OFFSITE_3MVA_CONSP = (decimal)reader["PRV_E1_OFFSITE_3MVA_CONSP"],
        PRV_E1_GEN_PWR_KSR_INT = (decimal)reader["PRV_E1_GEN_PWR_KSR_INT"],
        PRV_E1_GEN_PWR_KSR_CONSP = (decimal)reader["PRV_E1_GEN_PWR_KSR_CONSP"],
        PRV_E1_GEN_PWR_HOUSE_COL_INT = (decimal)reader["PRV_E1_GEN_PWR_HOUSE_COL_INT"],
        PRV_E1_GEN_PWR_HOUSE_COL_CONSP = (decimal)reader["PRV_E1_GEN_PWR_HOUSE_COL_CONSP"],
        PRV_E1_GEN_PWR_CIVIL_BLDG_INT = (decimal)reader["PRV_E1_GEN_PWR_CIVIL_BLDG_INT"],
        PRV_E1_GEN_PWR_CIVIL_BLDG_CONSP = (decimal)reader["PRV_E1_GEN_PWR_CIVIL_BLDG_CONSP"],
        PRV_E1_GEN_PWR_WS_FENCELIGHT_INT = (decimal)reader["PRV_E1_GEN_PWR_WS_FENCELIGHT_INT"],
        PRV_E1_GEN_PWR_WS_FENCELIGHT_CONSP = (decimal)reader["PRV_E1_GEN_PWR_WS_FENCELIGHT_CONSP"],
        PRV_E1_PUR_PWR_UPHS1_INT = (decimal)reader["PRV_E1_PUR_PWR_UPHS1_INT"],
        PRV_E1_PUR_PWR_UPHS1_CONSP = (decimal)reader["PRV_E1_PUR_PWR_UPHS1_CONSP"],
        PRV_E1_PUR_PWR_RW_INT = (decimal)reader["PRV_E1_PUR_PWR_RW_INT"],
        PRV_E1_PUR_PWR_RW_CONSP = (decimal)reader["PRV_E1_PUR_PWR_RW_CONSP"],
        PRV_E1_PUR_PWR_UPHS2_INT = (decimal)reader["PRV_E1_PUR_PWR_UPHS2_INT"],
        PRV_E1_PUR_PWR_UPHS2_CONSP = (decimal)reader["PRV_E1_PUR_PWR_UPHS2_CONSP"],
        PRV_E1_PUR_PWR_3MVA_INT = (decimal)reader["PRV_E1_PUR_PWR_3MVA_INT"],
        PRV_E1_PUR_PWR_3MVA_CONSP = (decimal)reader["PRV_E1_PUR_PWR_3MVA_CONSP"],
        PRV_E1_PUR_PWR_OTHER_INT = (decimal)reader["PRV_E1_PUR_PWR_OTHER_INT"],
        PRV_E1_PUR_PWR_OTHER_CONSP = (decimal)reader["PRV_E1_PUR_PWR_OTHER_CONSP"],
        PRV_E1_PUR_PWR_WPT_CONSP = (decimal)reader["PRV_E1_PUR_PWR_WPT_CONSP"],
        PRV_E1_PUR_PWR_DMP_CONSP = (decimal)reader["PRV_E1_PUR_PWR_DMP_CONSP"],
        PRV_E1_PUR_PWR_ETP_CONSP = (decimal)reader["PRV_E1_PUR_PWR_ETP_CONSP"],
        PRV_E1_PUR_PWR_ACT_CONSP = (decimal)reader["PRV_E1_PUR_PWR_ACT_CONSP"],
        PRV_E1_PUR_PWR_UCT_CONSP = (decimal)reader["PRV_E1_PUR_PWR_UCT_CONSP"],
        PRV_E1_PUR_PWR_IAC_CONSP = (decimal)reader["PRV_E1_PUR_PWR_IAC_CONSP"],
        PRV_E1_3MVA_COND_ID = (decimal)reader["PRV_E1_3MVA_COND_ID"],
        PRV_E1_3MVA_SUB_COND_ID = (decimal)reader["PRV_E1_3MVA_SUB_COND_ID"],
        PRV_E1_PUR_PWR_RATE = (decimal)reader["PRV_E1_PUR_PWR_RATE"],
        PRV_E1_PUR_PWR_NAPSTRG_INT = (decimal)reader["PRV_E1_PUR_PWR_NAPSTRG_INT"],
        PRV_E1_PUR_PWR_NAPSTRG_CONSP = (decimal)reader["PRV_E1_PUR_PWR_NAPSTRG_CONSP"],
        PRV_E1_PWR_CONSP_E_LOAD = (decimal)reader["PRV_E1_PWR_CONSP_E_LOAD"],
        PRV_E1_PWR_CONSP_NE_LOAD = (decimal)reader["PRV_E1_PWR_CONSP_NE_LOAD"],
        PRV_E1_CIVIL_BLDG_CONSP_RATE = (decimal)reader["PRV_E1_CIVIL_BLDG_CONSP_RATE"],
        PRV_E1_HOUSE_COL_CONSP_RATE = (decimal)reader["PRV_E1_HOUSE_COL_CONSP_RATE"],
        PRV_E1_KSR_CONSP_RATE = (decimal)reader["PRV_E1_KSR_CONSP_RATE"],
        PRV_E1_WS_FENCELIGHT_CONSP_RATE = (decimal)reader["PRV_E1_WS_FENCELIGHT_CONSP_RATE"],
        PRV_E1_PUR_PWR_UPHS1_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_UPHS1_CONSP_RATE"],
        PRV_E1_PUR_PWR_RW_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_RW_CONSP_RATE"],
        PRV_E1_PUR_PWR_3MVA_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_3MVA_CONSP_RATE"],
        PRV_E1_PUR_PWR_OTHER_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_OTHER_CONSP_RATE"],
        PRV_E1_PUR_PWR_CONSP_COND = reader["PRV_E1_PUR_PWR_CONSP_COND"].ToString(),
        PRV_E1_PUR_PWR_IND_LOAD = (decimal)reader["PRV_E1_PUR_PWR_IND_LOAD"],
        PRV_E1_PUR_PWR_HOUSE_LOAD = (decimal)reader["PRV_E1_PUR_PWR_HOUSE_LOAD"],
        PRV_E1_PUR_PWR_HOUSE_RDG_CORR = (decimal)reader["PRV_E1_PUR_PWR_HOUSE_RDG_CORR"],
        PRV_E1_PUR_PWR_MAX_DEMAND = (decimal)reader["PRV_E1_PUR_PWR_MAX_DEMAND"],
        PRV_E1_PUR_PWR_UPSH2_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_UPSH2_CONSP_RATE"],
        PRV_E1_PUR_PWR_NAPSTRG_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_NAPSTRG_CONSP_RATE"],
        PRV_E1_PUR_PWR_AVL_BAL_LOAD = (decimal)reader["PRV_E1_PUR_PWR_AVL_BAL_LOAD"],
        PRV_E1_REVAMP_CONSP_UNIT1 = (decimal)reader["PRV_E1_REVAMP_CONSP_UNIT1"],
        PRV_E1_PUR_PWR_SSP_INT = (decimal)reader["PRV_E1_PUR_PWR_SSP_INT"],
        PRV_E1_PUR_PWR_CONSP_SSP = (decimal)reader["PRV_E1_PUR_PWR_CONSP_SSP"],
        PRV_E1_PUR_PWR_SSP_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_SSP_CONSP_RATE"],
        PRV_E1_IEX_PURCHASED = (decimal)reader["PRV_E1_IEX_PURCHASED"],
        PRV_E1_PUR_POWER_TOTAL = (decimal)reader["PRV_E1_PUR_POWER_TOTAL"],
        PRV_E1_PUR_PWR_GP3_CONSP = (decimal)reader["PRV_E1_PUR_PWR_GP3_CONSP"],
        PRV_E1_PUR_PWR_GP3_CONSP_RATE = (decimal)reader["PRV_E1_PUR_PWR_GP3_CONSP_RATE"],
        PRV_E1_RECEIPT_UPH2_GP3 = (decimal)reader["PRV_E1_RECEIPT_UPH2_GP3"],
        PRV_E1_PUR_PWR_GP3_INT = (decimal)reader["PRV_E1_PUR_PWR_GP3_INT"],
        PRV_E1_GT2_EXPORT_GP3_ID = (decimal)reader["PRV_E1_GT2_EXPORT_GP3_ID"],
        PRV_E1_RECEIPT_UPH12_TOTAL = (decimal)reader["PRV_E1_RECEIPT_UPH12_TOTAL"],
        PRV_E1_GT1_EXPORT_GP3_ID = (decimal)reader["PRV_E1_GT1_EXPORT_GP3_ID"],
        PRV_E1_RECEIPT_UPH1_GP3 = (decimal)reader["PRV_E1_RECEIPT_UPH1_GP3"],
        PRV_E1_GT1_EXPORT_GP3 = (decimal)reader["PRV_E1_GT1_EXPORT_GP3"],
        PRV_E1_GT2_EXPORT_GP3 = (decimal)reader["PRV_E1_GT2_EXPORT_GP3"],
        PRV_TXT_TOT_OFFSITE_CONSP = (decimal)reader["PRV_TXT_TOT_OFFSITE_CONSP"]
      };
    }

    private PES002Dto MapToValueDV(SqlDataReader reader)
    {
      return new PES002Dto()
      {
        E1_RECEIPT_UPH1_GP3_DV = (decimal)reader["E1_RECEIPT_UPH1_GP3_DV"],
        E1_RECEIPT_UPH2_GP3_DV = (decimal)reader["E1_RECEIPT_UPH2_GP3_DV"],
        E1_CIVIL_BLDG_CONSP_RATE_DV = (decimal)reader["E1_CIVIL_BLDG_CONSP_RATE_DV"],
        E1_HOUSE_COL_CONSP_RATE_DV = (decimal)reader["E1_HOUSE_COL_CONSP_RATE_DV"],
        E1_KSR_CONSP_RATE_DV = (decimal)reader["E1_KSR_CONSP_RATE_DV"],
        E1_WS_FENCELIGHT_CONSP_RATE_DV = (decimal)reader["E1_WS_FENCELIGHT_CONSP_RATE_DV"],
        E1_PUR_PWR_RW_CONSP_RATE_DV = (decimal)reader["E1_PUR_PWR_RW_CONSP_RATE_DV"],
        E1_PUR_PWR_NAPSTRG_CONSP_RATE_DV = (decimal)reader["E1_PUR_PWR_NAPSTRG_CONSP_RATE_DV"],
        E1_PUR_PWR_3MVA_CONSP_RATE_DV = (decimal)reader["E1_PUR_PWR_3MVA_CONSP_RATE_DV"],
        E1_PUR_PWR_SSP_CONSP_RATE_DV = (decimal)reader["E1_PUR_PWR_SSP_CONSP_RATE_DV"],
        E1_PUR_PWR_OTHER_CONSP_RATE_DV = (decimal)reader["E1_PUR_PWR_OTHER_CONSP_RATE_DV"],
        E1_PUR_PWR_GP3_CONSP_RATE_DV = (decimal)reader["E1_PUR_PWR_GP3_CONSP_RATE_DV"],
        G_MF_NAPHTHA_STRG_INT_DV = (decimal)reader["G_MF_NAPHTHA_STRG_INT_DV"],
        G_MF_HOLDING_POND_INT1_DV = (decimal)reader["G_MF_HOLDING_POND_INT1_DV"],
        G_MF_HOLDING_POND_INT2_DV = (decimal)reader["G_MF_HOLDING_POND_INT2_DV"],
        E1_PUR_POWER_TOTAL_DV = (decimal)reader["E1_PUR_POWER_TOTAL_DV"],
        E1_HOUSE_COL_CONSP_DV = (decimal)reader["E1_HOUSE_COL_CONSP_DV"],
        ln_bal_days = (decimal)reader["ln_bal_days"]
      };
    }

    private PES002Dto MapToValueDV2(SqlDataReader reader)
    {
      return new PES002Dto()
      {
        E1_AB_PERCENT_DV = (decimal)reader["E1_AB_PERCENT_DV"],
        E1_CPP_PERCENT_DV = (decimal)reader["E1_CPP_PERCENT_DV"],
        E1_UCT_PERCENT_DV = (decimal)reader["E1_UCT_PERCENT_DV"],
        E1_WPT_PERCENT_DV = (decimal)reader["E1_WPT_PERCENT_DV"],
        E1_ACT_PERCENT_DV = (decimal)reader["E1_ACT_PERCENT_DV"],
        E1_IAC_PERCENT_DV = (decimal)reader["E1_IAC_PERCENT_DV"],
        E1_DM_PERCENT_DV = (decimal)reader["E1_DM_PERCENT_DV"],
        E1_ETP_PERCENT_DV = (decimal)reader["E1_ETP_PERCENT_DV"]
      };
    }

    public async Task<List<PES002Model>> getData(string IN_DATE)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPT_EL_ELECTRICAL_DETAILS", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
          var response = new List<PES002Model>();
          await sql.OpenAsync();
          using (var reader = await cmd.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              response.Add(MapToValue(reader));
            }
          }
          return response;
        }
      }
    }

    public async Task<PES002Model> putData(string IN_DATE)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPT_EL_ELECTRICAL_DETAILS", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
          PES002Model response = null;
          await sql.OpenAsync();
          using (var reader = await cmd.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              response = MapToValue(reader);
            }
          }
          return response;
        }
      }
    }

    public async Task<PES002Dto> putDataDV(string IN_DATE)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPT_EL_ELECTRICAL_DETAILS_DV", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
          PES002Dto response = null;
          await sql.OpenAsync();
          using (var reader = await cmd.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              response = MapToValueDV(reader);
            }
          }
          return response;
        }
      }
    }

    public async Task<PES002Dto> putDataDV2(decimal IN_SUB_COND_ID, string IN_TAB)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPT_EL_ELECTRICAL_DETAILS_DV2", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_SUB_COND_ID", IN_SUB_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_TAB", IN_TAB));
          PES002Dto response = null;
          await sql.OpenAsync();
          using (var reader = await cmd.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              response = MapToValueDV2(reader);
            }
          }
          return response;
        }
      }
    }

    public async Task saveData(PES002Model value)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_SAVE_PPT_EL_ELECTRICAL_DETAILS", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;

          cmd.Parameters.Add(new SqlParameter("@IN_E1_TRANS_DATE", value.E1_TRANS_DATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_USER_ID", value.E1_USER_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_FREEZE_FLG", value.E1_FREEZE_FLG));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT1_INT", value.E1_GT1_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT1_PROD", value.E1_GT1_PROD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT2_INT", value.E1_GT2_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT2_PROD", value.E1_GT2_PROD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT1_EXPORT_GP3_ID", value.E1_GT1_EXPORT_GP3_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT1_EXPORT_GP3", value.E1_GT1_EXPORT_GP3));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT2_EXPORT_GP3_ID", value.E1_GT2_EXPORT_GP3_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GT2_EXPORT_GP3", value.E1_GT2_EXPORT_GP3));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_TOT_GT_GEN", value.E1_TOT_GT_GEN));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RSEB_INT", value.E1_RSEB_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_POWER_TOTAL ", value.E1_PUR_POWER_TOTAL));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_IEX_PURCHASED ", value.E1_IEX_PURCHASED));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RSEB_PURCHASED ", value.E1_RSEB_PURCHASED));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_REMARKS", value.E1_REMARKS));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_AMM_INT ", value.E1_AMM_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_AMM_CONSP ", value.E1_AMM_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_U11_INT ", value.E1_U11_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_U11_CONSP ", value.E1_U11_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_U21_INT ", value.E1_U21_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_U21_CONSP ", value.E1_U21_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_AMM_STORAGE_INT ", value.E1_AMM_STORAGE_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_AMM_STORAGE_CONSP ", value.E1_AMM_STORAGE_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UPHS_INT ", value.E1_UPHS_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UPHS_CONSP ", value.E1_UPHS_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RW_INT ", value.E1_RW_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RW_CONSP ", value.E1_RW_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_SPG_INT ", value.E1_SPG_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_SPG_CONSP ", value.E1_SPG_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_15MVA_INT ", value.E1_OFFSITE_15MVA_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_15MVA_CONSP ", value.E1_OFFSITE_15MVA_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_3MVA_INT ", value.E1_OFFSITE_3MVA_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_3MVA_CONSP ", value.E1_OFFSITE_3MVA_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UNIT2_FDR1_INT ", value.E1_UNIT2_FDR1_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UNIT2_FDR1_CONSP ", value.E1_UNIT2_FDR1_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UNIT2_FDR2_INT ", value.E1_UNIT2_FDR2_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UNIT2_FDR2_CONSP ", value.E1_UNIT2_FDR2_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GEN_PWR_KSR_INT ", value.E1_GEN_PWR_KSR_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GEN_PWR_KSR_CONSP ", value.E1_GEN_PWR_KSR_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UNIT2_BAGG_INT ", value.E1_UNIT2_BAGG_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UNIT2_BAGG_CONSP ", value.E1_UNIT2_BAGG_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GEN_PWR_CIVIL_BLDG_INT ", value.E1_GEN_PWR_CIVIL_BLDG_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GEN_PWR_CIVIL_BLDG_CONSP ", value.E1_GEN_PWR_CIVIL_BLDG_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GEN_PWR_WS_FENCELIGHT_INT ", value.E1_GEN_PWR_WS_FENCELIGHT_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_GEN_PWR_WS_FENCELIGHT_CONSP ", value.E1_GEN_PWR_WS_FENCELIGHT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_REVAMP_CONSP_UNIT1 ", value.E1_REVAMP_CONSP_UNIT1));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_NAP_STORAGE_INT ", value.E1_NAP_STORAGE_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_NAP_STORAGE_CONSP ", value.E1_NAP_STORAGE_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOLDING_POND_INT ", value.E1_HOLDING_POND_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOLDING_POND_CONSP ", value.E1_HOLDING_POND_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOLDING_POND_INT2 ", value.E1_HOLDING_POND_INT2));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOLDING_POND_CONSP2 ", value.E1_HOLDING_POND_CONSP2));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_TOT_EBUS_CONSP ", value.E1_TOT_EBUS_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_TFR_TO_NEBUS ", value.E1_TFR_TO_NEBUS));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PWR_CONSP_E_LOAD ", value.E1_PWR_CONSP_E_LOAD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_CONSP ", value.E1_OFFSITE_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RECEIPT_UPH1_GP3 ", value.E1_RECEIPT_UPH1_GP3));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RECEIPT_UPH2_GP3 ", value.E1_RECEIPT_UPH2_GP3));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_RECEIPT_UPH12_TOTAL ", value.E1_RECEIPT_UPH12_TOTAL));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_CIVIL_BLDG_INT ", value.E1_CIVIL_BLDG_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_CIVIL_BLDG_CONSP ", value.E1_CIVIL_BLDG_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_CIVIL_BLDG_CONSP_RATE ", value.E1_CIVIL_BLDG_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOUSE_COL_INT ", value.E1_HOUSE_COL_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOUSE_COL_CONSP ", value.E1_HOUSE_COL_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_HOUSE_COL_CONSP_RATE ", value.E1_HOUSE_COL_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_KSR_INT ", value.E1_KSR_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_KSR_CONSP ", value.E1_KSR_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_KSR_CONSP_RATE ", value.E1_KSR_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_WS_FENCELIGHT_INT ", value.E1_WS_FENCELIGHT_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_WS_FENCELIGHT_CONSP ", value.E1_WS_FENCELIGHT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_WS_FENCELIGHT_CONSP_RATE ", value.E1_WS_FENCELIGHT_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_RW_INT ", value.E1_PUR_PWR_RW_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_RW_CONSP ", value.E1_PUR_PWR_RW_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_RW_CONSP_RATE ", value.E1_PUR_PWR_RW_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_NAPSTRG_INT ", value.E1_PUR_PWR_NAPSTRG_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_NAPSTRG_CONSP ", value.E1_PUR_PWR_NAPSTRG_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_NAPSTRG_CONSP_RATE ", value.E1_PUR_PWR_NAPSTRG_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_3MVA_INT ", value.E1_PUR_PWR_3MVA_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_3MVA_CONSP ", value.E1_PUR_PWR_3MVA_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_3MVA_CONSP_RATE ", value.E1_PUR_PWR_3MVA_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_SSP_INT ", value.E1_PUR_PWR_SSP_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_CONSP_SSP ", value.E1_PUR_PWR_CONSP_SSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_SSP_CONSP_RATE ", value.E1_PUR_PWR_SSP_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_OTHER_INT ", value.E1_PUR_PWR_OTHER_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_OTHER_CONSP ", value.E1_PUR_PWR_OTHER_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_OTHER_CONSP_RATE ", value.E1_PUR_PWR_OTHER_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_GP3_INT ", value.E1_PUR_PWR_GP3_INT));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_GP3_CONSP ", value.E1_PUR_PWR_GP3_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_GP3_CONSP_RATE ", value.E1_PUR_PWR_GP3_CONSP_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_TOT_NEBUS_CONSP ", value.E1_TOT_NEBUS_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_TFR_TO_EBUS ", value.E1_TFR_TO_EBUS));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PWR_CONSP_NE_LOAD ", value.E1_PWR_CONSP_NE_LOAD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_RATE ", value.E1_PUR_PWR_RATE));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_LOSS_GEN ", value.E1_LOSS_GEN));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_LOSS_RSEB ", value.E1_LOSS_RSEB));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_IND_LOAD ", value.E1_PUR_PWR_IND_LOAD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_HOUSE_LOAD ", value.E1_PUR_PWR_HOUSE_LOAD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_CONSP_COND ", value.E1_PUR_PWR_CONSP_COND));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_AVL_BAL_LOAD ", value.E1_PUR_PWR_AVL_BAL_LOAD));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_MAX_DEMAND ", value.E1_PUR_PWR_MAX_DEMAND));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_HOUSE_RDG_CORR ", value.E1_PUR_PWR_HOUSE_RDG_CORR));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_AB_CONSP ", value.E1_AB_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_CPP_CONSP ", value.E1_CPP_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_IAC_SPG_CONSP ", value.E1_IAC_SPG_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_UCT_CONSP ", value.E1_UCT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_WPT_CONSP ", value.E1_WPT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_ACT_CONSP ", value.E1_ACT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_IAC_OFFSITE_CONSP ", value.E1_IAC_OFFSITE_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_DMP_CONSP ", value.E1_DMP_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_ETP_CONSP ", value.E1_ETP_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_FIRE_CONSP ", value.E1_FIRE_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_WPT_CONSP ", value.E1_PUR_PWR_WPT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_DMP_CONSP ", value.E1_PUR_PWR_DMP_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_ETP_CONSP ", value.E1_PUR_PWR_ETP_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_ACT_CONSP ", value.E1_PUR_PWR_ACT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_UCT_CONSP ", value.E1_PUR_PWR_UCT_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_PUR_PWR_IAC_CONSP ", value.E1_PUR_PWR_IAC_CONSP));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_SPG_COND_ID ", value.E1_SPG_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_SPG_SUB_COND_ID ", value.E1_SPG_SUB_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_COND_ID ", value.E1_OFFSITE_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_OFFSITE_SUB_COND_ID ", value.E1_OFFSITE_SUB_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_3MVA_COND_ID ", value.E1_3MVA_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E1_3MVA_SUB_COND_ID ", value.E1_3MVA_SUB_COND_ID));
          await sql.OpenAsync();
          await cmd.ExecuteNonQueryAsync();
          return;
        }
      }
    }
  }
}
