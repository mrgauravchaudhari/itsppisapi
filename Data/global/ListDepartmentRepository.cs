using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ListDepartmentRepository
    {
        private readonly string _connectionString;
        public ListDepartmentRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListDepartmentModel MapToValue(SqlDataReader reader)
        {
            return new ListDepartmentModel()
            {
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                DEPT_NAME = reader["DEPT_NAME"].ToString()
            };
        }

        public async Task<List<ListDepartmentModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT DEPT_CODE,DEPT_NAME FROM [PPIS].[PPM_GL_Department]", sql))
                    {
                        var response = new List<ListDepartmentModel>();
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
                List<ListDepartmentModel> result = new List<ListDepartmentModel>();

                ListDepartmentModel data = new ListDepartmentModel();
                data.DEPT_CODE = "1";
                data.DEPT_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
