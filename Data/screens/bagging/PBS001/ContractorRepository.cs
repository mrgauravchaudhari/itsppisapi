using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ContractorRepository
    {
        private readonly string _connectionString;
        public ContractorRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ContractorModel MapToValue(SqlDataReader reader)
        {
            return new ContractorModel()
            {
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_CONTR_NAME = reader["B_CONTR_NAME"].ToString(),
                B_CONTR_ADD = reader["B_CONTR_ADD"].ToString(),
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<ContractorModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_GET_PPM_BG_CONTRACTOR", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<ContractorModel>();
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

        public async Task saveData(ContractorDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_SAVE_PPM_BG_CONTRACTOR", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.B_CONTR_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_NAME", value.B_CONTR_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_ADD", value.B_CONTR_ADD));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
