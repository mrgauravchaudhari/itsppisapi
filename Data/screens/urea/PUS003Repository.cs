using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS003Repository
    {
        private readonly string _connectionString;
        public PUS003Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS003Model MapToValue(SqlDataReader reader)
        {
            return new PUS003Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                U1_TRANS_DATE = reader["U1_TRANS_DATE"].ToString(),
                U1_UREA_UNIT = reader["U1_UREA_UNIT"].ToString(),
                DSP_BRKDWN_DESC = (decimal)reader["DSP_BRKDWN_DESC"],
                U1_DATE_TIME_FROM = reader["U1_DATE_TIME_FROM"].ToString(),
                U1_DATE_TIME_TO = reader["U1_DATE_TIME_TO"].ToString(),
                U1_DOWNTIME_HRS = (decimal)reader["U1_DOWNTIME_HRS"],
                U1_NO_MAJOR_INTRP_FLG = (decimal)reader["U1_NO_MAJOR_INTRP_FLG"],
                U1_REASON = reader["U1_REASON"].ToString(),
                DATE_MOD = reader["U1_DATE_MOD"].ToString(),
                U1_UNIT_ID = reader["U1_UNIT_ID"].ToString(),
                U1_DMY_FLG = reader["U1_DMY_FLG"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        private BREAKDOWN_LISTDto MapToValueList(SqlDataReader reader)
        {
            return new BREAKDOWN_LISTDto()
            {
                BRKDWN_ID = (decimal)reader["BRKDWN_ID"],
                BRKDWN_DESC = reader["BRKDWN_DESC"].ToString()
            };
        }

        public async Task<PUS003Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPT_UR_BREAKDOWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PUS003Model response = null;
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
        public async Task<List<BREAKDOWN_LISTDto>> getDataList()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_PPM_GL_BREAKDOWN_LIST", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<BREAKDOWN_LISTDto>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueList(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PUS003Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPT_UR_BREAKDOWN_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TRANS_DATE", value.U1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UNIT_ID", value.U1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UREA_UNIT", value.U1_UREA_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_DATE_TIME_FROM", value.U1_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_DMY_FLG", value.U1_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_BRKDWN_ID", value.U1_BRKDWN_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_DATE_TIME_TO", value.U1_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_REASON", value.U1_REASON));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_NO_MAJOR_INTRP_FLG", value.U1_NO_MAJOR_INTRP_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_DOWNTIME_HRS", value.U1_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
