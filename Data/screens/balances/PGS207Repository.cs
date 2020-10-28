using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS207Repository
    {
        private readonly string _connectionString;
        public PGS207Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS207Model MapToValue(SqlDataReader reader)
        {
            return new PGS207Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_AMM_FEEDER1_NG221 = (dynamic)reader["A2_AMM_FEEDER1_NG221"],
                A2_AMM_FEEDER2_NG222 = (dynamic)reader["A2_AMM_FEEDER2_NG222"],
                A2_UTIL_FEEDER1_NG227 = (dynamic)reader["A2_UTIL_FEEDER1_NG227"],
                A2_UTIL_FEEDER2_NG228 = (dynamic)reader["A2_UTIL_FEEDER2_NG228"],
                A2_AB_FDFAN_BGB101 = (dynamic)reader["A2_AB_FDFAN_BGB101"],
                A2_LEAN_PUMP_AGA402B = (dynamic)reader["A2_LEAN_PUMP_AGA402B"],
                A2_BFW_PUMP_AGA901C = (dynamic)reader["A2_BFW_PUMP_AGA901C"],
                A2_SEMILEAN_PUMP_AGA401C = (dynamic)reader["A2_SEMILEAN_PUMP_AGA401C"],
                A2_STARTUP_BLOWER_AGB301 = (dynamic)reader["A2_STARTUP_BLOWER_AGB301"],
                A2_PLANT_CONSP_GROSS = (dynamic)reader["A2_PLANT_CONSP_GROSS"],
                A2_LIGHT_TRANSFMR_NG401 = (dynamic)reader["A2_LIGHT_TRANSFMR_NG401"],
                A2_UPS_FEEDER1_NG601A = (dynamic)reader["A2_UPS_FEEDER1_NG601A"],
                A2_UPS_FEEDER2_NG601B = (dynamic)reader["A2_UPS_FEEDER2_NG601B"],
                A2_AIRCOND_NG312 = (dynamic)reader["A2_AIRCOND_NG312"],
                A2_BATT_CHARGER_AMM_NG501 = (dynamic)reader["A2_BATT_CHARGER_AMM_NG501"],
                A2_BATT_CHARGER_UTIL_NG503 = (dynamic)reader["A2_BATT_CHARGER_UTIL_NG503"],
                A2_NON_PLANT_CONSP = (dynamic)reader["A2_NON_PLANT_CONSP"],
                A2_TRANSFMR_LOSS = (dynamic)reader["A2_TRANSFMR_LOSS"],
                A2_PLANT_CONSP_NET = (dynamic)reader["A2_PLANT_CONSP_NET"],
                U2_TRAIN_A_FEEDER1_NG223 = (dynamic)reader["U2_TRAIN_A_FEEDER1_NG223"],
                U2_TRAIN_A_FEEDER2_NG224 = (dynamic)reader["U2_TRAIN_A_FEEDER2_NG224"],
                U2_TRAIN_B_FEEDER1_NG225 = (dynamic)reader["U2_TRAIN_B_FEEDER1_NG225"],
                U2_TRAIN_B_FEEDER2_NG226 = (dynamic)reader["U2_TRAIN_B_FEEDER2_NG226"],
                U2_PLANT_CONSP_GROSS = (dynamic)reader["U2_PLANT_CONSP_GROSS"],
                U2_LIGHT_TRANSFMR_NG402 = (dynamic)reader["U2_LIGHT_TRANSFMR_NG402"],
                U2_PDB_NG421 = (dynamic)reader["U2_PDB_NG421"],
                U2_NON_PLANT_CONSP = (dynamic)reader["U2_NON_PLANT_CONSP"],
                U2_TRANSFMR_LOSS = (dynamic)reader["U2_TRANSFMR_LOSS"],
                U2_PLANT_CONSP_NET = (dynamic)reader["U2_PLANT_CONSP_NET"],
                E1_UNIT2_FDR1_NG101 = (dynamic)reader["E1_UNIT2_FDR1_NG101"],
                E1_UNIT2_FDR2_NG102 = (dynamic)reader["E1_UNIT2_FDR2_NG102"],
                A2_TOT_DRAW_FRM_GPI = (dynamic)reader["A2_TOT_DRAW_FRM_GPI"],
                A2_LINE1_TRANSFMR_LOSS = (dynamic)reader["A2_LINE1_TRANSFMR_LOSS"],
                A2_REMARKS = reader["A2_REMARKS"].ToString(),
                U2_REMARKS = reader["U2_REMARKS"].ToString(),
                A2_UREA2_CW_PUMP_INT_DIFF = (dynamic)reader["A2_UREA2_CW_PUMP_INT_DIFF"]
            };
        }

        public async Task<PGS207Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_ELECT_BAL_PGS207", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS207Model response = null;
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
    }
}
