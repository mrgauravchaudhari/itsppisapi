using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PTS228Repository
    {
        private readonly string _connectionString;
        public PTS228Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PTS228Model MapToValue(SqlDataReader reader)
        {
            return new PTS228Model()
            {
                MINIDENTITY = (decimal)reader["MINIDENTITY"],
                MINYEAR = (decimal)reader["MINYEAR"],
                MAXIDENTITY = (decimal)reader["MAXIDENTITY"],
                MAXYEAR = (decimal)reader["MAXYEAR"],
                T_YEAR = (decimal)reader["T_YEAR"],
                T_IDENTITY = (decimal)reader["T_IDENTITY"],
                T_VERSION = (decimal)reader["T_VERSION"],
                T_UNIT_ID = reader["T_UNIT_ID"].ToString(),
                T_USER_ID = (decimal)reader["T_USER_ID"],
                T_USER_NAME = reader["T_USER_NAME"].ToString(),
                T_DATE_MOD = reader["T_DATE_MOD"].ToString(),

                T_RSB_PURCHASED = (decimal)reader["T_RSB_PURCHASED"],
                T_RSB_CONSP_UPH = (decimal)reader["T_RSB_CONSP_UPH"],
                T_RSB_CONSP_UPH_GP1 = (decimal)reader["T_RSB_CONSP_UPH_GP1"],
                T_RSB_CONSP_UPH_GP2 = (decimal)reader["T_RSB_CONSP_UPH_GP2"],
                T_RSB_CONSP_WPT = (decimal)reader["T_RSB_CONSP_WPT"],
                T_RSB_CONSP_DMW = (decimal)reader["T_RSB_CONSP_DMW"],
                T_RSB_CONSP_IA = (decimal)reader["T_RSB_CONSP_IA"],
                T_RSB_1905_CONSP_IA = (decimal)reader["T_RSB_1905_CONSP_IA"],
                T_RSB_CONSP_IA_GP1 = (decimal)reader["T_RSB_CONSP_IA_GP1"],
                T_RSB_CONSP_IA_GP2 = (decimal)reader["T_RSB_CONSP_IA_GP2"],
                T_RSB_1901_CONSP_IA_GP2 = (decimal)reader["T_RSB_1901_CONSP_IA_GP2"],
                T_RSB_CONSP_ETP = (decimal)reader["T_RSB_CONSP_ETP"],
                T_RSB_CONSP_ETP_GP1 = (decimal)reader["T_RSB_CONSP_ETP_GP1"],
                T_RSB_CONSP_ETP_GP2 = (decimal)reader["T_RSB_CONSP_ETP_GP2"],
                T_RSB_1901_CONSP_ETP_GP2 = (decimal)reader["T_RSB_1901_CONSP_ETP_GP2"],
                T_RSB_CONSP_RW_PMP = (decimal)reader["T_RSB_CONSP_RW_PMP"],
                T_RSB_CONSP_KS = (decimal)reader["T_RSB_CONSP_KS"],
                T_RSB_CONSP_KS_GP1 = (decimal)reader["T_RSB_CONSP_KS_GP1"],
                T_RSB_CONSP_KS_GP2 = (decimal)reader["T_RSB_CONSP_KS_GP2"],
                T_RSB_CONSP_HC = (decimal)reader["T_RSB_CONSP_HC"],
                T_RSB_CONSP_HC_GP1 = (decimal)reader["T_RSB_CONSP_HC_GP1"],
                T_RSB_CONSP_HC_GP2 = (decimal)reader["T_RSB_CONSP_HC_GP2"],
                T_RSB_CONSP_CBSL = (decimal)reader["T_RSB_CONSP_CBSL"],
                T_RSB_CONSP_CBSL_GP1 = (decimal)reader["T_RSB_CONSP_CBSL_GP1"],
                T_RSB_CONSP_CBSL_GP2 = (decimal)reader["T_RSB_CONSP_CBSL_GP2"],
                T_RSB_CONSP_OTHERS_GP1 = (decimal)reader["T_RSB_CONSP_OTHERS_GP1"],
                T_RSB_CONSP_ACT_GP1 = (decimal)reader["T_RSB_CONSP_ACT_GP1"],
                T_RSB_CONSP_UCT_GP1 = (decimal)reader["T_RSB_CONSP_UCT_GP1"],
                T_RSB_TOT_CONSP = (decimal)reader["T_RSB_TOT_CONSP"],
                T_RSB_CPP_TOT_CONSP = (decimal)reader["T_RSB_CPP_TOT_CONSP"],
                T_RSB_ALLOC_DM_TOT = (decimal)reader["T_RSB_ALLOC_DM_TOT"],
                T_RSB_ALLOC_AM2_DM = (decimal)reader["T_RSB_ALLOC_AM2_DM"],
                T_RSB_ALLOC_UR2_DM = (decimal)reader["T_RSB_ALLOC_UR2_DM"],
                T_RSB_ALLOC_GP2_DM = (decimal)reader["T_RSB_ALLOC_GP2_DM"],
                T_RSB_ALLOC_GP1_DM = (decimal)reader["T_RSB_ALLOC_GP1_DM"],
                T_RSB_TO_WPT = (decimal)reader["T_RSB_TO_WPT"],
                T_RSB_ALLOC_GP2_AM2_CT_MKUP_PW = (decimal)reader["T_RSB_ALLOC_GP2_AM2_CT_MKUP_PW"],
                T_RSB_ALLOC_GP2_UR2_CT_MKUP_PW = (decimal)reader["T_RSB_ALLOC_GP2_UR2_CT_MKUP_PW"],
                T_RSB_ALLOC_GP2_UR2_NP_PW = (decimal)reader["T_RSB_ALLOC_GP2_UR2_NP_PW"],
                T_RSB_ALLOC_GP2_UR2_TOT_PW = (decimal)reader["T_RSB_ALLOC_GP2_UR2_TOT_PW"],
                T_RSB_ALLOC_DM_GP2_PW = (decimal)reader["T_RSB_ALLOC_DM_GP2_PW"],
                T_RSB_ALLOC_TOT_GP2_PW = (decimal)reader["T_RSB_ALLOC_TOT_GP2_PW"],
                T_RSB_ALLOC_GP1_PW = (decimal)reader["T_RSB_ALLOC_GP1_PW"],
                T_RSB_1901_TOT = (decimal)reader["T_RSB_1901_TOT"],
                T_RSB_1905T_TOT = (decimal)reader["T_RSB_1905T_TOT"],
                T_RSB_20S_TOT = (decimal)reader["T_RSB_20S_TOT"],
                T_RSB_20S_TOT_NPC = (decimal)reader["T_RSB_20S_TOT_NPC"],
                T_RSB_CONSP_IA_GP2_SC_AP = (decimal)reader["T_RSB_CONSP_IA_GP2_SC_AP"],
                T_RSB_ALLOC_AM2_DM_SC_AP = (decimal)reader["T_RSB_ALLOC_AM2_DM_SC_AP"],
                T_RSB_ALO_G2_AMCTMKUP_PW_SC_AP = (decimal)reader["T_RSB_ALO_G2_AMCTMKUP_PW_SC_AP"],
                T_RSB_1901_CONSP_ETP_GP2_SC_AP = (decimal)reader["T_RSB_1901_CONSP_ETP_GP2_SC_AP"],
                T_RSB_1901_TOT_SC_AP = (decimal)reader["T_RSB_1901_TOT_SC_AP"],
                T_RSB_CONSP_IA_GP2_SC_AH = (decimal)reader["T_RSB_CONSP_IA_GP2_SC_AH"],
                T_RSB_ALLOC_AM2_DM_SC_AH = (decimal)reader["T_RSB_ALLOC_AM2_DM_SC_AH"],
                T_RSB_ALO_G2_AMCTMKUP_PW_SC_AH = (decimal)reader["T_RSB_ALO_G2_AMCTMKUP_PW_SC_AH"],
                T_RSB_1901_CONSP_ETP_GP2_SC_AH = (decimal)reader["T_RSB_1901_CONSP_ETP_GP2_SC_AH"],
                T_RSB_1901_TOT_SC_AH = (decimal)reader["T_RSB_1901_TOT_SC_AH"],
                T_RSB_CONSP_UPH_GP2_SC_UP = (decimal)reader["T_RSB_CONSP_UPH_GP2_SC_UP"],
                T_RSB_TO_WPT_SC_UP = (decimal)reader["T_RSB_TO_WPT_SC_UP"],
                T_RSB_ALLOC_UR2_DM_SC_UP = (decimal)reader["T_RSB_ALLOC_UR2_DM_SC_UP"],
                T_RSB_1905_CONSP_IA_SC_UP = (decimal)reader["T_RSB_1905_CONSP_IA_SC_UP"],
                T_RSB_1901_CONSP_ETP_GP2_SC_UP = (decimal)reader["T_RSB_1901_CONSP_ETP_GP2_SC_UP"],
                T_RSB_CONSP_KS_GP2_SC_UP = (decimal)reader["T_RSB_CONSP_KS_GP2_SC_UP"],
                T_RSB_CONSP_HC_GP2_SC_UP = (decimal)reader["T_RSB_CONSP_HC_GP2_SC_UP"],
                T_RSB_CONSP_CBSL_GP2_SC_UP = (decimal)reader["T_RSB_CONSP_CBSL_GP2_SC_UP"],
                T_RSB_1905T_TOT_SC_UP = (decimal)reader["T_RSB_1905T_TOT_SC_UP"],
                T_RSB_CONSP_UPH_GP2_SC_UH = (decimal)reader["T_RSB_CONSP_UPH_GP2_SC_UH"],
                T_RSB_TO_WPT_SC_UH = (decimal)reader["T_RSB_TO_WPT_SC_UH"],
                T_RSB_ALLOC_UR2_DM_SC_UH = (decimal)reader["T_RSB_ALLOC_UR2_DM_SC_UH"],
                T_RSB_1905_CONSP_IA_SC_UH = (decimal)reader["T_RSB_1905_CONSP_IA_SC_UH"],
                T_RSB_1901_CONSP_ETP_GP2_SC_UH = (decimal)reader["T_RSB_1901_CONSP_ETP_GP2_SC_UH"],
                T_RSB_CONSP_KS_GP2_SC_UH = (decimal)reader["T_RSB_CONSP_KS_GP2_SC_UH"],
                T_RSB_CONSP_HC_GP2_SC_UH = (decimal)reader["T_RSB_CONSP_HC_GP2_SC_UH"],
                T_RSB_CONSP_CBSL_GP2_SC_UH = (decimal)reader["T_RSB_CONSP_CBSL_GP2_SC_UH"],
                T_RSB_1905T_TOT_SC_UH = (decimal)reader["T_RSB_1905T_TOT_SC_UH"],
                T_RSB_PUR_SCA_UP = (decimal)reader["T_RSB_PUR_SCA_UP"],
                T_RSB_PUR_OE = (decimal)reader["T_RSB_PUR_OE"],
                T_RSB_NPC_SCA_UP = (decimal)reader["T_RSB_NPC_SCA_UP"],
                T_RSB_WS1_PURCHASED = (decimal)reader["T_RSB_WS1_PURCHASED"],
                T_RSB_WS1_ALLOC_TO_UR2 = (decimal)reader["T_RSB_WS1_ALLOC_TO_UR2"],
                T_FI2_TOT_RSB = (decimal)reader["T_FI2_TOT_RSB"],
                T_MI3_TOT_RSB = (decimal)reader["T_MI3_TOT_RSB"],
                T_STATUS = reader["T_STATUS"].ToString(),
                T_RSB_ALLOC_DMP_GP2 = (decimal)reader["T_RSB_ALLOC_DMP_GP2"],
                T_RSB_CONSP_SSP = (decimal)reader["T_RSB_CONSP_SSP"],
                T_IEX_PURCHASED = (decimal)reader["T_IEX_PURCHASED"],
                T_PUR_PWR_CONST_CFG3 = (decimal)reader["T_PUR_PWR_CONST_CFG3"],
                T_PUR_PWR_EXPORTT_GP3 = (decimal)reader["T_PUR_PWR_EXPORTT_GP3"],
                T_PWR_CONSP_HOUSING_UNIT3 = (decimal)reader["T_PWR_CONSP_HOUSING_UNIT3"],
                T_PWR_CONSP_BLDG_STRTS_UNIT3 = (decimal)reader["T_PWR_CONSP_BLDG_STRTS_UNIT3"],
                T_PRCHSD_PWR_CONSP_GP3 = (decimal)reader["T_PRCHSD_PWR_CONSP_GP3"],

                // --------------- DV -------------------

                DIS_TOTAL_GP1 = (decimal)reader["DIS_TOTAL_GP1"],
                DIS_TOTAL_GP2 = (decimal)reader["DIS_TOTAL_GP2"],
            };
        }

        public async Task<PTS228Model> putData(PTS228Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_TS2_GET_PPT_TS2_PWR_RSEB_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_T_YEAR", value.T_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_IDENTITY", value.T_IDENTITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_VERSION", value.T_VERSION));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PTS228Model response = null;
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