using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS014Repository
    {
        private readonly string _connectionString;
        public POS014Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS014Model MapToValue(SqlDataReader reader)
        {
            return new POS014Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_DMY_FLG = reader["OU1_DMY_FLG"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_AB1_FEED_WATER_INT = (decimal)reader["OU1_AB1_FEED_WATER_INT"],
                OU1_AB1_FEED_WATER_CONSP = (decimal)reader["OU1_AB1_FEED_WATER_CONSP"],
                OU1_AB2_FEED_WATER_INT = (decimal)reader["OU1_AB2_FEED_WATER_INT"],
                OU1_AB2_FEED_WATER_CONSP = (decimal)reader["OU1_AB2_FEED_WATER_CONSP"],
                OU1_HRSG1_FEED_WATER_INT = (decimal)reader["OU1_HRSG1_FEED_WATER_INT"],
                OU1_HRSG1_FEED_WATER_CONSP = (decimal)reader["OU1_HRSG1_FEED_WATER_CONSP"],
                OU1_HRSG2_FEED_WATER_INT = (decimal)reader["OU1_HRSG2_FEED_WATER_INT"],
                OU1_HRSG2_FEED_WATER_CONSP = (decimal)reader["OU1_HRSG2_FEED_WATER_CONSP"],
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                //PRV
                PRV_OU1_TRANS_DATE = reader["PRV_OU1_TRANS_DATE"].ToString(),
                PRV_OU1_AB1_FEED_WATER_INT = (decimal)reader["PRV_OU1_AB1_FEED_WATER_INT"],
                PRV_OU1_AB2_FEED_WATER_INT = (decimal)reader["PRV_OU1_AB2_FEED_WATER_INT"],
                PRV_OU1_HRSG1_FEED_WATER_INT = (decimal)reader["PRV_OU1_HRSG1_FEED_WATER_INT"],
                PRV_OU1_HRSG2_FEED_WATER_INT = (decimal)reader["PRV_OU1_HRSG2_FEED_WATER_INT"]
            };
        }

        public async Task<POS014Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_FEED_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    POS014Model response = null;
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

        public async Task saveData(POS014SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_FEED_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMY_FLG", value.OU1_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB1_FEED_WATER_INT", value.OU1_AB1_FEED_WATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB1_FEED_WATER_CONSP", value.OU1_AB1_FEED_WATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB2_FEED_WATER_INT", value.OU1_AB2_FEED_WATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB2_FEED_WATER_CONSP", value.OU1_AB2_FEED_WATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HRSG1_FEED_WATER_INT", value.OU1_HRSG1_FEED_WATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HRSG1_FEED_WATER_CONSP", value.OU1_HRSG1_FEED_WATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HRSG2_FEED_WATER_INT", value.OU1_HRSG2_FEED_WATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HRSG2_FEED_WATER_CONSP", value.OU1_HRSG2_FEED_WATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
