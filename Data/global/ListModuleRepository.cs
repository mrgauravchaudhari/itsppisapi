using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace itsppisapi.Data
{
    public class ListModuleRepository
    {
        private readonly string _connectionString;
        public ListModuleRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListModuleModel MapToValue(SqlDataReader reader)
        {
            return new ListModuleModel()
            {
                MODULE_ID = (decimal)reader["MODULE_ID"],
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString()
            };
        }

        public async Task<List<ListModuleModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT MODULE_ID,MODULE_NAME,MODULE_DESC FROM [PPIS].[PPM_GL_MODULE] WHERE MODULE_TYPE = 'S' AND ACTIVE_FLG = 'A'", sql))
                    {
                        var response = new List<ListModuleModel>();
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
                List<ListModuleModel> result = new List<ListModuleModel>();

                ListModuleModel data = new ListModuleModel();
                data.MODULE_NAME = "IT";
                data.MODULE_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }
        public async Task<List<ListModuleModel>> getData2()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT MODULE_ID,MODULE_NAME,MODULE_DESC FROM [PPIS].[PPM_GL_MODULE] WHERE MODULE_TYPE = 'S' AND ACTIVE_FLG = 'A'", sql))
                    {
                        var response = new List<ListModuleModel>();
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
                List<ListModuleModel> result = new List<ListModuleModel>();

                ListModuleModel data = new ListModuleModel();
                data.MODULE_NAME = "IT";
                data.MODULE_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
