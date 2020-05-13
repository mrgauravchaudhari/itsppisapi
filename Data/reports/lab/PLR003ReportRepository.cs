
using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace itsppisapi.Data
{
    public class PLR003ReportRepository
    {
        private readonly string _connectionString;
        public PLR003ReportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLR003ReportModel MapToValue(SqlDataReader reader)
        {
            return new PLR003ReportModel()
            {
                DEP_NAME = reader["DEP_NAME"].ToString(),
                MUNIT = reader["MUNIT"].ToString(),
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_SAMPLE_NAME = reader["L_SAMPLE_NAME"].ToString(),
                L_ATTRIBUTE_NAME = reader["L_ATTRIBUTE_NAME"].ToString(),
                L_VALUE = reader["L_VALUE"].ToString(),
                L_MIN_LIMIT = (decimal)reader["L_MIN_LIMIT"],
                L_MAX_LIMIT = (decimal)reader["L_MAX_LIMIT"],
                L_REPORT_NAME = reader["L_REPORT_NAME"].ToString(),
                L_SAMPLE_PRINT_SEQ = (decimal)reader["L_SAMPLE_PRINT_SEQ"],
                L_REP_PRINT_SEQ = (decimal)reader["L_REP_PRINT_SEQ"],
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                NEW_TIME = reader["NEW_TIME"].ToString()
            };
        }

        public async Task<List<PLR003ReportModel>> GetById(string TDATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_SAMPLE_ATTR_ANALYS_WISE_D_RPT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", TDATE));
                    var response = new List<PLR003ReportModel>();
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
