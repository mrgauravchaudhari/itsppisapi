using itsppisapi.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS301Repository
    {
        private readonly string _connectionString;
        public PUS301Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        // Put Data By Transaction Date 
        public async Task<PUS301Model> put(TransactionDateBtnDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_UR3_GET_PPT_UR3_UREA_DETAILS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", data.Btn));
                    PUS301Model response = null;
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

        // get DV Data By Transaction Date
        public async Task<PUS301DVModel> putDV(TransactionDateDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_UR3_GET_PPT_UR3_UREA_DETAILS_DV]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.TransactionDate));
                    PUS301DVModel response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue2(reader);
                        }
                    }
                    return response;
                }
            }
        }

        // Save Data
        public async Task save(PUS301SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_UR3_SAVE_PPT_UR3_UREA_DETAILS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_TDATE", value.TDATE));

                    // -------------PPT_UR3_MACHINERY_RUNNING_HOUR-------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_AMM_FEED_PUMP_A_INT", value.U3_MRH_TA_AMM_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_AMM_FEED_PUMP_B_INT", value.U3_MRH_TA_AMM_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_CARB_FEED_PUMP_A_INT", value.U3_MRH_TA_CARB_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_CARB_FEED_PUMP_B_INT", value.U3_MRH_TA_CARB_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_CO2_COMP_INT", value.U3_MRH_TA_CO2_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_AMM_FEED_PUMP_A_INT", value.U3_MRH_TB_AMM_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_AMM_FEED_PUMP_B_INT", value.U3_MRH_TB_AMM_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_CARB_FEED_PUMP_A_INT", value.U3_MRH_TB_CARB_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_CARB_FEED_PUMP_B_INT", value.U3_MRH_TB_CARB_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_CO2_COMP_INT", value.U3_MRH_TB_CO2_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_AMM_FEED_PUMP_A_INT_DIFF", value.U3_MRH_TA_AMM_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_AMM_FEED_PUMP_B_INT_DIFF", value.U3_MRH_TA_AMM_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_CARB_FEED_PUMP_A_INT_DIFF", value.U3_MRH_TA_CARB_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_CARB_FEED_PUMP_B_INT_DIFF", value.U3_MRH_TA_CARB_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TA_CO2_COMP_INT_DIFF", value.U3_MRH_TA_CO2_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_AMM_FEED_PUMP_A_INT_DIFF", value.U3_MRH_TB_AMM_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_AMM_FEED_PUMP_B_INT_DIFF", value.U3_MRH_TB_AMM_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_CARB_FEED_PUMP_A_INT_DIFF", value.U3_MRH_TB_CARB_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_CARB_FEED_PUMP_B_INT_DIFF", value.U3_MRH_TB_CARB_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MRH_TB_CO2_COMP_INT_DIFF", value.U3_MRH_TB_CO2_COMP_INT_DIFF));

                    // ------------------------PPT_UR3_RECORD_OF_SPILLED_UREA---------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SOLUTION_RECV_FROM_UPH", value.U3_SOLUTION_RECV_FROM_UPH));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SPILLED_DISSOLVED", value.U3_SPILLED_DISSOLVED));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_OILY_WATER_PUMP_RUN_HRS", value.U3_OILY_WATER_PUMP_RUN_HRS));

                    // ---------------------PPT_UR3_SPECIFIC_CONSUMPTION-------------------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_MP_STEAM", value.U3_TA_SP_CONSP_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_IP_STEAM", value.U3_TA_SP_CONSP_IP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_LP_STEAM", value.U3_TA_SP_CONSP_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_T_COND_EXPORT", value.U3_TA_SP_CONSP_T_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_P_COND_EXPORT", value.U3_TA_SP_CONSP_P_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_STEAM_COND_EXPORT", value.U3_TA_SP_CONSP_STEAM_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_NPC_UR", value.U3_TA_SP_CONSP_NPC_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_PWR_CONSP_UCT", value.U3_TA_SP_CONSP_PWR_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_SP_CONSP_MP_UCT_CWM", value.U3_TA_SP_CONSP_MP_UCT_CWM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_MP_STEAM", value.U3_TB_SP_CONSP_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_IP_STEAM", value.U3_TB_SP_CONSP_IP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_LP_STEAM", value.U3_TB_SP_CONSP_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_T_COND_EXPORT", value.U3_TB_SP_CONSP_T_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_P_COND_EXPORT", value.U3_TB_SP_CONSP_P_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_STEAM_COND_EXPORT", value.U3_TB_SP_CONSP_STEAM_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_NPC_UR", value.U3_TB_SP_CONSP_NPC_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_PWR_CONSP_UCT", value.U3_TB_SP_CONSP_PWR_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_SP_CONSP_MP_UCT_CWM", value.U3_TB_SP_CONSP_MP_UCT_CWM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_MP_STEAM", value.U3_TOT_SP_CONSP_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_IP_STEAM", value.U3_TOT_SP_CONSP_IP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_LP_STEAM", value.U3_TOT_SP_CONSP_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_T_COND_EXPORT", value.U3_TOT_SP_CONSP_T_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_P_COND_EXPORT", value.U3_TOT_SP_CONSP_P_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_STEAM_COND_EXPORT", value.U3_TOT_SP_CONSP_STEAM_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_NPC_UR", value.U3_TOT_SP_CONSP_NPC_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_PWR_CONSP_UCT", value.U3_TOT_SP_CONSP_PWR_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_SP_CONSP_MP_UCT_CWM", value.U3_TOT_SP_CONSP_MP_UCT_CWM));

                    // ------------------------- PPT_UR3_SPECIFIC_ENERGY -----------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_MP_STEAM", value.U3_SP_ENG_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_IP_STEAM", value.U3_SP_ENG_IP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_LP_STEAM", value.U3_SP_ENG_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_PWR_CONSP_INCLUDING_UCT", value.U3_SP_ENG_PWR_CONSP_INCLUDING_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_COMMON_FACILITIES", value.U3_SP_ENG_COMMON_FACILITIES));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG", value.U3_SP_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_CREDIT_FOR_MP_STEAM", value.U3_SP_ENG_CREDIT_FOR_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_SP_ENG_CREDIT_FOR_LP_STEAM", value.U3_SP_ENG_CREDIT_FOR_LP_STEAM));

                    // --------------------- PPT_UR3_UREA_EL_PO_RECEIPT_CON ---------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_AMM_FEED_PUMP_A_INT", value.U3_TA_AMM_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_AMM_FEED_PUMP_B_INT", value.U3_TA_AMM_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_CARB_FEED_PUMP_A_INT", value.U3_TA_CARB_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_CARB_FEED_PUMP_B_INT", value.U3_TA_CARB_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_AMM_FEED_PUMP_A_INT", value.U3_TB_AMM_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_AMM_FEED_PUMP_B_INT", value.U3_TB_AMM_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_CARB_FEED_PUMP_A_INT", value.U3_TB_CARB_FEED_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_CARB_FEED_PUMP_B_INT", value.U3_TB_CARB_FEED_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_HYDR_PUMP_A_INT", value.U3_HYDR_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_HYDR_PUMP_B_INT", value.U3_HYDR_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_UR_PWR", value.U3_TOT_UR_PWR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_UCT_PWR", value.U3_UCT_PWR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_NET_UR_PWR", value.U3_NET_UR_PWR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_AMM_FEED_PUMP_A_INT_DIFF", value.U3_TA_AMM_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_AMM_FEED_PUMP_B_INT_DIFF", value.U3_TA_AMM_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_CARB_FEED_PUMP_A_INT_DIFF", value.U3_TA_CARB_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TA_CARB_FEED_PUMP_B_INT_DIFF", value.U3_TA_CARB_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_AMM_FEED_PUMP_A_INT_DIFF", value.U3_TB_AMM_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_AMM_FEED_PUMP_B_INT_DIFF", value.U3_TB_AMM_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_CARB_FEED_PUMP_A_INT_DIFF", value.U3_TB_CARB_FEED_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TB_CARB_FEED_PUMP_B_INT_DIFF", value.U3_TB_CARB_FEED_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_HYDR_PUMP_A_INT_DIFF", value.U3_HYDR_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_HYDR_PUMP_B_INT_DIFF", value.U3_HYDR_PUMP_B_INT_DIFF));

                    // ------------------------------ PPT_UR3_UREA_PRODUCTION_REMARK ---------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_UR_PROD", value.U3_TOT_UR_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_OVERALL_UR_CO2_CONSP", value.U3_OVERALL_UR_CO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_CO2_FACTOR", value.U3_CO2_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_EFF_FACTOR", value.U3_EFF_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_OVERALL_OPERATING_FACTOR", value.U3_OVERALL_OPERATING_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3A_CO2_CONSP_INT", value.U3_STREAM_3A_CO2_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3A_ON_STREAM_HRS", value.U3_STREAM_3A_ON_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3A_UR_PROD", value.U3_STREAM_3A_UR_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3A_AMM_CONSP", value.U3_STREAM_3A_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3A_OPERATING_FACTOR", value.U3_STREAM_3A_OPERATING_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3B_CO2_CONSP_INT", value.U3_STREAM_3B_CO2_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3B_ON_STREAM_HRS", value.U3_STREAM_3B_ON_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3B_UR_PROD", value.U3_STREAM_3B_UR_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3B_AMM_CONSP", value.U3_STREAM_3B_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3B_OPERATING_FACTOR", value.U3_STREAM_3B_OPERATING_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_DAILY_REMARK", value.U3_DAILY_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MONTHLY_REMARK", value.U3_MONTHLY_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_COLD_AMM_RECV", value.U3_COLD_AMM_RECV));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_OVERALL_AMM_CONSP", value.U3_OVERALL_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3A_CO2_CONSP_INT_DIFF", value.U3_STREAM_3A_CO2_CONSP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_STREAM_3B_CO2_CONSP_INT_DIFF", value.U3_STREAM_3B_CO2_CONSP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_COLD_AMM_RECV_INT_DIFF", value.U3_COLD_AMM_RECV_INT_DIFF));

                    // -------------------------- PPT_UR3_WATER_N_STEAM_DETAILS -------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TC_EXPORT_INT", value.U3_TC_EXPORT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOT_COND_EXPORT", value.U3_TOT_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_TA_CO2_COMP_INT", value.U3_MP_STEAM_TA_CO2_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_TB_CO2_COMP_INT", value.U3_MP_STEAM_TB_CO2_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TOTAL_MP_STEAM_CONSP", value.U3_TOTAL_MP_STEAM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_PWR_UCT", value.U3_PWR_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_IP_STEAM_IMPORT_INT", value.U3_IP_STEAM_IMPORT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_UR_EFFL_HYDR_INT", value.U3_MP_STEAM_UR_EFFL_HYDR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_LP_STEAM_STRIPPER_INT", value.U3_LP_STEAM_STRIPPER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_CREDIT_GP1_ET_INT", value.U3_MP_STEAM_CREDIT_GP1_ET_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_CREDIT_GP2_ET_INT", value.U3_MP_STEAM_CREDIT_GP2_ET_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_LP_STEAM_CREDIT_GP1_ET_INT", value.U3_LP_STEAM_CREDIT_GP1_ET_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_LP_STEAM_CREDIT_GP2_ET_INT", value.U3_LP_STEAM_CREDIT_GP2_ET_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_WASTE_WATER_GUARD_POND_INT", value.U3_WASTE_WATER_GUARD_POND_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_WASTE_WATER_HOLDING_POND_INT", value.U3_WASTE_WATER_HOLDING_POND_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_UR_HYDR", value.U3_MP_STEAM_UR_HYDR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_TC_EXPORT_INT_DIFF", value.U3_TC_EXPORT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_TA_CO2_COMP_INT_DIFF", value.U3_MP_STEAM_TA_CO2_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_TB_CO2_COMP_INT_DIFF", value.U3_MP_STEAM_TB_CO2_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_IP_STEAM_IMPORT_INT_DIFF", value.U3_IP_STEAM_IMPORT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_UR_EFFL_HYDR_INT_DIFF", value.U3_MP_STEAM_UR_EFFL_HYDR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_LP_STEAM_STRIPPER_INT_DIFF", value.U3_LP_STEAM_STRIPPER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_WASTE_WATER_GUARD_POND_INT_DIFF", value.U3_WASTE_WATER_GUARD_POND_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_WASTE_WATER_HOLDING_POND_INT_DIFF", value.U3_WASTE_WATER_HOLDING_POND_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_MP_STEAM_UR_HYDR_INT_DIFF", value.U3_MP_STEAM_UR_HYDR_INT_DIFF));

                    cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_BY", value.ENTERED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODIFIED_BY", value.MODIFIED_BY));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        // Put Data Map With Fields
        private PUS301Model MapToValue(SqlDataReader reader)
        {
            return new PUS301Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),

                TDATE = reader["TDATE"].ToString(),

                // -------------PPT_UR3_MACHINERY_RUNNING_HOUR-------------------------------
                U3_MRH_TA_AMM_FEED_PUMP_A_INT = (decimal)reader["U3_MRH_TA_AMM_FEED_PUMP_A_INT"],
                U3_MRH_TA_AMM_FEED_PUMP_B_INT = (decimal)reader["U3_MRH_TA_AMM_FEED_PUMP_B_INT"],
                U3_MRH_TA_CARB_FEED_PUMP_A_INT = (decimal)reader["U3_MRH_TA_CARB_FEED_PUMP_A_INT"],
                U3_MRH_TA_CARB_FEED_PUMP_B_INT = (decimal)reader["U3_MRH_TA_CARB_FEED_PUMP_B_INT"],
                U3_MRH_TA_CO2_COMP_INT = (decimal)reader["U3_MRH_TA_CO2_COMP_INT"],
                U3_MRH_TB_AMM_FEED_PUMP_A_INT = (decimal)reader["U3_MRH_TB_AMM_FEED_PUMP_A_INT"],
                U3_MRH_TB_AMM_FEED_PUMP_B_INT = (decimal)reader["U3_MRH_TB_AMM_FEED_PUMP_B_INT"],
                U3_MRH_TB_CARB_FEED_PUMP_A_INT = (decimal)reader["U3_MRH_TB_CARB_FEED_PUMP_A_INT"],
                U3_MRH_TB_CARB_FEED_PUMP_B_INT = (decimal)reader["U3_MRH_TB_CARB_FEED_PUMP_B_INT"],
                U3_MRH_TB_CO2_COMP_INT = (decimal)reader["U3_MRH_TB_CO2_COMP_INT"],
                U3_MRH_TA_AMM_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_MRH_TA_AMM_FEED_PUMP_A_INT_DIFF"],
                U3_MRH_TA_AMM_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_MRH_TA_AMM_FEED_PUMP_B_INT_DIFF"],
                U3_MRH_TA_CARB_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_MRH_TA_CARB_FEED_PUMP_A_INT_DIFF"],
                U3_MRH_TA_CARB_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_MRH_TA_CARB_FEED_PUMP_B_INT_DIFF"],
                U3_MRH_TA_CO2_COMP_INT_DIFF = (decimal)reader["U3_MRH_TA_CO2_COMP_INT_DIFF"],
                U3_MRH_TB_AMM_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_MRH_TB_AMM_FEED_PUMP_A_INT_DIFF"],
                U3_MRH_TB_AMM_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_MRH_TB_AMM_FEED_PUMP_B_INT_DIFF"],
                U3_MRH_TB_CARB_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_MRH_TB_CARB_FEED_PUMP_A_INT_DIFF"],
                U3_MRH_TB_CARB_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_MRH_TB_CARB_FEED_PUMP_B_INT_DIFF"],
                U3_MRH_TB_CO2_COMP_INT_DIFF = (decimal)reader["U3_MRH_TB_CO2_COMP_INT_DIFF"],

                // ------------------------PPT_UR3_RECORD_OF_SPILLED_UREA---------------------------------
                U3_SOLUTION_RECV_FROM_UPH = (decimal)reader["U3_SOLUTION_RECV_FROM_UPH"],
                U3_SPILLED_DISSOLVED = (decimal)reader["U3_SPILLED_DISSOLVED"],
                U3_OILY_WATER_PUMP_RUN_HRS = (decimal)reader["U3_OILY_WATER_PUMP_RUN_HRS"],

                // ---------------------PPT_UR3_SPECIFIC_CONSUMPTION-------------------------------------------
                U3_TA_SP_CONSP_MP_STEAM = (decimal)reader["U3_TA_SP_CONSP_MP_STEAM"],
                U3_TA_SP_CONSP_IP_STEAM = (decimal)reader["U3_TA_SP_CONSP_IP_STEAM"],
                U3_TA_SP_CONSP_LP_STEAM = (decimal)reader["U3_TA_SP_CONSP_LP_STEAM"],
                U3_TA_SP_CONSP_T_COND_EXPORT = (decimal)reader["U3_TA_SP_CONSP_T_COND_EXPORT"],
                U3_TA_SP_CONSP_P_COND_EXPORT = (decimal)reader["U3_TA_SP_CONSP_P_COND_EXPORT"],
                U3_TA_SP_CONSP_STEAM_COND_EXPORT = (decimal)reader["U3_TA_SP_CONSP_STEAM_COND_EXPORT"],
                U3_TA_SP_CONSP_NPC_UR = (decimal)reader["U3_TA_SP_CONSP_NPC_UR"],
                U3_TA_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["U3_TA_SP_CONSP_PWR_CONSP_UCT"],
                U3_TA_SP_CONSP_MP_UCT_CWM = (decimal)reader["U3_TA_SP_CONSP_MP_UCT_CWM"],
                U3_TB_SP_CONSP_MP_STEAM = (decimal)reader["U3_TB_SP_CONSP_MP_STEAM"],
                U3_TB_SP_CONSP_IP_STEAM = (decimal)reader["U3_TB_SP_CONSP_IP_STEAM"],
                U3_TB_SP_CONSP_LP_STEAM = (decimal)reader["U3_TB_SP_CONSP_LP_STEAM"],
                U3_TB_SP_CONSP_T_COND_EXPORT = (decimal)reader["U3_TB_SP_CONSP_T_COND_EXPORT"],
                U3_TB_SP_CONSP_P_COND_EXPORT = (decimal)reader["U3_TB_SP_CONSP_P_COND_EXPORT"],
                U3_TB_SP_CONSP_STEAM_COND_EXPORT = (decimal)reader["U3_TB_SP_CONSP_STEAM_COND_EXPORT"],
                U3_TB_SP_CONSP_NPC_UR = (decimal)reader["U3_TB_SP_CONSP_NPC_UR"],
                U3_TB_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["U3_TB_SP_CONSP_PWR_CONSP_UCT"],
                U3_TB_SP_CONSP_MP_UCT_CWM = (decimal)reader["U3_TB_SP_CONSP_MP_UCT_CWM"],
                U3_TOT_SP_CONSP_MP_STEAM = (decimal)reader["U3_TOT_SP_CONSP_MP_STEAM"],
                U3_TOT_SP_CONSP_IP_STEAM = (decimal)reader["U3_TOT_SP_CONSP_IP_STEAM"],
                U3_TOT_SP_CONSP_LP_STEAM = (decimal)reader["U3_TOT_SP_CONSP_LP_STEAM"],
                U3_TOT_SP_CONSP_T_COND_EXPORT = (decimal)reader["U3_TOT_SP_CONSP_T_COND_EXPORT"],
                U3_TOT_SP_CONSP_P_COND_EXPORT = (decimal)reader["U3_TOT_SP_CONSP_P_COND_EXPORT"],
                U3_TOT_SP_CONSP_STEAM_COND_EXPORT = (decimal)reader["U3_TOT_SP_CONSP_STEAM_COND_EXPORT"],
                U3_TOT_SP_CONSP_NPC_UR = (decimal)reader["U3_TOT_SP_CONSP_NPC_UR"],
                U3_TOT_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["U3_TOT_SP_CONSP_PWR_CONSP_UCT"],
                U3_TOT_SP_CONSP_MP_UCT_CWM = (decimal)reader["U3_TOT_SP_CONSP_MP_UCT_CWM"],

                // ------------------------- PPT_UR3_SPECIFIC_ENERGY -----------------------
                U3_SP_ENG_MP_STEAM = (decimal)reader["U3_SP_ENG_MP_STEAM"],
                U3_SP_ENG_IP_STEAM = (decimal)reader["U3_SP_ENG_IP_STEAM"],
                U3_SP_ENG_LP_STEAM = (decimal)reader["U3_SP_ENG_LP_STEAM"],
                U3_SP_ENG_PWR_CONSP_INCLUDING_UCT = (decimal)reader["U3_SP_ENG_PWR_CONSP_INCLUDING_UCT"],
                U3_SP_ENG_COMMON_FACILITIES = (decimal)reader["U3_SP_ENG_COMMON_FACILITIES"],
                U3_SP_ENG = (decimal)reader["U3_SP_ENG"],
                U3_SP_ENG_CREDIT_FOR_MP_STEAM = (decimal)reader["U3_SP_ENG_CREDIT_FOR_MP_STEAM"],
                U3_SP_ENG_CREDIT_FOR_LP_STEAM = (decimal)reader["U3_SP_ENG_CREDIT_FOR_LP_STEAM"],

                // --------------------- PPT_UR3_UREA_EL_PO_RECEIPT_CON ---------------------------
                U3_TA_AMM_FEED_PUMP_A_INT = (decimal)reader["U3_TA_AMM_FEED_PUMP_A_INT"],
                U3_TA_AMM_FEED_PUMP_B_INT = (decimal)reader["U3_TA_AMM_FEED_PUMP_B_INT"],
                U3_TA_CARB_FEED_PUMP_A_INT = (decimal)reader["U3_TA_CARB_FEED_PUMP_A_INT"],
                U3_TA_CARB_FEED_PUMP_B_INT = (decimal)reader["U3_TA_CARB_FEED_PUMP_B_INT"],
                U3_TB_AMM_FEED_PUMP_A_INT = (decimal)reader["U3_TB_AMM_FEED_PUMP_A_INT"],
                U3_TB_AMM_FEED_PUMP_B_INT = (decimal)reader["U3_TB_AMM_FEED_PUMP_B_INT"],
                U3_TB_CARB_FEED_PUMP_A_INT = (decimal)reader["U3_TB_CARB_FEED_PUMP_A_INT"],
                U3_TB_CARB_FEED_PUMP_B_INT = (decimal)reader["U3_TB_CARB_FEED_PUMP_B_INT"],
                U3_HYDR_PUMP_A_INT = (decimal)reader["U3_HYDR_PUMP_A_INT"],
                U3_HYDR_PUMP_B_INT = (decimal)reader["U3_HYDR_PUMP_B_INT"],
                U3_TOT_UR_PWR = (decimal)reader["U3_TOT_UR_PWR"],
                U3_UCT_PWR = (decimal)reader["U3_UCT_PWR"],
                U3_NET_UR_PWR = (decimal)reader["U3_NET_UR_PWR"],
                U3_TA_AMM_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TA_AMM_FEED_PUMP_A_INT_DIFF"],
                U3_TA_AMM_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TA_AMM_FEED_PUMP_B_INT_DIFF"],
                U3_TA_CARB_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TA_CARB_FEED_PUMP_A_INT_DIFF"],
                U3_TA_CARB_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TA_CARB_FEED_PUMP_B_INT_DIFF"],
                U3_TB_AMM_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TB_AMM_FEED_PUMP_A_INT_DIFF"],
                U3_TB_AMM_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TB_AMM_FEED_PUMP_B_INT_DIFF"],
                U3_TB_CARB_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TB_CARB_FEED_PUMP_A_INT_DIFF"],
                U3_TB_CARB_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TB_CARB_FEED_PUMP_B_INT_DIFF"],
                U3_HYDR_PUMP_A_INT_DIFF = (decimal)reader["U3_HYDR_PUMP_A_INT_DIFF"],
                U3_HYDR_PUMP_B_INT_DIFF = (decimal)reader["U3_HYDR_PUMP_B_INT_DIFF"],

                // ------------------------------ PPT_UR3_UREA_PRODUCTION_REMARK ---------------------------------
                U3_TOT_UR_PROD = (decimal)reader["U3_TOT_UR_PROD"],
                U3_OVERALL_UR_CO2_CONSP = (decimal)reader["U3_OVERALL_UR_CO2_CONSP"],
                U3_CO2_FACTOR = (decimal)reader["U3_CO2_FACTOR"],
                U3_EFF_FACTOR = (decimal)reader["U3_EFF_FACTOR"],
                U3_OVERALL_OPERATING_FACTOR = (decimal)reader["U3_OVERALL_OPERATING_FACTOR"],
                U3_STREAM_3A_CO2_CONSP_INT = (decimal)reader["U3_STREAM_3A_CO2_CONSP_INT"],
                U3_STREAM_3A_ON_STREAM_HRS = (decimal)reader["U3_STREAM_3A_ON_STREAM_HRS"],
                U3_STREAM_3A_UR_PROD = (decimal)reader["U3_STREAM_3A_UR_PROD"],
                U3_STREAM_3A_AMM_CONSP = (decimal)reader["U3_STREAM_3A_AMM_CONSP"],
                U3_STREAM_3A_OPERATING_FACTOR = (decimal)reader["U3_STREAM_3A_OPERATING_FACTOR"],
                U3_STREAM_3B_CO2_CONSP_INT = (decimal)reader["U3_STREAM_3B_CO2_CONSP_INT"],
                U3_STREAM_3B_ON_STREAM_HRS = (decimal)reader["U3_STREAM_3B_ON_STREAM_HRS"],
                U3_STREAM_3B_UR_PROD = (decimal)reader["U3_STREAM_3B_UR_PROD"],
                U3_STREAM_3B_AMM_CONSP = (decimal)reader["U3_STREAM_3B_AMM_CONSP"],
                U3_STREAM_3B_OPERATING_FACTOR = (decimal)reader["U3_STREAM_3B_OPERATING_FACTOR"],
                U3_DAILY_REMARK = reader["U3_DAILY_REMARK"].ToString(),
                U3_MONTHLY_REMARK = reader["U3_MONTHLY_REMARK"].ToString(),
                U3_COLD_AMM_RECV = (decimal)reader["U3_COLD_AMM_RECV"],
                U3_OVERALL_AMM_CONSP = (decimal)reader["U3_OVERALL_AMM_CONSP"],
                U3_STREAM_3A_CO2_CONSP_INT_DIFF = (decimal)reader["U3_STREAM_3A_CO2_CONSP_INT_DIFF"],
                U3_STREAM_3B_CO2_CONSP_INT_DIFF = (decimal)reader["U3_STREAM_3B_CO2_CONSP_INT_DIFF"],
                U3_COLD_AMM_RECV_INT_DIFF = (decimal)reader["U3_COLD_AMM_RECV_INT_DIFF"],

                // -------------------------- PPT_UR3_WATER_N_STEAM_DETAILS -------------------
                U3_TC_EXPORT_INT = (decimal)reader["U3_TC_EXPORT_INT"],
                U3_TOT_COND_EXPORT = (decimal)reader["U3_TOT_COND_EXPORT"],
                U3_MP_STEAM_TA_CO2_COMP_INT = (decimal)reader["U3_MP_STEAM_TA_CO2_COMP_INT"],
                U3_MP_STEAM_TB_CO2_COMP_INT = (decimal)reader["U3_MP_STEAM_TB_CO2_COMP_INT"],
                U3_TOTAL_MP_STEAM_CONSP = (decimal)reader["U3_TOTAL_MP_STEAM_CONSP"],
                U3_PWR_UCT = (decimal)reader["U3_PWR_UCT"],
                U3_IP_STEAM_IMPORT_INT = (decimal)reader["U3_IP_STEAM_IMPORT_INT"],
                U3_MP_STEAM_UR_EFFL_HYDR_INT = (decimal)reader["U3_MP_STEAM_UR_EFFL_HYDR_INT"],
                U3_LP_STEAM_STRIPPER_INT = (decimal)reader["U3_LP_STEAM_STRIPPER_INT"],
                U3_MP_STEAM_CREDIT_GP1_ET_INT = (decimal)reader["U3_MP_STEAM_CREDIT_GP1_ET_INT"],
                U3_MP_STEAM_CREDIT_GP2_ET_INT = (decimal)reader["U3_MP_STEAM_CREDIT_GP2_ET_INT"],
                U3_LP_STEAM_CREDIT_GP1_ET_INT = (decimal)reader["U3_LP_STEAM_CREDIT_GP1_ET_INT"],
                U3_LP_STEAM_CREDIT_GP2_ET_INT = (decimal)reader["U3_LP_STEAM_CREDIT_GP2_ET_INT"],
                U3_WASTE_WATER_GUARD_POND_INT = (decimal)reader["U3_WASTE_WATER_GUARD_POND_INT"],
                U3_WASTE_WATER_HOLDING_POND_INT = (decimal)reader["U3_WASTE_WATER_HOLDING_POND_INT"],
                U3_MP_STEAM_UR_HYDR = (decimal)reader["U3_MP_STEAM_UR_HYDR"],
                U3_TC_EXPORT_INT_DIFF = (decimal)reader["U3_TC_EXPORT_INT_DIFF"],
                U3_MP_STEAM_TA_CO2_COMP_INT_DIFF = (decimal)reader["U3_MP_STEAM_TA_CO2_COMP_INT_DIFF"],
                U3_MP_STEAM_TB_CO2_COMP_INT_DIFF = (decimal)reader["U3_MP_STEAM_TB_CO2_COMP_INT_DIFF"],
                U3_IP_STEAM_IMPORT_INT_DIFF = (decimal)reader["U3_IP_STEAM_IMPORT_INT_DIFF"],
                U3_MP_STEAM_UR_EFFL_HYDR_INT_DIFF = (decimal)reader["U3_MP_STEAM_UR_EFFL_HYDR_INT_DIFF"],
                U3_LP_STEAM_STRIPPER_INT_DIFF = (decimal)reader["U3_LP_STEAM_STRIPPER_INT_DIFF"],
                U3_WASTE_WATER_GUARD_POND_INT_DIFF = (decimal)reader["U3_WASTE_WATER_GUARD_POND_INT_DIFF"],
                U3_WASTE_WATER_HOLDING_POND_INT_DIFF = (decimal)reader["U3_WASTE_WATER_HOLDING_POND_INT_DIFF"],
                U3_MP_STEAM_UR_HYDR_INT_DIFF = (decimal)reader["U3_MP_STEAM_UR_HYDR_INT_DIFF"],

                ENTERED_BY = reader["ENTERED_BY"].ToString(),
                MODIFIED_BY = reader["MODIFIED_BY"].ToString(),
                ENTERED_DATETIME = reader["ENTERED_DATETIME"].ToString(),
                MODIFY_DATETIME = reader["MODIFY_DATETIME"].ToString(),

                // -------------------------PRV---------------------------------------------------
                // -------------------- PPT_UR3_MACHINERY_RUNNING_HOUR----------------------------
                PRV_U3_MRH_TA_AMM_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_MRH_TA_AMM_FEED_PUMP_A_INT"],
                PRV_U3_MRH_TA_AMM_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_MRH_TA_AMM_FEED_PUMP_B_INT"],
                PRV_U3_MRH_TA_CARB_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_MRH_TA_CARB_FEED_PUMP_A_INT"],
                PRV_U3_MRH_TA_CARB_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_MRH_TA_CARB_FEED_PUMP_B_INT"],
                PRV_U3_MRH_TA_CO2_COMP_INT = (decimal)reader["PRV_U3_MRH_TA_CO2_COMP_INT"],
                PRV_U3_MRH_TB_AMM_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_MRH_TB_AMM_FEED_PUMP_A_INT"],
                PRV_U3_MRH_TB_AMM_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_MRH_TB_AMM_FEED_PUMP_B_INT"],
                PRV_U3_MRH_TB_CARB_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_MRH_TB_CARB_FEED_PUMP_A_INT"],
                PRV_U3_MRH_TB_CARB_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_MRH_TB_CARB_FEED_PUMP_B_INT"],
                PRV_U3_MRH_TB_CO2_COMP_INT = (decimal)reader["PRV_U3_MRH_TB_CO2_COMP_INT"],
                // -------------------- PPT_UR3_RECORD_OF_SPILLED_UREA --------------------
                PRV_U3_SOLUTION_RECV_FROM_UPH = (decimal)reader["PRV_U3_SOLUTION_RECV_FROM_UPH"],
                PRV_U3_SPILLED_DISSOLVED = (decimal)reader["PRV_U3_SPILLED_DISSOLVED"],
                PRV_U3_OILY_WATER_PUMP_RUN_HRS = (decimal)reader["PRV_U3_OILY_WATER_PUMP_RUN_HRS"],
                // --------------- PPT_UR3_SPECIFIC_CONSUMPTION ---------------------
                PRV_U3_TA_SP_CONSP_MP_STEAM = (decimal)reader["PRV_U3_TA_SP_CONSP_MP_STEAM"],
                PRV_U3_TA_SP_CONSP_IP_STEAM = (decimal)reader["PRV_U3_TA_SP_CONSP_IP_STEAM"],
                PRV_U3_TA_SP_CONSP_LP_STEAM = (decimal)reader["PRV_U3_TA_SP_CONSP_LP_STEAM"],
                PRV_U3_TA_SP_CONSP_T_COND_EXPORT = (decimal)reader["PRV_U3_TA_SP_CONSP_T_COND_EXPORT"],
                PRV_U3_TA_SP_CONSP_P_COND_EXPORT = (decimal)reader["PRV_U3_TA_SP_CONSP_P_COND_EXPORT"],
                PRV_U3_TA_SP_CONSP_STEAM_COND_EXPORT = (decimal)reader["PRV_U3_TA_SP_CONSP_STEAM_COND_EXPORT"],
                PRV_U3_TA_SP_CONSP_NPC_UR = (decimal)reader["PRV_U3_TA_SP_CONSP_NPC_UR"],
                PRV_U3_TA_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["PRV_U3_TA_SP_CONSP_PWR_CONSP_UCT"],
                PRV_U3_TA_SP_CONSP_MP_UCT_CWM = (decimal)reader["PRV_U3_TA_SP_CONSP_MP_UCT_CWM"],
                PRV_U3_TB_SP_CONSP_MP_STEAM = (decimal)reader["PRV_U3_TB_SP_CONSP_MP_STEAM"],
                PRV_U3_TB_SP_CONSP_IP_STEAM = (decimal)reader["PRV_U3_TB_SP_CONSP_IP_STEAM"],
                PRV_U3_TB_SP_CONSP_LP_STEAM = (decimal)reader["PRV_U3_TB_SP_CONSP_LP_STEAM"],
                PRV_U3_TB_SP_CONSP_T_COND_EXPORT = (decimal)reader["PRV_U3_TB_SP_CONSP_T_COND_EXPORT"],
                PRV_U3_TB_SP_CONSP_P_COND_EXPORT = (decimal)reader["PRV_U3_TB_SP_CONSP_P_COND_EXPORT"],
                PRV_U3_TB_SP_CONSP_STEAM_COND_EXPORT = (decimal)reader["PRV_U3_TB_SP_CONSP_STEAM_COND_EXPORT"],
                PRV_U3_TB_SP_CONSP_NPC_UR = (decimal)reader["PRV_U3_TB_SP_CONSP_NPC_UR"],
                PRV_U3_TB_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["PRV_U3_TB_SP_CONSP_PWR_CONSP_UCT"],
                PRV_U3_TB_SP_CONSP_MP_UCT_CWM = (decimal)reader["PRV_U3_TB_SP_CONSP_MP_UCT_CWM"],
                PRV_U3_TOT_SP_CONSP_MP_STEAM = (decimal)reader["PRV_U3_TOT_SP_CONSP_MP_STEAM"],
                PRV_U3_TOT_SP_CONSP_IP_STEAM = (decimal)reader["PRV_U3_TOT_SP_CONSP_IP_STEAM"],
                PRV_U3_TOT_SP_CONSP_LP_STEAM = (decimal)reader["PRV_U3_TOT_SP_CONSP_LP_STEAM"],
                PRV_U3_TOT_SP_CONSP_T_COND_EXPORT = (decimal)reader["PRV_U3_TOT_SP_CONSP_T_COND_EXPORT"],
                PRV_U3_TOT_SP_CONSP_P_COND_EXPORT = (decimal)reader["PRV_U3_TOT_SP_CONSP_P_COND_EXPORT"],
                PRV_U3_TOT_SP_CONSP_STEAM_COND_EXPORT = (decimal)reader["PRV_U3_TOT_SP_CONSP_STEAM_COND_EXPORT"],
                PRV_U3_TOT_SP_CONSP_NPC_UR = (decimal)reader["PRV_U3_TOT_SP_CONSP_NPC_UR"],
                PRV_U3_TOT_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["PRV_U3_TOT_SP_CONSP_PWR_CONSP_UCT"],
                PRV_U3_TOT_SP_CONSP_MP_UCT_CWM = (decimal)reader["PRV_U3_TOT_SP_CONSP_MP_UCT_CWM"],
                // -------------------- PPT_UR3_SPECIFIC_ENERGY------------------------------------------
                PRV_U3_SP_ENG_MP_STEAM = (decimal)reader["PRV_U3_SP_ENG_MP_STEAM"],
                PRV_U3_SP_ENG_IP_STEAM = (decimal)reader["PRV_U3_SP_ENG_IP_STEAM"],
                PRV_U3_SP_ENG_LP_STEAM = (decimal)reader["PRV_U3_SP_ENG_LP_STEAM"],
                PRV_U3_SP_ENG_PWR_CONSP_INCLUDING_UCT = (decimal)reader["PRV_U3_SP_ENG_PWR_CONSP_INCLUDING_UCT"],
                PRV_U3_SP_ENG_COMMON_FACILITIES = (decimal)reader["PRV_U3_SP_ENG_COMMON_FACILITIES"],
                PRV_U3_SP_ENG = (decimal)reader["PRV_U3_SP_ENG"],
                PRV_U3_SP_ENG_CREDIT_FOR_MP_STEAM = (decimal)reader["PRV_U3_SP_ENG_CREDIT_FOR_MP_STEAM"],
                PRV_U3_SP_ENG_CREDIT_FOR_LP_STEAM = (decimal)reader["PRV_U3_SP_ENG_CREDIT_FOR_LP_STEAM"],
                // -------------------PPT_UR3_UREA_EL_PO_RECEIPT_CON---------------------------------
                PRV_U3_TA_AMM_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_TA_AMM_FEED_PUMP_A_INT"],
                PRV_U3_TA_AMM_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_TA_AMM_FEED_PUMP_B_INT"],
                PRV_U3_TA_CARB_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_TA_CARB_FEED_PUMP_A_INT"],
                PRV_U3_TA_CARB_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_TA_CARB_FEED_PUMP_B_INT"],
                PRV_U3_TB_AMM_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_TB_AMM_FEED_PUMP_A_INT"],
                PRV_U3_TB_AMM_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_TB_AMM_FEED_PUMP_B_INT"],
                PRV_U3_TB_CARB_FEED_PUMP_A_INT = (decimal)reader["PRV_U3_TB_CARB_FEED_PUMP_A_INT"],
                PRV_U3_TB_CARB_FEED_PUMP_B_INT = (decimal)reader["PRV_U3_TB_CARB_FEED_PUMP_B_INT"],
                PRV_U3_HYDR_PUMP_A_INT = (decimal)reader["PRV_U3_HYDR_PUMP_A_INT"],
                PRV_U3_HYDR_PUMP_B_INT = (decimal)reader["PRV_U3_HYDR_PUMP_B_INT"],
                PRV_U3_TOT_UR_PWR = (decimal)reader["PRV_U3_TOT_UR_PWR"],
                PRV_U3_UCT_PWR = (decimal)reader["PRV_U3_UCT_PWR"],
                PRV_U3_NET_UR_PWR = (decimal)reader["PRV_U3_NET_UR_PWR"],
                // ----------------------PPT_UR3_UREA_PRODUCTION_REMARK------------------------
                PRV_U3_TOT_UR_PROD = (decimal)reader["PRV_U3_TOT_UR_PROD"],
                PRV_U3_OVERALL_UR_CO2_CONSP = (decimal)reader["PRV_U3_OVERALL_UR_CO2_CONSP"],
                PRV_U3_CO2_FACTOR = (decimal)reader["PRV_U3_CO2_FACTOR"],
                PRV_U3_EFF_FACTOR = (decimal)reader["PRV_U3_EFF_FACTOR"],
                PRV_U3_OVERALL_OPERATING_FACTOR = (decimal)reader["PRV_U3_OVERALL_OPERATING_FACTOR"],
                PRV_U3_STREAM_3A_CO2_CONSP_INT = (decimal)reader["PRV_U3_STREAM_3A_CO2_CONSP_INT"],
                PRV_U3_STREAM_3A_ON_STREAM_HRS = (decimal)reader["PRV_U3_STREAM_3A_ON_STREAM_HRS"],
                PRV_U3_STREAM_3A_UR_PROD = (decimal)reader["PRV_U3_STREAM_3A_UR_PROD"],
                PRV_U3_STREAM_3A_AMM_CONSP = (decimal)reader["PRV_U3_STREAM_3A_AMM_CONSP"],
                PRV_U3_STREAM_3A_OPERATING_FACTOR = (decimal)reader["PRV_U3_STREAM_3A_OPERATING_FACTOR"],
                PRV_U3_STREAM_3B_CO2_CONSP_INT = (decimal)reader["PRV_U3_STREAM_3B_CO2_CONSP_INT"],
                PRV_U3_STREAM_3B_ON_STREAM_HRS = (decimal)reader["PRV_U3_STREAM_3B_ON_STREAM_HRS"],
                PRV_U3_STREAM_3B_UR_PROD = (decimal)reader["PRV_U3_STREAM_3B_UR_PROD"],
                PRV_U3_STREAM_3B_AMM_CONSP = (decimal)reader["PRV_U3_STREAM_3B_AMM_CONSP"],
                PRV_U3_STREAM_3B_OPERATING_FACTOR = (decimal)reader["PRV_U3_STREAM_3B_OPERATING_FACTOR"],
                PRV_U3_DAILY_REMARK = reader["PRV_U3_DAILY_REMARK"].ToString(),
                PRV_U3_MONTHLY_REMARK = reader["PRV_U3_MONTHLY_REMARK"].ToString(),
                PRV_U3_COLD_AMM_RECV = (decimal)reader["PRV_U3_COLD_AMM_RECV"],
                PRV_U3_OVERALL_AMM_CONSP = (decimal)reader["PRV_U3_OVERALL_AMM_CONSP"],
                // --------------------------PPT_UR3_WATER_N_STEAM_DETAILS-------------------------------
                PRV_U3_TC_EXPORT_INT = (decimal)reader["PRV_U3_TC_EXPORT_INT"],
                PRV_U3_TOT_COND_EXPORT = (decimal)reader["PRV_U3_TOT_COND_EXPORT"],
                PRV_U3_MP_STEAM_TA_CO2_COMP_INT = (decimal)reader["PRV_U3_MP_STEAM_TA_CO2_COMP_INT"],
                PRV_U3_MP_STEAM_TB_CO2_COMP_INT = (decimal)reader["PRV_U3_MP_STEAM_TB_CO2_COMP_INT"],
                PRV_U3_TOTAL_MP_STEAM_CONSP = (decimal)reader["PRV_U3_TOTAL_MP_STEAM_CONSP"],
                PRV_U3_PWR_UCT = (decimal)reader["PRV_U3_PWR_UCT"],
                PRV_U3_IP_STEAM_IMPORT_INT = (decimal)reader["PRV_U3_IP_STEAM_IMPORT_INT"],
                PRV_U3_MP_STEAM_UR_EFFL_HYDR_INT = (decimal)reader["PRV_U3_MP_STEAM_UR_EFFL_HYDR_INT"],
                PRV_U3_LP_STEAM_STRIPPER_INT = (decimal)reader["PRV_U3_LP_STEAM_STRIPPER_INT"],
                PRV_U3_MP_STEAM_CREDIT_GP1_ET_INT = (decimal)reader["PRV_U3_MP_STEAM_CREDIT_GP1_ET_INT"],
                PRV_U3_MP_STEAM_CREDIT_GP2_ET_INT = (decimal)reader["PRV_U3_MP_STEAM_CREDIT_GP2_ET_INT"],
                PRV_U3_LP_STEAM_CREDIT_GP1_ET_INT = (decimal)reader["PRV_U3_LP_STEAM_CREDIT_GP1_ET_INT"],
                PRV_U3_LP_STEAM_CREDIT_GP2_ET_INT = (decimal)reader["PRV_U3_LP_STEAM_CREDIT_GP2_ET_INT"],
                PRV_U3_WASTE_WATER_GUARD_POND_INT = (decimal)reader["PRV_U3_WASTE_WATER_GUARD_POND_INT"],
                PRV_U3_WASTE_WATER_HOLDING_POND_INT = (decimal)reader["PRV_U3_WASTE_WATER_HOLDING_POND_INT"],
                PRV_U3_MP_STEAM_UR_HYDR = (decimal)reader["PRV_U3_MP_STEAM_UR_HYDR"],

            };
        }

        // Get DV Data Map With Fields
        private PUS301DVModel MapToValue2(SqlDataReader reader)
        {
            return new PUS301DVModel()
            {
                DIS_HOT_AMM_RECV = (decimal)reader["DIS_HOT_AMM_RECV"],
                DIS_PROCESS_COND_EXPORT = (decimal)reader["DIS_PROCESS_COND_EXPORT"],
                DIS_STEAM_COND_EXPORT = (decimal)reader["DIS_STEAM_COND_EXPORT"],
                DIS_TOT_PROCESS_WATER_CONSP = (decimal)reader["DIS_TOT_PROCESS_WATER_CONSP"],
                DIS_MP_STEAM_CONSP = (decimal)reader["DIS_MP_STEAM_CONSP"],
                DIS_MP_STEAM_UCT_PUMP = (decimal)reader["DIS_MP_STEAM_UCT_PUMP"],
                U3_PWR_UCT_CV = (double)reader["U3_PWR_UCT_CV"],
                DIS_UCT_TURBINE_COND = (decimal)reader["DIS_UCT_TURBINE_COND"],
                E3_UR_TA_PMCC_FEEDER_1_INT_DIFF = (decimal)reader["E3_UR_TA_PMCC_FEEDER_1_INT_DIFF"],
                E3_UR_TA_PMCC_FEEDER_2_INT_DIFF = (decimal)reader["E3_UR_TA_PMCC_FEEDER_2_INT_DIFF"],
                E3_UR_TB_PMCC_FEEDER_1_INT_DIFF = (decimal)reader["E3_UR_TB_PMCC_FEEDER_1_INT_DIFF"],
                E3_UR_TB_PMCC_FEEDER_2_INT_DIFF = (decimal)reader["E3_UR_TB_PMCC_FEEDER_2_INT_DIFF"],
                E3_3_3_KV_UNACCOUNTED = (decimal)reader["E3_3_3_KV_UNACCOUNTED"],
                E3_11_KV_PWR_GP3_UNACCOUNTED = (decimal)reader["E3_11_KV_PWR_GP3_UNACCOUNTED"],
                A3_UCT_CONSP = (decimal)reader["A3_UCT_CONSP"],
                A3_NET_UCT_MAKEUP = (decimal)reader["A3_NET_UCT_MAKEUP"],
                UN_MPSE_CONS = reader["UN_MPSE_CONS"].ToString(),
                UN_IPSE_CONS = reader["UN_IPSE_CONS"].ToString(),
                O3_KS_STEAM_GEN_HRSG3_DIFF = (decimal)reader["O3_KS_STEAM_GEN_HRSG3_DIFF"],
                O3_KSE_CONS = reader["O3_KSE_CONS"].ToString(),
                O3_BFWE_CONS = reader["O3_BFWE_CONS"].ToString(),
                O3_GP3_ONU_TOTAL_CONSP = (decimal)reader["O3_GP3_ONU_TOTAL_CONSP"],
                A3_SP_ENG_ALLOC_FOR_CV_UR_ENG = (decimal)reader["A3_SP_ENG_ALLOC_FOR_CV_UR_ENG"],
                A3_SP_ENG_NET_ENG_UR = (decimal)reader["A3_SP_ENG_NET_ENG_UR"],
            };
        }
    }
}
