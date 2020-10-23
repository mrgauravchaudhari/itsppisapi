using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PGS017Repository
    {
        private readonly string _connectionString;
        public PGS017Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PGS017Model MapToValueMM(SqlDataReader reader)
        {
            return new PGS017Model()
            {
                UNIT_ID = reader["UNIT_ID"].ToString(),
                UNIT_DESC = reader["UNIT_DESC"].ToString(),
                DATE_MOD = reader["DATE_MOD"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                UNIT_INCEPTION_DATE = reader["UNIT_INCEPTION_DATE"].ToString(),
                UNIT_DESC_IN_COST = reader["UNIT_DESC_IN_COST"].ToString(),
                UNIT_MAILS = reader["UNIT_MAILS"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<PGS017Model>> putData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_PPM_GL_UNIT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<PGS017Model>();
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

        public async Task saveData(PGS017SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_SAVE_PPM_GL_UNIT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_DESC", value.UNIT_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_INCEPTION_DATE", value.UNIT_INCEPTION_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_DESC_IN_COST", value.UNIT_DESC_IN_COST));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_MAILS", value.UNIT_MAILS));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
