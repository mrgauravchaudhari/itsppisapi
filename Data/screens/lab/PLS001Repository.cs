using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Data
{
    public class PLS001Repository
    {
        private readonly string _connectionString;
        public PLS001Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS001Model MapToValue(SqlDataReader reader)
        {
            return new PLS001Model()
            {
                L_REPORT_NAME = reader["L_REPORT_NAME"].ToString(),
                L_REP_UNIT = reader["L_REP_UNIT"].ToString(),
                L_REP_PRINT_SEQ = (decimal)reader["L_REP_PRINT_SEQ"],
                L_REPORT_DESC = reader["L_REPORT_DESC"].ToString(),
                L_ACTIVE_FLG = reader["L_ACTIVE_FLG"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                DEPT_NAME = reader["DEPT_NAME"].ToString(),
                L_DEPT_CODE = reader["L_DEPT_CODE"].ToString()
            };
        }

        public async Task<List<PLS001Model>> getData(string DEPT_CODE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_1_GET_PPM_LB_REPORTS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@L_DEPT_CODE", DEPT_CODE));
                    var response = new List<PLS001Model>();
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

        public async Task<List<PLS001Model>> getDept()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select DEPT_CODE,DEPT_NAME from [CFCL8FULL].[PPIS].[PPM_GL_DEPARTMENT]", sql))
                {
                    var response = new List<PLS001Model>();
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
