using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace itsppisapi.Data
{
    public class ListAccessModuleRepository
    {
        private readonly string _connectionString;
        public ListAccessModuleRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListAccessModuleModel MapToValue(SqlDataReader reader)
        {
            return new ListAccessModuleModel()
            {
                ROLE_ID = (decimal)reader["ROLE_ID"],
                USER_ID = (decimal)reader["USER_ID"],
                ACCESS_FLAG = reader["ACCESS_FLAG"].ToString()
            };
        }

        public async Task<List<ListAccessModuleModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [ROLE_ID],[USER_ID],[ACCESS_FLAG] FROM [PPIS].[PPM_GL_MODULE_ACCESS]", sql))
                {
                    var response = new List<ListAccessModuleModel>();
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
