using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PBS203Repository
    {
        private readonly string _connectionString;
        public PBS203Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS203Model MapToValue(SqlDataReader reader)
        {
            return new PBS203Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_SHIFT_NO = reader["B_SHIFT_NO"].ToString(),
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_CONTR_NAME = reader["B_CONTR_NAME"].ToString(),
                B_LOADING_TYPE = reader["B_LOADING_TYPE"].ToString(),
                B_WORK_DESC = reader["B_WORK_DESC"].ToString(),
                B_UOM = reader["B_UOM"].ToString(),
                B_BAGG_QTY_PF1 = (dynamic)reader["B_BAGG_QTY_PF1"],
                B_BAGG_QTY = (dynamic)reader["B_BAGG_QTY"],
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<PBS203Model>> put2(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_SHIFT_LOADING", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PBS203Model>();
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
    }
}
