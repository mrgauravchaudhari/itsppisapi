using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS006Repository
    {
        private readonly string _connectionString;
        public POS006Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS006Model MapToValue(SqlDataReader reader)
        {
            return new POS006Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (dynamic)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_NAP_TFR_TANK = reader["OU1_NAP_TFR_TANK"].ToString(),
                OU1_NAP_GT1_INT = (dynamic)reader["OU1_NAP_GT1_INT"],
                OU1_NAP_GT1_INT_DIFF = (dynamic)reader["OU1_NAP_GT1_INT_DIFF"],
                OU1_NAP_CONSP_GT = (dynamic)reader["OU1_NAP_CONSP_GT"],
                OU1_NAP_CONSP_GT1 = (dynamic)reader["OU1_NAP_CONSP_GT1"],
                OU1_NAP_GT2_INT = (dynamic)reader["OU1_NAP_GT2_INT"],
                OU1_NAP_GT2_INT_DIFF = (dynamic)reader["OU1_NAP_GT2_INT_DIFF"],
                OU1_NAP_CONSP_GT2 = (dynamic)reader["OU1_NAP_CONSP_GT2"],
                OU1_NAP_AB1_INT = (dynamic)reader["OU1_NAP_AB1_INT"],
                OU1_NAP_CONSP_AB = (dynamic)reader["OU1_NAP_CONSP_AB"],
                OU1_NAP_CONSP_AB1 = (dynamic)reader["OU1_NAP_CONSP_AB1"],
                OU1_NAP_AB2_INT = (dynamic)reader["OU1_NAP_AB2_INT"],
                OU1_NAP_CONSP_AB2 = (dynamic)reader["OU1_NAP_CONSP_AB2"],
                OU1_NAP_CONSP_SPG = (dynamic)reader["OU1_NAP_CONSP_SPG"],
                A_NAP_CONSP_AMM = (dynamic)reader["A_NAP_CONSP_AMM"],
                OU1_DAYTANK_LEVEL = (dynamic)reader["OU1_DAYTANK_LEVEL"],
                OU1_DAYTANK_MEAS_STOCK = (dynamic)reader["OU1_DAYTANK_MEAS_STOCK"],
                OU1_NAP_IMPORTF_UNIT2 = (dynamic)reader["OU1_NAP_IMPORTF_UNIT2"],
                OU1_DAYTANK_CALC_STOCK = (dynamic)reader["OU1_DAYTANK_CALC_STOCK"],
                OU1_DAYTANK_DIFF_PERCENT = (dynamic)reader["OU1_DAYTANK_DIFF_PERCENT"],
                OU1_NAP_STOCK = (dynamic)reader["OU1_NAP_STOCK"],
                OU1_TANK_A_NAP_LEVEL = (dynamic)reader["OU1_TANK_A_NAP_LEVEL"],
                OU1_TANK_A_WTR_LEVEL = (dynamic)reader["OU1_TANK_A_WTR_LEVEL"],
                OU1_TANK_A_TEMP = (dynamic)reader["OU1_TANK_A_TEMP"],
                OU1_TANK_A_DENSITY = (dynamic)reader["OU1_TANK_A_DENSITY"],
                OU1_TANK_A_STOCK = (dynamic)reader["OU1_TANK_A_STOCK"],
                OU1_TANK_B_NAP_LEVEL = (dynamic)reader["OU1_TANK_B_NAP_LEVEL"],
                OU1_TANK_B_WTR_LEVEL = (dynamic)reader["OU1_TANK_B_WTR_LEVEL"],
                OU1_TANK_B_TEMP = (dynamic)reader["OU1_TANK_B_TEMP"],
                OU1_TANK_B_DENSITY = (dynamic)reader["OU1_TANK_B_DENSITY"],
                OU1_TANK_B_STOCK = (dynamic)reader["OU1_TANK_B_STOCK"],
                OU1_TANK_C_NAP_LEVEL = (dynamic)reader["OU1_TANK_C_NAP_LEVEL"],
                OU1_TANK_C_WTR_LEVEL = (dynamic)reader["OU1_TANK_C_WTR_LEVEL"],
                OU1_TANK_C_TEMP = (dynamic)reader["OU1_TANK_C_TEMP"],
                OU1_TANK_C_DENSITY = (dynamic)reader["OU1_TANK_C_DENSITY"],
                OU1_TANK_C_STOCK = (dynamic)reader["OU1_TANK_C_STOCK"],
                OU1_TANK_D_NAP_LEVEL = (dynamic)reader["OU1_TANK_D_NAP_LEVEL"],
                OU1_TANK_D_WTR_LEVEL = (dynamic)reader["OU1_TANK_D_WTR_LEVEL"],
                OU1_TANK_D_TEMP = (dynamic)reader["OU1_TANK_D_TEMP"],
                OU1_TANK_D_DENSITY = (dynamic)reader["OU1_TANK_D_DENSITY"],
                OU1_TANK_D_STOCK = (dynamic)reader["OU1_TANK_D_STOCK"],
                OU1_SNT_NAP_LEVEL = (dynamic)reader["OU1_SNT_NAP_LEVEL"],
                OU1_SNT_WTR_LEVEL = (dynamic)reader["OU1_SNT_WTR_LEVEL"],
                OU1_SNT_TEMP = (dynamic)reader["OU1_SNT_TEMP"],
                OU1_SNT_DENSITY = (dynamic)reader["OU1_SNT_DENSITY"],
                OU1_SNT_STOCK = (dynamic)reader["OU1_SNT_STOCK"],
                OU1_NAP_TFR_TANK1_GPII = reader["OU1_NAP_TFR_TANK1_GPII"].ToString(),
                OU1_NAP_TFRT_DAYTANK_GPII = (dynamic)reader["OU1_NAP_TFRT_DAYTANK_GPII"],
                OU1_SNT_RECPT = (dynamic)reader["OU1_SNT_RECPT"],
                OU1_SNT_TFR = (dynamic)reader["OU1_SNT_TFR"],
                OU1_DAY_TANK_LEVEL_ACTL = (dynamic)reader["OU1_DAY_TANK_LEVEL_ACTL"],
                OU1_DAYTANK_MEAS_STOCK_ACTL = (dynamic)reader["OU1_DAYTANK_MEAS_STOCK_ACTL"],
                OU1_TANK_A_NAP_LEVEL_ACTL = (dynamic)reader["OU1_TANK_A_NAP_LEVEL_ACTL"],
                OU1_TANK_A_STOCK_ACTL = (dynamic)reader["OU1_TANK_A_STOCK_ACTL"],
                OU1_TANK_B_NAP_LEVEL_ACTL = (dynamic)reader["OU1_TANK_B_NAP_LEVEL_ACTL"],
                OU1_TANK_B_STOCK_ACTL = (dynamic)reader["OU1_TANK_B_STOCK_ACTL"],
                OU1_TANK_C_NAP_LEVEL_ACTL = (dynamic)reader["OU1_TANK_C_NAP_LEVEL_ACTL"],
                OU1_TANK_C_STOCK_ACTL = (dynamic)reader["OU1_TANK_C_STOCK_ACTL"],
                OU1_TANK_D_NAP_LEVEL_ACTL = (dynamic)reader["OU1_TANK_D_NAP_LEVEL_ACTL"],
                OU1_TANK_D_STOCK_ACTL = (dynamic)reader["OU1_TANK_D_STOCK_ACTL"],
                OU1_SNT_NAP_LEVEL_ACTL = (dynamic)reader["OU1_SNT_NAP_LEVEL_ACTL"],
                OU1_SNT_STOCK_ACTL = (dynamic)reader["OU1_SNT_STOCK_ACTL"],
                DIFF_GP2_ACTL = (dynamic)reader["DIFF_GP2_ACTL"],
                OU1_NAP_UNITTFR_TANK = reader["OU1_NAP_UNITTFR_TANK"].ToString(),
                OU1_NAP_UNITTFR_TO_TANK = reader["OU1_NAP_UNITTFR_TO_TANK"].ToString(),
                OU1_NAP_TFR_FOR_UNIT = reader["OU1_NAP_TFR_FOR_UNIT"].ToString(),
                OU1_TFRTANK_NAP_LEVEL_BFR = (dynamic)reader["OU1_TFRTANK_NAP_LEVEL_BFR"],
                OU1_TFRTANK_WTR_LEVEL_BFR = (dynamic)reader["OU1_TFRTANK_WTR_LEVEL_BFR"],
                OU1_TFRTANK_STOCK_BFR = (dynamic)reader["OU1_TFRTANK_STOCK_BFR"],
                OU1_TFRTANK_NAP_LEVEL_AFT = (dynamic)reader["OU1_TFRTANK_NAP_LEVEL_AFT"],
                OU1_TFRTANK_WTR_LEVEL_AFT = (dynamic)reader["OU1_TFRTANK_WTR_LEVEL_AFT"],
                OU1_TFRTANK_STOCK_AFT = (dynamic)reader["OU1_TFRTANK_STOCK_AFT"],

                OU1_NAP_TOT_RECEIPT = (dynamic)reader["OU1_NAP_TOT_RECEIPT"],
                OU1_NAP_CONSP_TOTAL = (dynamic)reader["OU1_NAP_CONSP_TOTAL"],
                OU1_NAP_CONSP_UNIT2 = (dynamic)reader["OU1_NAP_CONSP_UNIT2"],

                TXT_TOT_NAP_CONSP_GP1 = (dynamic)reader["TXT_TOT_NAP_CONSP_GP1"],
                TXT_RCPT_IOC = (dynamic)reader["TXT_RCPT_IOC"],
                TXT_NAP_TFRT_DT_GPII_DIFF = (dynamic)reader["TXT_NAP_TFRT_DT_GPII_DIFF"],
                TXT_NAP_IMPORTF_UNIT2 = (dynamic)reader["TXT_NAP_IMPORTF_UNIT2"],
                TXT_TOT_NAP_STK_GP1 = (dynamic)reader["TXT_TOT_NAP_STK_GP1"],
                TXT_TANK_A_WTR_LEVEL = (dynamic)reader["TXT_TANK_A_WTR_LEVEL"],
                TXT_TANK_A_TEMP = (dynamic)reader["TXT_TANK_A_TEMP"],
                TXT_TANK_A_DENSITY = (dynamic)reader["TXT_TANK_A_DENSITY"],
                TXT_TANK_B_WTR_LEVEL = (dynamic)reader["TXT_TANK_B_WTR_LEVEL"],
                TXT_TANK_B_TEMP = (dynamic)reader["TXT_TANK_B_TEMP"],
                TXT_TANK_B_DENSITY = (dynamic)reader["TXT_TANK_B_DENSITY"],
                TXT_TANK_C_WTR_LEVEL = (dynamic)reader["TXT_TANK_C_WTR_LEVEL"],
                TXT_TANK_C_TEMP = (dynamic)reader["TXT_TANK_C_TEMP"],
                TXT_TANK_C_DENSITY = (dynamic)reader["TXT_TANK_C_DENSITY"],
                TXT_TANK_D_WTR_LEVEL = (dynamic)reader["TXT_TANK_D_WTR_LEVEL"],
                TXT_TANK_D_TEMP = (dynamic)reader["TXT_TANK_D_TEMP"],
                TXT_TANK_D_DENSITY = (dynamic)reader["TXT_TANK_D_DENSITY"],
                TXT_SNT_WTR_LEVEL = (dynamic)reader["TXT_SNT_WTR_LEVEL"],
                TXT_SNT_TEMP = (dynamic)reader["TXT_SNT_TEMP"],
                TXT_SNT_DENSITY = (dynamic)reader["TXT_SNT_DENSITY"],
                TXT_TOT_NAP_ACTL_STK_CFCL = (dynamic)reader["TXT_TOT_NAP_ACTL_STK_CFCL"],
                TXT_TOT_NAP_STK_GP2 = (dynamic)reader["TXT_TOT_NAP_STK_GP2"],
                TXT_NAP_QTY_TFR = (dynamic)reader["TXT_NAP_QTY_TFR"],

                // ------------------PRV-----------------------------
                PRV_OU1_TRANS_DATE = reader["PRV_OU1_TRANS_DATE"].ToString(),
                PRV_OU1_NAP_TFR_TANK = (dynamic)reader["PRV_OU1_NAP_TFR_TANK"],
                PRV_OU1_NAP_GT1_INT = (dynamic)reader["PRV_OU1_NAP_GT1_INT"],
                PRV_OU1_NAP_GT1_INT_DIFF = (dynamic)reader["PRV_OU1_NAP_GT1_INT_DIFF"],
                PRV_OU1_NAP_CONSP_GT1 = (dynamic)reader["PRV_OU1_NAP_CONSP_GT1"],
                PRV_OU1_NAP_GT2_INT = (dynamic)reader["PRV_OU1_NAP_GT2_INT"],
                PRV_OU1_NAP_GT2_INT_DIFF = (dynamic)reader["PRV_OU1_NAP_GT2_INT_DIFF"],
                PRV_OU1_NAP_CONSP_GT2 = (dynamic)reader["PRV_OU1_NAP_CONSP_GT2"],
                PRV_OU1_NAP_AB1_INT = (dynamic)reader["PRV_OU1_NAP_AB1_INT"],
                PRV_OU1_NAP_CONSP_AB1 = (dynamic)reader["PRV_OU1_NAP_CONSP_AB1"],
                PRV_OU1_NAP_AB2_INT = (dynamic)reader["PRV_OU1_NAP_AB2_INT"],
                PRV_OU1_NAP_CONSP_AB2 = (dynamic)reader["PRV_OU1_NAP_CONSP_AB2"],
                PRV_OU1_NAP_CONSP_SPG = (dynamic)reader["PRV_OU1_NAP_CONSP_SPG"],
                PRV_A_NAP_CONSP_AMM = (dynamic)reader["PRV_A_NAP_CONSP_AMM"],
                PRV_OU1_DAYTANK_LEVEL = (dynamic)reader["PRV_OU1_DAYTANK_LEVEL"],
                PRV_OU1_DAYTANK_MEAS_STOCK = (dynamic)reader["PRV_OU1_DAYTANK_MEAS_STOCK"],
                PRV_OU1_NAP_IMPORTF_UNIT2 = (dynamic)reader["PRV_OU1_NAP_IMPORTF_UNIT2"],
                PRV_OU1_DAYTANK_CALC_STOCK = (dynamic)reader["PRV_OU1_DAYTANK_CALC_STOCK"],
                PRV_OU1_DAYTANK_DIFF_PERCENT = (dynamic)reader["PRV_OU1_DAYTANK_DIFF_PERCENT"],
                PRV_OU1_NAP_STOCK = (dynamic)reader["PRV_OU1_NAP_STOCK"],
                PRV_OU1_TANK_A_NAP_LEVEL = (dynamic)reader["PRV_OU1_TANK_A_NAP_LEVEL"],
                PRV_OU1_TANK_A_WTR_LEVEL = (dynamic)reader["PRV_OU1_TANK_A_WTR_LEVEL"],
                PRV_OU1_TANK_A_TEMP = (dynamic)reader["PRV_OU1_TANK_A_TEMP"],
                PRV_OU1_TANK_A_DENSITY = (dynamic)reader["PRV_OU1_TANK_A_DENSITY"],
                PRV_OU1_TANK_A_STOCK = (dynamic)reader["PRV_OU1_TANK_A_STOCK"],
                PRV_OU1_TANK_B_NAP_LEVEL = (dynamic)reader["PRV_OU1_TANK_B_NAP_LEVEL"],
                PRV_OU1_TANK_B_WTR_LEVEL = (dynamic)reader["PRV_OU1_TANK_B_WTR_LEVEL"],
                PRV_OU1_TANK_B_TEMP = (dynamic)reader["PRV_OU1_TANK_B_TEMP"],
                PRV_OU1_TANK_B_DENSITY = (dynamic)reader["PRV_OU1_TANK_B_DENSITY"],
                PRV_OU1_TANK_B_STOCK = (dynamic)reader["PRV_OU1_TANK_B_STOCK"],
                PRV_OU1_TANK_C_NAP_LEVEL = (dynamic)reader["PRV_OU1_TANK_C_NAP_LEVEL"],
                PRV_OU1_TANK_C_WTR_LEVEL = (dynamic)reader["PRV_OU1_TANK_C_WTR_LEVEL"],
                PRV_OU1_TANK_C_TEMP = (dynamic)reader["PRV_OU1_TANK_C_TEMP"],
                PRV_OU1_TANK_C_DENSITY = (dynamic)reader["PRV_OU1_TANK_C_DENSITY"],
                PRV_OU1_TANK_C_STOCK = (dynamic)reader["PRV_OU1_TANK_C_STOCK"],
                PRV_OU1_TANK_D_NAP_LEVEL = (dynamic)reader["PRV_OU1_TANK_D_NAP_LEVEL"],
                PRV_OU1_TANK_D_WTR_LEVEL = (dynamic)reader["PRV_OU1_TANK_D_WTR_LEVEL"],
                PRV_OU1_TANK_D_TEMP = (dynamic)reader["PRV_OU1_TANK_D_TEMP"],
                PRV_OU1_TANK_D_DENSITY = (dynamic)reader["PRV_OU1_TANK_D_DENSITY"],
                PRV_OU1_TANK_D_STOCK = (dynamic)reader["PRV_OU1_TANK_D_STOCK"],
                PRV_OU1_SNT_NAP_LEVEL = (dynamic)reader["PRV_OU1_SNT_NAP_LEVEL"],
                PRV_OU1_SNT_WTR_LEVEL = (dynamic)reader["PRV_OU1_SNT_WTR_LEVEL"],
                PRV_OU1_SNT_TEMP = (dynamic)reader["PRV_OU1_SNT_TEMP"],
                PRV_OU1_SNT_DENSITY = (dynamic)reader["PRV_OU1_SNT_DENSITY"],
                PRV_OU1_SNT_STOCK = (dynamic)reader["PRV_OU1_SNT_STOCK"],
                PRV_OU1_NAP_TFR_TANK1_GPII = reader["PRV_OU1_NAP_TFR_TANK1_GPII"].ToString(),
                PRV_OU1_NAP_TFRT_DAYTANK_GPII = (dynamic)reader["PRV_OU1_NAP_TFRT_DAYTANK_GPII"],
                PRV_OU1_SNT_RECPT = (dynamic)reader["PRV_OU1_SNT_RECPT"],
                PRV_OU1_SNT_TFR = (dynamic)reader["PRV_OU1_SNT_TFR"],
                PRV_OU1_DAY_TANK_LEVEL_ACTL = (dynamic)reader["PRV_OU1_DAY_TANK_LEVEL_ACTL"],
                PRV_OU1_DAYTANK_MEAS_STOCK_ACTL = (dynamic)reader["PRV_OU1_DAYTANK_MEAS_STOCK_ACTL"],
                PRV_OU1_TANK_A_NAP_LEVEL_ACTL = (dynamic)reader["PRV_OU1_TANK_A_NAP_LEVEL_ACTL"],
                PRV_OU1_TANK_A_STOCK_ACTL = (dynamic)reader["PRV_OU1_TANK_A_STOCK_ACTL"],
                PRV_OU1_TANK_B_NAP_LEVEL_ACTL = (dynamic)reader["PRV_OU1_TANK_B_NAP_LEVEL_ACTL"],
                PRV_OU1_TANK_B_STOCK_ACTL = (dynamic)reader["PRV_OU1_TANK_B_STOCK_ACTL"],
                PRV_OU1_TANK_C_NAP_LEVEL_ACTL = (dynamic)reader["PRV_OU1_TANK_C_NAP_LEVEL_ACTL"],
                PRV_OU1_TANK_C_STOCK_ACTL = (dynamic)reader["PRV_OU1_TANK_C_STOCK_ACTL"],
                PRV_OU1_TANK_D_NAP_LEVEL_ACTL = (dynamic)reader["PRV_OU1_TANK_D_NAP_LEVEL_ACTL"],
                PRV_OU1_TANK_D_STOCK_ACTL = (dynamic)reader["PRV_OU1_TANK_D_STOCK_ACTL"],
                PRV_OU1_SNT_NAP_LEVEL_ACTL = (dynamic)reader["PRV_OU1_SNT_NAP_LEVEL_ACTL"],
                PRV_OU1_SNT_STOCK_ACTL = (dynamic)reader["PRV_OU1_SNT_STOCK_ACTL"],
                PRV_OU1_NAP_UNITTFR_TANK = reader["PRV_OU1_NAP_UNITTFR_TANK"].ToString(),
                PRV_OU1_NAP_UNITTFR_TO_TANK = reader["PRV_OU1_NAP_UNITTFR_TO_TANK"].ToString(),
                PRV_OU1_NAP_TFR_FOR_UNIT = reader["PRV_OU1_NAP_TFR_FOR_UNIT"].ToString(),
                PRV_OU1_TFRTANK_NAP_LEVEL_BFR = (dynamic)reader["PRV_OU1_TFRTANK_NAP_LEVEL_BFR"],
                PRV_OU1_TFRTANK_WTR_LEVEL_BFR = (dynamic)reader["PRV_OU1_TFRTANK_WTR_LEVEL_BFR"],
                PRV_OU1_TFRTANK_STOCK_BFR = (dynamic)reader["PRV_OU1_TFRTANK_STOCK_BFR"],
                PRV_OU1_TFRTANK_NAP_LEVEL_AFT = (dynamic)reader["PRV_OU1_TFRTANK_NAP_LEVEL_AFT"],
                PRV_OU1_TFRTANK_WTR_LEVEL_AFT = (dynamic)reader["PRV_OU1_TFRTANK_WTR_LEVEL_AFT"],
                PRV_OU1_TFRTANK_STOCK_AFT = (dynamic)reader["PRV_OU1_TFRTANK_STOCK_AFT"],

                // ------------------DV-----------------------------
                parm_nap_numeric_const = (dynamic)reader["parm_nap_numeric_const"],
                PARM_TANK_A_DENSITY15 = (dynamic)reader["PARM_TANK_A_DENSITY15"],
                PARM_TANK_B_DENSITY15 = (dynamic)reader["PARM_TANK_B_DENSITY15"],
                PARM_TANK_C_DENSITY15 = (dynamic)reader["PARM_TANK_C_DENSITY15"],
                PARM_TANK_D_DENSITY15 = (dynamic)reader["PARM_TANK_D_DENSITY15"],
                PARM_SNT_DENSITY15 = (dynamic)reader["PARM_SNT_DENSITY15"],
                PARM_TANK_A_DENSITY30 = (dynamic)reader["PARM_TANK_A_DENSITY30"],
                PARM_TANK_B_DENSITY30 = (dynamic)reader["PARM_TANK_B_DENSITY30"],
                PARM_TANK_C_DENSITY30 = (dynamic)reader["PARM_TANK_C_DENSITY30"],
                PARM_TANK_D_DENSITY30 = (dynamic)reader["PARM_TANK_D_DENSITY30"],
                PARM_SNT_DENSITY30 = (dynamic)reader["PARM_SNT_DENSITY30"],
                parm_mf_day_tank_stock = (dynamic)reader["parm_mf_day_tank_stock"],
                parm_tank_a_dead_stock = (dynamic)reader["parm_tank_a_dead_stock"],
                parm_tank_b_dead_stock = (dynamic)reader["parm_tank_b_dead_stock"],
                parm_tank_c_dead_stock = (dynamic)reader["parm_tank_c_dead_stock"],
                parm_tank_d_dead_stock = (dynamic)reader["parm_tank_d_dead_stock"],
                parm_tank_snt_dead_stock = (dynamic)reader["parm_tank_snt_dead_stock"],
                parm_tank_a_calib_const = (dynamic)reader["parm_tank_a_calib_const"],
                parm_tank_b_calib_const = (dynamic)reader["parm_tank_b_calib_const"],
                parm_tank_c_calib_const = (dynamic)reader["parm_tank_c_calib_const"],
                parm_tank_d_calib_const = (dynamic)reader["parm_tank_d_calib_const"],
                parm_tank_snt_calib_const = (dynamic)reader["parm_tank_snt_calib_const"],
                parm_tank_a_vol_pm = (dynamic)reader["parm_tank_a_vol_pm"],
                parm_tank_b_vol_pm = (dynamic)reader["parm_tank_b_vol_pm"],
                parm_tank_c_vol_pm = (dynamic)reader["parm_tank_c_vol_pm"],
                parm_tank_d_vol_pm = (dynamic)reader["parm_tank_d_vol_pm"],
                parm_tank_snt_vol_pm = (dynamic)reader["parm_tank_snt_vol_pm"],
                parm_nap_cv = (dynamic)reader["parm_nap_cv"],
                parm_tank_a_roof_wt = (dynamic)reader["parm_tank_a_roof_wt"],
                parm_tank_b_roof_wt = (dynamic)reader["parm_tank_b_roof_wt"],
                parm_tank_c_roof_wt = (dynamic)reader["parm_tank_c_roof_wt"],
                parm_tank_d_roof_wt = (dynamic)reader["parm_tank_d_roof_wt"],
                parm_snt_stock = (dynamic)reader["parm_snt_stock"],
                lvch_unit_G_101A = reader["lvch_unit_G_101A"].ToString(),
                lvch_unit_G_6001A = reader["lvch_unit_G_6001A"].ToString(),
                lvch_unit_G_6001B = reader["lvch_unit_G_6001B"].ToString(),
                lvch_unit_G_6001C = reader["lvch_unit_G_6001C"].ToString(),
                parm_nap_stock = (dynamic)reader["parm_nap_stock"],
                parm_tank_c_stock = (dynamic)reader["parm_tank_c_stock"],
            };
        }

        public async Task<POS006Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_NAP_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS006Model response = null;
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

        public async Task saveData(POS006SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_NAP_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_IMPORTF_UNIT2_INT", value.OU1_NAP_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_IMPORTF_UNIT2_INT_DIFF", value.OU1_NAP_IMPORTF_UNIT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_IMPORTF_UNIT2", value.OU1_NAP_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TOT_RECEIPT", value.OU1_NAP_TOT_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GT1_INT", value.OU1_NAP_GT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GT2_INT", value.OU1_NAP_GT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GT1_INT_DIFF", value.OU1_NAP_GT1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GT2_INT_DIFF", value.OU1_NAP_GT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_AB1_INT", value.OU1_NAP_AB1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_AB1", value.OU1_NAP_CONSP_AB1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_AB2_INT", value.OU1_NAP_AB2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_AB2", value.OU1_NAP_CONSP_AB2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_GT1", value.OU1_NAP_CONSP_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_GT2", value.OU1_NAP_CONSP_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_AB", value.OU1_NAP_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_GT", value.OU1_NAP_CONSP_GT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_SPG", value.OU1_NAP_CONSP_SPG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_UNIT2_INT", value.OU1_NAP_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_UNIT2_INT_DIFF", value.OU1_NAP_UNIT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_UNIT2", value.OU1_NAP_CONSP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CONSP_TOTAL", value.OU1_NAP_CONSP_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GROSS_CV", value.OU1_NAP_GROSS_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_NET_CV", value.OU1_NAP_NET_CV));
                    // cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_SHORTAGE_FLG", value.OU1_NAP_SHORTAGE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFR_TANK", value.OU1_NAP_TFR_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_RECPT", value.OU1_SNT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_TFR", value.OU1_SNT_TFR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_NAP_LEVEL", value.OU1_SNT_NAP_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_WTR_LEVEL", value.OU1_SNT_WTR_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_STOCK", value.OU1_SNT_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DAYTANK_LEVEL", value.OU1_DAYTANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DAYTANK_MEAS_STOCK", value.OU1_DAYTANK_MEAS_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DAYTANK_CALC_STOCK", value.OU1_DAYTANK_CALC_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DAYTANK_DIFF_PERCENT", value.OU1_DAYTANK_DIFF_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_NAP_LEVEL", value.OU1_TANK_A_NAP_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_WTR_LEVEL", value.OU1_TANK_A_WTR_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_STOCK", value.OU1_TANK_A_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_NAP_LEVEL", value.OU1_TANK_B_NAP_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_WTR_LEVEL", value.OU1_TANK_B_WTR_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_STOCK", value.OU1_TANK_B_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_NAP_LEVEL", value.OU1_TANK_C_NAP_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_WTR_LEVEL", value.OU1_TANK_C_WTR_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_STOCK", value.OU1_TANK_C_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_NAP_LEVEL", value.OU1_TANK_D_NAP_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_WTR_LEVEL", value.OU1_TANK_D_WTR_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_STOCK", value.OU1_TANK_D_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_STOCK", value.OU1_NAP_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GROSS_CV_GP2", value.OU1_NAP_GROSS_CV_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_NET_CV_GP2", value.OU1_NAP_NET_CV_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_NAP_LEVEL_ACTL", value.OU1_SNT_NAP_LEVEL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DAY_TANK_LEVEL_ACTL", value.OU1_DAY_TANK_LEVEL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_NAP_LEVEL_ACTL", value.OU1_TANK_A_NAP_LEVEL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_TEMP", value.OU1_TANK_A_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_TEMP", value.OU1_TANK_B_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_NAP_LEVEL_ACTL", value.OU1_TANK_B_NAP_LEVEL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_TEMP", value.OU1_TANK_C_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_TEMP", value.OU1_TANK_D_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_TEMP", value.OU1_SNT_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_DENSITY", value.OU1_TANK_A_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_DENSITY", value.OU1_TANK_B_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_DENSITY", value.OU1_TANK_C_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_DENSITY", value.OU1_TANK_D_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_NAP_LEVEL_ACTL", value.OU1_TANK_C_NAP_LEVEL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_DENSITY", value.OU1_SNT_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_NAP_LEVEL_ACTL", value.OU1_TANK_D_NAP_LEVEL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_UNITTFR_TANK", value.OU1_NAP_UNITTFR_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TFRTANK_NAP_LEVEL_BFR", value.OU1_TFRTANK_NAP_LEVEL_BFR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TFRTANK_WTR_LEVEL_BFR", value.OU1_TFRTANK_WTR_LEVEL_BFR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TFRTANK_STOCK_BFR", value.OU1_TFRTANK_STOCK_BFR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TFRTANK_NAP_LEVEL_AFT", value.OU1_TFRTANK_NAP_LEVEL_AFT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TFRTANK_WTR_LEVEL_AFT", value.OU1_TFRTANK_WTR_LEVEL_AFT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TFRTANK_STOCK_AFT", value.OU1_TFRTANK_STOCK_AFT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFR_FOR_UNIT", value.OU1_NAP_TFR_FOR_UNIT));
                    // cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFR_TANK_UNIT2", value.OU1_NAP_TFR_TANK_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_A_STOCK_ACTL", value.OU1_TANK_A_STOCK_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_B_STOCK_ACTL", value.OU1_TANK_B_STOCK_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_C_STOCK_ACTL", value.OU1_TANK_C_STOCK_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_D_STOCK_ACTL", value.OU1_TANK_D_STOCK_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SNT_STOCK_ACTL", value.OU1_SNT_STOCK_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFR_TANK1_GPII", value.OU1_NAP_TFR_TANK1_GPII));
                    // cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFR_TANK2_GPII", value.OU1_NAP_TFR_TANK2_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFRT_DAYTANK_GPII", value.OU1_NAP_TFRT_DAYTANK_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_UNITTFR_TO_TANK", value.OU1_NAP_UNITTFR_TO_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOT_GP2_NAP_STK", value.OU1_TOT_GP2_NAP_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOT_NAP_STOCK_CFCL", value.OU1_TOT_NAP_STOCK_CFCL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DAYTANK_MEAS_STOCK_ACTL", value.OU1_DAYTANK_MEAS_STOCK_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFRT_DT_GPII_CALC", value.OU1_NAP_TFRT_DT_GPII_CALC));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFRT_DT_GPII_DIFF", value.OU1_NAP_TFRT_DT_GPII_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_QTR_CV_GPII", value.OU1_NAP_QTR_CV_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_QTR_CV", value.OU1_NAP_QTR_CV));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
