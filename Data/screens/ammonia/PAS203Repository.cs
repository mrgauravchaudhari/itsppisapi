using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class PAS203Repository
    {
        private readonly string _connectionString;
        public PAS203Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS203Model MapToValue(SqlDataReader reader)
        {
            return new PAS203Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_DATE_TIME_FROM = reader["A2_DATE_TIME_FROM"].ToString(),
                A2_DATE_TIME_TO = reader["A2_DATE_TIME_TO"].ToString(),
                A2_TRIP_CLASS = (dynamic)reader["A2_TRIP_CLASS"],
                A2_DOWNTIME_HRS = (dynamic)reader["A2_DOWNTIME_HRS"],
                A2_MAJOR_INTRP_FLG = (dynamic)reader["A2_MAJOR_INTRP_FLG"],
                A2_UNPROD_HRS = (dynamic)reader["A2_UNPROD_HRS"],
                A2_COM_SHUT_HRS = (dynamic)reader["A2_COM_SHUT_HRS"],
                A2_EQUIP_BRKDOWN = (dynamic)reader["A2_EQUIP_BRKDOWN"],
                A2_PROD_LOSS = (dynamic)reader["A2_PROD_LOSS"],
                A2_UNPROD_NAP = (dynamic)reader["A2_UNPROD_NAP"],
                A2_UNPROD_NG = (dynamic)reader["A2_UNPROD_NG"],
                A2_BRKDOWN_REASON = reader["A2_BRKDOWN_REASON"].ToString(),
                TXT_ON_STREAM_HSR = (dynamic)reader["TXT_ON_STREAM_HSR"],
                A2_TRIP_TYPE_ID = reader["A2_TRIP_TYPE_ID"].ToString(),
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
            };
        }

        private PAS203_2Model MapToValue2(SqlDataReader reader)
        {
            return new PAS203_2Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_DATE_TIME_FROM = reader["A2_DATE_TIME_FROM"].ToString(),
                A2_BRKDWN_CAUSE_ID = reader["A2_BRKDWN_CAUSE_ID"].ToString(),
                A2_BRKDWN_HRS = (dynamic)reader["A2_BRKDWN_HRS"],
                TXT_TOT_BRKDWN_HRS = (dynamic)reader["TXT_TOT_BRKDWN_HRS"],
            };
        }

        public async Task<PAS203Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_BRKDWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS203Model response = null;
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

        public async Task<List<PAS203_2Model>> putData2(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_BRKDWN_BREAKUP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PAS203_2Model>();
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

        public async Task saveData(PAS203SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_BRKDWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DATE_TIME_FROM", value.A2_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DATE_TIME_TO", value.A2_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRIP_TYPE_ID", value.A2_TRIP_TYPE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRIP_CLASS", value.A2_TRIP_CLASS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DOWNTIME_HRS", value.A2_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UNPROD_HRS", value.A2_UNPROD_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_COM_SHUT_HRS", value.A2_COM_SHUT_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_EQUIP_BRKDOWN", value.A2_EQUIP_BRKDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MAJOR_INTRP_FLG", value.A2_MAJOR_INTRP_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BRKDOWN_REASON", value.A2_BRKDOWN_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PROD_LOSS", value.A2_PROD_LOSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UNPROD_NAP", value.A2_UNPROD_NAP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UNPROD_NG", value.A2_UNPROD_NG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        public async Task saveData2(PAS203_2SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_BRKDWN_BREAKUP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DATE_TIME_FROM", value.A2_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BRKDWN_CAUSE_ID", value.A2_BRKDWN_CAUSE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BRKDWN_HRS", value.A2_BRKDWN_HRS));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
