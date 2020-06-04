using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class TreeMenuRepository
    {
        private readonly string _connectionString;
        public TreeMenuRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        public async Task<List<PPV_TREEMENU>> GetAll(NumberParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_TREEMENU]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER", data.NumberParameter));
                    var response = new List<PPV_TREEMENU>();
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

        private PPV_TREEMENU MapToValue(SqlDataReader reader)
        {
            return new PPV_TREEMENU()
            {
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString(),
                MODULE_TYPE = reader["MODULE_TYPE"].ToString(),
                ROUTE_LINK = reader["ROUTE_LINK"].ToString(),
                PARENT_MODULE_NAME = reader["PARENT_MODULE_NAME"].ToString(),
            };
        }
    }
}
