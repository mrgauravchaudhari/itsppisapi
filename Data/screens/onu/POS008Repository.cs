using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System;

namespace itsppisapi.Data
{
    public class POS008Repository
    {
        private readonly string _connectionString;
        public POS008Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS008Model MapToValue(SqlDataReader reader)
        {
            return new POS008Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DMY_FLG = reader["OU1_DMY_FLG"].ToString(),
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),
                OU1_SP_NAP_AB1 = (decimal)reader["OU1_SP_NAP_AB1"],
                OU1_SP_NAP_AB2 = (decimal)reader["OU1_SP_NAP_AB2"],
                OU1_SP_NAP_AB = (decimal)reader["OU1_SP_NAP_AB"],
                OU1_SP_NAP_GT1 = (decimal)reader["OU1_SP_NAP_GT1"],
                OU1_SP_NAP_GT2 = (decimal)reader["OU1_SP_NAP_GT2"],
                OU1_SP_EQ_GAS_AB1 = (decimal)reader["OU1_SP_EQ_GAS_AB1"],
                OU1_SP_EQ_GAS_AB2 = (decimal)reader["OU1_SP_EQ_GAS_AB2"],
                OU1_SP_EQ_GAS_AB = (decimal)reader["OU1_SP_EQ_GAS_AB"],
                OU1_SP_EQ_GAS_GT1 = (decimal)reader["OU1_SP_EQ_GAS_GT1"],
                OU1_SP_EQ_GAS_GT2 = (decimal)reader["OU1_SP_EQ_GAS_GT2"],
                OU1_BOILER_EFF_AB1 = (decimal)reader["OU1_BOILER_EFF_AB1"],
                OU1_BOILER_EFF_AB2 = (decimal)reader["OU1_BOILER_EFF_AB2"],
                OU1_HEAT_RATE_GT1 = (decimal)reader["OU1_HEAT_RATE_GT1"],
                OU1_HEAT_RATE_GT2 = (decimal)reader["OU1_HEAT_RATE_GT2"],
                OU1_EQ_GAS_HRSG_GT1 = (decimal)reader["OU1_EQ_GAS_HRSG_GT1"],
                OU1_EQ_GAS_HRSG_GT2 = (decimal)reader["OU1_EQ_GAS_HRSG_GT2"],
                OU1_COMB_CYCLE_EFF_GT1 = (decimal)reader["OU1_COMB_CYCLE_EFF_GT1"],
                OU1_COMB_CYCLE_EFF_GT2 = (decimal)reader["OU1_COMB_CYCLE_EFF_GT2"],
                OU1_SP_REMARK = reader["OU1_SP_REMARK"].ToString(),
                TXT_NAPTHA = (decimal)reader["TXT_NAPTHA"],
                TXT_GAS = (decimal)reader["TXT_GAS"],
                TXT_FUEL_SPG = (decimal)reader["TXT_FUEL_SPG"],
                TXT_TOT_ENG_GEN = (decimal)reader["TXT_TOT_ENG_GEN"],
                TXT_SPG_ENG = (decimal)reader["TXT_SPG_ENG"]
            };
        }

        public async Task<POS008Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_SPECIFIC_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    POS008Model response = null;
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

        public async Task saveData(POS008SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_SPECIFIC_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMY_FLG", value.OU1_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_GAS_AB1", value.OU1_SP_GAS_AB1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_GAS_AB2", value.OU1_SP_GAS_AB2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_GAS_AB", value.OU1_SP_GAS_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_GAS_GT1", value.OU1_SP_GAS_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_GAS_GT2", value.OU1_SP_GAS_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_NAP_AB1", value.OU1_SP_NAP_AB1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_NAP_AB2", value.OU1_SP_NAP_AB2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_NAP_AB", value.OU1_SP_NAP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_NAP_GT1", value.OU1_SP_NAP_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_NAP_GT2", value.OU1_SP_NAP_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_EQ_GAS_AB1", value.OU1_SP_EQ_GAS_AB1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_EQ_GAS_AB2", value.OU1_SP_EQ_GAS_AB2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_EQ_GAS_AB", value.OU1_SP_EQ_GAS_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_EQ_GAS_GT1", value.OU1_SP_EQ_GAS_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_EQ_GAS_GT2", value.OU1_SP_EQ_GAS_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BOILER_EFF_AB1", value.OU1_BOILER_EFF_AB1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BOILER_EFF_AB2", value.OU1_BOILER_EFF_AB2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BOILER_EFF_AB", value.OU1_BOILER_EFF_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HEAT_RATE_GT1", value.OU1_HEAT_RATE_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HEAT_RATE_GT2", value.OU1_HEAT_RATE_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EQ_GAS_HRSG_GT1", value.OU1_EQ_GAS_HRSG_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EQ_GAS_HRSG_GT2", value.OU1_EQ_GAS_HRSG_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_COMB_CYCLE_EFF_GT1", value.OU1_COMB_CYCLE_EFF_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_COMB_CYCLE_EFF_GT2", value.OU1_COMB_CYCLE_EFF_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SP_REMARK", value.OU1_SP_REMARK));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
