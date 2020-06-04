using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS008Repository
    {
        private readonly string _connectionString;
        public PLS008Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS008Model MapToValue(SqlDataReader reader)
        {
            return new PLS008Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                DSP_L_REPORT_NAME = reader["DSP_L_REPORT_NAME"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_SHIFT_NO = reader["L_SHIFT_NO"].ToString()
            };
        }

        public async Task<List<PLS008Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_1_GET_PPM_LB_DATA_ENTRY", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PLS008Model>();
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
