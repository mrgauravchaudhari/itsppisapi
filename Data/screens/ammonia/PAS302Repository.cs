using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS302Repository
    {
        private readonly string _connectionString;
        public PAS302Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS302Model MapToValue(SqlDataReader reader)
        {
            return new PAS302Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                TDATE = reader["TDATE"].ToString(),
                A3_DATE_MOD = reader["A3_DATE_MOD"].ToString(),
                A3_USER_ID = (decimal)reader["A3_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                A3_DATE_TIME_FROM = reader["A3_DATE_TIME_FROM"].ToString(),
                A3_DATE_TIME_TO = reader["A3_DATE_TIME_TO"].ToString(),
                A3_TRIP_CLASS = reader["A3_TRIP_CLASS"].ToString(),
                A3_DOWNTIME_HRS = (decimal)reader["A3_DOWNTIME_HRS"],
                A3_MAJOR_INTRP_FLG = (decimal)reader["A3_MAJOR_INTRP_FLG"],
                A3_UNPROD_HRS = (decimal)reader["A3_UNPROD_HRS"],
                A3_COM_SHUT_HRS = (decimal)reader["A3_COM_SHUT_HRS"],
                A3_EQUIP_BRKDOWN = reader["A3_EQUIP_BRKDOWN"].ToString(),
                A3_PROD_LOSS = (decimal)reader["A3_PROD_LOSS"],
                A3_UNPROD_NAP = (decimal)reader["A3_UNPROD_NAP"],
                A3_UNPROD_NG = (decimal)reader["A3_UNPROD_NG"],
                A3_BRKDOWN_REASON = reader["A3_BRKDOWN_REASON"].ToString(),
                TXT_ON_STREAM_HSR = (decimal)reader["TXT_ON_STREAM_HSR"],
                TXT_TRIP_TYPE_DESC = reader["TXT_TRIP_TYPE_DESC"].ToString(),
                A3_TRIP_TYPE_ID = (decimal)reader["A3_TRIP_TYPE_ID"],
            };
        }

        private PAS302_2Model MapToValue2(SqlDataReader reader)
        {
            return new PAS302_2Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                TDATE = reader["TDATE"].ToString(),
                A3_DATE_MOD = reader["A3_DATE_MOD"].ToString(),
                A3_DATE_TIME_FROM = reader["A3_DATE_TIME_FROM"].ToString(),
                A3_USER_ID = (decimal)reader["A3_USER_ID"],
                A3_BRKDWN_HRS = (decimal)reader["A3_BRKDWN_HRS"],
                TXT_TOT_BRKDWN_HRS = (decimal)reader["TXT_TOT_BRKDWN_HRS"],
                A3_BRKDWN_CAUSE_ID = (decimal)reader["A3_BRKDWN_CAUSE_ID"],

            };
        }

        public async Task<PAS302Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM3_GET_PPT_AM3_BRKDWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS302Model response = null;
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

        public async Task<List<PAS302_2Model>> putData2(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM3_GET_PPT_AM3_BRKDWN_BREAKUP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PAS302_2Model>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue2(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PAS302SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM3_SAVE_PPT_AM3_BRKDWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_TDATE", value.TDATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_USER_ID", value.A3_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_DATE_TIME_FROM", value.A3_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_DATE_TIME_TO", value.A3_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TRIP_TYPE_ID", value.A3_TRIP_TYPE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TRIP_CLASS", value.A3_TRIP_CLASS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_DOWNTIME_HRS", value.A3_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UNPROD_HRS", value.A3_UNPROD_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_COM_SHUT_HRS", value.A3_COM_SHUT_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_EQUIP_BRKDOWN", value.A3_EQUIP_BRKDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MAJOR_INTRP_FLG", value.A3_MAJOR_INTRP_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_BRKDOWN_REASON", value.A3_BRKDOWN_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PROD_LOSS", value.A3_PROD_LOSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UNPROD_NAP", value.A3_UNPROD_NAP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UNPROD_NG", value.A3_UNPROD_NG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        public async Task saveData2(PAS302_2SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM3_SAVE_PPT_AM3_BRKDWN_BREAKUP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_TDATE", value.TDATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_USER_ID", value.A3_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_BRKDWN_CAUSE_ID", value.A3_BRKDWN_CAUSE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_BRKDWN_HRS", value.A3_BRKDWN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_DATE_TIME_FROM", value.A3_DATE_TIME_FROM));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
