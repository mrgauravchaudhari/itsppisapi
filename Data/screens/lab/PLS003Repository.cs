using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using cfclapi.Dtos;

namespace cfclapi.Data
{
    public class PLS003Repository
    {
        private readonly string _connectionString;
        public PLS003Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS003Model MapToValue(SqlDataReader reader)
        {
            return new PLS003Model()
            {
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_REPORT_ID = reader["L_REPORT_ID"].ToString(),
                DIS_REPORT_NAME = reader["DIS_REPORT_NAME"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_SHIFT_NO = reader["L_SHIFT_NO"].ToString(),
                L_SAMPLE_NAME = reader["L_SAMPLE_NAME"].ToString(),
                L_ATTRIBUTE_NAME = reader["L_ATTRIBUTE_NAME"].ToString(),
                L_VALUE = reader["L_VALUE"].ToString()
            };
        }

        public async Task<List<PLS003Model>> getData(PLS003Dto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB1_GET_PPT_LB_DATA_ENTRY", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.L_TRANS_DATE));
                    var response = new List<PLS003Model>();
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