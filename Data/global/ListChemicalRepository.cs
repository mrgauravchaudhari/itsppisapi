using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ListChemicalRepository
    {
        private readonly string _connectionString;
        public ListChemicalRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListChemicalModel MapToValue(SqlDataReader reader)
        {
            return new ListChemicalModel()
            {
                OU_CHEMICAL_ID = reader["OU_CHEMICAL_ID"].ToString(),
                OU_CHEMICAL_NAME = reader["OU_CHEMICAL_NAME"].ToString()
            };
        }

        public async Task<List<ListChemicalModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT OU_CHEMICAL_ID,OU_CHEMICAL_NAME FROM PPIS.PPM_OU_CHEMICAL", sql))
                    {
                        var response = new List<ListChemicalModel>();
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
                List<ListChemicalModel> result = new List<ListChemicalModel>();

                ListChemicalModel data = new ListChemicalModel();
                data.OU_CHEMICAL_ID = "1";
                data.OU_CHEMICAL_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
