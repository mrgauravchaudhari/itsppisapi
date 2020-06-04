using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace itsppisapi.Data
{
    public class ListRoleRepository
    {
        private readonly string _connectionString;
        public ListRoleRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListRoleModel MapToValue(SqlDataReader reader)
        {
            return new ListRoleModel()
            {
                ROLE_ID = (decimal)reader["ROLE_ID"],
                ROLE_NAME = reader["ROLE_NAME"].ToString()
            };
        }

        public async Task<List<ListRoleModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT ROLE_ID,ROLE_NAME FROM [PPIS].[PPM_GL_ROLES]", sql))
                    {
                        var response = new List<ListRoleModel>();
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
                List<ListRoleModel> result = new List<ListRoleModel>();

                ListRoleModel data = new ListRoleModel();
                data.ROLE_ID = 1;
                data.ROLE_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }
         public async Task<List<ListRoleModel>> getData2()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT ROLE_ID,ROLE_NAME FROM [PPIS].[PPM_GL_ROLES] WHERE ACTIVE_FLG = 'A'", sql))
                    {
                        var response = new List<ListRoleModel>();
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
                List<ListRoleModel> result = new List<ListRoleModel>();

                ListRoleModel data = new ListRoleModel();
                data.ROLE_ID = 1;
                data.ROLE_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
