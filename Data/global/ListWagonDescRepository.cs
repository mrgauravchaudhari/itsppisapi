using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class ListWagonDescRepository
    {
        private readonly string _connectionString;
        public ListWagonDescRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListWagonDescModel MapToValue(SqlDataReader reader)
        {
            return new ListWagonDescModel()
            {
                B_WAGON_TYPE = reader["B_WAGON_TYPE"].ToString(),
                B_WAGON_DESC = reader["B_WAGON_DESC"].ToString(),
            };
        }

        public async Task<List<ListWagonDescModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT B_WAGON_TYPE,B_WAGON_DESC FROM PPIS.PPM_BG_WAGON_TYPE", sql))
                    {
                        var response = new List<ListWagonDescModel>();
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
                List<ListWagonDescModel> result = new List<ListWagonDescModel>();
                ListWagonDescModel data = new ListWagonDescModel();
                data.B_WAGON_TYPE = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
