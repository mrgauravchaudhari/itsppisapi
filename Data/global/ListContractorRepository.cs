using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Microsoft.Data.SqlClient;

namespace itsppisapi.Data
{
    public class ListContractorRepository
    {
        private readonly string _connectionString;
        public ListContractorRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListContractorModel MapToValue(SqlDataReader reader)
        {
            return new ListContractorModel()
            {
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_CONTR_NAME = reader["B_CONTR_NAME"].ToString()
            };
        }

        public async Task<List<ListContractorModel>> getData()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT B_CONTR_CODE,B_CONTR_NAME FROM PPIS.PPM_BG_CONTRACTOR", sql))
                    {
                        var response = new List<ListContractorModel>();
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
                List<ListContractorModel> result = new List<ListContractorModel>();
                ListContractorModel data = new ListContractorModel();
                data.B_CONTR_CODE = "";
                data.B_CONTR_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
