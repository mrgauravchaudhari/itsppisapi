using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PGS004Repository
    {
        private readonly string _connectionString;
        public PGS004Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS004Model MapToValue(SqlDataReader reader)
        {
            return new PGS004Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                E1_TRANS_DATE = reader["E1_TRANS_DATE"].ToString(),
                E1_UNIT_ID = reader["E1_UNIT_ID"].ToString(),
                E1_DATE_MOD = reader["E1_DATE_MOD"].ToString(),
                E1_USER_ID = (decimal)reader["E1_USER_ID"],
                E1_USER_NAME = reader["E1_USER_NAME"].ToString(),
                E1_GT1_PROD = (decimal)reader["E1_GT1_PROD"],
                E1_GT2_PROD = (decimal)reader["E1_GT2_PROD"],
                E1_TOT_GT_GEN = (decimal)reader["E1_TOT_GT_GEN"],
                E1_AMM_CONSP = (decimal)reader["E1_AMM_CONSP"],
                E1_SPG_CONSP = (decimal)reader["E1_SPG_CONSP"],
                E1_U11_CONSP = (decimal)reader["E1_U11_CONSP"],
                E1_U21_CONSP = (decimal)reader["E1_U21_CONSP"],
                E1_OFFSITE_CONSP = (decimal)reader["E1_OFFSITE_CONSP"],
                E1_AMM_STORAGE_CONSP = (decimal)reader["E1_AMM_STORAGE_CONSP"],
                E1_UPHS_CONSP = (decimal)reader["E1_UPHS_CONSP"],
                E1_RW_CONSP = (decimal)reader["E1_RW_CONSP"],
                E1_TFR_TO_NEBUS = (decimal)reader["E1_TFR_TO_NEBUS"],
                TXT_DLY_GP_II = (decimal)reader["TXT_DLY_GP_II"],
                E1_TOT_EBUS_CONSP = (decimal)reader["E1_TOT_EBUS_CONSP"],
                E1_LOSS_GEN = (decimal)reader["E1_LOSS_GEN"],
                E1_RSEB_PURCHASED = (decimal)reader["E1_RSEB_PURCHASED"],
                E1_KSR_CONSP = (decimal)reader["E1_KSR_CONSP"],
                E1_HOUSE_COL_CONSP = (decimal)reader["E1_HOUSE_COL_CONSP"],
                E1_CONST_POWER_UNIT2_CONSP = (decimal)reader["E1_CONST_POWER_UNIT2_CONSP"],
                E1_WS_FENCELIGHT_CONSP = (decimal)reader["E1_WS_FENCELIGHT_CONSP"],
                E1_TFR_TO_EBUS = (decimal)reader["E1_TFR_TO_EBUS"],
                E1_CIVIL_BLDG_CONSP = (decimal)reader["E1_CIVIL_BLDG_CONSP"],
                E1_TOT_NEBUS_CONSP = (decimal)reader["E1_TOT_NEBUS_CONSP"],
                E1_LOSS_RSEB = (decimal)reader["E1_LOSS_RSEB"],
                E1_AB_CONSP = (decimal)reader["E1_AB_CONSP"],
                E1_CPP_CONSP = (decimal)reader["E1_CPP_CONSP"],
                E1_IAC_SPG_CONSP = (decimal)reader["E1_IAC_SPG_CONSP"],
                TXT_DLY_TOT_SPG = (decimal)reader["TXT_DLY_TOT_SPG"],
                E1_ACT_CONSP = (decimal)reader["E1_ACT_CONSP"],
                E1_UCT_CONSP = (decimal)reader["E1_UCT_CONSP"],
                E1_WPT_CONSP = (decimal)reader["E1_WPT_CONSP"],
                E1_DMP_CONSP = (decimal)reader["E1_DMP_CONSP"],
                E1_ETP_CONSP = (decimal)reader["E1_ETP_CONSP"],
                E1_FIRE_CONSP = (decimal)reader["E1_FIRE_CONSP"],
                E1_IAC_OFFSITE_CONSP = (decimal)reader["E1_IAC_OFFSITE_CONSP"],
                TXT_DLY_TOT_OFFSITE = (decimal)reader["TXT_DLY_TOT_OFFSITE"]
            };
        }

        public async Task<PGS004Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_ELECT_BAL_PGS004", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS004Model response = null;
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
    }
}
