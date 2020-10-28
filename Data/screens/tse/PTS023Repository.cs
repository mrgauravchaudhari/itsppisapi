using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PTS023Repository
    {
        private readonly string _connectionString;
        public PTS023Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PTS023Model MapToValueMM(SqlDataReader reader)
        {
            return new PTS023Model()
            {
                CONST_CODE = reader["CONST_CODE"].ToString(),
                CONST_DESC = reader["CONST_DESC"].ToString(),
                CONST_REF = reader["CONST_REF"].ToString(),
                CONST_VALUE = reader["CONST_VALUE"].ToString(),
                CONST_UNIT = reader["CONST_UNIT"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                DATE_MOD = reader["DATE_MOD"].ToString(),
                CONST_FROM_DATE = reader["CONST_FROM_DATE"].ToString(),
                CONST_TO_DATE = reader["CONST_TO_DATE"].ToString(),
                CONST_UNIT_ID = reader["CONST_UNIT_ID"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<PTS023Model>> putData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_PPM_TS_CONST_PARAMS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<PTS023Model>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueMM(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PTS023SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_SAVE_PPM_TS_CONST_PARAMS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_CODE", value.CONST_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_DESC", value.CONST_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_REF", value.CONST_REF));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_VALUE", value.CONST_VALUE));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_UNIT", value.CONST_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_FROM_DATE", value.CONST_FROM_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_TO_DATE", value.CONST_TO_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_CONST_UNIT_ID", value.CONST_UNIT_ID));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
