using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS007Repository
    {
        private readonly string _connectionString;
        public POS007Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS007Model MapToValue(SqlDataReader reader)
        {
            return new POS007Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_NPIT_INT = (decimal)reader["OU1_NPIT_INT"],
                OU1_NPIT_INT_DIFF = (decimal)reader["OU1_NPIT_INT_DIFF"],
                OU1_NPIT_NEW_INT = (decimal)reader["OU1_NPIT_NEW_INT"],
                OU1_NPIT_NEW_INT_DIFF = (decimal)reader["OU1_NPIT_NEW_INT_DIFF"],
                OU1_ACT_BD_UNIT1_INT = (decimal)reader["OU1_ACT_BD_UNIT1_INT"],
                OU1_NPIT_INT_DIFF_TOTAL = (decimal)reader["OU1_NPIT_INT_DIFF_TOTAL"],
                OU1_UCT_BD_UNIT1_INT = (decimal)reader["OU1_UCT_BD_UNIT1_INT"],
                OU1_ACT_BD_ETP = (decimal)reader["OU1_ACT_BD_ETP"],
                OU1_UCT_BD_ETP = (decimal)reader["OU1_UCT_BD_ETP"],
                OU1_KSR_INT = (decimal)reader["OU1_KSR_INT"],
                OU1_KSR_INT_DIFF = (decimal)reader["OU1_KSR_INT_DIFF"],
                OU1_KSR = (decimal)reader["OU1_KSR"],
                OU1_EFFL_HP_TO_GB_INT = (decimal)reader["OU1_EFFL_HP_TO_GB_INT"],
                OU1_EFFL_HP_TO_GB_INT_DIFF = (decimal)reader["OU1_EFFL_HP_TO_GB_INT_DIFF"],
                OU1_EFFL_HP_TO_GB = (decimal)reader["OU1_EFFL_HP_TO_GB"],
                OU1_OILY_EFFL_INT = (decimal)reader["OU1_OILY_EFFL_INT"],
                OU1_OILY_EFFL_INT_DIFF = (decimal)reader["OU1_OILY_EFFL_INT_DIFF"],
                OU1_OILY_EFFL_ETP = (decimal)reader["OU1_OILY_EFFL_ETP"],
                OU1_ACT_BW_ETP = (decimal)reader["OU1_ACT_BW_ETP"],
                OU1_UCT_BW_ETP = (decimal)reader["OU1_UCT_BW_ETP"],
                OU1_ACT_BD = (decimal)reader["OU1_ACT_BD"],
                OU1_UCT_BD = (decimal)reader["OU1_UCT_BD"],
                OU1_OIL_WATER_EFFL_ETP = (decimal)reader["OU1_OIL_WATER_EFFL_ETP"],
                OU1_EFFL_TO_GB = (decimal)reader["OU1_EFFL_TO_GB"],
                OU1_TOTAL_HP_CONSP = (decimal)reader["OU1_TOTAL_HP_CONSP"],
                OU1_TOT_EFF_FRM_ETP = (decimal)reader["OU1_TOT_EFF_FRM_ETP"],
                OU1_HP_EAST_LEVEL = (decimal)reader["OU1_HP_EAST_LEVEL"],
                OU1_HP_EAST_STOCK = (decimal)reader["OU1_HP_EAST_STOCK"],
                OU1_HP_WEST_LEVEL = (decimal)reader["OU1_HP_WEST_LEVEL"],
                OU1_HP_WEST_STOCK = (decimal)reader["OU1_HP_WEST_STOCK"],
                OU1_500PIT_GEN = (decimal)reader["OU1_500PIT_GEN"],
                TXT_EFFL_FROM_100M3 = (decimal)reader["TXT_EFFL_FROM_100M3"],
                OU1_HP_RECIPT_ETP = (decimal)reader["OU1_HP_RECIPT_ETP"],
                OU1_BAGG_GEN = (decimal)reader["OU1_BAGG_GEN"],
                OU1_TOTAL_HP_RECIPT = (decimal)reader["OU1_TOTAL_HP_RECIPT"],
                OU1_HP_DISTRIBUTION_KSR = (decimal)reader["OU1_HP_DISTRIBUTION_KSR"],
                OU1_HP_DISTRIBUTION_GB = (decimal)reader["OU1_HP_DISTRIBUTION_GB"],
                OU1_EFFL_NET_DISCHARGE = (decimal)reader["OU1_EFFL_NET_DISCHARGE"],
                OU1_AVG_HP_DISTRIBUTION_KSR = (decimal)reader["OU1_AVG_HP_DISTRIBUTION_KSR"],
                OU1_AVG_HP_DISTRIBUTION_GB = (decimal)reader["OU1_AVG_HP_DISTRIBUTION_GB"],
                OU1_GB_DISTRIBUTION_ETP = (decimal)reader["OU1_GB_DISTRIBUTION_ETP"],
                OU1_GB_DISTRIBUTION_HP = (decimal)reader["OU1_GB_DISTRIBUTION_HP"],
                OU1_FROM_STP = (decimal)reader["OU1_FROM_STP"],
                OU1_SUM_GB_DISTRIBUTION = (decimal)reader["OU1_SUM_GB_DISTRIBUTION"],
                OU1_STP_EFFL_RECYCLED = (decimal)reader["OU1_STP_EFFL_RECYCLED"],
                OU1_CLEAR_RATE = (decimal)reader["OU1_CLEAR_RATE"],
                OU1_OILY_SLUDGE = (decimal)reader["OU1_OILY_SLUDGE"],
                OU1_WPT = (decimal)reader["OU1_WPT"],
                OU1_NEW_STP = (decimal)reader["OU1_NEW_STP"],
                OU1_OLD_STP = (decimal)reader["OU1_OLD_STP"],
                OU1_STP = (decimal)reader["OU1_STP"],
                OU1_50PIT_GEN = (decimal)reader["OU1_50PIT_GEN"],
                OU1_EFFL_FROM_100M3 = (decimal)reader["OU1_EFFL_FROM_100M3"],
                OU1_EFFL_RECYCLE_100M3 = (decimal)reader["OU1_EFFL_RECYCLE_100M3"],
                OU1_OLD_STP_INT = (decimal)reader["OU1_OLD_STP_INT"],
                OU1_OLD_STP_INPUT = (decimal)reader["OU1_OLD_STP_INPUT"],
                OU1_NEW_STP_INT = (decimal)reader["OU1_NEW_STP_INT"],
                OU1_NEW_STP_INPUT = (decimal)reader["OU1_NEW_STP_INPUT"],
                OU1_STP_INPUT_TOT = (decimal)reader["OU1_STP_INPUT_TOT"],
                TXT_FROM_STP = (decimal)reader["TXT_FROM_STP"],
                OU1_STP_DISCHARGE_RECYCLED = (decimal)reader["OU1_STP_DISCHARGE_RECYCLED"],

                // ------------------PRV-----------------------------
                PRV_OU_TRANS_DATE = reader["PRV_OU_TRANS_DATE"].ToString(),
                PRV_OU_NPIT_INT = (decimal)reader["PRV_OU_NPIT_INT"],
                PRV_OU_NPIT_NEW_INT = (decimal)reader["PRV_OU_NPIT_NEW_INT"],
                PRV_OU_ACT_BD_UNIT1_INT = (decimal)reader["PRV_OU_ACT_BD_UNIT1_INT"],
                PRV_OU_UCT_BD_UNIT1_INT = (decimal)reader["PRV_OU_UCT_BD_UNIT1_INT"],
                PRV_OU_KSR_INT = (decimal)reader["PRV_OU_KSR_INT"],
                PRV_OU_EFFL_HP_TO_GB_INT = (decimal)reader["PRV_OU_EFFL_HP_TO_GB_INT"],
                PRV_OU_OILY_EFFL_INT = (decimal)reader["PRV_OU_OILY_EFFL_INT"],
                PRV_OU_HP_EAST_LEVEL = (decimal)reader["PRV_OU_HP_EAST_LEVEL"],
                PRV_OU_HP_WEST_LEVEL = (decimal)reader["PRV_OU_HP_WEST_LEVEL"],
                PRV_OU_500PIT_GEN = (decimal)reader["PRV_OU_500PIT_GEN"],
                PRV_OU_CLEAR_RATE = (decimal)reader["PRV_OU_CLEAR_RATE"],
                PRV_OU_OILY_SLUDGE = (decimal)reader["PRV_OU_OILY_SLUDGE"],
                PRV_OU_WPT = (decimal)reader["PRV_OU_WPT"],
                PRV_OU_NEW_STP = (decimal)reader["PRV_OU_NEW_STP"],
                PRV_OU_STP = (decimal)reader["PRV_OU_STP"],
                PRV_OU_50PIT_GEN = (decimal)reader["PRV_OU_50PIT_GEN"],
                PRV_OU_EFFL_RECYCLE_100M3 = (decimal)reader["PRV_OU_EFFL_RECYCLE_100M3"],
                PRV_OU_OLD_STP_INT = (decimal)reader["PRV_OU_OLD_STP_INT"],
                PRV_OU_NEW_STP_INT = (decimal)reader["PRV_OU_NEW_STP_INT"],
                PRV_OU_STP_DISCHARGE_RECYCLED = (decimal)reader["PRV_OU_STP_DISCHARGE_RECYCLED"],

                // ------------------DV-----------------------------
                parm_npit_etp = (decimal)reader["parm_npit_etp"],
                parm_hp_etp = (decimal)reader["parm_hp_etp"],
                parm_ksr_etp = (decimal)reader["parm_ksr_etp"],
                parm_p822_ph_etp = (decimal)reader["parm_p822_ph_etp"],
                parm_p823_ph_etp = (decimal)reader["parm_p823_ph_etp"],
                parm_poily_ph_etp = (decimal)reader["parm_poily_ph_etp"],
                parm_p50pita_ph_etp = (decimal)reader["parm_p50pita_ph_etp"],
                parm_p50pitb_ph_etp = (decimal)reader["parm_p50pitb_ph_etp"],
                parm_p50pitc_ph_etp = (decimal)reader["parm_p50pitc_ph_etp"],
                parm_p50pitd_ph_etp = (decimal)reader["parm_p50pitd_ph_etp"],
                parm_p500pita_ph_etp = (decimal)reader["parm_p500pita_ph_etp"],
                parm_p500pitb_ph_etp = (decimal)reader["parm_p500pitb_ph_etp"],
                parm_p500pitc_ph_etp = (decimal)reader["parm_p500pitc_ph_etp"],
                parm_p500pitd_ph_etp = (decimal)reader["parm_p500pitd_ph_etp"],
                parm_p500pite_ph_etp = (decimal)reader["parm_p500pite_ph_etp"],
                parm_p500pitf_ph_etp = (decimal)reader["parm_p500pitf_ph_etp"],
                parm_pstpa_ph_etp = (decimal)reader["parm_pstpa_ph_etp"],
                parm_pstpb_ph_etp = (decimal)reader["parm_pstpb_ph_etp"],
                parm_pstpc_ph_etp = (decimal)reader["parm_pstpc_ph_etp"],
                parm_pstpd_ph_etp = (decimal)reader["parm_pstpd_ph_etp"],
                PARM_BAGG_EASTA_PH = (decimal)reader["PARM_BAGG_EASTA_PH"],
                PARM_BAGG_EASTB_PH = (decimal)reader["PARM_BAGG_EASTB_PH"],
                PARM_BAGG_WESTA_PH = (decimal)reader["PARM_BAGG_WESTA_PH"],
                PARM_BAGG_WESTB_PH = (decimal)reader["PARM_BAGG_WESTB_PH"],
                parm_100m3_old_pump_ph_etp = (decimal)reader["parm_100m3_old_pump_ph_etp"],
                parm_p6752a_ph_etp = (decimal)reader["parm_p6752a_ph_etp"],
                parm_p6752b_ph_etp = (decimal)reader["parm_p6752b_ph_etp"],
                parm_p6752c_ph_etp = (decimal)reader["parm_p6752c_ph_etp"],
                parm_p6751pita_ph_etp = (decimal)reader["parm_p6751pita_ph_etp"],
                parm_p6751pitb_ph_etp = (decimal)reader["parm_p6751pitb_ph_etp"],
                parm_p6751pitc_ph_etp = (decimal)reader["parm_p6751pitc_ph_etp"],
                parm_effl_recycle_ph_stp = (decimal)reader["parm_effl_recycle_ph_stp"],
                PARM_G_MF_HP_TO_GB = (decimal)reader["PARM_G_MF_HP_TO_GB"],
                PARM_G_MF_OIL_EFFL_ETP = (decimal)reader["PARM_G_MF_OIL_EFFL_ETP"],
                parm_p822_run_hrs = (decimal)reader["parm_p822_run_hrs"],
                parm_p823_run_hrs = (decimal)reader["parm_p823_run_hrs"],
                OU1_RW_CONSP_DILUTION = (decimal)reader["OU1_RW_CONSP_DILUTION"],
                OU1_FW_CONSP_BW = (decimal)reader["OU1_FW_CONSP_BW"],
                parm_hp_stock = (decimal)reader["parm_hp_stock"],
                parm_hp_east_stock = (decimal)reader["parm_hp_east_stock"],
                parm_hp_west_stock = (decimal)reader["parm_hp_west_stock"],
                PARM_BAGGEA_RUN_HRS_P50_EASTA = (decimal)reader["PARM_BAGGEA_RUN_HRS_P50_EASTA"],
                PARM_BAGGEB_RUN_HRS_P50_EASTB = (decimal)reader["PARM_BAGGEB_RUN_HRS_P50_EASTB"],
                PARM_BAGGWA_RUN_HRS_P50_WESTA = (decimal)reader["PARM_BAGGWA_RUN_HRS_P50_WESTA"],
                PARM_BAGGWB_RUN_HRS_P50_WESTB = (decimal)reader["PARM_BAGGWB_RUN_HRS_P50_WESTB"],
                A_TOTAL_BLOWDOWN = (decimal)reader["A_TOTAL_BLOWDOWN"],
                PARM_BAGGEA_RUN_HRS_P301B = (decimal)reader["PARM_BAGGEA_RUN_HRS_P301B"],
                PARM_BAGGEB_RUN_HRS_P301B = (decimal)reader["PARM_BAGGEB_RUN_HRS_P301B"],
                PARM_BAGGWA_RUN_HRS_P301C = (decimal)reader["PARM_BAGGWA_RUN_HRS_P301C"],
                PARM_BAGGWB_RUN_HRS_P301D = (decimal)reader["PARM_BAGGWB_RUN_HRS_P301D"],
                parm_effl_recycle_pump_run_hrs = (decimal)reader["parm_effl_recycle_pump_run_hrs"],
                ou1_hp_stock = (decimal)reader["ou1_hp_stock"],
            };
        }

        public async Task<POS007Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_EFFL_GENERATION", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS007Model response = null;
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

        public async Task saveData(POS007SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_EFFL_GENERATION", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NPIT_INT", value.OU1_NPIT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NPIT_INT_DIFF", value.OU1_NPIT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NPIT_ETP", value.OU1_NPIT_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_BD_ETP", value.OU1_ACT_BD_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_BD_ETP", value.OU1_UCT_BD_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HP_EAST_LEVEL", value.OU1_HP_EAST_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HP_EAST_STOCK", value.OU1_HP_EAST_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HP_WEST_LEVEL", value.OU1_HP_WEST_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HP_WEST_STOCK", value.OU1_HP_WEST_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KSR_INT", value.OU1_KSR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KSR_INT_DIFF", value.OU1_KSR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TO_KSR", value.OU1_TO_KSR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_BW_ETP", value.OU1_ACT_BW_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_BW_ETP", value.OU1_UCT_BW_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OILYWTR_RUNHRS", value.OU1_OILYWTR_RUNHRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OILY_EFFL_ETP", value.OU1_OILY_EFFL_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_EFFL_GEN", value.OU1_TOTAL_EFFL_GEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_50PIT_GEN", value.OU1_50PIT_GEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_500PIT_GEN", value.OU1_500PIT_GEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_HP_CONSP", value.OU1_TOTAL_HP_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HP_STOCK", value.OU1_HP_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_NET_DISCHARGE", value.OU1_EFFL_NET_DISCHARGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FROM_HTP", value.OU1_FROM_HTP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FROM_STP", value.OU1_FROM_STP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLEAR_RATE", value.OU1_CLEAR_RATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OILY_SLUDGE", value.OU1_OILY_SLUDGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WPT", value.OU1_WPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STP", value.OU1_STP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BAGG_GEN", value.OU1_BAGG_GEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NPIT_NEW_INT", value.OU1_NPIT_NEW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NPIT_NEW_INT_DIFF", value.OU1_NPIT_NEW_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_BD_UNIT1_INT", value.OU1_ACT_BD_UNIT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_BD_UNIT1_INT", value.OU1_UCT_BD_UNIT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_TO_GB", value.OU1_EFFL_TO_GB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_STP", value.OU1_NEW_STP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_FROM_100M3", value.OU1_EFFL_FROM_100M3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_RECYCLE_100M3", value.OU1_EFFL_RECYCLE_100M3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STP_DISCHARGE_RECYCLED", value.OU1_STP_DISCHARGE_RECYCLED));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STP_EFFL_RECYCLED", value.OU1_STP_EFFL_RECYCLED));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_STP_INT", value.OU1_OLD_STP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_STP_INPUT", value.OU1_OLD_STP_INPUT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_STP_INT", value.OU1_NEW_STP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_STP_INPUT", value.OU1_NEW_STP_INPUT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STP_INPUT_TOT", value.OU1_STP_INPUT_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_HP_TO_GB_INT", value.OU1_EFFL_HP_TO_GB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_HP_TO_GB_INT_DIFF", value.OU1_EFFL_HP_TO_GB_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OILY_EFFL_INT", value.OU1_OILY_EFFL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OILY_EFFL_INT_DIFF", value.OU1_OILY_EFFL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_HP_TO_GB", value.OU1_EFFL_HP_TO_GB));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
