using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class FormAccessRepository
    {
        private readonly string _connectionString;
        public FormAccessRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private FormAccessModel MapToValue1(SqlDataReader reader)
        {
            return new FormAccessModel()
            {
                ACCESS_FLAG = reader["ACCESS_FLAG"].ToString(),
            };
        }

        public async Task<FormAccessModel> putData(FormAccessParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PPIS.PPU_F_GET_USER_FRM_ACCESS_MASTERS('" + value.USER_ID + "','" + value.TDATE + "','" + value.FORM_CODE + "','" + value.UNIT_ID + "') AS ACCESS_FLAG", sql))
                {
                    FormAccessModel response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue1(reader);
                        }
                    }
                    return response;
                }
            }
        }

        private FormAccessModel MapToValue2(SqlDataReader reader)
        {
            return new FormAccessModel()
            {
                ACCESS_FLAG = reader["ACCESS_FLAG"].ToString(),
            };
        }

        public async Task<FormAccessModel> putData2(FormAccessParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PPIS.PPU_F_GET_USER_FRM_ACCESS_TRANSACTIONS('" + value.USER_ID + "','" + value.TDATE + "','" + value.FORM_CODE + "','" + value.UNIT_ID + "') AS ACCESS_FLAG", sql))
                {
                    FormAccessModel response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue2(reader);
                        }
                    }
                    return response;
                }
            }
        }
    }
}