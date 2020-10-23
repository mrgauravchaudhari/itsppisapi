using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class DefectTypeRepository
    {
        private readonly string _connectionString;
        public DefectTypeRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private DefectTypeModel MapToValue(SqlDataReader reader)
        {
            return new DefectTypeModel()
            {
                B_DEFECT_TYPE_ID = (decimal)reader["B_DEFECT_TYPE_ID"],
                B_DEFECT_TYPE_NAME = reader["B_DEFECT_TYPE_NAME"].ToString(),
                B_DEFECT_GROUP = (decimal)reader["B_DEFECT_GROUP"],
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString(),
            };
        }

        public async Task<List<DefectTypeModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_GET_PPM_BG_DEFECT_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<DefectTypeModel>();
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

        public async Task saveData(DefectTypeDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_SAVE_PPM_BG_DEFECT_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEFECT_TYPE_NAME", value.B_DEFECT_TYPE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEFECT_GROUP", value.B_DEFECT_GROUP));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
