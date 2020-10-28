using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS020Repository
    {
        private readonly string _connectionString;
        public POS020Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS020Model MapToValue(SqlDataReader reader)
        {
            return new POS020Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_S_TRANS_DATE = reader["OU1_S_TRANS_DATE"].ToString(),
                OU1_S_DATE_MOD = reader["OU1_S_DATE_MOD"].ToString(),
                OU1_S_USER_ID = reader["OU1_S_USER_ID"].ToString(),
                OU1_S_USER_NAME = reader["OU1_S_USER_NAME"].ToString(),
                OU1_GTG_PWR = (decimal)reader["OU1_GTG_PWR"],
                OU1_JVVNL_PWR = (decimal)reader["OU1_JVVNL_PWR"],
                OU1_KS_STEAM = (decimal)reader["OU1_KS_STEAM"],
                OU1_MP_STEAM = (decimal)reader["OU1_MP_STEAM"],
                OU1_LP_STEAM = (decimal)reader["OU1_LP_STEAM"],
                OU1_NAT_GAS = (decimal)reader["OU1_NAT_GAS"],
                OU1_NITROGEN = (decimal)reader["OU1_NITROGEN"],
                OU1_SA = (decimal)reader["OU1_SA"],
                OU1_IA = (decimal)reader["OU1_IA"],
                OU1_RAW_WATER = (decimal)reader["OU1_RAW_WATER"],
                OU1_FTL_WATER = (decimal)reader["OU1_FTL_WATER"],
                OU1_DM_WATER = (decimal)reader["OU1_DM_WATER"],
                OU1_HCL = (decimal)reader["OU1_HCL"],
                OU1_NAOH = (decimal)reader["OU1_NAOH"],
                OU1_H2SO4 = (decimal)reader["OU1_H2SO4"],
                OU1_PAC = (decimal)reader["OU1_PAC"],
                OU1_ALUM = (decimal)reader["OU1_ALUM"],
                OU1_CHLORINE = (decimal)reader["OU1_CHLORINE"],
                OU1_SODIUM = (decimal)reader["OU1_SODIUM"],
                OU1_S_REMARKS = reader["OU1_S_REMARKS"].ToString()
            };
        }

        public async Task<POS020Model> putData(StringParamWbtnDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_UTL_EXPORTT_UNIT_III", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.StringParameter));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", data.Btn));
                    POS020Model response = null;
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

        public async Task saveData(POS020SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_UTL_EXPORTT_UNIT_III", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_S_TRANS_DATE", value.OU1_S_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_S_USER_ID", value.OU1_S_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_GTG_PWR", value.OU1_GTG_PWR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_JVVNL_PWR", value.OU1_JVVNL_PWR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_STEAM", value.OU1_KS_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MP_STEAM", value.OU1_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LP_STEAM", value.OU1_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAT_GAS", value.OU1_NAT_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NITROGEN", value.OU1_NITROGEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SA", value.OU1_SA));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_IA", value.OU1_IA));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAW_WATER", value.OU1_RAW_WATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FTL_WATER", value.OU1_FTL_WATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DM_WATER", value.OU1_DM_WATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL", value.OU1_HCL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAOH", value.OU1_NAOH));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_H2SO4", value.OU1_H2SO4));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC", value.OU1_PAC));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ALUM", value.OU1_ALUM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLORINE", value.OU1_CHLORINE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SODIUM", value.OU1_SODIUM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_S_REMARKS", value.OU1_S_REMARKS));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
