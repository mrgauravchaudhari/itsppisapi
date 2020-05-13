
using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace cfclapi.Data
{
    public class PLR205ReportRepository
    {
        private readonly string _connectionString;
        public PLR205ReportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLR205ReportModel MapToValue(SqlDataReader reader)
        {
            return new PLR205ReportModel()
            {
                SEQ = reader["SEQ"].ToString(),
                PARTICULAR = reader["PARTICULAR"].ToString(),
                PARTICULAR_DTL = reader["PARTICULAR_DTL"].ToString(),
                FCO_LIMIT = reader["FCO_LIMIT"].ToString(),
                LIMIT_1 = reader["LIMIT_1"].ToString(),
                LIMIT_2 = reader["LIMIT_2"].ToString(),
                INTERNAL_BENCH_MARKING = reader["INTERNAL_BENCH_MARKING"].ToString()
            };
        }

        public async Task<List<PLR205ReportModel>> GetById()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_COMPAR_STATEMENT_LAB_ANALS_D_RPT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<PLR205ReportModel>();
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
