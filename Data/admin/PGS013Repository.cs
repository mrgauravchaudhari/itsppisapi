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
    public class PGS013Repository
    {
        private readonly string _connectionString;

        public PGS013Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PGS013Model MapToValue(SqlDataReader reader)
        {
            return new PGS013Model()
            {
                ROLE_ID = (decimal)reader["ROLE_ID"],
                ROLE_MODULES = reader["ROLE_MODULES"].ToString()
            };
        }

        public async Task<List<PGS013Model>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ROLE_ID, ROLE_MODULES FROM [PPIS].[PPM_GL_ROLES]", sql))
                {
                    var response = new List<PGS013Model>();
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

        public async Task saveData(PGS013SaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE_ACCESS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_ID", data.ROLE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", data.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_ROLE_MODULES", data.ROLE_MODULES));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACCESS_FLAG", data.ACCESS_FLAG));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_BY", data.USER_BY));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
