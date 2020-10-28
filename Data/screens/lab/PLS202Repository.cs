using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS202Repository
    {
        private readonly string _connectionString;
        public PLS202Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS202Model MapToValue(SqlDataReader reader)
        {
            return new PLS202Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_TEMP = (decimal)reader["L_TEMP"],
                L_DENSITY = (decimal)reader["L_DENSITY"],
                L_DENSITY_15C = (decimal)reader["L_DENSITY_15C"],
                L_SULPHUR = (decimal)reader["L_SULPHUR"],
                L_BR_NO = (decimal)reader["L_BR_NO"],
                L_OLEFINES = (decimal)reader["L_OLEFINES"],
                L_AROMATICS = (decimal)reader["L_AROMATICS"],
                L_IBP = (decimal)reader["L_IBP"],
                L_NRA_50 = (decimal)reader["L_NRA_50"],
                L_NRA_95 = (decimal)reader["L_NRA_95"],
                L_FBP = (decimal)reader["L_FBP"],
                L_CH_RATIO = (decimal)reader["L_CH_RATIO"],
                L_RESIDUE = (decimal)reader["L_RESIDUE"],
                L_RECOVERY = (decimal)reader["L_RECOVERY"],
                L_LIQ_REMAIN = (decimal)reader["L_LIQ_REMAIN"],
                L_LOSS = (decimal)reader["L_LOSS"],
                L_NET_CV = (decimal)reader["L_NET_CV"],
                L_GROSS_CV = (decimal)reader["L_GROSS_CV"],
                L_USER_ID = (decimal)reader["L_USER_ID"],
                L_DATE_MOD = reader["L_DATE_MOD"].ToString(),
                L_USER_NAME = reader["L_USER_NAME"].ToString()
            };
        }

        public async Task<PLS202Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB2_GET_PPT_LB_NAP_DAYTANK2_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PLS202Model response = null;
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

        public async Task saveData(PLS202SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB2_SAVE_PPT_LB_NAP_DAYTANK2_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_L_TRANS_DATE", value.L_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TIME", value.L_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_USER_ID", value.L_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TEMP", value.L_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_DENSITY", value.L_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_DENSITY_15C", value.L_DENSITY_15C));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_SULPHUR", value.L_SULPHUR));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_AROMATICS", value.L_AROMATICS));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_BR_NO", value.L_BR_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_OLEFINES", value.L_OLEFINES));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_IBP", value.L_IBP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_NRA_50", value.L_NRA_50));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_NRA_95", value.L_NRA_95));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_FBP", value.L_FBP));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_CH_RATIO", value.L_CH_RATIO));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_RESIDUE", value.L_RESIDUE));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_RECOVERY", value.L_RECOVERY));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_LIQ_REMAIN", value.L_LIQ_REMAIN));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_LOSS", value.L_LOSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_NET_CV", value.L_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_GROSS_CV", value.L_GROSS_CV));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
