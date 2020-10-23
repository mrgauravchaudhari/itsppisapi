using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace itsppisapi.Data
{
    public class ListUserRepository
    {
        private readonly string _connectionString;
        public ListUserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListUserModel MapToValue(SqlDataReader reader)
        {
            return new ListUserModel()
            {
                USER_ID = (decimal)reader["USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<ListUserModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT USER_ID,USER_NAME FROM [PPIS].[PPM_GL_MST_USERS] WHERE ACTIVE_FLAG = 'A'", sql))
                    {
                        var response = new List<ListUserModel>();
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
            catch (Exception ex)
            {
                List<ListUserModel> result = new List<ListUserModel>();

                ListUserModel data = new ListUserModel();
                data.USER_ID = 1;
                data.USER_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
