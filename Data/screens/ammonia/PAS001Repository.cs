using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS001Repository
    {
        private readonly string _connectionString;
        public PAS001Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS001Model MapToValue(SqlDataReader reader)
        {
            return new PAS001Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A1_TRANS_DATE = reader["A1_TRANS_DATE"].ToString(),
                A1_PRS_NG_FEED_REFMR_INT = (dynamic)reader["A1_PRS_NG_FEED_REFMR_INT"],
                A1_PRS_NG_FEED_REFMR_INT_DIFF = (dynamic)reader["A1_PRS_NG_FEED_REFMR_INT_DIFF"],
                A1_TEMP_NG_FEED_REFMR_INT = (dynamic)reader["A1_TEMP_NG_FEED_REFMR_INT"],
                A1_TEMP_NG_FEED_REFMR_INT_DIFF = (dynamic)reader["A1_TEMP_NG_FEED_REFMR_INT_DIFF"],
                A1_NG_FEED_REFMR_INT = (dynamic)reader["A1_NG_FEED_REFMR_INT"],
                A1_NG_FEED_REFMR_INT_DIFF = (dynamic)reader["A1_NG_FEED_REFMR_INT_DIFF"],
                A1_MEAS_NG_CONSP_FEED_REFMR = (dynamic)reader["A1_MEAS_NG_CONSP_FEED_REFMR"],
                A1_NG_CONSP_KRES_FEED_INT = (dynamic)reader["A1_NG_CONSP_KRES_FEED_INT"],
                A1_NG_CONSP_KRES_FEED_INT_DIFF = (dynamic)reader["A1_NG_CONSP_KRES_FEED_INT_DIFF"],
                A1_NG_CONSP_KRES_FEED = (dynamic)reader["A1_NG_CONSP_KRES_FEED"],
                A1_PRS_NG_FUEL_REFMR_INT = (dynamic)reader["A1_PRS_NG_FUEL_REFMR_INT"],
                A1_PRS_NG_FUEL_REFMR_INT_DIFF = (dynamic)reader["A1_PRS_NG_FUEL_REFMR_INT_DIFF"],
                A1_TEMP_NG_FUEL_REFMR_INT = (dynamic)reader["A1_TEMP_NG_FUEL_REFMR_INT"],
                A1_TEMP_NG_FUEL_REFMR_INT_DIFF = (dynamic)reader["A1_TEMP_NG_FUEL_REFMR_INT_DIFF"],
                A1_NG_FUEL_REFMR_INT = (dynamic)reader["A1_NG_FUEL_REFMR_INT"],
                A1_NG_FUEL_REFMR_INT_DIFF = (dynamic)reader["A1_NG_FUEL_REFMR_INT_DIFF"],
                A1_NG_CONSP_FUEL_REFMR = (dynamic)reader["A1_NG_CONSP_FUEL_REFMR"],
                A1_PRS_NG_FUEL_HEATER_INT = (dynamic)reader["A1_PRS_NG_FUEL_HEATER_INT"],
                A1_PRS_NG_FUEL_HEATER_INT_DIFF = (dynamic)reader["A1_PRS_NG_FUEL_HEATER_INT_DIFF"],
                A1_NG_FUEL_HEATER_INT = (dynamic)reader["A1_NG_FUEL_HEATER_INT"],
                A1_NG_FUEL_HEATER_INT_DIFF = (dynamic)reader["A1_NG_FUEL_HEATER_INT_DIFF"],
                A1_NG_CONSP_FUEL_HEATER = (dynamic)reader["A1_NG_CONSP_FUEL_HEATER"],
                A1_NG_FUEL_ABURNER_INT = (dynamic)reader["A1_NG_FUEL_ABURNER_INT"],
                A1_NG_FUEL_ABURNER_INT_DIF = (dynamic)reader["A1_NG_FUEL_ABURNER_INT_DIF"],
                A1_NG_FUEL_ABURNER = (dynamic)reader["A1_NG_FUEL_ABURNER"],
                A1_SPOT_GAS_ENG_ALLOC = (dynamic)reader["A1_SPOT_GAS_ENG_ALLOC"],
                A1_SPOT_GAS_ALLOC = (dynamic)reader["A1_SPOT_GAS_ALLOC"],
                A1_SPOT_GAS_RECEIPT = (dynamic)reader["A1_SPOT_GAS_RECEIPT"],
                A1_NG_ALLOCATION = (dynamic)reader["A1_NG_ALLOCATION"],
                A1_APM_NG_RECEIPT = (dynamic)reader["A1_APM_NG_RECEIPT"],
                A1_NON_APM_ALLOC = (dynamic)reader["A1_NON_APM_ALLOC"],
                A1_NON_APM_RECPT = (dynamic)reader["A1_NON_APM_RECPT"],
                A1_RLNG_ENG_ALLOC = (dynamic)reader["A1_RLNG_ENG_ALLOC"],
                A1_RLNG_ALLOCATION = (dynamic)reader["A1_RLNG_ALLOCATION"],
                A1_GAIL_RLNG_RECEIPT = (dynamic)reader["A1_GAIL_RLNG_RECEIPT"],
                A1_GAIL_LT_RLNG_FIRM_MMBTU = (dynamic)reader["A1_GAIL_LT_RLNG_FIRM_MMBTU"],
                A1_GAIL_LT_RLNG_FIRM_ALLOC = (dynamic)reader["A1_GAIL_LT_RLNG_FIRM_ALLOC"],
                A1_GAIL_LT_RLNG_FIRM_RECEIPT = (dynamic)reader["A1_GAIL_LT_RLNG_FIRM_RECEIPT"],
                A1_GAIL_LT_RLNG_RE_MMBTU = (dynamic)reader["A1_GAIL_LT_RLNG_RE_MMBTU"],
                A1_GAIL_LT_RLNG_RE_ALLOC = (dynamic)reader["A1_GAIL_LT_RLNG_RE_ALLOC"],
                A1_GAIL_LT_RLNG_RE_RECEIPT = (dynamic)reader["A1_GAIL_LT_RLNG_RE_RECEIPT"],
                A1_PMT_NG_ENG_ALLOC = (dynamic)reader["A1_PMT_NG_ENG_ALLOC"],
                A1_PMT_NG_ALLOC = (dynamic)reader["A1_PMT_NG_ALLOC"],
                A1_PMT_NG_RECEIPT = (dynamic)reader["A1_PMT_NG_RECEIPT"],
                A1_RLNG_SPOT_ENG_ALLOC = (dynamic)reader["A1_RLNG_SPOT_ENG_ALLOC"],
                A1_RLNG_SPOT_ALLOC = (dynamic)reader["A1_RLNG_SPOT_ALLOC"],
                A1_RLNG_SPOT_RECPT = (dynamic)reader["A1_RLNG_SPOT_RECPT"],
                A1_FALLBACK_GAS_ALLOC = (dynamic)reader["A1_FALLBACK_GAS_ALLOC"],
                A1_NG_IMPORTF_UNIT2 = (dynamic)reader["A1_NG_IMPORTF_UNIT2"],
                A1_NG_CONSP_UNIT2 = (dynamic)reader["A1_NG_CONSP_UNIT2"],
                A1_AMM_CFG3_SPOT_GAS_ALLOC_ENG = (dynamic)reader["A1_AMM_CFG3_SPOT_GAS_ALLOC_ENG"],
                A1_AMM_CFG3_SPOT_GAS_ALLOC_SM3 = (dynamic)reader["A1_AMM_CFG3_SPOT_GAS_ALLOC_SM3"],
                A1_AMM_CFG3_SPOT_GAS_RECEIPT = (dynamic)reader["A1_AMM_CFG3_SPOT_GAS_RECEIPT"],
                A1_NG_CONSP_AMM = (dynamic)reader["A1_NG_CONSP_AMM"],
                A1_BAL_NG_CONSP_FEED_REFMR = (dynamic)reader["A1_BAL_NG_CONSP_FEED_REFMR"],
                A1_NG_RECPT = (dynamic)reader["A1_NG_RECPT"],
                A1_NG_LIMITATION_FLG = reader["A1_NG_LIMITATION_FLG"].ToString(),
                A1_ACTL_NG_CV_NET = (dynamic)reader["A1_ACTL_NG_CV_NET"],
                A1_RLNG_GCV = (dynamic)reader["A1_RLNG_GCV"],
                A1_MOL_WT_NG = (dynamic)reader["A1_MOL_WT_NG"],
                A1_NG_CARBON_NO = (dynamic)reader["A1_NG_CARBON_NO"],
                A1_GAIL_METER_ONLINE = reader["A1_GAIL_METER_ONLINE"].ToString(),
                A1_PRS_SURPLUS_GAS_INT = (dynamic)reader["A1_PRS_SURPLUS_GAS_INT"],
                A1_PRS_SURPLUS_GAS_INT_DIFF = (dynamic)reader["A1_PRS_SURPLUS_GAS_INT_DIFF"],
                A1_TEMP_SURPLUS_GAS_INT = (dynamic)reader["A1_TEMP_SURPLUS_GAS_INT"],
                A1_TEMP_SURPLUS_GAS_INT_DIFF = (dynamic)reader["A1_TEMP_SURPLUS_GAS_INT_DIFF"],
                A1_SURPLUS_GAS_INT = (dynamic)reader["A1_SURPLUS_GAS_INT"],
                A1_SURPLUS_GAS_INT_DIFF = (dynamic)reader["A1_SURPLUS_GAS_INT_DIFF"],
                A1_SURPLUS_GAS_PROD = (dynamic)reader["A1_SURPLUS_GAS_PROD"],
                A1_PRS_CO2_INT = (dynamic)reader["A1_PRS_CO2_INT"],
                A1_PRS_CO2_INT_DIFF = (dynamic)reader["A1_PRS_CO2_INT_DIFF"],
                A1_TEMP_CO2_INT = (dynamic)reader["A1_TEMP_CO2_INT"],
                A1_TEMP_CO2_INT_DIFF = (dynamic)reader["A1_TEMP_CO2_INT_DIFF"],
                A1_CO2_INT = (dynamic)reader["A1_CO2_INT"],
                A1_CO2_INT_DIFF = (dynamic)reader["A1_CO2_INT_DIFF"],
                A1_CO2_PROD = (dynamic)reader["A1_CO2_PROD"],
                A1_PRS_PERMEATE_INT = (dynamic)reader["A1_PRS_PERMEATE_INT"],
                A1_PRS_PERMEATE_INT_DIFF = (dynamic)reader["A1_PRS_PERMEATE_INT_DIFF"],
                A1_TEMP_PERMEATE_INT = (dynamic)reader["A1_TEMP_PERMEATE_INT"],
                A1_TEMP_PERMEATE_INT_DIFF = (dynamic)reader["A1_TEMP_PERMEATE_INT_DIFF"],
                A1_PERMEATE_INT = (dynamic)reader["A1_PERMEATE_INT"],
                A1_PERMEATE_INT_DIFF = (dynamic)reader["A1_PERMEATE_INT_DIFF"],
                A1_PERMEATE_FLOW = (dynamic)reader["A1_PERMEATE_FLOW"],
                A1_AMM_TANK_A_LEVEL = (dynamic)reader["A1_AMM_TANK_A_LEVEL"],
                A1_AMM_TANK_A_STOCK = (dynamic)reader["A1_AMM_TANK_A_STOCK"],
                A1_AMM_TANK_B_LEVEL = (dynamic)reader["A1_AMM_TANK_B_LEVEL"],
                A1_AMM_TANK_B_STOCK = (dynamic)reader["A1_AMM_TANK_B_STOCK"],
                A1_PROD_HRS = (dynamic)reader["A1_PROD_HRS"],
                A1_PGRU_RUN_HRS = (dynamic)reader["A1_PGRU_RUN_HRS"],
                A1_HOT_AMM_TO_UREA_INT = (dynamic)reader["A1_HOT_AMM_TO_UREA_INT"],
                A1_AMM_SUPP_UREA = (dynamic)reader["A1_AMM_SUPP_UREA"],
                A1_AMM_STORAGE_TO_UREA = (dynamic)reader["A1_AMM_STORAGE_TO_UREA"],
                A1_AMM_TRFR_UREA_SHIFT_A = (dynamic)reader["A1_AMM_TRFR_UREA_SHIFT_A"],
                A1_AMM_TRFR_UREA_SHIFT_B = (dynamic)reader["A1_AMM_TRFR_UREA_SHIFT_B"],
                A1_AMM_VAPOUR_EXPORTT_UNIT2 = (dynamic)reader["A1_AMM_VAPOUR_EXPORTT_UNIT2"],
                A1_AMM_SALE = (dynamic)reader["A1_AMM_SALE"],
                A1_AMM_PROD = (dynamic)reader["A1_AMM_PROD"],
                A1_RECVFROM_AMM2_STOCK = (dynamic)reader["A1_RECVFROM_AMM2_STOCK"],
                A1_TFRTO_AMM2_STOCK = (dynamic)reader["A1_TFRTO_AMM2_STOCK"],
                A1_RECVFROM_AMM3_STOCK = (dynamic)reader["A1_RECVFROM_AMM3_STOCK"],
                A1_AMM2_LOGICAL_STOCK = (dynamic)reader["A1_AMM2_LOGICAL_STOCK"],
                A1_TFRTO_AMM3_STOCK = (dynamic)reader["A1_TFRTO_AMM3_STOCK"],
                A1_AMM3_LOGICAL_STOCK = (dynamic)reader["A1_AMM3_LOGICAL_STOCK"],
                A1_AMM1_LOGICAL_STOCK = (dynamic)reader["A1_AMM1_LOGICAL_STOCK"],
                A1_AMM_CAP_UTIL = (dynamic)reader["A1_AMM_CAP_UTIL"],
                A1_REMARKS_D = reader["A1_REMARKS_D"].ToString(),
                A1_REMARKS_M = reader["A1_REMARKS_M"].ToString(),
                A1_NAP_AMM_REFMR_INT = (dynamic)reader["A1_NAP_AMM_REFMR_INT"],
                A1_NAP_CONSP_AMM_REFMR = (dynamic)reader["A1_NAP_CONSP_AMM_REFMR"],
                A1_NAP_AMM_HEATER_INT = (dynamic)reader["A1_NAP_AMM_HEATER_INT"],
                A1_NAP_CONSP_AMM_HEATER = (dynamic)reader["A1_NAP_CONSP_AMM_HEATER"],
                A1_NAP_CONSP_AMM = (dynamic)reader["A1_NAP_CONSP_AMM"],
                A1_ATC_PROD_INT1 = (dynamic)reader["A1_ATC_PROD_INT1"],
                A1_ATC_PROD_INT1_DIFF = (dynamic)reader["A1_ATC_PROD_INT1_DIFF"],
                A1_ATC_PROD_INT2 = (dynamic)reader["A1_ATC_PROD_INT2"],
                A1_ATC_PROD_INT2_DIFF = (dynamic)reader["A1_ATC_PROD_INT2_DIFF"],
                A1_ATC_PROD_INT3 = (dynamic)reader["A1_ATC_PROD_INT3"],
                A1_ATC_PROD_INT3_DIFF = (dynamic)reader["A1_ATC_PROD_INT3_DIFF"],
                A1_ATC_PROD_INT4 = (dynamic)reader["A1_ATC_PROD_INT4"],
                A1_ATC_PROD_INT4_DIFF = (dynamic)reader["A1_ATC_PROD_INT4_DIFF"],
                A1_ATC_PROD = (dynamic)reader["A1_ATC_PROD"],
                A1_PROCESS_STEAM_INT = (dynamic)reader["A1_PROCESS_STEAM_INT"],
                A1_PROCESS_STEAMM_CONSP = (dynamic)reader["A1_PROCESS_STEAMM_CONSP"],
                A1_PROCESS_STEAM_KRES_INT = (dynamic)reader["A1_PROCESS_STEAM_KRES_INT"],
                A1_PROCESS_STEAM_CONSP_KRES = (dynamic)reader["A1_PROCESS_STEAM_CONSP_KRES"],
                A1_LS_CONSP_AMM_INT = (dynamic)reader["A1_LS_CONSP_AMM_INT"],
                A1_LS_CONSP_AMM = (dynamic)reader["A1_LS_CONSP_AMM"],
                A1_AMM_SP_CONSP_FEED = (dynamic)reader["A1_AMM_SP_CONSP_FEED"],
                A1_AMM_SP_CONSP_EQ_FUEL = (dynamic)reader["A1_AMM_SP_CONSP_EQ_FUEL"],
                A1_AMM_SP_CONSP_TOTAL_GAS = (dynamic)reader["A1_AMM_SP_CONSP_TOTAL_GAS"],
                A1_AMM_SP_CONSP_KS = (dynamic)reader["A1_AMM_SP_CONSP_KS"],
                A1_AMM_SP_CONSP_HS = (dynamic)reader["A1_AMM_SP_CONSP_HS"],
                A1_AMM_SP_CONSP_LS = (dynamic)reader["A1_AMM_SP_CONSP_LS"],
                A1_AMM_SP_CONSP_CT = (dynamic)reader["A1_AMM_SP_CONSP_CT"],
                A1_AMM_SP_CONSP_DMW_IMPORT = (dynamic)reader["A1_AMM_SP_CONSP_DMW_IMPORT"],
                A1_AMM_SP_CONSP_DMW_EXPORT = (dynamic)reader["A1_AMM_SP_CONSP_DMW_EXPORT"],
                A1_AMM_SP_CONSP_DMW = (dynamic)reader["A1_AMM_SP_CONSP_DMW"],
                A1_AMM_SP_CONSP_TC = (dynamic)reader["A1_AMM_SP_CONSP_TC"],
                A1_AMM_SP_CONSP_PC = (dynamic)reader["A1_AMM_SP_CONSP_PC"],
                A1_AMM_SP_CONSP_CONDENSATE = (dynamic)reader["A1_AMM_SP_CONSP_CONDENSATE"],
                A1_AMM_SP_CONSP_NET_BFW = (dynamic)reader["A1_AMM_SP_CONSP_NET_BFW"],
                A1_UR_SP_CONSP_AMM = (dynamic)reader["A1_UR_SP_CONSP_AMM"],
                A1_UR_SP_CONSP_FEED = (dynamic)reader["A1_UR_SP_CONSP_FEED"],
                A1_UR_SP_CONSP_EQ_FUEL = (dynamic)reader["A1_UR_SP_CONSP_EQ_FUEL"],
                A1_UR_SP_CONSP_TOTAL_FUEL = (dynamic)reader["A1_UR_SP_CONSP_TOTAL_FUEL"],
                A1_UR_SP_CONSP_SPG_GAS = (dynamic)reader["A1_UR_SP_CONSP_SPG_GAS"],
                A1_UR_SP_CONSP_SPG_NAP = (dynamic)reader["A1_UR_SP_CONSP_SPG_NAP"],
                A1_UR_SP_CONSP_EQ_SPG = (dynamic)reader["A1_UR_SP_CONSP_EQ_SPG"],
                A1_UR_SP_CONSP_TOTAL_GAS = (dynamic)reader["A1_UR_SP_CONSP_TOTAL_GAS"],
                A1_SP_CONSP_ELECT_BL = (dynamic)reader["A1_SP_CONSP_ELECT_BL"],
                A1_SP_CONSP_ELECT_CT = (dynamic)reader["A1_SP_CONSP_ELECT_CT"],
                A1_SP_CONSP_ELECT_AMM_STRG = (dynamic)reader["A1_SP_CONSP_ELECT_AMM_STRG"],
                A1_AVG_NG_CV = (dynamic)reader["A1_AVG_NG_CV"],
                A1_SP_ENG_FEED_GAS = (dynamic)reader["A1_SP_ENG_FEED_GAS"],
                A1_SP_ENG_FUEL = (dynamic)reader["A1_SP_ENG_FUEL"],
                A1_SP_ENG_TOTAL = (dynamic)reader["A1_SP_ENG_TOTAL"],
                A1_SP_ENG_DIR_STEAM_BL = (dynamic)reader["A1_SP_ENG_DIR_STEAM_BL"],
                A1_SP_ENG_DIR_ELECT_BL = (dynamic)reader["A1_SP_ENG_DIR_ELECT_BL"],
                A1_SP_ENG_SUB_TOT_UTIL_BL = (dynamic)reader["A1_SP_ENG_SUB_TOT_UTIL_BL"],
                A1_SP_ENG_TOT_BL = (dynamic)reader["A1_SP_ENG_TOT_BL"],
                A1_SP_ENG_CT_STEAM = (dynamic)reader["A1_SP_ENG_CT_STEAM"],
                A1_SP_ENG_CT_ELECT = (dynamic)reader["A1_SP_ENG_CT_ELECT"],
                A1_SP_ENG_SUB_TOT_UTIL = (dynamic)reader["A1_SP_ENG_SUB_TOT_UTIL"],
                A1_SP_ENG_TOT_INCL_CT = (dynamic)reader["A1_SP_ENG_TOT_INCL_CT"],
                A1_SP_ENG_OTH_UTIL_ALLOC = (dynamic)reader["A1_SP_ENG_OTH_UTIL_ALLOC"],
                A1_SP_ENG_GROSS_ENG = (dynamic)reader["A1_SP_ENG_GROSS_ENG"],
                A1_SP_ENG_CREDIT_BFW = (dynamic)reader["A1_SP_ENG_CREDIT_BFW"],
                A1_SP_ENG_GRAND_TOTAL = (dynamic)reader["A1_SP_ENG_GRAND_TOTAL"],
                A1_SP_ENG_OVERALL_UREA = (dynamic)reader["A1_SP_ENG_OVERALL_UREA"],
                A1_AMM_BLOWER = (dynamic)reader["A1_AMM_BLOWER"],
                A1_AMM_COMPRESSER_A = (dynamic)reader["A1_AMM_COMPRESSER_A"],
                A1_AMM_COMPRESSER_B = (dynamic)reader["A1_AMM_COMPRESSER_B"],
                A1_AMM_TRANS_PUMP = (dynamic)reader["A1_AMM_TRANS_PUMP"],
                TXT_A_NG_EXPORTT_SSP = (dynamic)reader["TXT_A_NG_EXPORTT_SSP"],
                TXT_A_NG_CONSP_SPG = (dynamic)reader["TXT_A_NG_CONSP_SPG"],
                TXT_NG_EXPORTT_CFG3 = (dynamic)reader["TXT_NG_EXPORTT_CFG3"],
                TXT_SYN_IMP_GP2 = (dynamic)reader["TXT_SYN_IMP_GP2"],
                TXT_SYN_EXP_GP2 = (dynamic)reader["TXT_SYN_EXP_GP2"],
                TXT_SUM_AMM_STK = (dynamic)reader["TXT_SUM_AMM_STK"],
                TXT_AMM_COLD_STORAGE = (dynamic)reader["TXT_AMM_COLD_STORAGE"],
                TXT_OU_NAP_CONSP_SPG = (dynamic)reader["TXT_OU_NAP_CONSP_SPG"],
                TXT_OU_KS_CONSP_AMM = (dynamic)reader["TXT_OU_KS_CONSP_AMM"],
                TXT_OU_HS_CONSP_AMM = (dynamic)reader["TXT_OU_HS_CONSP_AMM"],
                TXT_E_ELECT_CONSP_AMM = (dynamic)reader["TXT_E_ELECT_CONSP_AMM"],
                TXT_E_ELECT_CONSP_ACT = (dynamic)reader["TXT_E_ELECT_CONSP_ACT"],
                TXT_E_ELECT_CONSP_AMMSTG = (dynamic)reader["TXT_E_ELECT_CONSP_AMMSTG"],
                TXT_UR_SP_CONSP_ALLOC_GP2 = (dynamic)reader["TXT_UR_SP_CONSP_ALLOC_GP2"],
                A1_GAIL_RLNG5_MMBTU = (dynamic)reader["A1_GAIL_RLNG5_MMBTU"],
                A1_GAIL_RLNG5_ALLOC = (dynamic)reader["A1_GAIL_RLNG5_ALLOC"],
                A1_GAIL_RLNG5_RECEIPT = (dynamic)reader["A1_GAIL_RLNG5_RECEIPT"],
                A1_GAIL_RLNG19_MMBTU = (dynamic)reader["A1_GAIL_RLNG19_MMBTU"],
                A1_GAIL_RLNG19_ALLOC = (dynamic)reader["A1_GAIL_RLNG19_ALLOC"],
                A1_GAIL_RLNG19_RECEIPT = (dynamic)reader["A1_GAIL_RLNG19_RECEIPT"],
                A1_GAIL_RLNG3_MMBTU = (dynamic)reader["A1_GAIL_RLNG3_MMBTU"],
                A1_GAIL_RLNG3_ALLOC = (dynamic)reader["A1_GAIL_RLNG3_ALLOC"],
                A1_GAIL_RLNG3_RECEIPT = (dynamic)reader["A1_GAIL_RLNG3_RECEIPT"],
                A1_SPOT_GSPSC_MMBTU = (dynamic)reader["A1_SPOT_GSPSC_MMBTU"],
                A1_SPOT_GSPSC_ALLOC = (dynamic)reader["A1_SPOT_GSPSC_ALLOC"],
                A1_SPOT_GSPSC_RECEIPT = (dynamic)reader["A1_SPOT_GSPSC_RECEIPT"],
                A1_SPOT_IOCL_MMBTU = (dynamic)reader["A1_SPOT_IOCL_MMBTU"],
                A1_SPOT_IOCL_ALLOC = (dynamic)reader["A1_SPOT_IOCL_ALLOC"],
                A1_SPOT_IOCL_RECEIPT = (dynamic)reader["A1_SPOT_IOCL_RECEIPT"],
                A1_SPOT_GAIL_MMBTU = (dynamic)reader["A1_SPOT_GAIL_MMBTU"],
                A1_SPOT_GAIL_ALLOC = (dynamic)reader["A1_SPOT_GAIL_ALLOC"],
                A1_SPOT_GAIL_RECEIPT = (dynamic)reader["A1_SPOT_GAIL_RECEIPT"],
                A1_DATE_MOD = reader["A1_DATE_MOD"].ToString(),
                A1_USER_ID = (dynamic)reader["A1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                A1_KS_STEAM_INT = (dynamic)reader["A1_KS_STEAM_INT"],
                A1_KS_STEAM_CONSP = (dynamic)reader["A1_KS_STEAM_CONSP"],

                // ------Gas Priority -----------
                ln_max_prior = (int)reader["ln_max_prior"],

                PMT_PSC_PRIORITY = (int)reader["PMT_PSC_PRIORITY"],
                APM_NG_PRIORITY = (int)reader["APM_NG_PRIORITY"],
                NON_APM_NG_PRIORITY = (int)reader["NON_APM_NG_PRIORITY"],
                RLNG_PRIORITY = (int)reader["RLNG_PRIORITY"],
                RLNG_MT_FIRM_PRIORITY = (int)reader["RLNG_MT_FIRM_PRIORITY"],
                RLNG_MT_RE_PRIORITY = (int)reader["RLNG_MT_RE_PRIORITY"],
                PMT_GAS_PRIORITY = (int)reader["PMT_GAS_PRIORITY"],
                SPOT_RLNG_POOL_PRIORITY = (int)reader["SPOT_RLNG_POOL_PRIORITY"],
                GAIL_LT_RLNG05_PRIORITY = (int)reader["GAIL_LT_RLNG05_PRIORITY"],
                GAIL_LT_RLNG19_PRIORITY = (int)reader["GAIL_LT_RLNG19_PRIORITY"],
                GAIL_LT_RLNG03_PRIORITY = (int)reader["GAIL_LT_RLNG03_PRIORITY"],
                SPOT_GSPSC_PRIORITY = (int)reader["SPOT_GSPSC_PRIORITY"],
                SPOT_IOCL_PRIORITY = (int)reader["SPOT_IOCL_PRIORITY"],
                SPOT_GAIL_PRIORITY = (int)reader["SPOT_GAIL_PRIORITY"],
                CFG3_SPOT_GAS_PRIORITY = (int)reader["CFG3_SPOT_GAS_PRIORITY"],

                PRIORITY_TAG1 = reader["PRIORITY_TAG1"].ToString(),
                PRIORITY_TAG2 = reader["PRIORITY_TAG2"].ToString(),
                PRIORITY_TAG3 = reader["PRIORITY_TAG3"].ToString(),
                PRIORITY_TAG4 = reader["PRIORITY_TAG4"].ToString(),
                PRIORITY_TAG5 = reader["PRIORITY_TAG5"].ToString(),
                PRIORITY_TAG6 = reader["PRIORITY_TAG6"].ToString(),
                PRIORITY_TAG7 = reader["PRIORITY_TAG7"].ToString(),
                PRIORITY_TAG8 = reader["PRIORITY_TAG8"].ToString(),
                PRIORITY_TAG9 = reader["PRIORITY_TAG9"].ToString(),
                PRIORITY_TAG10 = reader["PRIORITY_TAG10"].ToString(),
                PRIORITY_TAG11 = reader["PRIORITY_TAG11"].ToString(),
                PRIORITY_TAG12 = reader["PRIORITY_TAG12"].ToString(),
                PRIORITY_TAG13 = reader["PRIORITY_TAG13"].ToString(),
                PRIORITY_TAG14 = reader["PRIORITY_TAG14"].ToString(),
                PRIORITY_TAG15 = reader["PRIORITY_TAG15"].ToString(),

                // // // PRV
                PRV_A1_TRANS_DATE = reader["PRV_A1_TRANS_DATE"].ToString(),
                PRV_A1_PRS_NG_FEED_REFMR_INT = (dynamic)reader["PRV_A1_PRS_NG_FEED_REFMR_INT"],
                PRV_A1_PRS_NG_FEED_REFMR_INT_DIFF = (dynamic)reader["PRV_A1_PRS_NG_FEED_REFMR_INT_DIFF"],
                PRV_A1_TEMP_NG_FEED_REFMR_INT = (dynamic)reader["PRV_A1_TEMP_NG_FEED_REFMR_INT"],
                PRV_A1_TEMP_NG_FEED_REFMR_INT_DIFF = (dynamic)reader["PRV_A1_TEMP_NG_FEED_REFMR_INT_DIFF"],
                PRV_A1_NG_FEED_REFMR_INT = (dynamic)reader["PRV_A1_NG_FEED_REFMR_INT"],
                PRV_A1_NG_FEED_REFMR_INT_DIFF = (dynamic)reader["PRV_A1_NG_FEED_REFMR_INT_DIFF"],
                PRV_A1_MEAS_NG_CONSP_FEED_REFMR = (dynamic)reader["PRV_A1_MEAS_NG_CONSP_FEED_REFMR"],
                PRV_A1_NG_CONSP_KRES_FEED_INT = (dynamic)reader["PRV_A1_NG_CONSP_KRES_FEED_INT"],
                PRV_A1_NG_CONSP_KRES_FEED_INT_DIFF = (dynamic)reader["PRV_A1_NG_CONSP_KRES_FEED_INT_DIFF"],
                PRV_A1_NG_CONSP_KRES_FEED = (dynamic)reader["PRV_A1_NG_CONSP_KRES_FEED"],
                PRV_A1_PRS_NG_FUEL_REFMR_INT = (dynamic)reader["PRV_A1_PRS_NG_FUEL_REFMR_INT"],
                PRV_A1_PRS_NG_FUEL_REFMR_INT_DIFF = (dynamic)reader["PRV_A1_PRS_NG_FUEL_REFMR_INT_DIFF"],
                PRV_A1_TEMP_NG_FUEL_REFMR_INT = (dynamic)reader["PRV_A1_TEMP_NG_FUEL_REFMR_INT"],
                PRV_A1_TEMP_NG_FUEL_REFMR_INT_DIFF = (dynamic)reader["PRV_A1_TEMP_NG_FUEL_REFMR_INT_DIFF"],
                PRV_A1_NG_FUEL_REFMR_INT = (dynamic)reader["PRV_A1_NG_FUEL_REFMR_INT"],
                PRV_A1_NG_FUEL_REFMR_INT_DIFF = (dynamic)reader["PRV_A1_NG_FUEL_REFMR_INT_DIFF"],
                PRV_A1_NG_CONSP_FUEL_REFMR = (dynamic)reader["PRV_A1_NG_CONSP_FUEL_REFMR"],
                PRV_A1_PRS_NG_FUEL_HEATER_INT = (dynamic)reader["PRV_A1_PRS_NG_FUEL_HEATER_INT"],
                PRV_A1_PRS_NG_FUEL_HEATER_INT_DIFF = (dynamic)reader["PRV_A1_PRS_NG_FUEL_HEATER_INT_DIFF"],
                PRV_A1_NG_FUEL_HEATER_INT = (dynamic)reader["PRV_A1_NG_FUEL_HEATER_INT"],
                PRV_A1_NG_FUEL_HEATER_INT_DIFF = (dynamic)reader["PRV_A1_NG_FUEL_HEATER_INT_DIFF"],
                PRV_A1_NG_CONSP_FUEL_HEATER = (dynamic)reader["PRV_A1_NG_CONSP_FUEL_HEATER"],
                PRV_A1_NG_FUEL_ABURNER_INT = (dynamic)reader["PRV_A1_NG_FUEL_ABURNER_INT"],
                PRV_A1_NG_FUEL_ABURNER_INT_DIF = (dynamic)reader["PRV_A1_NG_FUEL_ABURNER_INT_DIF"],
                PRV_A1_NG_FUEL_ABURNER = (dynamic)reader["PRV_A1_NG_FUEL_ABURNER"],
                PRV_A1_SPOT_GAS_ENG_ALLOC = (dynamic)reader["PRV_A1_SPOT_GAS_ENG_ALLOC"],
                PRV_A1_SPOT_GAS_ALLOC = (dynamic)reader["PRV_A1_SPOT_GAS_ALLOC"],
                PRV_A1_SPOT_GAS_RECEIPT = (dynamic)reader["PRV_A1_SPOT_GAS_RECEIPT"],
                PRV_A1_NG_ALLOCATION = (dynamic)reader["PRV_A1_NG_ALLOCATION"],
                PRV_A1_APM_NG_RECEIPT = (dynamic)reader["PRV_A1_APM_NG_RECEIPT"],
                PRV_A1_NON_APM_ALLOC = (dynamic)reader["PRV_A1_NON_APM_ALLOC"],
                PRV_A1_NON_APM_RECPT = (dynamic)reader["PRV_A1_NON_APM_RECPT"],
                PRV_A1_RLNG_ENG_ALLOC = (dynamic)reader["PRV_A1_RLNG_ENG_ALLOC"],
                PRV_A1_RLNG_ALLOCATION = (dynamic)reader["PRV_A1_RLNG_ALLOCATION"],
                PRV_A1_GAIL_RLNG_RECEIPT = (dynamic)reader["PRV_A1_GAIL_RLNG_RECEIPT"],
                PRV_A1_GAIL_LT_RLNG_FIRM_MMBTU = (dynamic)reader["PRV_A1_GAIL_LT_RLNG_FIRM_MMBTU"],
                PRV_A1_GAIL_LT_RLNG_FIRM_ALLOC = (dynamic)reader["PRV_A1_GAIL_LT_RLNG_FIRM_ALLOC"],
                PRV_A1_GAIL_LT_RLNG_FIRM_RECEIPT = (dynamic)reader["PRV_A1_GAIL_LT_RLNG_FIRM_RECEIPT"],
                PRV_A1_GAIL_LT_RLNG_RE_MMBTU = (dynamic)reader["PRV_A1_GAIL_LT_RLNG_RE_MMBTU"],
                PRV_A1_GAIL_LT_RLNG_RE_ALLOC = (dynamic)reader["PRV_A1_GAIL_LT_RLNG_RE_ALLOC"],
                PRV_A1_GAIL_LT_RLNG_RE_RECEIPT = (dynamic)reader["PRV_A1_GAIL_LT_RLNG_RE_RECEIPT"],
                PRV_A1_PMT_NG_ENG_ALLOC = (dynamic)reader["PRV_A1_PMT_NG_ENG_ALLOC"],
                PRV_A1_PMT_NG_ALLOC = (dynamic)reader["PRV_A1_PMT_NG_ALLOC"],
                PRV_A1_PMT_NG_RECEIPT = (dynamic)reader["PRV_A1_PMT_NG_RECEIPT"],
                PRV_A1_RLNG_SPOT_ENG_ALLOC = (dynamic)reader["PRV_A1_RLNG_SPOT_ENG_ALLOC"],
                PRV_A1_RLNG_SPOT_ALLOC = (dynamic)reader["PRV_A1_RLNG_SPOT_ALLOC"],
                PRV_A1_RLNG_SPOT_RECPT = (dynamic)reader["PRV_A1_RLNG_SPOT_RECPT"],
                PRV_A1_FALLBACK_GAS_ALLOC = (dynamic)reader["PRV_A1_FALLBACK_GAS_ALLOC"],
                PRV_A1_NG_IMPORTF_UNIT2 = (dynamic)reader["PRV_A1_NG_IMPORTF_UNIT2"],
                PRV_A1_NG_CONSP_UNIT2 = (dynamic)reader["PRV_A1_NG_CONSP_UNIT2"],
                PRV_A1_AMM_CFG3_SPOT_GAS_ALLOC_ENG = (dynamic)reader["PRV_A1_AMM_CFG3_SPOT_GAS_ALLOC_ENG"],
                PRV_A1_AMM_CFG3_SPOT_GAS_ALLOC_SM3 = (dynamic)reader["PRV_A1_AMM_CFG3_SPOT_GAS_ALLOC_SM3"],
                PRV_A1_AMM_CFG3_SPOT_GAS_RECEIPT = (dynamic)reader["PRV_A1_AMM_CFG3_SPOT_GAS_RECEIPT"],
                PRV_A1_NG_CONSP_AMM = (dynamic)reader["PRV_A1_NG_CONSP_AMM"],
                PRV_A1_BAL_NG_CONSP_FEED_REFMR = (dynamic)reader["PRV_A1_BAL_NG_CONSP_FEED_REFMR"],
                PRV_A1_NG_RECPT = (dynamic)reader["PRV_A1_NG_RECPT"],
                PRV_A1_NG_LIMITATION_FLG = reader["PRV_A1_NG_LIMITATION_FLG"].ToString(),
                PRV_A1_ACTL_NG_CV_NET = (dynamic)reader["PRV_A1_ACTL_NG_CV_NET"],
                PRV_A1_RLNG_GCV = (dynamic)reader["PRV_A1_RLNG_GCV"],
                PRV_A1_MOL_WT_NG = (dynamic)reader["PRV_A1_MOL_WT_NG"],
                PRV_A1_NG_CARBON_NO = (dynamic)reader["PRV_A1_NG_CARBON_NO"],
                PRV_A1_GAIL_METER_ONLINE = reader["PRV_A1_GAIL_METER_ONLINE"].ToString(),
                PRV_A1_PRS_SURPLUS_GAS_INT = (dynamic)reader["PRV_A1_PRS_SURPLUS_GAS_INT"],
                PRV_A1_PRS_SURPLUS_GAS_INT_DIFF = (dynamic)reader["PRV_A1_PRS_SURPLUS_GAS_INT_DIFF"],
                PRV_A1_TEMP_SURPLUS_GAS_INT = (dynamic)reader["PRV_A1_TEMP_SURPLUS_GAS_INT"],
                PRV_A1_TEMP_SURPLUS_GAS_INT_DIFF = (dynamic)reader["PRV_A1_TEMP_SURPLUS_GAS_INT_DIFF"],
                PRV_A1_SURPLUS_GAS_INT = (dynamic)reader["PRV_A1_SURPLUS_GAS_INT"],
                PRV_A1_SURPLUS_GAS_INT_DIFF = (dynamic)reader["PRV_A1_SURPLUS_GAS_INT_DIFF"],
                PRV_A1_SURPLUS_GAS_PROD = (dynamic)reader["PRV_A1_SURPLUS_GAS_PROD"],
                PRV_A1_PRS_CO2_INT = (dynamic)reader["PRV_A1_PRS_CO2_INT"],
                PRV_A1_PRS_CO2_INT_DIFF = (dynamic)reader["PRV_A1_PRS_CO2_INT_DIFF"],
                PRV_A1_TEMP_CO2_INT = (dynamic)reader["PRV_A1_TEMP_CO2_INT"],
                PRV_A1_TEMP_CO2_INT_DIFF = (dynamic)reader["PRV_A1_TEMP_CO2_INT_DIFF"],
                PRV_A1_CO2_INT = (dynamic)reader["PRV_A1_CO2_INT"],
                PRV_A1_CO2_INT_DIFF = (dynamic)reader["PRV_A1_CO2_INT_DIFF"],
                PRV_A1_CO2_PROD = (dynamic)reader["PRV_A1_CO2_PROD"],
                PRV_A1_PRS_PERMEATE_INT = (dynamic)reader["PRV_A1_PRS_PERMEATE_INT"],
                PRV_A1_PRS_PERMEATE_INT_DIFF = (dynamic)reader["PRV_A1_PRS_PERMEATE_INT_DIFF"],
                PRV_A1_TEMP_PERMEATE_INT = (dynamic)reader["PRV_A1_TEMP_PERMEATE_INT"],
                PRV_A1_TEMP_PERMEATE_INT_DIFF = (dynamic)reader["PRV_A1_TEMP_PERMEATE_INT_DIFF"],
                PRV_A1_PERMEATE_INT = (dynamic)reader["PRV_A1_PERMEATE_INT"],
                PRV_A1_PERMEATE_INT_DIFF = (dynamic)reader["PRV_A1_PERMEATE_INT_DIFF"],
                PRV_A1_PERMEATE_FLOW = (dynamic)reader["PRV_A1_PERMEATE_FLOW"],
                PRV_A1_AMM_TANK_A_LEVEL = (dynamic)reader["PRV_A1_AMM_TANK_A_LEVEL"],
                PRV_A1_AMM_TANK_A_STOCK = (dynamic)reader["PRV_A1_AMM_TANK_A_STOCK"],
                PRV_A1_AMM_TANK_B_LEVEL = (dynamic)reader["PRV_A1_AMM_TANK_B_LEVEL"],
                PRV_A1_AMM_TANK_B_STOCK = (dynamic)reader["PRV_A1_AMM_TANK_B_STOCK"],
                PRV_A1_PROD_HRS = (dynamic)reader["PRV_A1_PROD_HRS"],
                PRV_A1_PGRU_RUN_HRS = (dynamic)reader["PRV_A1_PGRU_RUN_HRS"],
                PRV_A1_HOT_AMM_TO_UREA_INT = (dynamic)reader["PRV_A1_HOT_AMM_TO_UREA_INT"],
                PRV_A1_AMM_SUPP_UREA = (dynamic)reader["PRV_A1_AMM_SUPP_UREA"],
                PRV_A1_AMM_STORAGE_TO_UREA = (dynamic)reader["PRV_A1_AMM_STORAGE_TO_UREA"],
                PRV_A1_AMM_TRFR_UREA_SHIFT_A = (dynamic)reader["PRV_A1_AMM_TRFR_UREA_SHIFT_A"],
                PRV_A1_AMM_TRFR_UREA_SHIFT_B = (dynamic)reader["PRV_A1_AMM_TRFR_UREA_SHIFT_B"],
                PRV_A1_AMM_VAPOUR_EXPORTT_UNIT2 = (dynamic)reader["PRV_A1_AMM_VAPOUR_EXPORTT_UNIT2"],
                PRV_A1_AMM_SALE = (dynamic)reader["PRV_A1_AMM_SALE"],
                PRV_A1_AMM_PROD = (dynamic)reader["PRV_A1_AMM_PROD"],
                PRV_A1_RECVFROM_AMM2_STOCK = (dynamic)reader["PRV_A1_RECVFROM_AMM2_STOCK"],
                PRV_A1_TFRTO_AMM2_STOCK = (dynamic)reader["PRV_A1_TFRTO_AMM2_STOCK"],
                PRV_A1_RECVFROM_AMM3_STOCK = (dynamic)reader["PRV_A1_RECVFROM_AMM3_STOCK"],
                PRV_A1_AMM2_LOGICAL_STOCK = (dynamic)reader["PRV_A1_AMM2_LOGICAL_STOCK"],
                PRV_A1_TFRTO_AMM3_STOCK = (dynamic)reader["PRV_A1_TFRTO_AMM3_STOCK"],
                PRV_A1_AMM3_LOGICAL_STOCK = (dynamic)reader["PRV_A1_AMM3_LOGICAL_STOCK"],
                PRV_A1_AMM1_LOGICAL_STOCK = (dynamic)reader["PRV_A1_AMM1_LOGICAL_STOCK"],
                PRV_A1_AMM_CAP_UTIL = (dynamic)reader["PRV_A1_AMM_CAP_UTIL"],
                PRV_A1_REMARKS = reader["PRV_A1_REMARKS"].ToString(),
                PRV_A1_NAP_AMM_REFMR_INT = (dynamic)reader["PRV_A1_NAP_AMM_REFMR_INT"],
                PRV_A1_NAP_CONSP_AMM_REFMR = (dynamic)reader["PRV_A1_NAP_CONSP_AMM_REFMR"],
                PRV_A1_NAP_AMM_HEATER_INT = (dynamic)reader["PRV_A1_NAP_AMM_HEATER_INT"],
                PRV_A1_NAP_CONSP_AMM_HEATER = (dynamic)reader["PRV_A1_NAP_CONSP_AMM_HEATER"],
                PRV_A1_NAP_CONSP_AMM = (dynamic)reader["PRV_A1_NAP_CONSP_AMM"],
                PRV_A1_ATC_PROD_INT1 = (dynamic)reader["PRV_A1_ATC_PROD_INT1"],
                PRV_A1_ATC_PROD_INT1_DIFF = (dynamic)reader["PRV_A1_ATC_PROD_INT1_DIFF"],
                PRV_A1_ATC_PROD_INT2 = (dynamic)reader["PRV_A1_ATC_PROD_INT2"],
                PRV_A1_ATC_PROD_INT2_DIFF = (dynamic)reader["PRV_A1_ATC_PROD_INT2_DIFF"],
                PRV_A1_ATC_PROD_INT3 = (dynamic)reader["PRV_A1_ATC_PROD_INT3"],
                PRV_A1_ATC_PROD_INT3_DIFF = (dynamic)reader["PRV_A1_ATC_PROD_INT3_DIFF"],
                PRV_A1_ATC_PROD_INT4 = (dynamic)reader["PRV_A1_ATC_PROD_INT4"],
                PRV_A1_ATC_PROD_INT4_DIFF = (dynamic)reader["PRV_A1_ATC_PROD_INT4_DIFF"],
                PRV_A1_ATC_PROD = (dynamic)reader["PRV_A1_ATC_PROD"],
                PRV_A1_PROCESS_STEAM_INT = (dynamic)reader["PRV_A1_PROCESS_STEAM_INT"],
                PRV_A1_PROCESS_STEAMM_CONSP = (dynamic)reader["PRV_A1_PROCESS_STEAMM_CONSP"],
                PRV_A1_PROCESS_STEAM_KRES_INT = (dynamic)reader["PRV_A1_PROCESS_STEAM_KRES_INT"],
                PRV_A1_PROCESS_STEAM_CONSP_KRES = (dynamic)reader["PRV_A1_PROCESS_STEAM_CONSP_KRES"],
                PRV_A1_LS_CONSP_AMM_INT = (dynamic)reader["PRV_A1_LS_CONSP_AMM_INT"],
                PRV_A1_LS_CONSP_AMM = (dynamic)reader["PRV_A1_LS_CONSP_AMM"],
                PRV_A1_AMM_SP_CONSP_FEED = (dynamic)reader["PRV_A1_AMM_SP_CONSP_FEED"],
                PRV_A1_AMM_SP_CONSP_EQ_FUEL = (dynamic)reader["PRV_A1_AMM_SP_CONSP_EQ_FUEL"],
                PRV_A1_AMM_SP_CONSP_TOTAL_GAS = (dynamic)reader["PRV_A1_AMM_SP_CONSP_TOTAL_GAS"],
                PRV_A1_AMM_SP_CONSP_KS = (dynamic)reader["PRV_A1_AMM_SP_CONSP_KS"],
                PRV_A1_AMM_SP_CONSP_HS = (dynamic)reader["PRV_A1_AMM_SP_CONSP_HS"],
                PRV_A1_AMM_SP_CONSP_LS = (dynamic)reader["PRV_A1_AMM_SP_CONSP_LS"],
                PRV_A1_AMM_SP_CONSP_CT = (dynamic)reader["PRV_A1_AMM_SP_CONSP_CT"],
                PRV_A1_AMM_SP_CONSP_DMW_IMPORT = (dynamic)reader["PRV_A1_AMM_SP_CONSP_DMW_IMPORT"],
                PRV_A1_AMM_SP_CONSP_DMW_EXPORT = (dynamic)reader["PRV_A1_AMM_SP_CONSP_DMW_EXPORT"],
                PRV_A1_AMM_SP_CONSP_DMW = (dynamic)reader["PRV_A1_AMM_SP_CONSP_DMW"],
                PRV_A1_AMM_SP_CONSP_TC = (dynamic)reader["PRV_A1_AMM_SP_CONSP_TC"],
                PRV_A1_AMM_SP_CONSP_PC = (dynamic)reader["PRV_A1_AMM_SP_CONSP_PC"],
                PRV_A1_AMM_SP_CONSP_CONDENSATE = (dynamic)reader["PRV_A1_AMM_SP_CONSP_CONDENSATE"],
                PRV_A1_AMM_SP_CONSP_NET_BFW = (dynamic)reader["PRV_A1_AMM_SP_CONSP_NET_BFW"],
                PRV_A1_UR_SP_CONSP_AMM = (dynamic)reader["PRV_A1_UR_SP_CONSP_AMM"],
                PRV_A1_UR_SP_CONSP_FEED = (dynamic)reader["PRV_A1_UR_SP_CONSP_FEED"],
                PRV_A1_UR_SP_CONSP_EQ_FUEL = (dynamic)reader["PRV_A1_UR_SP_CONSP_EQ_FUEL"],
                PRV_A1_UR_SP_CONSP_TOTAL_FUEL = (dynamic)reader["PRV_A1_UR_SP_CONSP_TOTAL_FUEL"],
                PRV_A1_UR_SP_CONSP_SPG_GAS = (dynamic)reader["PRV_A1_UR_SP_CONSP_SPG_GAS"],
                PRV_A1_UR_SP_CONSP_SPG_NAP = (dynamic)reader["PRV_A1_UR_SP_CONSP_SPG_NAP"],
                PRV_A1_UR_SP_CONSP_EQ_SPG = (dynamic)reader["PRV_A1_UR_SP_CONSP_EQ_SPG"],
                PRV_A1_UR_SP_CONSP_TOTAL_GAS = (dynamic)reader["PRV_A1_UR_SP_CONSP_TOTAL_GAS"],
                PRV_A1_SP_CONSP_ELECT_BL = (dynamic)reader["PRV_A1_SP_CONSP_ELECT_BL"],
                PRV_A1_SP_CONSP_ELECT_CT = (dynamic)reader["PRV_A1_SP_CONSP_ELECT_CT"],
                PRV_A1_SP_CONSP_ELECT_AMM_STRG = (dynamic)reader["PRV_A1_SP_CONSP_ELECT_AMM_STRG"],
                PRV_A1_AVG_NG_CV = (dynamic)reader["PRV_A1_AVG_NG_CV"],
                PRV_A1_SP_ENG_FEED_GAS = (dynamic)reader["PRV_A1_SP_ENG_FEED_GAS"],
                PRV_A1_SP_ENG_FUEL = (dynamic)reader["PRV_A1_SP_ENG_FUEL"],
                PRV_A1_SP_ENG_TOTAL = (dynamic)reader["PRV_A1_SP_ENG_TOTAL"],
                PRV_A1_SP_ENG_DIR_STEAM_BL = (dynamic)reader["PRV_A1_SP_ENG_DIR_STEAM_BL"],
                PRV_A1_SP_ENG_DIR_ELECT_BL = (dynamic)reader["PRV_A1_SP_ENG_DIR_ELECT_BL"],
                PRV_A1_SP_ENG_SUB_TOT_UTIL_BL = (dynamic)reader["PRV_A1_SP_ENG_SUB_TOT_UTIL_BL"],
                PRV_A1_SP_ENG_TOT_BL = (dynamic)reader["PRV_A1_SP_ENG_TOT_BL"],
                PRV_A1_SP_ENG_CT_STEAM = (dynamic)reader["PRV_A1_SP_ENG_CT_STEAM"],
                PRV_A1_SP_ENG_CT_ELECT = (dynamic)reader["PRV_A1_SP_ENG_CT_ELECT"],
                PRV_A1_SP_ENG_SUB_TOT_UTIL = (dynamic)reader["PRV_A1_SP_ENG_SUB_TOT_UTIL"],
                PRV_A1_SP_ENG_TOT_INCL_CT = (dynamic)reader["PRV_A1_SP_ENG_TOT_INCL_CT"],
                PRV_A1_SP_ENG_OTH_UTIL_ALLOC = (dynamic)reader["PRV_A1_SP_ENG_OTH_UTIL_ALLOC"],
                PRV_A1_SP_ENG_GROSS_ENG = (dynamic)reader["PRV_A1_SP_ENG_GROSS_ENG"],
                PRV_A1_SP_ENG_CREDIT_BFW = (dynamic)reader["PRV_A1_SP_ENG_CREDIT_BFW"],
                PRV_A1_SP_ENG_GRAND_TOTAL = (dynamic)reader["PRV_A1_SP_ENG_GRAND_TOTAL"],
                PRV_A1_SP_ENG_OVERALL_UREA = (dynamic)reader["PRV_A1_SP_ENG_OVERALL_UREA"],
                PRV_A1_AMM_BLOWER = (dynamic)reader["PRV_A1_AMM_BLOWER"],
                PRV_A1_AMM_COMPRESSER_A = (dynamic)reader["PRV_A1_AMM_COMPRESSER_A"],
                PRV_A1_AMM_COMPRESSER_B = (dynamic)reader["PRV_A1_AMM_COMPRESSER_B"],
                PRV_A1_AMM_TRANS_PUMP = (dynamic)reader["PRV_A1_AMM_TRANS_PUMP"],
                PRV_TXT_A_NG_EXPORTT_SSP = (dynamic)reader["PRV_TXT_A_NG_EXPORTT_SSP"],
                PRV_TXT_A_NG_CONSP_SPG = (dynamic)reader["PRV_TXT_A_NG_CONSP_SPG"],
                PRV_TXT_NG_EXPORTT_CFG3 = (dynamic)reader["PRV_TXT_NG_EXPORTT_CFG3"],
                PRV_TXT_SYN_IMP_GP2 = (dynamic)reader["PRV_TXT_SYN_IMP_GP2"],
                PRV_TXT_SYN_EXP_GP2 = (dynamic)reader["PRV_TXT_SYN_EXP_GP2"],
                PRV_TXT_SUM_AMM_STK = (dynamic)reader["PRV_TXT_SUM_AMM_STK"],
                PRV_TXT_AMM_COLD_STORAGE = (dynamic)reader["PRV_TXT_AMM_COLD_STORAGE"],
                PRV_TXT_OU_NAP_CONSP_SPG = (dynamic)reader["PRV_TXT_OU_NAP_CONSP_SPG"],
                PRV_TXT_OU_KS_CONSP_AMM = (dynamic)reader["PRV_TXT_OU_KS_CONSP_AMM"],
                PRV_TXT_OU_HS_CONSP_AMM = (dynamic)reader["PRV_TXT_OU_HS_CONSP_AMM"],
                PRV_TXT_E_ELECT_CONSP_AMM = (dynamic)reader["PRV_TXT_E_ELECT_CONSP_AMM"],
                PRV_TXT_E_ELECT_CONSP_ACT = (dynamic)reader["PRV_TXT_E_ELECT_CONSP_ACT"],
                PRV_TXT_E_ELECT_CONSP_AMMSTG = (dynamic)reader["PRV_TXT_E_ELECT_CONSP_AMMSTG"],
                PRV_TXT_UR_SP_CONSP_ALLOC_GP2 = (dynamic)reader["PRV_TXT_UR_SP_CONSP_ALLOC_GP2"],
                PRV_A1_GAIL_RLNG5_MMBTU = (dynamic)reader["PRV_A1_GAIL_RLNG5_MMBTU"],
                PRV_A1_GAIL_RLNG5_ALLOC = (dynamic)reader["PRV_A1_GAIL_RLNG5_ALLOC"],
                PRV_A1_GAIL_RLNG5_RECEIPT = (dynamic)reader["PRV_A1_GAIL_RLNG5_RECEIPT"],
                PRV_A1_GAIL_RLNG19_MMBTU = (dynamic)reader["PRV_A1_GAIL_RLNG19_MMBTU"],
                PRV_A1_GAIL_RLNG19_ALLOC = (dynamic)reader["PRV_A1_GAIL_RLNG19_ALLOC"],
                PRV_A1_GAIL_RLNG19_RECEIPT = (dynamic)reader["PRV_A1_GAIL_RLNG19_RECEIPT"],
                PRV_A1_SPOT_GSPSC_MMBTU = (dynamic)reader["PRV_A1_SPOT_GSPSC_MMBTU"],
                PRV_A1_SPOT_GSPSC_ALLOC = (dynamic)reader["PRV_A1_SPOT_GSPSC_ALLOC"],
                PRV_A1_SPOT_GSPSC_RECEIPT = (dynamic)reader["PRV_A1_SPOT_GSPSC_RECEIPT"],
                PRV_A1_SPOT_IOCL_MMBTU = (dynamic)reader["PRV_A1_SPOT_IOCL_MMBTU"],
                PRV_A1_SPOT_IOCL_ALLOC = (dynamic)reader["PRV_A1_SPOT_IOCL_ALLOC"],
                PRV_A1_SPOT_IOCL_RECEIPT = (dynamic)reader["PRV_A1_SPOT_IOCL_RECEIPT"],
                PRV_A1_SPOT_GAIL_MMBTU = (dynamic)reader["PRV_A1_SPOT_GAIL_MMBTU"],
                PRV_A1_SPOT_GAIL_ALLOC = (dynamic)reader["PRV_A1_SPOT_GAIL_ALLOC"],
                PRV_A1_SPOT_GAIL_RECEIPT = (dynamic)reader["PRV_A1_SPOT_GAIL_RECEIPT"],

                PRV_A1_KS_STEAM_INT = (dynamic)reader["PRV_A1_KS_STEAM_INT"],

            };
        }

        private AMM1DVDto MapToValueDV(SqlDataReader reader)
        {
            return new AMM1DVDto()
            {
                ou1_pw_consp_unit1 = (dynamic)reader["ou1_pw_consp_unit1"],
                OU1_PW_CONSP_SPG = (dynamic)reader["OU1_PW_CONSP_SPG"],
                OU1_PW_CONSP_AMM = (dynamic)reader["OU1_PW_CONSP_AMM"],
                OU1_APC_PROD = (dynamic)reader["OU1_APC_PROD"],
                OU1_HS_CONSP_AMM = (dynamic)reader["OU1_HS_CONSP_AMM"],
                parm_eff = (dynamic)reader["parm_eff"], // As ln_eff
                parm_cf_nh3_sm3 = (dynamic)reader["parm_cf_nh3_sm3"],
                parm_ks_enthalpy = (dynamic)reader["parm_ks_enthalpy"],
                parm_hs_enthalpy = (dynamic)reader["parm_hs_enthalpy"],
                parm_ls_enthalpy = (dynamic)reader["parm_ls_enthalpy"],
                parm_eng_eq_power = (dynamic)reader["parm_eng_eq_power"],
                parm_temp_rise_bfw = (dynamic)reader["parm_temp_rise_bfw"],
                parm_amm_daily_inst_cap = (dynamic)reader["parm_amm_daily_inst_cap"],

                parm_k_surplus_gas = (dynamic)reader["parm_k_surplus_gas"],
                parm_amm_prs_const = (dynamic)reader["parm_amm_prs_const"],
                parm_kelvin_temp = (dynamic)reader["parm_kelvin_temp"],
                parm_dsgnd_mw_surplus_gas = (dynamic)reader["parm_dsgnd_mw_surplus_gas"],
                parm_z_surplus_gas = (dynamic)reader["parm_z_surplus_gas"],
                parm_k_co2 = (dynamic)reader["parm_k_co2"],
                parm_dsgnd_mw_co2 = (dynamic)reader["parm_dsgnd_mw_co2"],
                parm_z_co2 = (dynamic)reader["parm_z_co2"],

                a_vpr1_to_amm2 = (dynamic)reader["a_vpr1_to_amm2"],
                a_recvfrom_amm2_stock = (dynamic)reader["a_recvfrom_amm2_stock"],
                a_tfrto_amm2_stock = (dynamic)reader["a_tfrto_amm2_stock"],
                a_amm2_logical_stock = (dynamic)reader["a_amm2_logical_stock"],
                A_NG_EXPORTT_UNIT1 = (dynamic)reader["A_NG_EXPORTT_UNIT1"],
                u_tot_urea_prod = (dynamic)reader["u_tot_urea_prod"],
                a_ng_alloc_revamp = (dynamic)reader["a_ng_alloc_revamp"],
                A_ALLOC_NG_SH_EXP_GP1 = (dynamic)reader["A_ALLOC_NG_SH_EXP_GP1"],
                a_ng_alloc_pwr_amm_tr_gpi = (dynamic)reader["a_ng_alloc_pwr_amm_tr_gpi"],
                A_ALLOC_NAP_SH_EXP_GP1 = (dynamic)reader["A_ALLOC_NAP_SH_EXP_GP1"],
                a_nap_net_cv = (dynamic)reader["a_nap_net_cv"],
                a_ioc_rlng_lcv = (dynamic)reader["a_ioc_rlng_lcv"],
                A3_STK_TRSFER_FROM_GP3_TO_GP1 = (dynamic)reader["A3_STK_TRSFER_FROM_GP3_TO_GP1"], // As A3_PDR_T9
                A3_STK_TRSFER_FROM_GP1_TO_GP3 = (dynamic)reader["A3_STK_TRSFER_FROM_GP1_TO_GP3"], // As A3_PDR_T11
                A3_AMM_3_LOGICAL_STK = (dynamic)reader["A3_AMM_3_LOGICAL_STK"], // As A3_PDR_T15_CV
                CALC_DAILY_NG_CV = (dynamic)reader["CALC_DAILY_NG_CV"],

                parm_mf_amm_tank = (dynamic)reader["parm_mf_amm_tank"],
                ln_log_stk2 = (dynamic)reader["ln_log_stk2"],
                a_am_ng_alloc_feed_gp2 = (dynamic)reader["a_am_ng_alloc_feed_gp2"],
                a_am_ng_alloc_fuel_gp2 = (dynamic)reader["a_am_ng_alloc_fuel_gp2"],
                a_am_nap_alloc = (dynamic)reader["a_am_nap_alloc"],
                ou_import_ks_consp_amm = (dynamic)reader["ou_import_ks_consp_amm"],
                ou_hs_consp_act = (dynamic)reader["ou_hs_consp_act"],
                ou_pw_consp_unit1 = (dynamic)reader["ou_pw_consp_unit1"],
                ou_pw_consp_spg = (dynamic)reader["ou_pw_consp_spg"],
                ou_pw_consp_amm = (dynamic)reader["ou_pw_consp_amm"],
                ou_apc_prod = (dynamic)reader["ou_apc_prod"],
                txt_a_ng_alloc_gp2 = (dynamic)reader["txt_a_ng_alloc_gp2"],
                txt_a_nap_alloc_gp2 = (dynamic)reader["txt_a_nap_alloc_gp2"],
                a_nap_alloc_revamp = (dynamic)reader["a_nap_alloc_revamp"],
                parm_dsgnd_nap_cv = (dynamic)reader["parm_dsgnd_nap_cv"],
                txt_ou_hs_consp_ctt = (dynamic)reader["txt_ou_hs_consp_ctt"],
                txt_ou_pw_consp_spg = (dynamic)reader["txt_ou_pw_consp_spg"],

                ln_amm_op_stk = (dynamic)reader["ln_amm_op_stk"],
                ln_vpr1_amm = (dynamic)reader["ln_vpr1_amm"],
                ln_amm_tfrto_amm2_stk = (dynamic)reader["ln_amm_tfrto_amm2_stk"],
                ln_amm_tfrto_amm1_stk = (dynamic)reader["ln_amm_tfrto_amm1_stk"],
                G_K_NG_FUEL_SSHEATER = (dynamic)reader["G_K_NG_FUEL_SSHEATER"],
                G_Z_NG_FUEL_SSHEATER = (dynamic)reader["G_Z_NG_FUEL_SSHEATER"],
                G_AMM_PRS_CONST = (dynamic)reader["G_AMM_PRS_CONST"],
                G_KELVIN_TEMP = (dynamic)reader["G_KELVIN_TEMP"],
                G_Z_NG_FUEL_REFMR = (dynamic)reader["G_Z_NG_FUEL_REFMR"],
                G_K_NG_FUEL_REFMR = (dynamic)reader["G_K_NG_FUEL_REFMR"],
                G_K_NG_FEED_REFMR = (dynamic)reader["G_K_NG_FEED_REFMR"],
                G_Z_NG_FEED_REFMR = (dynamic)reader["G_Z_NG_FEED_REFMR"],
                TXT_MAX_PRODUCTION = (dynamic)reader["TXT_MAX_PRODUCTION"],
                TXT_MAX_PROD_DATE = reader["TXT_MAX_PROD_DATE"].ToString()
            };
        }

        public async Task<PAS001Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_GET_PPT_AM_AMMONIA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS001Model response = null;
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

        public async Task<AMM1DVDto> putDataDV(string IN_DATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_GET_PPT_AM_AMMONIA_DETAILS_DV", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    AMM1DVDto response = null;
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

        public async Task saveData(PAS001SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_SAVE_PPT_AM_AMMONIA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TRANS_DATE", value.A1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_USER_ID", value.A1_USER_ID));
                    //   cmd.Parameters.Add(new SqlParameter("@IN_A1_FREEZE_FLG", value.A1_FREEZE_FLG));
                    //   cmd.Parameters.Add(new SqlParameter("@IN_A1_FREEZE_TIME", value.A1_FREEZE_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_D", value.A1_REMARKS_D));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_M", value.A1_REMARKS_M));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_METER_ONLINE", value.A1_GAIL_METER_ONLINE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_LIMITATION_FLG", value.A1_NG_LIMITATION_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SURPLUS_GAS_INT", value.A1_SURPLUS_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SURPLUS_GAS_INT_DIFF", value.A1_SURPLUS_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_SURPLUS_GAS_INT", value.A1_PRS_SURPLUS_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_SURPLUS_GAS_INT_DIFF", value.A1_PRS_SURPLUS_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_SURPLUS_GAS_INT", value.A1_TEMP_SURPLUS_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_SURPLUS_GAS_INT_DIFF", value.A1_TEMP_SURPLUS_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CO2_INT", value.A1_CO2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CO2_INT_DIFF", value.A1_CO2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_CO2_INT", value.A1_PRS_CO2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_CO2_INT_DIFF", value.A1_PRS_CO2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_CO2_INT", value.A1_TEMP_CO2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_CO2_INT_DIFF", value.A1_TEMP_CO2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PERMEATE_INT", value.A1_PERMEATE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PERMEATE_INT_DIFF", value.A1_PERMEATE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_PERMEATE_INT", value.A1_PRS_PERMEATE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_PERMEATE_INT_DIFF", value.A1_PRS_PERMEATE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_PERMEATE_INT", value.A1_TEMP_PERMEATE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_PERMEATE_INT_DIFF", value.A1_TEMP_PERMEATE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PGRU_RUN_HRS", value.A1_PGRU_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_SURPLUS_GAS", value.A1_CF_SURPLUS_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_CO2", value.A1_CF_CO2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SURPLUS_GAS_PROD", value.A1_SURPLUS_GAS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CO2_PROD", value.A1_CO2_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PERMEATE_FLOW", value.A1_PERMEATE_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PROD_HRS", value.A1_PROD_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_PROD", value.A1_AMM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_CAP_UTIL", value.A1_AMM_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_STOCK", value.A1_AMM_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SUPP_UREA", value.A1_AMM_SUPP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PGRU_PROD", value.A1_PGRU_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_FEED", value.A1_AMM_SP_CONSP_FEED));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_IMPORTF_UNIT2", value.A1_AMM_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_EQ_FUEL", value.A1_AMM_SP_CONSP_EQ_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_TOTAL_GAS", value.A1_AMM_SP_CONSP_TOTAL_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_KS", value.A1_AMM_SP_CONSP_KS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_HS", value.A1_AMM_SP_CONSP_HS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_LS", value.A1_AMM_SP_CONSP_LS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_CT", value.A1_AMM_SP_CONSP_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_DMW_IMPORT", value.A1_AMM_SP_CONSP_DMW_IMPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_DMW_EXPORT", value.A1_AMM_SP_CONSP_DMW_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_DMW", value.A1_AMM_SP_CONSP_DMW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_TC", value.A1_AMM_SP_CONSP_TC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_PC", value.A1_AMM_SP_CONSP_PC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_CONDENSATE", value.A1_AMM_SP_CONSP_CONDENSATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SP_CONSP_NET_BFW", value.A1_AMM_SP_CONSP_NET_BFW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_AMM", value.A1_UR_SP_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_FEED", value.A1_UR_SP_CONSP_FEED));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_EQ_FUEL", value.A1_UR_SP_CONSP_EQ_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_TOTAL_FUEL", value.A1_UR_SP_CONSP_TOTAL_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_SPG_GAS", value.A1_UR_SP_CONSP_SPG_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_SPG_NAP", value.A1_UR_SP_CONSP_SPG_NAP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_EQ_SPG", value.A1_UR_SP_CONSP_EQ_SPG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_SP_CONSP_TOTAL_GAS", value.A1_UR_SP_CONSP_TOTAL_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_CONSP_ELECT_BL", value.A1_SP_CONSP_ELECT_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_CONSP_ELECT_CT", value.A1_SP_CONSP_ELECT_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_CONSP_ELECT_AMM_STRG", value.A1_SP_CONSP_ELECT_AMM_STRG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_FEED_GAS", value.A1_SP_ENG_FEED_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_FUEL", value.A1_SP_ENG_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_TOTAL", value.A1_SP_ENG_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_DIR_STEAM_BL", value.A1_SP_ENG_DIR_STEAM_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_DIR_ELECT_BL", value.A1_SP_ENG_DIR_ELECT_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_SUB_TOT_UTIL_BL", value.A1_SP_ENG_SUB_TOT_UTIL_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_TOT_BL", value.A1_SP_ENG_TOT_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_CT_STEAM", value.A1_SP_ENG_CT_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_CT_ELECT", value.A1_SP_ENG_CT_ELECT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_SUB_TOT_UTIL", value.A1_SP_ENG_SUB_TOT_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_TOT_INCL_CT", value.A1_SP_ENG_TOT_INCL_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_OTH_UTIL_ALLOC", value.A1_SP_ENG_OTH_UTIL_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_GROSS_ENG", value.A1_SP_ENG_GROSS_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_CREDIT_BFW", value.A1_SP_ENG_CREDIT_BFW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_GRAND_TOTAL", value.A1_SP_ENG_GRAND_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SP_ENG_OVERALL_UREA", value.A1_SP_ENG_OVERALL_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CARBON_NO", value.A1_NG_CARBON_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SUPP_UNIT2", value.A1_AMM_SUPP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_SALE", value.A1_AMM_SALE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AM_PD_CAP_PROD_LOST", value.A1_AM_PD_CAP_PROD_LOST));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UR_PD_CAP_PROD_LOST", value.A1_UR_PD_CAP_PROD_LOST));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SURPLUS_PROD_PT_AM", value.A1_SURPLUS_PROD_PT_AM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PROD_STEAM_CONSP_UR_GTR", value.A1_PROD_STEAM_CONSP_UR_GTR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_ALLOCATION", value.A1_NG_ALLOCATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MOL_WT_NG", value.A1_MOL_WT_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_RECPT", value.A1_NG_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_IMPORTF_UNIT2_INT", value.A1_NG_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_IMPORTF_UNIT2_INT_DIFF", value.A1_NG_IMPORTF_UNIT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_IMPORTF_UNIT2", value.A1_CF_NG_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_IMPORTF_UNIT2", value.A1_NG_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_TOT_RECEIPT", value.A1_NG_TOT_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FEED_REFMR_INT_DIFF", value.A1_NG_FEED_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FEED_REFMR_INT", value.A1_NG_FEED_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_NG_FEED_REFMR_INT_DIFF", value.A1_PRS_NG_FEED_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_NG_FEED_REFMR_INT", value.A1_PRS_NG_FEED_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_NG_FEED_REFMR_INT", value.A1_TEMP_NG_FEED_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_NG_FEED_REFMR_INT_DIFF", value.A1_TEMP_NG_FEED_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_HEATER_INT", value.A1_NG_FUEL_HEATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_HEATER_INT_DIFF", value.A1_NG_FUEL_HEATER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_NG_FUEL_HEATER_INT", value.A1_PRS_NG_FUEL_HEATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_NG_FUEL_HEATER_INT_DIFF", value.A1_PRS_NG_FUEL_HEATER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_NG_FUEL_HEATER_INT", value.A1_TEMP_NG_FUEL_HEATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_NG_FUEL_HEATER_INT_DIFF", value.A1_TEMP_NG_FUEL_HEATER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_FEED_REFMR", value.A1_CF_NG_FEED_REFMR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_REFMR_INT", value.A1_NG_FUEL_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_REFMR_INT_DIFF", value.A1_NG_FUEL_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_NG_FUEL_REFMR_INT", value.A1_PRS_NG_FUEL_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PRS_NG_FUEL_REFMR_INT_DIFF", value.A1_PRS_NG_FUEL_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_NG_FUEL_REFMR_INT", value.A1_TEMP_NG_FUEL_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TEMP_NG_FUEL_REFMR_INT_DIFF", value.A1_TEMP_NG_FUEL_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_FUEL_REFMR", value.A1_CF_NG_FUEL_REFMR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_FUEL_HEATER", value.A1_CF_NG_FUEL_HEATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MEAS_NG_CONSP_FEED_REFMR", value.A1_MEAS_NG_CONSP_FEED_REFMR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_FUEL_REFMR", value.A1_NG_CONSP_FUEL_REFMR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_BAL_NG_CONSP_FEED_REFMR", value.A1_BAL_NG_CONSP_FEED_REFMR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_FUEL_HEATER", value.A1_NG_CONSP_FUEL_HEATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AMM", value.A1_NG_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_UNIT2_INT", value.A1_NG_CONSP_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_UNIT2_INT_DIFF", value.A1_NG_CONSP_UNIT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_CONSP_UNIT2", value.A1_CF_NG_CONSP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_UNIT2", value.A1_NG_CONSP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_TOT_CONSP", value.A1_NG_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ACTL_NG_CV_GROSS", value.A1_ACTL_NG_CV_GROSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ACTL_NG_CV_NET", value.A1_ACTL_NG_CV_NET));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NAP_AMM_REFMR_INT", value.A1_NAP_AMM_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NAP_AMM_HEATER_INT", value.A1_NAP_AMM_HEATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NAP_CONSP_AMM_REFMR", value.A1_NAP_CONSP_AMM_REFMR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NAP_CONSP_AMM_HEATER", value.A1_NAP_CONSP_AMM_HEATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NAP_CONSP_AMM", value.A1_NAP_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT1", value.A1_ATC_PROD_INT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT1_DIFF", value.A1_ATC_PROD_INT1_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT2", value.A1_ATC_PROD_INT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT2_DIFF", value.A1_ATC_PROD_INT2_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT3", value.A1_ATC_PROD_INT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT3_DIFF", value.A1_ATC_PROD_INT3_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT4", value.A1_ATC_PROD_INT4));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD_INT4_DIFF", value.A1_ATC_PROD_INT4_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ATC_PROD", value.A1_ATC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_VAPOUR_EXPORTT_UNIT2", value.A1_AMM_VAPOUR_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TANK_A_LEVEL", value.A1_AMM_TANK_A_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TANK_A_STOCK", value.A1_AMM_TANK_A_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TANK_B_LEVEL", value.A1_AMM_TANK_B_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TANK_B_STOCK", value.A1_AMM_TANK_B_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_STORAGE_TO_UREA", value.A1_AMM_STORAGE_TO_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RECVFROM_AMM2_STOCK", value.A1_RECVFROM_AMM2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TFRTO_AMM2_STOCK", value.A1_TFRTO_AMM2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM1_LOGICAL_STOCK", value.A1_AMM1_LOGICAL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM2_LOGICAL_STOCK", value.A1_AMM2_LOGICAL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_HOT_AMM_TO_UREA_INT", value.A1_HOT_AMM_TO_UREA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_LS_CONSP_AMM_INT", value.A1_LS_CONSP_AMM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_LS_CONSP_AMM", value.A1_LS_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_RECEIPT", value.A1_RLNG_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_ALLOCATION", value.A1_RLNG_ALLOCATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_GCV", value.A1_RLNG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_IOC_RLNG_RECEIPT", value.A1_IOC_RLNG_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_IOC_RLNG_ALLOC", value.A1_IOC_RLNG_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG_RECEIPT", value.A1_GAIL_RLNG_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG_GCV", value.A1_GAIL_RLNG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_IOC_RLNG_GCV", value.A1_IOC_RLNG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PMT_NG_ALLOC", value.A1_PMT_NG_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_FALLBACK_GAS_ALLOC", value.A1_FALLBACK_GAS_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PMT_NG_RECEIPT", value.A1_PMT_NG_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PMT_NG_LCV", value.A1_PMT_NG_LCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_FALLBACK_GCV", value.A1_FALLBACK_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_APM_NG_CV", value.A1_APM_NG_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_APM_NG_RECEIPT", value.A1_APM_NG_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAS_ALLOC", value.A1_SPOT_GAS_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAS_RECEIPT", value.A1_SPOT_GAS_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAS_GCV", value.A1_SPOT_GAS_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PROCESS_STEAM_INT", value.A1_PROCESS_STEAM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PROCESS_STEAMM_CONSP", value.A1_PROCESS_STEAMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_REVAMP_FEED", value.A1_NG_CONSP_REVAMP_FEED));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_REVAMP_FUEL", value.A1_NG_CONSP_REVAMP_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_KRES_FEED_INT", value.A1_NG_CONSP_KRES_FEED_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_KRES_FEED_INT_DIFF", value.A1_NG_CONSP_KRES_FEED_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_KRES_FEED", value.A1_NG_CONSP_KRES_FEED));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_ABURNER_INT", value.A1_NG_FUEL_ABURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_ABURNER_INT_DIF", value.A1_NG_FUEL_ABURNER_INT_DIF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_FUEL_ABURNER", value.A1_NG_FUEL_ABURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PROCESS_STEAM_KRES_INT", value.A1_PROCESS_STEAM_KRES_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PROCESS_STEAM_CONSP_KRES", value.A1_PROCESS_STEAM_CONSP_KRES));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_FALLBACK_RECEIPT", value.A1_FALLBACK_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_SPOT_ALLOC", value.A1_RLNG_SPOT_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_SPOT_RECPT", value.A1_RLNG_SPOT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_SPOT_MMBTU", value.A1_RLNG_SPOT_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_NG_CV", value.A1_AVG_NG_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAS_ENG_ALLOC", value.A1_SPOT_GAS_ENG_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_ENG_ALLOC", value.A1_RLNG_ENG_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PMT_NG_ENG_ALLOC", value.A1_PMT_NG_ENG_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_SPOT_ENG_ALLOC", value.A1_RLNG_SPOT_ENG_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NON_APM_ALLOC", value.A1_NON_APM_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NON_APM_RECPT", value.A1_NON_APM_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_RLNG_EXPORTT_UNIT2", value.A1_SPOT_RLNG_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RLNG_GAIL_EXPORTT_UNIT2", value.A1_RLNG_GAIL_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PMT_PSC_EXPORTT_UNIT2", value.A1_PMT_PSC_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PMT_APM_EXPORTT_UNIT2", value.A1_PMT_APM_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_APM_EXPORTT_UNIT2", value.A1_APM_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_LT_RLNG_FIRM_MMBTU", value.A1_GAIL_LT_RLNG_FIRM_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_LT_RLNG_FIRM_ALLOC", value.A1_GAIL_LT_RLNG_FIRM_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_LT_RLNG_FIRM_RECEIPT", value.A1_GAIL_LT_RLNG_FIRM_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_LT_RLNG_RE_MMBTU", value.A1_GAIL_LT_RLNG_RE_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_LT_RLNG_RE_ALLOC", value.A1_GAIL_LT_RLNG_RE_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_LT_RLNG_RE_RECEIPT", value.A1_GAIL_LT_RLNG_RE_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TRFR_UREA_SHIFT_A", value.A1_AMM_TRFR_UREA_SHIFT_A));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TRFR_UREA_SHIFT_B", value.A1_AMM_TRFR_UREA_SHIFT_B));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_CFG3_SPOT_GAS_ALLOC_ENG", value.A1_AMM_CFG3_SPOT_GAS_ALLOC_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_CFG3_SPOT_GAS_ALLOC_SM3", value.A1_AMM_CFG3_SPOT_GAS_ALLOC_SM3));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_CFG3_SPOT_GAS_RECEIPT", value.A1_AMM_CFG3_SPOT_GAS_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_BLOWER_CV", value.A1_AMM_BLOWER_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_COMPRESSER_A_CV", value.A1_AMM_COMPRESSER_A_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_COMPRESSER_B_CV", value.A1_AMM_COMPRESSER_B_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TRANS_PUMP_CV", value.A1_AMM_TRANS_PUMP_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TOT_MACH_RUN_HRS", value.A1_AMM_TOT_MACH_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_BLOWER", value.A1_AMM_BLOWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_COMPRESSER_A", value.A1_AMM_COMPRESSER_A));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_COMPRESSER_B", value.A1_AMM_COMPRESSER_B));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM_TRANS_PUMP", value.A1_AMM_TRANS_PUMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RECVFROM_AMM3_STOCK", value.A1_RECVFROM_AMM3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TFRTO_AMM3_STOCK", value.A1_TFRTO_AMM3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AMM3_LOGICAL_STOCK", value.A1_AMM3_LOGICAL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG5_MMBTU", value.A1_GAIL_RLNG5_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG5_ALLOC", value.A1_GAIL_RLNG5_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG5_RECEIPT", value.A1_GAIL_RLNG5_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG19_MMBTU", value.A1_GAIL_RLNG19_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG19_ALLOC", value.A1_GAIL_RLNG19_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG19_RECEIPT", value.A1_GAIL_RLNG19_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_KS_STEAM_INT", value.A1_KS_STEAM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_KS_STEAM_CONSP", value.A1_KS_STEAM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG3_MMBTU", value.A1_GAIL_RLNG3_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG3_ALLOC", value.A1_GAIL_RLNG3_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_GAIL_RLNG3_RECEIPT", value.A1_GAIL_RLNG3_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GSPSC_MMBTU", value.A1_SPOT_GSPSC_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GSPSC_ALLOC", value.A1_SPOT_GSPSC_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GSPSC_RECEIPT", value.A1_SPOT_GSPSC_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_IOCL_MMBTU", value.A1_SPOT_IOCL_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_IOCL_ALLOC", value.A1_SPOT_IOCL_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_IOCL_RECEIPT", value.A1_SPOT_IOCL_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAIL_MMBTU", value.A1_SPOT_GAIL_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAIL_ALLOC", value.A1_SPOT_GAIL_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SPOT_GAIL_RECEIPT", value.A1_SPOT_GAIL_RECEIPT));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
