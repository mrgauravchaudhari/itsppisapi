using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class BreakdownMasterRepository
    {
        private readonly string _connectionString;
        public BreakdownMasterRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private BreakdownMasterModel MapToValue(SqlDataReader reader)
        {
            return new BreakdownMasterModel()
            {
                BRKDWN_ID = (decimal)reader["BRKDWN_ID"],
                BRKDWN_TYPE = reader["BRKDWN_TYPE"].ToString(),
                BRKDWN_DESC = reader["BRKDWN_DESC"].ToString(),
                DATE_MOD = reader["DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<BreakdownMasterModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPM_GL_BREAKDOWN", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<BreakdownMasterModel>();
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

        public async Task saveData(BreakdownMasterDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPM_GL_BREAKDOWN", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_BRKDWN_ID", value.BRKDWN_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_BRKDWN_TYPE", value.BRKDWN_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_BRKDWN_DESC", value.BRKDWN_DESC));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
