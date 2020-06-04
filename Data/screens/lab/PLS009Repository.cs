using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS009Repository
    {
        private readonly string _connectionString;
        public PLS009Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS009Model MapToValue(SqlDataReader reader)
        {
            return new PLS009Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_REPORT_NAME = reader["L_REPORT_NAME"].ToString(),
                L_SHIFT_NO = reader["L_SHIFT_NO"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_SAMPLE_NAME = reader["L_SAMPLE_NAME"].ToString(),
                L_ATTRIBUTE_NAME = reader["L_ATTRIBUTE_NAME"].ToString(),
                L_VALUE = reader["L_VALUE"].ToString()
            };
        }
        public async Task<List<PLS009Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB1_GET_PPT_LB_ADHOC_DATA_ENTRY", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PLS009Model>();
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
