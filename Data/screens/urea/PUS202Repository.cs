using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS202Repository
    {
        private readonly string _connectionString;
        public PUS202Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS202Model MapToValue(SqlDataReader reader)
        {
            return new PUS202Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                U2_TRANS_DATE = reader["U2_TRANS_DATE"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),
                U2_USER_ID = (dynamic)reader["U2_USER_ID"],

                U2_BRKDWN_ID = (dynamic)reader["U2_BRKDWN_ID"],
                U2_UREA_UNIT = reader["U2_UREA_UNIT"].ToString(),
                U2_DATE_TIME_FROM = reader["U2_DATE_TIME_FROM"].ToString(),
                U2_DATE_TIME_TO = reader["U2_DATE_TIME_TO"].ToString(),
                U2_DOWNTIME_HRS = (dynamic)reader["U2_DOWNTIME_HRS"],
                U2_NO_MAJOR_INTRP_TRAIN = (dynamic)reader["U2_NO_MAJOR_INTRP_TRAIN"],
                U2_NO_MAJOR_INTRP_PLANT = (dynamic)reader["U2_NO_MAJOR_INTRP_PLANT"],
                U2_REASON = reader["U2_REASON"].ToString(),
                U2_DATE_MOD = reader["U2_DATE_MOD"].ToString(),
            };
        }

        public async Task<List<PUS202Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_GET_PPT_UR2_BRKDWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PUS202Model>();
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

        public async Task saveData(PUS202Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_SAVE_PPT_UR2_BRKDWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TRANS_DATE", value.U2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_USER_ID", value.U2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_UREA_UNIT", value.U2_UREA_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DATE_TIME_FROM", value.U2_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DATE_TIME_TO", value.U2_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_BRKDWN_ID", value.U2_BRKDWN_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_NO_MAJOR_INTRP_TRAIN", value.U2_NO_MAJOR_INTRP_TRAIN));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_NO_MAJOR_INTRP_PLANT", value.U2_NO_MAJOR_INTRP_PLANT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DOWNTIME_HRS", value.U2_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_REASON", value.U2_REASON));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
