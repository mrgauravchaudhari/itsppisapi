using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class RakeWagonDltsRepository
    {
        private readonly string _connectionString;
        public RakeWagonDltsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private RakeWagonDlts MapToValue(SqlDataReader reader)
        {
            return new RakeWagonDlts()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_RAKE_NO = reader["B_RAKE_NO"].ToString(),
                B_WAGON_TYPE = reader["B_WAGON_TYPE"].ToString(),
                B_NO_WAGONS_PF1 = (dynamic)reader["B_NO_WAGONS_PF1"],
                B_NO_WAGONS = (dynamic)reader["B_NO_WAGONS"],
            };
        }
        public async Task<List<RakeWagonDlts>> putData(threeParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_RAKE_WAGON_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<RakeWagonDlts>();
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

        public async Task saveData(RakeWagonDltsSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_RAKE_WAGON_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_NO", value.B_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAGON_TYPE", value.B_WAGON_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_WAGONS", value.B_NO_WAGONS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_WAGONS_PF1", value.B_NO_WAGONS_PF1));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
