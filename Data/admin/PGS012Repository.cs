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
                ROLE_ID = (decimal)reader["ROLE_ID"],
                ROLE_NAME = reader["ROLE_NAME"].ToString(),
                ROLE_DESC = reader["ROLE_DESC"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),
                ACTIVE_FLG = reader["ACTIVE_FLG"].ToString(),
                ROLE_MODULES = reader["ROLE_MODULES"].ToString()
            };
        }

        public async Task<PGS012Model> putData(StringParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_ROLES]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_NAME", data.StringParameter));
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
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_ROLES]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_NAME", data.ROLE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_DESC", data.ROLE_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLG", data.ACTIVE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_BY", data.USER_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_MODULES", data.ROLE_MODULES));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
