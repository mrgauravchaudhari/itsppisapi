using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class ModuleMasterRepository
    {
        private readonly string _connectionString;
        public ModuleMasterRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ModuleMasterModel MapToValue(SqlDataReader reader)
        {
            return new ModuleMasterModel()
            {
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString(),
                MODULE_TYPE = reader["MODULE_TYPE"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                PARENT_MODULE_NAME = reader["PARENT_MODULE_NAME"].ToString(),
                LONG_DESC = reader["LONG_DESC"].ToString(),
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                FREQUENCY = reader["FREQUENCY"].ToString(),
                MOD_LEVEL = (decimal)reader["MOD_LEVEL"],
                NO_PAGES = (decimal)reader["NO_PAGES"],
                FORM_NAME = reader["FORM_NAME"].ToString(),
                UNIT_ID = reader["UNIT_ID"].ToString(),
                ACTIVE_FLG = reader["ACTIVE_FLG"].ToString()
            };
        }

        public async Task<ModuleMasterModel> getData(string modulename)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MODULE]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_NAME", modulename));
                    ModuleMasterModel response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(ModuleMasterSaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_NAME", data.MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_DESC", data.MODULE_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_TYPE", data.MODULE_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", 1));
                    cmd.Parameters.Add(new SqlParameter("@IN_PARENT_MODULE_NAME", data.PARENT_MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_LONG_DESC", data.LONG_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_DEPT_CODE", data.DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_FREQUENCY", data.FREQUENCY));
                    cmd.Parameters.Add(new SqlParameter("@IN_MOD_LEVEL", data.MOD_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_NO_PAGES", data.NO_PAGES));
                    cmd.Parameters.Add(new SqlParameter("@IN_FORM_NAME", data.FORM_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", data.UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLG", data.ACTIVE_FLG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        //public async Task<List<ModuleMasterModel>> getData(string username)
        // {
        //   using (SqlConnection sql = new SqlConnection(_connectionString))
        //   {
        //     using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_GL_MST_USERS", sql))
        //     {
        //       cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //       cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", username));
        //       var response = new List<ModuleMasterModel>();
        //       await sql.OpenAsync();
        //       using (var reader = await cmd.ExecuteReaderAsync())
        //       {
        //         while (await reader.ReadAsync())
        //         {
        //           response.Add(MapToValue(reader));
        //         }
        //       }
        //       return response;
        //     }
        //   }
        // }
    }
}
