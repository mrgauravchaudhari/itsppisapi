using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PBS007Repository
    {
        private readonly string _connectionString;
        public PBS007Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS007Model MapToValue(SqlDataReader reader)
        {
            return new PBS007Model()
            {
                B_WORK_CODE = reader["B_WORK_CODE"].ToString(),
                B_WORK_DESC = reader["B_WORK_DESC"].ToString(),
                B_UOM = reader["B_UOM"].ToString(),
                B_WORK_RATE = (decimal)reader["B_WORK_RATE"],

                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_FROM_DATE = reader["B_FROM_DATE"].ToString(),
                B_TO_DATE = reader["B_TO_DATE"].ToString(),

                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<PBS007Model>> putData(PBS007ParmDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_GET_PPM_BG_WORK_RATE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.B_CONTR_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_FROM_DATE", value.B_FROM_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TO_DATE", value.B_TO_DATE));
                    var response = new List<PBS007Model>();
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
    }
}
