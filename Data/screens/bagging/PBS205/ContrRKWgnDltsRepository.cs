using Microsoft.Extensions.Configuration;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class ContrRKWgnDltsRepository
    {
        private readonly string _connectionString;
        public ContrRKWgnDltsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ContrRKWgnDlts MapToValue(SqlDataReader reader)
        {
            return new ContrRKWgnDlts()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_RAKE_NO = reader["B_RAKE_NO"].ToString(),
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_WAGON_TYPE = reader["B_WAGON_TYPE"].ToString(),
                B_NO_WAGONS_PF1 = (dynamic)reader["B_NO_WAGONS_PF1"],
                B_NO_WAGONS = (dynamic)reader["B_NO_WAGONS"]
            };
        }
        public async Task<List<ContrRKWgnDlts>> putData(threeParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_CONTR_RK_WGN_DTLS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<ContrRKWgnDlts>();
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

        public async Task saveData(ContrRKWgnDltsSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_CONTR_RK_WGN_DTLS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_NO", value.B_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAGON_TYPE", value.B_WAGON_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_WAGONS_PF1", value.B_NO_WAGONS_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_WAGONS", value.B_NO_WAGONS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.B_CONTR_CODE));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
