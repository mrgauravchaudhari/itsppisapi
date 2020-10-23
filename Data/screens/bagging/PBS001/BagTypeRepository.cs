using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class BagTypeRepository
    {
        private readonly string _connectionString;
        public BagTypeRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private BagTypeModel MapToValue(SqlDataReader reader)
        {
            return new BagTypeModel()
            {
                B_BAG_TYPE_ID = (decimal)reader["B_BAG_TYPE_ID"],
                B_BAG_TYPE = reader["B_BAG_TYPE"].ToString(),
                B_BAG_SIZE = (decimal)reader["B_BAG_SIZE"],
                B_SERVICE_CONST = (decimal)reader["B_SERVICE_CONST"],
                B_BAG_WEIGHT = (decimal)reader["B_BAG_WEIGHT"],
                B_BAG_DESC = reader["B_BAG_DESC"].ToString(),
                B_BAG_ACTIVE_FLAG = reader["B_BAG_ACTIVE_FLAG"].ToString(),
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<BagTypeModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_GET_PPM_BG_BAG_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<BagTypeModel>();
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

        public async Task saveData(BagTypeDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_SAVE_PPM_BG_BAG_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_TYPE", value.B_BAG_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_SIZE", value.B_BAG_SIZE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESC", value.B_BAG_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_SERVICE_CONST", value.B_SERVICE_CONST));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_WEIGHT", value.B_BAG_WEIGHT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_ACTIVE_FLAG", value.B_BAG_ACTIVE_FLAG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
