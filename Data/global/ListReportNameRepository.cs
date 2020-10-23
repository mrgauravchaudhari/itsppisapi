using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ListReportNameRepository
    {
        private readonly string _connectionString;
        public ListReportNameRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListReportNameModel MapToValue(SqlDataReader reader)
        {
            return new ListReportNameModel()
            {
                L_REPORT_ID = reader["L_REPORT_ID"].ToString(),
                L_REPORT_NAME = reader["L_REPORT_NAME"].ToString()
            };
        }

        public async Task<List<ListReportNameModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT L_REPORT_ID,L_REPORT_NAME FROM [PPIS].[PPM_LB_REPORTS] ", sql))
                {
                    var response = new List<ListReportNameModel>();
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
