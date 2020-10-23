using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace itsppisapi.Data
{
    public class PGS011Repository
    {
        private readonly string _connectionString;

        public PGS011Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PGS011Model MapToValue(SqlDataReader reader)
        {
            return new PGS011Model()
            {
                MODULE_ID = (decimal)reader["MODULE_ID"],
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString(),
                MODULE_TYPE = reader["MODULE_TYPE"].ToString(),
                PARENT_MODULE_NAME = reader["PARENT_MODULE_NAME"].ToString(),
                FORM_NAME = reader["FORM_NAME"].ToString(),
                ROUTE_LINK = reader["ROUTE_LINK"].ToString(),
                LONG_DESC = reader["LONG_DESC"].ToString(),
                MOD_LEVEL = (dynamic)reader["MOD_LEVEL"],
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                UNIT_ID = reader["UNIT_ID"].ToString(),
                ACTIVE_FLG = reader["ACTIVE_FLG"].ToString(),
                ENTERED_BY = (decimal)reader["ENTERED_BY"],
            };
        }

        public async Task<List<PGS011Model>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MODULE_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<PGS011Model>();
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

        private ListParentModuleModel MapToValue2(SqlDataReader reader)
        {
            return new ListParentModuleModel()
            {
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString(),
            };
        }
        public async Task<List<ListParentModuleModel>> getData2()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PARENT_MODULE_LIST_PGS011]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<ListParentModuleModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue2(reader));
                        }
                    }
                    return response;
                }
            }
        }
       
        public async Task saveData(PGS011SaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_NAME", data.MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_DESC", data.MODULE_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_TYPE", data.MODULE_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_PARENT_MODULE_NAME", data.PARENT_MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_FORM_NAME", data.FORM_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_ROUTE_LINK", data.ROUTE_LINK));
                    cmd.Parameters.Add(new SqlParameter("@IN_LONG_DESC", data.LONG_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_DEPT_CODE", data.DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_MOD_LEVEL", data.MOD_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", data.UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLG", data.ACTIVE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_BY", data.ENTERED_BY));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}