using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PLS007Repository
    {
        private readonly string _connectionString;
        public PLS007Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS007Model MapToValue(SqlDataReader reader)
        {
            return new PLS007Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_UNIT_ID = reader["L_UNIT_ID"].ToString(),
                L_TANK_A_TEMP = (decimal)reader["L_TANK_A_TEMP"],
                L_TANK_A_DENSITY = (decimal)reader["L_TANK_A_DENSITY"],
                L_TANK_A_DENSITY15 = (decimal)reader["L_TANK_A_DENSITY15"],
                L_TANK_B_TEMP = (decimal)reader["L_TANK_B_TEMP"],
                L_TANK_B_DENSITY = (decimal)reader["L_TANK_B_DENSITY"],
                L_TANK_B_DENSITY15 = (decimal)reader["L_TANK_B_DENSITY15"],
                L_TANK_C_TEMP = (decimal)reader["L_TANK_C_TEMP"],
                L_TANK_C_DENSITY = (decimal)reader["L_TANK_C_DENSITY"],
                L_TANK_C_DENSITY15 = (decimal)reader["L_TANK_C_DENSITY15"],
                L_TANK_D_TEMP = (decimal)reader["L_TANK_D_TEMP"],
                L_TANK_D_DENSITY = (decimal)reader["L_TANK_D_DENSITY"],
                L_TANK_D_DENSITY15 = (decimal)reader["L_TANK_D_DENSITY15"],
                L_SNT_TEMP = (decimal)reader["L_SNT_TEMP"],
                L_SNT_DENSITY = (decimal)reader["L_SNT_DENSITY"],
                L_SNT_DENSITY15 = (decimal)reader["L_SNT_DENSITY15"],
                L_USER_ID = (decimal)reader["L_USER_ID"],
                L_USER_NAME = reader["L_USER_NAME"].ToString(),
                L_DATE_MOD = reader["L_DATE_MOD"].ToString(),
                L_TANK_A_DENSITY30 = (decimal)reader["L_TANK_A_DENSITY30"],
                L_TANK_B_DENSITY30 = (decimal)reader["L_TANK_B_DENSITY30"],
                L_TANK_C_DENSITY30 = (decimal)reader["L_TANK_C_DENSITY30"],
                L_TANK_D_DENSITY30 = (decimal)reader["L_TANK_D_DENSITY30"],
                L_SNT_DENSITY30 = (decimal)reader["L_SNT_DENSITY30"]
            };
        }

        public async Task<PLS007Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_PPT_LB_NAP_TANK_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PLS007Model response = null;
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

        public async Task saveData(PLS007SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_SAVE_PPT_LB_NAP_TANK_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_L_TRANS_DATE", value.L_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_UNIT_ID", value.L_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_SNT_TEMP", value.L_SNT_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_SNT_DENSITY", value.L_SNT_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_SNT_DENSITY15", value.L_SNT_DENSITY15));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_A_TEMP", value.L_TANK_A_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_A_DENSITY", value.L_TANK_A_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_A_DENSITY15", value.L_TANK_A_DENSITY15));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_B_TEMP", value.L_TANK_B_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_B_DENSITY", value.L_TANK_B_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_B_DENSITY15", value.L_TANK_B_DENSITY15));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_C_TEMP", value.L_TANK_C_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_C_DENSITY", value.L_TANK_C_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_C_DENSITY15", value.L_TANK_C_DENSITY15));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_D_TEMP", value.L_TANK_D_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_D_DENSITY", value.L_TANK_D_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_D_DENSITY15", value.L_TANK_D_DENSITY15));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_USER_ID", value.L_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_A_DENSITY30", value.L_TANK_A_DENSITY30));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_B_DENSITY30", value.L_TANK_B_DENSITY30));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_C_DENSITY30", value.L_TANK_C_DENSITY30));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TANK_D_DENSITY30", value.L_TANK_D_DENSITY30));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_SNT_DENSITY30", value.L_SNT_DENSITY30));
                    cmd.Parameters.Add(new SqlParameter("@IN_FORM_CODE", value.FORM_CODE));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
