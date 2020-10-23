using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS302Repository
    {
        private readonly string _connectionString;
        public PUS302Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS302Model MapToValue(SqlDataReader reader)
        {
            return new PUS302Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                TDATE = reader["TDATE"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),
                U3_USER_ID = (dynamic)reader["U3_USER_ID"],

                U3_BRKDWN_ID = (dynamic)reader["U3_BRKDWN_ID"],
                U3_UREA_UNIT = reader["U3_UREA_UNIT"].ToString(),
                U3_DATE_TIME_FROM = reader["U3_DATE_TIME_FROM"].ToString(),
                U3_DATE_TIME_TO = reader["U3_DATE_TIME_TO"].ToString(),
                U3_DOWNTIME_HRS = (dynamic)reader["U3_DOWNTIME_HRS"],
                U3_NO_MAJOR_INTRP_TRAIN = (dynamic)reader["U3_NO_MAJOR_INTRP_TRAIN"],
                U3_NO_MAJOR_INTRP_PLANT = (dynamic)reader["U3_NO_MAJOR_INTRP_PLANT"],
                U3_REASON = reader["U3_REASON"].ToString(),
                U3_DATE_MOD = reader["U3_DATE_MOD"].ToString(),
            };
        }

        public async Task<List<PUS302Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR3_GET_PPT_UR3_BREAKDOWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PUS302Model>();
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

        public async Task saveData(PUS302Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR3_SAVE_PPT_UR3_BREAKDOWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_TDATE", value.TDATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_USER_ID", value.U3_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_UREA_UNIT", value.U3_UREA_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_DATE_TIME_FROM", value.U3_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_DATE_TIME_TO", value.U3_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_BRKDWN_ID", value.U3_BRKDWN_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_NO_MAJOR_INTRP_TRAIN", value.U3_NO_MAJOR_INTRP_TRAIN));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_NO_MAJOR_INTRP_PLANT", value.U3_NO_MAJOR_INTRP_PLANT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_DOWNTIME_HRS", value.U3_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U3_REASON", value.U3_REASON));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
