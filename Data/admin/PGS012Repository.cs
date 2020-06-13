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
    public class PGS012Repository
    {
        private readonly string _connectionString;

        public PGS012Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PGS012Model MapToValue(SqlDataReader reader)
        {
            return new PGS012Model()
            {
                GROUP_ID = (decimal)reader["GROUP_ID"],
                GROUP_NAME = reader["GROUP_NAME"].ToString(),
                GROUP_DESC = reader["GROUP_DESC"].ToString(),
                USER_BY = (decimal)reader["USER_BY"],
                ACTIVE_FLG = reader["ACTIVE_FLG"].ToString(),
                GROUP_MODULES = reader["GROUP_MODULES"].ToString()
            };
        }

        public async Task<PGS012Model> putData(StringParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MODULE_GROUP_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_NAME", data.StringParameter));
                    PGS012Model response = null;
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

        public async Task saveRole(PGS012SaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE_GROUP_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_NAME", data.GROUP_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_DESC", data.GROUP_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLG", data.ACTIVE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_BY", data.USER_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_MODULES", data.GROUP_MODULES));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
