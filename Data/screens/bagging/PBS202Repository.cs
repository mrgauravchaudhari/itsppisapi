using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class PBS202Repository
    {
        private readonly string _connectionString;
        public PBS202Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS202Model MapToValue(SqlDataReader reader)
        {
            return new PBS202Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                TXT_TOT_DAMAGED = (dynamic)reader["TXT_TOT_DAMAGED"],
                TXT_TOT_RUPTURED = (dynamic)reader["TXT_TOT_RUPTURED"],
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_DEFCT_TYPE_ID = (decimal)reader["B_DEFCT_TYPE_ID"],
                B_BAG_TYPE_ID = (dynamic)reader["B_BAG_TYPE_ID"],
                B_BAG_TYPE = reader["B_BAG_TYPE"].ToString(),
                B_BAG_SIZE = (dynamic)reader["B_BAG_SIZE"],
                B_NO_BAGS_PF1 = (dynamic)reader["B_NO_BAGS_PF1"],
                B_NO_BAGS_PF2 = (dynamic)reader["B_NO_BAGS_PF2"],
                B_NO_BAGS_PF3 = (dynamic)reader["B_NO_BAGS_PF3"],
                B_NO_BAGS = (dynamic)reader["B_NO_BAGS"],
                B_AMOUNT = (dynamic)reader["B_AMOUNT"],
                B_DMY_FLG = (dynamic)reader["B_DMY_FLG"],
                TXT_DAMAGED = (dynamic)reader["TXT_DAMAGED"],
                TXT_DAMAGED_PF2 = (dynamic)reader["TXT_DAMAGED_PF2"],
                TXT_DAMAGED_PF3 = (dynamic)reader["TXT_DAMAGED_PF3"],
                TXT_RUPTURED = (dynamic)reader["TXT_RUPTURED"],
                TXT_RUPTURED_PF2 = (dynamic)reader["TXT_RUPTURED_PF2"],
                TXT_RUPTURED_PF3 = (dynamic)reader["TXT_RUPTURED_PF3"],
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<PBS202Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_DEFECTIVE_BAG_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PBS202Model>();
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

        public async Task saveData(PBS202Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_DEFECTIVE_BAG_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_TYPE_ID", value.B_BAG_TYPE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEFCT_TYPE_ID", value.B_DEFCT_TYPE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_BAGS", value.B_NO_BAGS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_AMOUNT", value.B_AMOUNT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_BAGS_PF1", value.B_NO_BAGS_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_BAGS_PF2", value.B_NO_BAGS_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_BAGS_PF3", value.B_NO_BAGS_PF3));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
