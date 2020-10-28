using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS002Repository
    {
        private readonly string _connectionString;
        public PLS002Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS002Model MapToValue(SqlDataReader reader)
        {
            return new PLS002Model()
            {
                L_SAMPLE_NAME = reader["L_SAMPLE_NAME"].ToString(),
                L_ATTRIBUTE_NAME = reader["L_ATTRIBUTE_NAME"].ToString(),
                L_SAMPLE_PRINT_SEQ = (decimal)reader["L_SAMPLE_PRINT_SEQ"],
                L_ACTIVE_FLAG = reader["L_ACTIVE_FLAG"].ToString(),
                L_MIN_LIMIT = (decimal)reader["L_MIN_LIMIT"],
                L_MAX_LIMIT = (decimal)reader["L_MAX_LIMIT"],
                L_MEAS_UNIT = reader["L_MEAS_UNIT"].ToString(),
                DSP_L_REPORT_NAME = reader["DSP_L_REPORT_NAME"].ToString(),
                L_REPORT_ID = (decimal)reader["L_REPORT_ID"]
            };
        }

        public async Task<List<PLS002Model>> getData()
        {
            string paramVal = "ALL";
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB1_GET_PPM_LB_REPORT_SAMPLES", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@L_REPORT_ID", paramVal));
                    var response = new List<PLS002Model>();
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
