using Microsoft.Extensions.Configuration;
using itsppisapi.Dtos;
using itsppisapi.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PBS210Repository
    {
        private readonly string _connectionString;
        public PBS210Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS210Model MapToValue(SqlDataReader reader)
        {
            return new PBS210Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                S_TRANS_DATE = reader["S_TRANS_DATE"].ToString(),
                S_USER_NAME = reader["S_USER_NAME"].ToString(),
                S_USER_ID = reader["S_USER_ID"].ToString(),
                S_DATE_MOD = reader["S_DATE_MOD"].ToString(),
                NOBAG_G1_1 = (decimal)reader["NOBAG_G1_1"],
                NOBAG_G1_2 = (decimal)reader["NOBAG_G1_2"],
                NOBAG_G1_3 = (decimal)reader["NOBAG_G1_3"],
                NOBAG_G1_4 = (decimal)reader["NOBAG_G1_4"],
                NOBAG_G1_5 = (decimal)reader["NOBAG_G1_5"],
                NOBAG_G1_6 = (decimal)reader["NOBAG_G1_6"],
                NOBAG_G1_7 = (decimal)reader["NOBAG_G1_7"],
                NOBAG_G1_8 = (decimal)reader["NOBAG_G1_8"],
                NOBAG_G1_9 = (decimal)reader["NOBAG_G1_9"],
                NOBAG_G1_10 = (decimal)reader["NOBAG_G1_10"],
                BAGQTY_G1_1 = (decimal)reader["BAGQTY_G1_1"],
                BAGQTY_G1_2 = (decimal)reader["BAGQTY_G1_2"],
                BAGQTY_G1_3 = (decimal)reader["BAGQTY_G1_3"],
                BAGQTY_G1_4 = (decimal)reader["BAGQTY_G1_4"],
                BAGQTY_G1_5 = (decimal)reader["BAGQTY_G1_5"],
                BAGQTY_G1_6 = (decimal)reader["BAGQTY_G1_6"],
                BAGQTY_G1_7 = (decimal)reader["BAGQTY_G1_7"],
                BAGQTY_G1_8 = (decimal)reader["BAGQTY_G1_8"],
                BAGQTY_G1_9 = (decimal)reader["BAGQTY_G1_9"],
                BAGQTY_G1_10 = (decimal)reader["BAGQTY_G1_10"],
                NOBAG45_G1_1 = (decimal)reader["NOBAG45_G1_1"],
                NOBAG45_G1_2 = (decimal)reader["NOBAG45_G1_2"],
                NOBAG45_G1_3 = (decimal)reader["NOBAG45_G1_3"],
                NOBAG45_G1_4 = (decimal)reader["NOBAG45_G1_4"],
                NOBAG45_G1_5 = (decimal)reader["NOBAG45_G1_5"],
                NOBAG45_G1_6 = (decimal)reader["NOBAG45_G1_6"],
                NOBAG45_G1_7 = (decimal)reader["NOBAG45_G1_7"],
                NOBAG45_G1_8 = (decimal)reader["NOBAG45_G1_8"],
                NOBAG45_G1_9 = (decimal)reader["NOBAG45_G1_9"],
                NOBAG45_G1_10 = (decimal)reader["NOBAG45_G1_10"],
                NOBAG45_G1_11 = (decimal)reader["NOBAG45_G1_11"],
                NOBAG45_G1_12 = (decimal)reader["NOBAG45_G1_12"],
                NOBAG45_G1_13 = (decimal)reader["NOBAG45_G1_13"],
                BAGQTY45_G1_1 = (decimal)reader["BAGQTY45_G1_1"],
                BAGQTY45_G1_2 = (decimal)reader["BAGQTY45_G1_2"],
                BAGQTY45_G1_3 = (decimal)reader["BAGQTY45_G1_3"],
                BAGQTY45_G1_4 = (decimal)reader["BAGQTY45_G1_4"],
                BAGQTY45_G1_5 = (decimal)reader["BAGQTY45_G1_5"],
                BAGQTY45_G1_6 = (decimal)reader["BAGQTY45_G1_6"],
                BAGQTY45_G1_7 = (decimal)reader["BAGQTY45_G1_7"],
                BAGQTY45_G1_8 = (decimal)reader["BAGQTY45_G1_8"],
                BAGQTY45_G1_9 = (decimal)reader["BAGQTY45_G1_9"],
                BAGQTY45_G1_10 = (decimal)reader["BAGQTY45_G1_10"],
                BAGQTY45_G1_11 = (decimal)reader["BAGQTY45_G1_11"],
                BAGQTY45_G1_12 = (decimal)reader["BAGQTY45_G1_12"],
                BAGQTY45_G1_13 = (decimal)reader["BAGQTY45_G1_13"],
                NOBAG_G2_1 = (decimal)reader["NOBAG_G2_1"],
                NOBAG_G2_2 = (decimal)reader["NOBAG_G2_2"],
                NOBAG_G2_3 = (decimal)reader["NOBAG_G2_3"],
                NOBAG_G2_4 = (decimal)reader["NOBAG_G2_4"],
                BAGQTY_G2_1 = (decimal)reader["BAGQTY_G2_1"],
                BAGQTY_G2_2 = (decimal)reader["BAGQTY_G2_2"],
                BAGQTY_G2_3 = (decimal)reader["BAGQTY_G2_3"],
                BAGQTY_G2_4 = (decimal)reader["BAGQTY_G2_4"],
                NOBAG45_G2_1 = (decimal)reader["NOBAG45_G2_1"],
                NOBAG45_G2_2 = (decimal)reader["NOBAG45_G2_2"],
                NOBAG45_G2_3 = (decimal)reader["NOBAG45_G2_3"],
                NOBAG45_G2_4 = (decimal)reader["NOBAG45_G2_4"],
                BAGQTY45_G2_1 = (decimal)reader["BAGQTY45_G2_1"],
                BAGQTY45_G2_2 = (decimal)reader["BAGQTY45_G2_2"],
                BAGQTY45_G2_3 = (decimal)reader["BAGQTY45_G2_3"],
                BAGQTY45_G2_4 = (decimal)reader["BAGQTY45_G2_4"],
                NOBAG45_G3_1 = (decimal)reader["NOBAG45_G3_1"],
                NOBAG45_G3_2 = (decimal)reader["NOBAG45_G3_2"],
                NOBAG45_G3_3 = (decimal)reader["NOBAG45_G3_3"],
                NOBAG45_G3_4 = (decimal)reader["NOBAG45_G3_4"],
                NOBAG45_G3_5 = (decimal)reader["NOBAG45_G3_5"],
                NOBAG45_G3_6 = (decimal)reader["NOBAG45_G3_6"],
                NOBAG45_G3_7 = (decimal)reader["NOBAG45_G3_7"],
                NOBAG45_G3_8 = (decimal)reader["NOBAG45_G3_8"],
                BAGQTY45_G3_1 = (decimal)reader["BAGQTY45_G3_1"],
                BAGQTY45_G3_2 = (decimal)reader["BAGQTY45_G3_2"],
                BAGQTY45_G3_3 = (decimal)reader["BAGQTY45_G3_3"],
                BAGQTY45_G3_4 = (decimal)reader["BAGQTY45_G3_4"],
                BAGQTY45_G3_5 = (decimal)reader["BAGQTY45_G3_5"],
                BAGQTY45_G3_6 = (decimal)reader["BAGQTY45_G3_6"],
                BAGQTY45_G3_7 = (decimal)reader["BAGQTY45_G3_7"],
                BAGQTY45_G3_8 = (decimal)reader["BAGQTY45_G3_8"],
                NOBAG_DISLV = (decimal)reader["NOBAG_DISLV"],
                NOBAG_DISLV_U2 = (decimal)reader["NOBAG_DISLV_U2"],
                NOBAG_DISLV_U3 = (decimal)reader["NOBAG_DISLV_U3"],
                NOBAG_DISLV_UPH = (decimal)reader["NOBAG_DISLV_UPH"],
                TOT = (decimal)reader["TOT"],
                DMG_BG_A = (decimal)reader["DMG_BG_A"],
                DMG_BG_B = (decimal)reader["DMG_BG_B"],
                DMG_BG_C = (decimal)reader["DMG_BG_C"],
                TOTD = (decimal)reader["TOTD"],
                G_WEIGHT_OF_BAG = (dynamic)reader["G_WEIGHT_OF_BAG"],
                G_WEIGHT_OF_BAG_45 = (dynamic)reader["G_WEIGHT_OF_BAG_45"]
            };
        }

        public async Task<PBS210Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_SLAT_DTL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PBS210Model response = null;
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

        public async Task saveData(PBS210SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_SLAT_DTL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_S_TRANS_DATE", value.S_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_1", value.NOBAG_G1_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_1", value.BAGQTY_G1_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_2", value.NOBAG_G1_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_2", value.BAGQTY_G1_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_3", value.NOBAG_G1_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_3", value.BAGQTY_G1_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_4", value.NOBAG_G1_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_4", value.BAGQTY_G1_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_5", value.NOBAG_G1_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_5", value.BAGQTY_G1_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_6", value.NOBAG_G1_6));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_6", value.BAGQTY_G1_6));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_7", value.NOBAG_G1_7));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_7", value.BAGQTY_G1_7));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_8", value.NOBAG_G1_8));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_8", value.BAGQTY_G1_8));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_9", value.NOBAG_G1_9));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_9", value.BAGQTY_G1_9));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G1_10", value.NOBAG_G1_10));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G1_10", value.BAGQTY_G1_10));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G2_1", value.NOBAG_G2_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G2_1", value.BAGQTY_G2_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G2_2", value.NOBAG_G2_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G2_2", value.BAGQTY_G2_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G2_3", value.NOBAG_G2_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G2_3", value.BAGQTY_G2_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_G2_4", value.NOBAG_G2_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY_G2_4", value.BAGQTY_G2_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_DISLV", value.NOBAG_DISLV));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_1", value.NOBAG45_G1_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_1", value.BAGQTY45_G1_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_2", value.NOBAG45_G1_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_2", value.BAGQTY45_G1_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_3", value.NOBAG45_G1_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_3", value.BAGQTY45_G1_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_4", value.NOBAG45_G1_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_4", value.BAGQTY45_G1_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_5", value.NOBAG45_G1_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_5", value.BAGQTY45_G1_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_6", value.NOBAG45_G1_6));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_6", value.BAGQTY45_G1_6));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_7", value.NOBAG45_G1_7));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_7", value.BAGQTY45_G1_7));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_8", value.NOBAG45_G1_8));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_8", value.BAGQTY45_G1_8));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G2_1", value.NOBAG45_G2_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G2_1", value.BAGQTY45_G2_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G2_2", value.NOBAG45_G2_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G2_2", value.BAGQTY45_G2_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G2_3", value.NOBAG45_G2_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G2_3", value.BAGQTY45_G2_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G2_4", value.NOBAG45_G2_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G2_4", value.BAGQTY45_G2_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_DISLV", value.NOBAG45_DISLV));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_9", value.NOBAG45_G1_9));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_9", value.BAGQTY45_G1_9));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_10", value.NOBAG45_G1_10));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_10", value.BAGQTY45_G1_10));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_1", value.NOBAG45_G3_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_1", value.BAGQTY45_G3_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_2", value.NOBAG45_G3_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_2", value.BAGQTY45_G3_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_3", value.NOBAG45_G3_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_3", value.BAGQTY45_G3_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_4", value.NOBAG45_G3_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_4", value.BAGQTY45_G3_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_5", value.NOBAG45_G3_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_5", value.BAGQTY45_G3_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_6", value.NOBAG45_G3_6));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_6", value.BAGQTY45_G3_6));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_7", value.NOBAG45_G3_7));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_7", value.BAGQTY45_G3_7));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G3_8", value.NOBAG45_G3_8));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G3_8", value.BAGQTY45_G3_8));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_11", value.NOBAG45_G1_11));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_11", value.BAGQTY45_G1_11));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_12", value.NOBAG45_G1_12));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_12", value.BAGQTY45_G1_12));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG45_G1_13", value.NOBAG45_G1_13));
                    cmd.Parameters.Add(new SqlParameter("@IN_BAGQTY45_G1_13", value.BAGQTY45_G1_13));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_DISLV_U2", value.NOBAG_DISLV_U2));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_DISLV_U3", value.NOBAG_DISLV_U3));
                    cmd.Parameters.Add(new SqlParameter("@IN_NOBAG_DISLV_UPH", value.NOBAG_DISLV_UPH));
                    cmd.Parameters.Add(new SqlParameter("@IN_DMG_BG_A", value.DMG_BG_A));
                    cmd.Parameters.Add(new SqlParameter("@IN_DMG_BG_B", value.DMG_BG_B));
                    cmd.Parameters.Add(new SqlParameter("@IN_DMG_BG_C", value.DMG_BG_C));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_USER_ID", value.S_USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
