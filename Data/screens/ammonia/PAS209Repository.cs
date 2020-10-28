using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS209Repository
    {
        private readonly string _connectionString;
        public PAS209Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS209Model MapToValue(SqlDataReader reader)
        {
            return new PAS209Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_AMM_FEEDER1_INT = (dynamic)reader["A2_AMM_FEEDER1_INT"],
                A2_AMM_FEEDER1_INT_DIFF = (dynamic)reader["A2_AMM_FEEDER1_INT_DIFF"],
                A2_AMM_FEEDER2_INT = (dynamic)reader["A2_AMM_FEEDER2_INT"],
                A2_AMM_FEEDER2_INT_DIFF = (dynamic)reader["A2_AMM_FEEDER2_INT_DIFF"],
                A2_UTIL_FEEDER1_INT = (dynamic)reader["A2_UTIL_FEEDER1_INT"],
                A2_UTIL_FEEDER1_INT_DIFF = (dynamic)reader["A2_UTIL_FEEDER1_INT_DIFF"],
                A2_UTIL_FEEDER2_INT = (dynamic)reader["A2_UTIL_FEEDER2_INT"],
                A2_UTIL_FEEDER2_INT_DIFF = (dynamic)reader["A2_UTIL_FEEDER2_INT_DIFF"],
                A2_AB_FDFAN_INT = (dynamic)reader["A2_AB_FDFAN_INT"],
                A2_AB_FDFAN_INT_DIFF = (dynamic)reader["A2_AB_FDFAN_INT_DIFF"],
                A2_LEAN_PUMP_INT = (dynamic)reader["A2_LEAN_PUMP_INT"],
                A2_LEAN_PUMP_INT_DIFF = (dynamic)reader["A2_LEAN_PUMP_INT_DIFF"],
                A2_BFW_PUMP_INT = (dynamic)reader["A2_BFW_PUMP_INT"],
                A2_BFW_PUMP_INT_DIFF = (dynamic)reader["A2_BFW_PUMP_INT_DIFF"],
                A2_SEMILEAN_PUMP_INT = (dynamic)reader["A2_SEMILEAN_PUMP_INT"],
                A2_SEMILEAN_PUMP_INT_DIFF = (dynamic)reader["A2_SEMILEAN_PUMP_INT_DIFF"],
                A2_STARTUP_BLOWER_INT = (dynamic)reader["A2_STARTUP_BLOWER_INT"],
                A2_STARTUP_BLOWER_INT_DIFF = (dynamic)reader["A2_STARTUP_BLOWER_INT_DIFF"],
                A2_UREA2_CW_PUMP_INT = (dynamic)reader["A2_UREA2_CW_PUMP_INT"],
                A2_UREA2_CW_PUMP_INT_DIFF = (dynamic)reader["A2_UREA2_CW_PUMP_INT_DIFF"],
                A2_PLANT_CONSP_GROSS = (dynamic)reader["A2_PLANT_CONSP_GROSS"],
                A2_LIGHT_TRANSFMR_INT = (dynamic)reader["A2_LIGHT_TRANSFMR_INT"],
                A2_LIGHT_TRANSFMR_INT_DIFF = (dynamic)reader["A2_LIGHT_TRANSFMR_INT_DIFF"],
                A2_UPS_FEEDER1_INT = (dynamic)reader["A2_UPS_FEEDER1_INT"],
                A2_UPS_FEEDER1_INT_DIFF = (dynamic)reader["A2_UPS_FEEDER1_INT_DIFF"],
                A2_UPS_FEEDER2_INT = (dynamic)reader["A2_UPS_FEEDER2_INT"],
                A2_UPS_FEEDER2_INT_DIFF = (dynamic)reader["A2_UPS_FEEDER2_INT_DIFF"],
                A2_AIRCOND_INT = (dynamic)reader["A2_AIRCOND_INT"],
                A2_AIRCOND_INT_DIFF = (dynamic)reader["A2_AIRCOND_INT_DIFF"],
                A2_BATT_CHARGER_AMM_INT = (dynamic)reader["A2_BATT_CHARGER_AMM_INT"],
                A2_BATT_CHARGER_AMM_INT_DIFF = (dynamic)reader["A2_BATT_CHARGER_AMM_INT_DIFF"],
                A2_BATT_CHARGER_UTIL_INT = (dynamic)reader["A2_BATT_CHARGER_UTIL_INT"],
                A2_BATT_CHARGER_UTIL_INT_DIFF = (dynamic)reader["A2_BATT_CHARGER_UTIL_INT_DIFF"],
                A2_NON_PLANT_CONSP = (dynamic)reader["A2_NON_PLANT_CONSP"],
                A2_PLANT_CONSP_NET = (dynamic)reader["A2_PLANT_CONSP_NET"],
                A2_REMARKS = reader["A2_REMARKS"].ToString(),
                TXT_TRANS_LOSS = (dynamic)reader["TXT_TRANS_LOSS"],
                TXT_FDR1_CONSP = (dynamic)reader["TXT_FDR1_CONSP"],
                TXT_FDR2_CONSP = (dynamic)reader["TXT_FDR2_CONSP"],
                TXT_LINE_TRANS_LOSS = (dynamic)reader["TXT_LINE_TRANS_LOSS"],
                TXT_TOT_FDR = (dynamic)reader["TXT_TOT_FDR"],
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_A2_TRANS_DATE = reader["PRV_A2_TRANS_DATE"].ToString(),
                PRV_A2_AMM_FEEDER1_INT = (dynamic)reader["PRV_A2_AMM_FEEDER1_INT"],
                PRV_A2_AMM_FEEDER1_INT_DIFF = (dynamic)reader["PRV_A2_AMM_FEEDER1_INT_DIFF"],
                PRV_A2_AMM_FEEDER2_INT = (dynamic)reader["PRV_A2_AMM_FEEDER2_INT"],
                PRV_A2_AMM_FEEDER2_INT_DIFF = (dynamic)reader["PRV_A2_AMM_FEEDER2_INT_DIFF"],
                PRV_A2_UTIL_FEEDER1_INT = (dynamic)reader["PRV_A2_UTIL_FEEDER1_INT"],
                PRV_A2_UTIL_FEEDER1_INT_DIFF = (dynamic)reader["PRV_A2_UTIL_FEEDER1_INT_DIFF"],
                PRV_A2_UTIL_FEEDER2_INT = (dynamic)reader["PRV_A2_UTIL_FEEDER2_INT"],
                PRV_A2_UTIL_FEEDER2_INT_DIFF = (dynamic)reader["PRV_A2_UTIL_FEEDER2_INT_DIFF"],
                PRV_A2_AB_FDFAN_INT = (dynamic)reader["PRV_A2_AB_FDFAN_INT"],
                PRV_A2_AB_FDFAN_INT_DIFF = (dynamic)reader["PRV_A2_AB_FDFAN_INT_DIFF"],
                PRV_A2_LEAN_PUMP_INT = (dynamic)reader["PRV_A2_LEAN_PUMP_INT"],
                PRV_A2_LEAN_PUMP_INT_DIFF = (dynamic)reader["PRV_A2_LEAN_PUMP_INT_DIFF"],
                PRV_A2_BFW_PUMP_INT = (dynamic)reader["PRV_A2_BFW_PUMP_INT"],
                PRV_A2_BFW_PUMP_INT_DIFF = (dynamic)reader["PRV_A2_BFW_PUMP_INT_DIFF"],
                PRV_A2_SEMILEAN_PUMP_INT = (dynamic)reader["PRV_A2_SEMILEAN_PUMP_INT"],
                PRV_A2_SEMILEAN_PUMP_INT_DIFF = (dynamic)reader["PRV_A2_SEMILEAN_PUMP_INT_DIFF"],
                PRV_A2_STARTUP_BLOWER_INT = (dynamic)reader["PRV_A2_STARTUP_BLOWER_INT"],
                PRV_A2_STARTUP_BLOWER_INT_DIFF = (dynamic)reader["PRV_A2_STARTUP_BLOWER_INT_DIFF"],
                PRV_A2_UREA2_CW_PUMP_INT = (dynamic)reader["PRV_A2_UREA2_CW_PUMP_INT"],
                PRV_A2_UREA2_CW_PUMP_INT_DIFF = (dynamic)reader["PRV_A2_UREA2_CW_PUMP_INT_DIFF"],
                PRV_A2_PLANT_CONSP_GROSS = (dynamic)reader["PRV_A2_PLANT_CONSP_GROSS"],
                PRV_A2_LIGHT_TRANSFMR_INT = (dynamic)reader["PRV_A2_LIGHT_TRANSFMR_INT"],
                PRV_A2_LIGHT_TRANSFMR_INT_DIFF = (dynamic)reader["PRV_A2_LIGHT_TRANSFMR_INT_DIFF"],
                PRV_A2_UPS_FEEDER1_INT = (dynamic)reader["PRV_A2_UPS_FEEDER1_INT"],
                PRV_A2_UPS_FEEDER1_INT_DIFF = (dynamic)reader["PRV_A2_UPS_FEEDER1_INT_DIFF"],
                PRV_A2_UPS_FEEDER2_INT = (dynamic)reader["PRV_A2_UPS_FEEDER2_INT"],
                PRV_A2_UPS_FEEDER2_INT_DIFF = (dynamic)reader["PRV_A2_UPS_FEEDER2_INT_DIFF"],
                PRV_A2_AIRCOND_INT = (dynamic)reader["PRV_A2_AIRCOND_INT"],
                PRV_A2_AIRCOND_INT_DIFF = (dynamic)reader["PRV_A2_AIRCOND_INT_DIFF"],
                PRV_A2_BATT_CHARGER_AMM_INT = (dynamic)reader["PRV_A2_BATT_CHARGER_AMM_INT"],
                PRV_A2_BATT_CHARGER_AMM_INT_DIFF = (dynamic)reader["PRV_A2_BATT_CHARGER_AMM_INT_DIFF"],
                PRV_A2_BATT_CHARGER_UTIL_INT = (dynamic)reader["PRV_A2_BATT_CHARGER_UTIL_INT"],
                PRV_A2_BATT_CHARGER_UTIL_INT_DIFF = (dynamic)reader["PRV_A2_BATT_CHARGER_UTIL_INT_DIFF"],
                PRV_A2_NON_PLANT_CONSP = (dynamic)reader["PRV_A2_NON_PLANT_CONSP"],
                PRV_A2_PLANT_CONSP_NET = (dynamic)reader["PRV_A2_PLANT_CONSP_NET"],
                PRV_A2_REMARKS = reader["PRV_A2_REMARKS"].ToString(),
                PRV_TXT_TRANS_LOSS = (dynamic)reader["PRV_TXT_TRANS_LOSS"],
                PRV_TXT_FDR1_CONSP = (dynamic)reader["PRV_TXT_FDR1_CONSP"],
                PRV_TXT_FDR2_CONSP = (dynamic)reader["PRV_TXT_FDR2_CONSP"],
                PRV_TXT_LINE_TRANS_LOSS = (dynamic)reader["PRV_TXT_LINE_TRANS_LOSS"],
                PRV_TXT_TOT_FDR = (dynamic)reader["PRV_TXT_TOT_FDR"],

                // DV
                parm_ur_gross = (dynamic)reader["parm_ur_gross"]
            };
        }


        public async Task<PAS209Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_ELECT_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS209Model response = null;
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

        public async Task saveData(PAS209SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_ELECT_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_FEEDER1_INT", value.A2_AMM_FEEDER1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_FEEDER1_INT_DIFF", value.A2_AMM_FEEDER1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_FEEDER2_INT", value.A2_AMM_FEEDER2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_FEEDER2_INT_DIFF", value.A2_AMM_FEEDER2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UTIL_FEEDER1_INT", value.A2_UTIL_FEEDER1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UTIL_FEEDER1_INT_DIFF", value.A2_UTIL_FEEDER1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UTIL_FEEDER2_INT", value.A2_UTIL_FEEDER2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UTIL_FEEDER2_INT_DIFF", value.A2_UTIL_FEEDER2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_FDFAN_INT", value.A2_AB_FDFAN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_FDFAN_INT_DIFF", value.A2_AB_FDFAN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_LEAN_PUMP_INT", value.A2_LEAN_PUMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_LEAN_PUMP_INT_DIFF", value.A2_LEAN_PUMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BFW_PUMP_INT", value.A2_BFW_PUMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BFW_PUMP_INT_DIFF", value.A2_BFW_PUMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SEMILEAN_PUMP_INT", value.A2_SEMILEAN_PUMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SEMILEAN_PUMP_INT_DIFF", value.A2_SEMILEAN_PUMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_STARTUP_BLOWER_INT", value.A2_STARTUP_BLOWER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_STARTUP_BLOWER_INT_DIFF", value.A2_STARTUP_BLOWER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PLANT_CONSP_GROSS", value.A2_PLANT_CONSP_GROSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_LIGHT_TRANSFMR_INT", value.A2_LIGHT_TRANSFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_LIGHT_TRANSFMR_INT_DIFF", value.A2_LIGHT_TRANSFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UPS_FEEDER1_INT", value.A2_UPS_FEEDER1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UPS_FEEDER1_INT_DIFF", value.A2_UPS_FEEDER1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UPS_FEEDER2_INT", value.A2_UPS_FEEDER2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UPS_FEEDER2_INT_DIFF", value.A2_UPS_FEEDER2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AIRCOND_INT", value.A2_AIRCOND_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AIRCOND_INT_DIFF", value.A2_AIRCOND_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BATT_CHARGER_AMM_INT", value.A2_BATT_CHARGER_AMM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BATT_CHARGER_AMM_INT_DIFF", value.A2_BATT_CHARGER_AMM_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BATT_CHARGER_UTIL_INT", value.A2_BATT_CHARGER_UTIL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BATT_CHARGER_UTIL_INT_DIFF", value.A2_BATT_CHARGER_UTIL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NON_PLANT_CONSP", value.A2_NON_PLANT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PLANT_CONSP_NET", value.A2_PLANT_CONSP_NET));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UREA2_CW_PUMP_INT", value.A2_UREA2_CW_PUMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UREA2_CW_PUMP_INT_DIFF", value.A2_UREA2_CW_PUMP_INT_DIFF));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
