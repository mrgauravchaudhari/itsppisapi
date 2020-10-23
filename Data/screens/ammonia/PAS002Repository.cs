using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PAS002Repository
    {
        private readonly string _connectionString;
        public PAS002Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS002Model MapToValue(SqlDataReader reader)
        {
            return new PAS002Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A1_TRANS_DATE = reader["A1_TRANS_DATE"].ToString(),
                A1_TRIP_TIME = reader["A1_TRIP_TIME"].ToString(),
                A1_RESUME_TIME = reader["A1_RESUME_TIME"].ToString(),
                A1_TRIP_TYPE_ID = (decimal)reader["A1_TRIP_TYPE_ID"],
                RUNNING_HOURS = (decimal)reader["RUNNING_HOURS"],
                A1_NO_MAJOR_INTRP_FLG = (decimal)reader["A1_NO_MAJOR_INTRP_FLG"],
                A1_UNPROD_HRS = (decimal)reader["A1_UNPROD_HRS"],
                A1_SHUTDOWN_HRS = (decimal)reader["A1_SHUTDOWN_HRS"],
                A1_PROD_LOSS = (decimal)reader["A1_PROD_LOSS"],
                A1_UNPROD_NG = (decimal)reader["A1_UNPROD_NG"],
                A1_PREV_MAINT_HRS = (decimal)reader["A1_PREV_MAINT_HRS"],
                A1_INSTRUMENTATION_PROB_HRS = (decimal)reader["A1_INSTRUMENTATION_PROB_HRS"],
                A1_EQP_BAD_HRS = (decimal)reader["A1_EQP_BAD_HRS"],
                A1_EXTER_POWER_HRS = (decimal)reader["A1_EXTER_POWER_HRS"],
                A1_RAW_MAT_SHORTAGE_HRS = (decimal)reader["A1_RAW_MAT_SHORTAGE_HRS"],
                A1_MISC1_HRS = (decimal)reader["A1_MISC1_HRS"],
                A1_MISC1_REASON = reader["A1_MISC1_REASON"].ToString(),
                A1_MISC2_HRS = (decimal)reader["A1_MISC2_HRS"],
                A1_MISC2_REASON = reader["A1_MISC2_REASON"].ToString(),
                A1_MISC3_HRS = (decimal)reader["A1_MISC3_HRS"],
                A1_MISC3_REASON = reader["A1_MISC3_REASON"].ToString(),
                A1_BRKDOWN_REASON = reader["A1_BRKDOWN_REASON"].ToString(),
                A1_DATE_MOD = reader["A1_DATE_MOD"].ToString(),
                A1_USER_ID = (decimal)reader["A1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_A1_TRANS_DATE = reader["PRV_A1_TRANS_DATE"].ToString(),
                PRV_A1_TRIP_TIME = reader["PRV_A1_TRIP_TIME"].ToString(),
                PRV_A1_RESUME_TIME = reader["PRV_A1_RESUME_TIME"].ToString(),
                PRV_A1_TRIP_TYPE_ID = (decimal)reader["PRV_A1_TRIP_TYPE_ID"],
                PRV_A1_NO_MAJOR_INTRP_FLG = (decimal)reader["PRV_A1_NO_MAJOR_INTRP_FLG"],
                PRV_A1_UNPROD_HRS = (decimal)reader["PRV_A1_UNPROD_HRS"],
                PRV_A1_SHUTDOWN_HRS = (decimal)reader["PRV_A1_SHUTDOWN_HRS"],
                PRV_A1_PREV_MAINT_HRS = (decimal)reader["PRV_A1_PREV_MAINT_HRS"],
                PRV_A1_INSTRUMENTATION_PROB_HRS = (decimal)reader["PRV_A1_INSTRUMENTATION_PROB_HRS"],
                PRV_A1_EQP_BAD_HRS = (decimal)reader["PRV_A1_EQP_BAD_HRS"],
                PRV_A1_EXTER_POWER_HRS = (decimal)reader["PRV_A1_EXTER_POWER_HRS"],
                PRV_A1_RAW_MAT_SHORTAGE_HRS = (decimal)reader["PRV_A1_RAW_MAT_SHORTAGE_HRS"],
                PRV_A1_MISC1_HRS = (decimal)reader["PRV_A1_MISC1_HRS"],
                PRV_A1_MISC1_REASON = reader["PRV_A1_MISC1_REASON"].ToString(),
                PRV_A1_MISC2_HRS = (decimal)reader["PRV_A1_MISC2_HRS"],
                PRV_A1_MISC2_REASON = reader["PRV_A1_MISC2_REASON"].ToString(),
                PRV_A1_MISC3_HRS = (decimal)reader["PRV_A1_MISC3_HRS"],
                PRV_A1_MISC3_REASON = reader["PRV_A1_MISC3_REASON"].ToString(),
                PRV_A1_BRKDOWN_REASON = reader["PRV_A1_BRKDOWN_REASON"].ToString()
            };
        }

        public async Task<PAS002Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_GET_PPT_AM_BRKDOWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS002Model response = null;
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

        public async Task saveData(PAS002SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_SAVE_PPT_AM_BRKDOWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TRANS_DATE", value.A1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_USER_ID", value.A1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MISC2_HRS", value.A1_MISC2_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TRIP_TYPE_ID", value.A1_TRIP_TYPE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_SHUTDOWN_HRS", value.A1_SHUTDOWN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_BRKDOWN_REASON", value.A1_BRKDOWN_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NO_MAJOR_INTRP_FLG", value.A1_NO_MAJOR_INTRP_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UNPROD_HRS", value.A1_UNPROD_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_PREV_MAINT_HRS", value.A1_PREV_MAINT_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_EQP_BAD_HRS", value.A1_EQP_BAD_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_EXTER_POWER_HRS", value.A1_EXTER_POWER_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RAW_MAT_SHORTAGE_HRS", value.A1_RAW_MAT_SHORTAGE_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_INSTRUMENTATION_PROB_HRS", value.A1_INSTRUMENTATION_PROB_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MISC1_HRS", value.A1_MISC1_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MISC1_REASON", value.A1_MISC1_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MISC2_REASON", value.A1_MISC2_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MISC3_HRS", value.A1_MISC3_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MISC3_REASON", value.A1_MISC3_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TRIP_TIME", value.A1_TRIP_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_RESUME_TIME", value.A1_RESUME_TIME));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
