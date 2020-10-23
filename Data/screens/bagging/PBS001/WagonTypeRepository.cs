using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class WagonTypeRepository
    {
        private readonly string _connectionString;
        public WagonTypeRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private WagonTypeModel MapToValue(SqlDataReader reader)
        {
            return new WagonTypeModel()
            {
                B_WAGON_TYPE = reader["B_WAGON_TYPE"].ToString(),
                B_WAGON_DESC = reader["B_WAGON_DESC"].ToString(),
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<WagonTypeModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_GET_PPM_BG_WAGON_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<WagonTypeModel>();
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

        public async Task saveData(WagonTypeDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_SAVE_PPM_BG_WAGON_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAGON_TYPE", value.B_WAGON_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAGON_DESC", value.B_WAGON_DESC));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
