using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PBS015Repository
    {
        private readonly string _connectionString;
        public PBS015Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS015Model MapToValue(SqlDataReader reader)
        {
            return new PBS015Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                TXT_BAGG_QTY = (dynamic)reader["TXT_BAGG_QTY"],
                TXT_NEEM_OIL_OP_STOCK = (dynamic)reader["TXT_NEEM_OIL_OP_STOCK"],
                B_NEEM_OIL_RECEIPT = (dynamic)reader["B_NEEM_OIL_RECEIPT"],
                B_NEEM_OIL_STOCK = (dynamic)reader["B_NEEM_OIL_STOCK"],
                B_NEEM_OIL_CONSP = (dynamic)reader["B_NEEM_OIL_CONSP"],
                B_SP_CONSP_NEEM_OIL = (dynamic)reader["B_SP_CONSP_NEEM_OIL"],
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<PBS015Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_NEEM_OIL_DETAILS_G2", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PBS015Model response = null;
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

        public async Task saveData(PBS015Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_NEEM_OIL_DETAILS_G2", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_CONSP", value.B_NEEM_OIL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_STOCK", value.B_NEEM_OIL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_SP_CONSP_NEEM_OIL", value.B_SP_CONSP_NEEM_OIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_RECEIPT", value.B_NEEM_OIL_RECEIPT));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
