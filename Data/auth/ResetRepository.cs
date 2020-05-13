using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using cfclapi.Dtos;

namespace cfclapi.Data
{
    public class ResetRepository
    {
        private readonly string _connectionString;
        public ResetRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ResetModel MapToValue(SqlDataReader reader)
        {
            return new ResetModel()
            {
                PASSWORD_TEMP = reader["PASSWORD_TEMP"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),
            };
        }

        public async Task<ResetModel> getData(StringParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.TEMP_PWD_SET", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_UserName", data.StringParameter));
                    ResetModel response = null;
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
    }
}
