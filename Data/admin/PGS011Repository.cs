using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
                USER_ID = (decimal)reader["USER_ID"],
                PARENT_MODULE_NAME = reader["PARENT_MODULE_NAME"].ToString(),
                ROUTE_LINK = reader["ROUTE_LINK"].ToString(),
                LONG_DESC = reader["LONG_DESC"].ToString(),
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                UNIT_ID = reader["UNIT_ID"].ToString(),
                ACTIVE_FLG = reader["ACTIVE_FLG"].ToString(),
            };
        }

        public async Task<List<PGS011Model>> getData()
        {

            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [PPIS].[PPM_GL_MODULE]", sql))
                {
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
        public async Task<PGS011Model> putData(StringParameterDto data)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_PPM_GL_MODULE", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_MODULE_NAME", data.StringParameter));
                        PGS011Model response = null;
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
            catch (Exception ex)
            {
                PGS011Model objdata = new PGS011Model();
                objdata.MODULE_NAME = "";
                objdata.MODULE_DESC = "";
                objdata.MODULE_TYPE = "";
                objdata.USER_ID = 0;
                objdata.PARENT_MODULE_NAME = "";
                objdata.ROUTE_LINK = "";
                objdata.LONG_DESC = "";
                objdata.DEPT_CODE = "";
                objdata.UNIT_ID = "";
                objdata.ACTIVE_FLG = ex.Message;
                return objdata;
            }
        }

        public async Task saveData(PGS011SaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_NAME", data.MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_DESC", data.MODULE_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_TYPE", data.MODULE_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", data.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_PARENT_MODULE_NAME", data.PARENT_MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_ROUTE_LINK", data.ROUTE_LINK));
                    cmd.Parameters.Add(new SqlParameter("@IN_LONG_DESC", data.LONG_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_DEPT_CODE", data.DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", data.UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLG", data.ACTIVE_FLG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
