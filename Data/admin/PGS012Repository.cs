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
                USER_ID = (int)reader["USER_ID"],
                ACTIVE_FLG = reader["ACTIVE_FLG"].ToString(),
            };
        }

        public async Task<List<PGS012Model>> getData()
        {

            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [PPIS].[PPM_GL_ROLES]", sql))
                {
                    var response = new List<PGS012Model>();
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

        public async Task saveData(PGS012SaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_ROLES]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_NAME", data.ROLE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_DESC", data.ROLE_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", data.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLG", data.ACTIVE_FLG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
