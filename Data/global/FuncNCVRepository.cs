using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class FuncNCVRepository
    {
        private readonly string _connectionString;
        public FuncNCVRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private FuncNCVModel MapToValue(SqlDataReader reader)
        {
            return new FuncNCVModel()
            {
                NCV_GP3 = (decimal)reader["NCV_GP3"],
            };
        }

        public async Task<FuncNCVModel> putData(FuncNCVParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PPIS.NCV_GP3 (CONVERT(DATE,'" + value.A3_TRANS_DATE + "',105),'" + value.TAG + "','" + value.A3_TOT_NG_RECV + "','" + value.A3_NG_LCV + "','" + value.A3_NG_IMPORT_FROM_GP_I + "','" + value.GP1_NCV + "','" + value.A3_NG_IMPORT_FROM_GP_II + "','" + value.GP2_NCV + "') AS NCV_GP3", sql))
                {
                    FuncNCVModel response = null;
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
