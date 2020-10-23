using Microsoft.Extensions.Configuration;
using itsppisapi.Dtos;
using itsppisapi.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PBS008Repository
    {
        private readonly string _connectionString;
        public PBS008Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS008Model MapToValue(SqlDataReader reader)
        {
            return new PBS008Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                TXT_BAGG_QTY = (dynamic)reader["TXT_BAGG_QTY"],
                TXT_NEEM_OIL_OP_STOCK = (dynamic)reader["TXT_NEEM_OIL_OP_STOCK"],
                B_NEEM_OIL_RECEIPT = (dynamic)reader["B_NEEM_OIL_RECEIPT"],
                B_NEEM_OIL_STOCK = (dynamic)reader["B_NEEM_OIL_STOCK"],
                B_NEEM_OIL_TRANSFER_G3 = (dynamic)reader["B_NEEM_OIL_TRANSFER_G3"],
                B_NEEM_OIL_CONSP = (dynamic)reader["B_NEEM_OIL_CONSP"],
                B_SP_CONSP_NEEM_OIL = (dynamic)reader["B_SP_CONSP_NEEM_OIL"],
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<PBS008Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_NEEM_OIL_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PBS008Model response = null;
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

        public async Task saveData(PBS008Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_NEEM_OIL_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_CONSP", value.B_NEEM_OIL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_STOCK", value.B_NEEM_OIL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_SP_CONSP_NEEM_OIL", value.B_SP_CONSP_NEEM_OIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_RECEIPT", value.B_NEEM_OIL_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NEEM_OIL_TRANSFER_G3", value.B_NEEM_OIL_TRANSFER_G3));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
