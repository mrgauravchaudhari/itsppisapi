using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class FuncNcvOnuNgRepository
    {
        private readonly string _connectionString;
        public FuncNcvOnuNgRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private FuncNcvOnuNgModel MapToValue(SqlDataReader reader)
        {
            return new FuncNcvOnuNgModel()
            {
                NCV_ONU_NG = (decimal)reader["NCV_ONU_NG"],
            };
        }

        public async Task<FuncNcvOnuNgModel> putData(FuncNcvOnuNgParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PPIS.NCV_ONU_NG (CONVERT(DATE,'" + value.A3_TRANS_DATE + "',105),'" + value.TAG + "','" + value.O3_NG_RECV_GP1_FOR_GTG3_HRSG3_CONSP + "','" + value.O3_NG_RECV_GP3_FOR_GTG3_HRSG4_CONSP + "','" + value.LCV_GP_I + "','" + value.LCV_GP_III + "') AS NCV_ONU_NG", sql))
                {
                    FuncNcvOnuNgModel response = null;
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
