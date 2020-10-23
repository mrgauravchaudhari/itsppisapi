using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PTS229Repository
    {
        private readonly string _connectionString;
        public PTS229Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PTS229Model MapToValue(SqlDataReader reader)
        {
            return new PTS229Model()
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
                T_DM_MKUP_GP1 = (decimal)reader["T_DM_MKUP_GP1"],
                T_DM_MKUP_GP2 = (decimal)reader["T_DM_MKUP_GP2"],
                T_DM_MKUP_NET = (decimal)reader["T_DM_MKUP_NET"],
                T_APC_FR_AM2 = (decimal)reader["T_APC_FR_AM2"],
                T_ATC_FR_AM2 = (decimal)reader["T_ATC_FR_AM2"],
                T_SC_FR_AM2 = (decimal)reader["T_SC_FR_AM2"],
                T_UPC_FR_UR2 = (decimal)reader["T_UPC_FR_UR2"],
                T_TC_UR2_TA = (decimal)reader["T_TC_UR2_TA"],
                T_TC_UR2_TB = (decimal)reader["T_TC_UR2_TB"],
                T_TC_UR2 = (decimal)reader["T_TC_UR2"],
                T_SC_FR_UR2 = (decimal)reader["T_SC_FR_UR2"],
                T_ACTTC_EXP_TO_AM2 = (decimal)reader["T_ACTTC_EXP_TO_AM2"],
                T_TC_FR_CW_TURBINE = (decimal)reader["T_TC_FR_CW_TURBINE"],
                T_REC_COND_SUB_TOT = (decimal)reader["T_REC_COND_SUB_TOT"],
                T_PW_RC_OTHERS_GP1 = (decimal)reader["T_PW_RC_OTHERS_GP1"],
                T_REC_COND_TOT = (decimal)reader["T_REC_COND_TOT"],
                T_BFW_TO_STOR_TNK = (decimal)reader["T_BFW_TO_STOR_TNK"],
                T_BFW_FR_STOR_TNK = (decimal)reader["T_BFW_FR_STOR_TNK"],
                T_PW_D_TNK_TRF = (decimal)reader["T_PW_D_TNK_TRF"],
                T_PW_CONSP_AM2 = (decimal)reader["T_PW_CONSP_AM2"],
                T_PW_CONSP_AB3 = (decimal)reader["T_PW_CONSP_AB3"],
                T_PW_PB_AM2 = (decimal)reader["T_PW_PB_AM2"],
                T_PW_PB_UR2 = (decimal)reader["T_PW_PB_UR2"],
                T_PW_CONSP_SUB_TOT = (decimal)reader["T_PW_CONSP_SUB_TOT"],
                T_PW_CONSP_IN_GP1 = (decimal)reader["T_PW_CONSP_IN_GP1"],
                T_PW_CONSP_TOT = (decimal)reader["T_PW_CONSP_TOT"],
                T_FW_PRODN_FR_WPT = (decimal)reader["T_FW_PRODN_FR_WPT"],
                T_FW_PURCHASED = (decimal)reader["T_FW_PURCHASED"],
                T_FW_TRF_TO_STRG_TNK = (decimal)reader["T_FW_TRF_TO_STRG_TNK"],
                T_FW_TAKEN_FR_TNK = (decimal)reader["T_FW_TAKEN_FR_TNK"],
                T_FW_AS_FEED_TO_DMP = (decimal)reader["T_FW_AS_FEED_TO_DMP"],
                T_FW_AS_FEED_TO_DMP_GP1 = (decimal)reader["T_FW_AS_FEED_TO_DMP_GP1"],
                T_FW_AS_FEED_TO_DMP_GP2 = (decimal)reader["T_FW_AS_FEED_TO_DMP_GP2"],
                T_FW_MKUP_ACT = (decimal)reader["T_FW_MKUP_ACT"],
                T_FW_MKUP_UCT = (decimal)reader["T_FW_MKUP_UCT"],
                T_FW_MKUP_ACT_UCT = (decimal)reader["T_FW_MKUP_ACT_UCT"],
                T_FW_PORT = (decimal)reader["T_FW_PORT"],
                T_FW_IN_FBW = (decimal)reader["T_FW_IN_FBW"],
                T_FW_IN_FBW_GP1 = (decimal)reader["T_FW_IN_FBW_GP1"],
                T_FW_IN_FBW_GP2 = (decimal)reader["T_FW_IN_FBW_GP2"],
                T_FW_IN_ETP = (decimal)reader["T_FW_IN_ETP"],
                T_FW_CONSP_OTHERS_GP1 = (decimal)reader["T_FW_CONSP_OTHERS_GP1"],
                T_FW_SB_TOT_PLT_CONSP = (decimal)reader["T_FW_SB_TOT_PLT_CONSP"],
                T_FW_IN_FAC_TSHIP = (decimal)reader["T_FW_IN_FAC_TSHIP"],
                T_FW_IN_FIRE = (decimal)reader["T_FW_IN_FIRE"],
                T_FW_IN_SERVICE = (decimal)reader["T_FW_IN_SERVICE"],
                T_FW_SB_TOT_NON_PLT_CONSP = (decimal)reader["T_FW_SB_TOT_NON_PLT_CONSP"],
                T_FW_NON_PLT_OTHERS_GP1 = (decimal)reader["T_FW_NON_PLT_OTHERS_GP1"],
                T_FW_NON_PLT_CONSP_TOT = (decimal)reader["T_FW_NON_PLT_CONSP_TOT"],
                T_FW_TOT_CONSP = (decimal)reader["T_FW_TOT_CONSP"],
                T_FI1_PW_MKUP_SC_AP = (decimal)reader["T_FI1_PW_MKUP_SC_AP"],
                T_PW_CONS_AM2 = (decimal)reader["T_PW_CONS_AM2"],
                T_RW_KS_PURCHASE = (decimal)reader["T_RW_KS_PURCHASE"],
                T_RW_KS_PURCHASE_GP1 = (decimal)reader["T_RW_KS_PURCHASE_GP1"],
                T_RW_KS_PURCHASE_GP2 = (decimal)reader["T_RW_KS_PURCHASE_GP2"],
                T_RW_OTHERS_PURCHASED = (decimal)reader["T_RW_OTHERS_PURCHASED"],
                T_RW_SENT_TO_RESVOIR = (decimal)reader["T_RW_SENT_TO_RESVOIR"],
                T_RW_DRW_FR_RESVOIR = (decimal)reader["T_RW_DRW_FR_RESVOIR"],
                T_RW_TO_PW_PROD = (decimal)reader["T_RW_TO_PW_PROD"],
                T_RW_DILUTION = (decimal)reader["T_RW_DILUTION"],
                T_RW_DILUTION_GP1 = (decimal)reader["T_RW_DILUTION_GP1"],
                T_RW_DILUTION_GP2 = (decimal)reader["T_RW_DILUTION_GP2"],
                T_RW_CONSP_GP1 = (decimal)reader["T_RW_CONSP_GP1"],
                T_RW_CONSP_GP2 = (decimal)reader["T_RW_CONSP_GP2"],
                T_RW_LOSSES = (decimal)reader["T_RW_LOSSES"],
                T_RW_DISTRIBTION_NET = (decimal)reader["T_RW_DISTRIBTION_NET"],
                T_RW_1901 = (decimal)reader["T_RW_1901"],
                T_1901_COND_IMP_FR_DMP = (decimal)reader["T_1901_COND_IMP_FR_DMP"],
                T_1901_TC_SC_TO_DMP = (decimal)reader["T_1901_TC_SC_TO_DMP"],
                T_1901_TOT_COND_EXP = (decimal)reader["T_1901_TOT_COND_EXP"],
                T_1901_PW_EXP_NET = (decimal)reader["T_1901_PW_EXP_NET"],
                T_PW_CONSP_AM2_SC_AP = (decimal)reader["T_PW_CONSP_AM2_SC_AP"],
                T_FW_MKUP_ACT_SC_AP = (decimal)reader["T_FW_MKUP_ACT_SC_AP"],
                T_FI1_EXP_BFW_SC_AP = (decimal)reader["T_FI1_EXP_BFW_SC_AP"],
                T_RW_1901_SC_AP = (decimal)reader["T_RW_1901_SC_AP"],
                T_1901_COND_IMP_FR_DMP_SC_AP = (decimal)reader["T_1901_COND_IMP_FR_DMP_SC_AP"],
                T_APC_FR_AM2_SC_AP = (decimal)reader["T_APC_FR_AM2_SC_AP"],
                T_1901_TC_SC_TO_DMP_SC_AP = (decimal)reader["T_1901_TC_SC_TO_DMP_SC_AP"],
                T_ACTTC_EXP_TO_AM2_SC_AP = (decimal)reader["T_ACTTC_EXP_TO_AM2_SC_AP"],
                T_1901_TOT_COND_EXP_SC_AP = (decimal)reader["T_1901_TOT_COND_EXP_SC_AP"],
                T_1901_PW_EXP_NET_SC_AP = (decimal)reader["T_1901_PW_EXP_NET_SC_AP"],
                T_PW_CONSP_AM2_SC_AH = (decimal)reader["T_PW_CONSP_AM2_SC_AH"],
                T_FW_MKUP_ACT_SC_AH = (decimal)reader["T_FW_MKUP_ACT_SC_AH"],
                T_RW_1901_SC_AH = (decimal)reader["T_RW_1901_SC_AH"],
                T_1901_COND_IMP_FR_DMP_SC_AH = (decimal)reader["T_1901_COND_IMP_FR_DMP_SC_AH"],
                T_APC_FR_AM2_SC_AH = (decimal)reader["T_APC_FR_AM2_SC_AH"],
                T_1901_TC_SC_TO_DMP_SC_AH = (decimal)reader["T_1901_TC_SC_TO_DMP_SC_AH"],
                T_ACTTC_EXP_TO_AM2_SC_AH = (decimal)reader["T_ACTTC_EXP_TO_AM2_SC_AH"],
                T_1901_TOT_COND_EXP_SC_AH = (decimal)reader["T_1901_TOT_COND_EXP_SC_AH"],
                T_1901_PW_EXP_NET_SC_AH = (decimal)reader["T_1901_PW_EXP_NET_SC_AH"],
                T_FW_1905_TOT = (decimal)reader["T_FW_1905_TOT"],
                T_RW_1905_PL_CONSP = (decimal)reader["T_RW_1905_PL_CONSP"],
                T_RW_1905_PORT = (decimal)reader["T_RW_1905_PORT"],
                T_RW_1905_NP_CONSP = (decimal)reader["T_RW_1905_NP_CONSP"],
                T_RW_1905_TOT = (decimal)reader["T_RW_1905_TOT"],
                T_CD_TCSC_EXP = (decimal)reader["T_CD_TCSC_EXP"],
                T_CD_TC_EXP = (decimal)reader["T_CD_TC_EXP"],
                T_CD_1905_TOT = (decimal)reader["T_CD_1905_TOT"],
                T_CD_DM_IMP = (decimal)reader["T_CD_DM_IMP"],
                T_CD_NET_EXP = (decimal)reader["T_CD_NET_EXP"],
                T_FW_MKUP_UCT_SC_UP = (decimal)reader["T_FW_MKUP_UCT_SC_UP"],
                T_FW_PORT_SC_UP = (decimal)reader["T_FW_PORT_SC_UP"],
                T_FW_SB_TOT_NON_PT_CONSP_SC_UP = (decimal)reader["T_FW_SB_TOT_NON_PT_CONSP_SC_UP"],
                T_PW_1905_TOT_SC_UP = (decimal)reader["T_PW_1905_TOT_SC_UP"],
                T_RW_1905_PL_CONSP_SC_UP = (decimal)reader["T_RW_1905_PL_CONSP_SC_UP"],
                T_RW_1905_PORT_SC_UP = (decimal)reader["T_RW_1905_PORT_SC_UP"],
                T_RW_1905_NP_CONSP_SC_UP = (decimal)reader["T_RW_1905_NP_CONSP_SC_UP"],
                T_RW_1905_TOT_SC_UP = (decimal)reader["T_RW_1905_TOT_SC_UP"],
                T_UPC_FR_UR2_SC_UP = (decimal)reader["T_UPC_FR_UR2_SC_UP"],
                T_CD_TCSC_EXP_SC_UP = (decimal)reader["T_CD_TCSC_EXP_SC_UP"],
                T_CD_TC_EXP_SC_UP = (decimal)reader["T_CD_TC_EXP_SC_UP"],
                T_CD_1905_TOT_SC_UP = (decimal)reader["T_CD_1905_TOT_SC_UP"],
                T_CD_DM_IMP_SC_UP = (decimal)reader["T_CD_DM_IMP_SC_UP"],
                T_CD_NET_EXP_SC_UP = (decimal)reader["T_CD_NET_EXP_SC_UP"],
                T_PW_PB_UR2_SC_UP = (decimal)reader["T_PW_PB_UR2_SC_UP"],
                T_FW_MKUP_UCT_SC_UH = (decimal)reader["T_FW_MKUP_UCT_SC_UH"],
                T_FW_PORT_SC_UH = (decimal)reader["T_FW_PORT_SC_UH"],
                T_FW_SB_TOT_NON_PT_CONSP_SC_UH = (decimal)reader["T_FW_SB_TOT_NON_PT_CONSP_SC_UH"],
                T_FW_1905_TOT_SC_UH = (decimal)reader["T_FW_1905_TOT_SC_UH"],
                T_RW_1905_PL_CONSP_SC_UH = (decimal)reader["T_RW_1905_PL_CONSP_SC_UH"],
                T_RW_1905_PORT_SC_UH = (decimal)reader["T_RW_1905_PORT_SC_UH"],
                T_RW_1905_NP_CONSP_SC_UH = (decimal)reader["T_RW_1905_NP_CONSP_SC_UH"],
                T_RW_1905_TOT_SC_UH = (decimal)reader["T_RW_1905_TOT_SC_UH"],
                T_UPC_FR_UR2_SC_UH = (decimal)reader["T_UPC_FR_UR2_SC_UH"],
                T_CD_TCSC_EXP_SC_UH = (decimal)reader["T_CD_TCSC_EXP_SC_UH"],
                T_CD_TC_EXP_SC_UH = (decimal)reader["T_CD_TC_EXP_SC_UH"],
                T_CD_1905_TOT_SC_UH = (decimal)reader["T_CD_1905_TOT_SC_UH"],
                T_CD_DM_IMP_SC_UH = (decimal)reader["T_CD_DM_IMP_SC_UH"],
                T_CD_NET_EXP_SC_UH = (decimal)reader["T_CD_NET_EXP_SC_UH"],
                T_FW_IMP_DMW = (decimal)reader["T_FW_IMP_DMW"],
                T_RW_PL_CONSP = (decimal)reader["T_RW_PL_CONSP"],
                T_RW_NP_CONSP = (decimal)reader["T_RW_NP_CONSP"],
                T_RW_1909_PL_NP = (decimal)reader["T_RW_1909_PL_NP"],
                T_PW_PB_UR2_SC_UH = (decimal)reader["T_PW_PB_UR2_SC_UH"],
                T_FW_IMP_DMW_SC_SP = (decimal)reader["T_FW_IMP_DMW_SC_SP"],
                T_PW_CONSP_AB3_SC_SP = (decimal)reader["T_PW_CONSP_AB3_SC_SP"],
                T_RW_PL_CONSP_SC_SP = (decimal)reader["T_RW_PL_CONSP_SC_SP"],
                T_RW_NP_CONSP_SC_SP = (decimal)reader["T_RW_NP_CONSP_SC_SP"],
                T_RW_1909_PL_NP_SC_SP = (decimal)reader["T_RW_1909_PL_NP_SC_SP"],
                T_FW_IMP_DMW_SC_SH = (decimal)reader["T_FW_IMP_DMW_SC_SH"],
                T_PW_CONSP_AB3_SC_SH = (decimal)reader["T_PW_CONSP_AB3_SC_SH"],
                T_RW_PL_CONSP_SC_SH = (decimal)reader["T_RW_PL_CONSP_SC_SH"],
                T_RW_NP_CONSP_SC_SH = (decimal)reader["T_RW_NP_CONSP_SC_SH"],
                T_RW_1909_PL_NP_SC_SH = (decimal)reader["T_RW_1909_PL_NP_SC_SH"],
                T_RW_PUR_SCA_UP = (decimal)reader["T_RW_PUR_SCA_UP"],
                T_PW_IN_AM2_RGB = (decimal)reader["T_PW_IN_AM2_RGB"],
                T_PW_IN_AM2_DES_F1925 = (decimal)reader["T_PW_IN_AM2_DES_F1925"],
                T_PW_IN_AM2_DES_F1910 = (decimal)reader["T_PW_IN_AM2_DES_F1910"],
                T_PW_IN_AM2_REC_TRF = (decimal)reader["T_PW_IN_AM2_REC_TRF"],
                T_PW_IN_AM2 = (decimal)reader["T_PW_IN_AM2"],
                T_PW_IN_GP2 = (decimal)reader["T_PW_IN_GP2"],
                T_FI2_COND_EXP = (decimal)reader["T_FI2_COND_EXP"],
                T_FI2_COND_EXP_SC_AP = (decimal)reader["T_FI2_COND_EXP_SC_AP"],
                T_FI2_CW_MKUP_SC_AP = (decimal)reader["T_FI2_CW_MKUP_SC_AP"],
                T_FI2_PW_MKUP_SC_AP = (decimal)reader["T_FI2_PW_MKUP_SC_AP"],
                T_RW_STK_OP = (decimal)reader["T_RW_STK_OP"],
                T_RW_STK_CL = (decimal)reader["T_RW_STK_CL"],
                T_FW_STK_OP = (decimal)reader["T_FW_STK_OP"],
                T_FW_STK_CL = (decimal)reader["T_FW_STK_CL"],
                T_DMW_STK_OP = (decimal)reader["T_DMW_STK_OP"],
                T_DMW_STK_CL = (decimal)reader["T_DMW_STK_CL"],
                T_PW_STK_OP = (decimal)reader["T_PW_STK_OP"],
                T_PW_STK_CL = (decimal)reader["T_PW_STK_CL"],
                T_CONDENSATE_DRAINED = (decimal)reader["T_CONDENSATE_DRAINED"],
                T_NET_CONDENSATE = (decimal)reader["T_NET_CONDENSATE"],
                T_STATUS = reader["T_STATUS"].ToString(),
                T_FW_CONSP_SSP = (decimal)reader["T_FW_CONSP_SSP"],
                T_RW_EXPORTT_UNIT3 = (decimal)reader["T_RW_EXPORTT_UNIT3"],
                T_RW_IMPORTF_UNIT3 = (decimal)reader["T_RW_IMPORTF_UNIT3"],
                T_FW_IMPORTF_FB_UNIT3 = (decimal)reader["T_FW_IMPORTF_FB_UNIT3"],
                T_FW_EXPORTT_UNIT3 = (decimal)reader["T_FW_EXPORTT_UNIT3"],
                T_FW_IMPORTF_UNIT3 = (decimal)reader["T_FW_IMPORTF_UNIT3"],
                T_FW_CONSP_NP_UNIT3 = (decimal)reader["T_FW_CONSP_NP_UNIT3"],
                DIS_REC_WPT = (decimal)reader["DIS_REC_WPT"],
                DIS_FBW_GP1 = (decimal)reader["DIS_FBW_GP1"],
                DIS_FBW_GP2 = (decimal)reader["DIS_FBW_GP2"],
                DIS_FBW_TOTAL = (decimal)reader["DIS_FBW_TOTAL"]
            };
        }

        public async Task<PTS229Model> putData(PTS229Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_TS2_GET_PPT_TS2_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_T_YEAR", value.T_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_IDENTITY", value.T_IDENTITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_VERSION", value.T_VERSION));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PTS229Model response = null;
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