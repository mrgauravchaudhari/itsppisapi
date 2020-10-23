using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS212Repository
    {
        private readonly string _connectionString;
        public PAS212Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS212Model MapToValue(SqlDataReader reader)
        {
            return new PAS212Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_PRS_CO2_INT = (dynamic)reader["A2_PRS_CO2_INT"],
                A2_TEMP_CO2_INT = (dynamic)reader["A2_TEMP_CO2_INT"],
                A2_CO2_INT = (dynamic)reader["A2_CO2_INT"],
                A2_CO2_INT_DIFF = (dynamic)reader["A2_CO2_INT_DIFF"],
                A2_CO2_PROD = (dynamic)reader["A2_CO2_PROD"],
                A2_PRS_CO2_EXPORTT_GP1_INT = (dynamic)reader["A2_PRS_CO2_EXPORTT_GP1_INT"],
                A2_TEMP_CO2_EXPORTT_GP1_INT = (dynamic)reader["A2_TEMP_CO2_EXPORTT_GP1_INT"],
                A2_CO2_EXPORTT_GP1_INT = (dynamic)reader["A2_CO2_EXPORTT_GP1_INT"],
                A2_CO2_EXPORTT_GP1_INT_DIFF = (dynamic)reader["A2_CO2_EXPORTT_GP1_INT_DIFF"],
                A2_CO2_EXPORTT_GP1 = (dynamic)reader["A2_CO2_EXPORTT_GP1"],
                A2_CO2_SUPPLY_UREA = (dynamic)reader["A2_CO2_SUPPLY_UREA"],
                A2_PRS_PERMEATE_INT = (dynamic)reader["A2_PRS_PERMEATE_INT"],
                A2_PRS_PERMEATE_INT_DIFF = (dynamic)reader["A2_PRS_PERMEATE_INT_DIFF"],
                A2_TEMP_PERMEATE_INT = (dynamic)reader["A2_TEMP_PERMEATE_INT"],
                A2_TEMP_PERMEATE_INT_DIFF = (dynamic)reader["A2_TEMP_PERMEATE_INT_DIFF"],
                A2_PERMEATE_INT = (dynamic)reader["A2_PERMEATE_INT"],
                A2_PERMEATE_INT_DIFF = (dynamic)reader["A2_PERMEATE_INT_DIFF"],
                A2_PERMEATE_FLOW = (dynamic)reader["A2_PERMEATE_FLOW"],
                A2_PROD_HRS = (dynamic)reader["A2_PROD_HRS"],
                A2_PGRU_RUN_HRS = (dynamic)reader["A2_PGRU_RUN_HRS"],
                A2_AMM_SALE = (dynamic)reader["A2_AMM_SALE"],
                A2_PGRU_PROD = (dynamic)reader["A2_PGRU_PROD"],
                A2_AMM_SUPP_UREA_INT = (dynamic)reader["A2_AMM_SUPP_UREA_INT"],
                A2_AMM_SUPP_UREA = (dynamic)reader["A2_AMM_SUPP_UREA"],
                A2_AMM_TO_STORAGE_INT = (dynamic)reader["A2_AMM_TO_STORAGE_INT"],
                A2_AMM_TO_STORAGE = (dynamic)reader["A2_AMM_TO_STORAGE"],
                A2_PRS_VAPOUR_AMM_ACTL = (dynamic)reader["A2_PRS_VAPOUR_AMM_ACTL"],
                A2_TOT_VPR_TO_AMM2_INT = (dynamic)reader["A2_TOT_VPR_TO_AMM2_INT"],
                A2_TOT_VPR_TO_AMM2_INT_DIFF = (dynamic)reader["A2_TOT_VPR_TO_AMM2_INT_DIFF"],
                A2_TOT_VPR_TO_AMM2 = (dynamic)reader["A2_TOT_VPR_TO_AMM2"],
                A2_VPR1_TO_AMM2 = (dynamic)reader["A2_VPR1_TO_AMM2"],
                A2_VPR2_TO_AMM2 = (dynamic)reader["A2_VPR2_TO_AMM2"],
                A2_AMM_PROD = (dynamic)reader["A2_AMM_PROD"],
                A2_AMM2_LOGICAL_STOCK = (dynamic)reader["A2_AMM2_LOGICAL_STOCK"],
                A2_AMM_CAP_UTIL = (dynamic)reader["A2_AMM_CAP_UTIL"],
                A2_REMARKS = reader["A2_REMARKS"].ToString(),
                A2_SP_FEED_NG = (dynamic)reader["A2_SP_FEED_NG"],
                A2_SP_FUEL_NG = (dynamic)reader["A2_SP_FUEL_NG"],
                A2_SP_TOT_NG = (dynamic)reader["A2_SP_TOT_NG"],
                A2_SP_FEED_NAP = (dynamic)reader["A2_SP_FEED_NAP"],
                A2_SP_FUEL_NAP = (dynamic)reader["A2_SP_FUEL_NAP"],
                A2_SP_TOT_NAP = (dynamic)reader["A2_SP_TOT_NAP"],
                A2_SP_PW_AMM = (dynamic)reader["A2_SP_PW_AMM"],
                A2_SP_ATC_EXP = (dynamic)reader["A2_SP_ATC_EXP"],
                A2_SP_APC_EXP = (dynamic)reader["A2_SP_APC_EXP"],
                A2_SP_ASC_EXP = (dynamic)reader["A2_SP_ASC_EXP"],
                A2_SP_ACTTC_EXP = (dynamic)reader["A2_SP_ACTTC_EXP"],
                A2_SP_TOT_COND_EXP_AMM2 = (dynamic)reader["A2_SP_TOT_COND_EXP_AMM2"],
                A2_SP_PW_IMP_AMM2 = (dynamic)reader["A2_SP_PW_IMP_AMM2"],
                A2_SP_SH_STEAM_AMM2 = (dynamic)reader["A2_SP_SH_STEAM_AMM2"],
                A2_SP_SM_STEAM_EXP_ACT = (dynamic)reader["A2_SP_SM_STEAM_EXP_ACT"],
                A2_SP_PWR_CONSP_AMM2 = (dynamic)reader["A2_SP_PWR_CONSP_AMM2"],
                A2_SP_PWR_AMM2 = (dynamic)reader["A2_SP_PWR_AMM2"],
                A2_SP_PWR_CONSP_ACT = (dynamic)reader["A2_SP_PWR_CONSP_ACT"],
                A2_SP_COOL_WTR_AMM2 = (dynamic)reader["A2_SP_COOL_WTR_AMM2"],
                A2_SP_UR_NG_AMM2 = (dynamic)reader["A2_SP_UR_NG_AMM2"],
                A2_SP_UR_NG_AB = (dynamic)reader["A2_SP_UR_NG_AB"],
                A2_SP_UR_TOT_COOL_WTR = (dynamic)reader["A2_SP_UR_TOT_COOL_WTR"],
                A2_SP_UR_NAP_AMM2 = (dynamic)reader["A2_SP_UR_NAP_AMM2"],
                A2_SP_UR_NAP_AB = (dynamic)reader["A2_SP_UR_NAP_AB"],
                A2_SP_UR_DMW_AMM2 = (dynamic)reader["A2_SP_UR_DMW_AMM2"],
                A2_ENG_FEED_GAS = (dynamic)reader["A2_ENG_FEED_GAS"],
                A2_ENG_FUEL_GAS = (dynamic)reader["A2_ENG_FUEL_GAS"],
                A2_ENG_TOT_GAS = (dynamic)reader["A2_ENG_TOT_GAS"],
                A2_ENG_FEED_NAP = (dynamic)reader["A2_ENG_FEED_NAP"],
                A2_ENG_FUEL_NAP = (dynamic)reader["A2_ENG_FUEL_NAP"],
                A2_ENG_TOT_NAP = (dynamic)reader["A2_ENG_TOT_NAP"],
                A2_ENG_TOT_GAS_NAP = (dynamic)reader["A2_ENG_TOT_GAS_NAP"],
                A2_ENG_SH_STEAM_AMM2 = (dynamic)reader["A2_ENG_SH_STEAM_AMM2"],
                A2_ENG_PWR_AMM2 = (dynamic)reader["A2_ENG_PWR_AMM2"],
                A2_ENG_TOT_AMM2 = (dynamic)reader["A2_ENG_TOT_AMM2"],
                A2_ENG_ACT_STEAM = (dynamic)reader["A2_ENG_ACT_STEAM"],
                A2_ENG_ACT_PWR = (dynamic)reader["A2_ENG_ACT_PWR"],
                A2_ENG_TOT_CT = (dynamic)reader["A2_ENG_TOT_CT"],
                A2_ENG_CR_BWF_PHEAT = (dynamic)reader["A2_ENG_CR_BWF_PHEAT"],
                A2_ENG_CR_BFW_PWR = (dynamic)reader["A2_ENG_CR_BFW_PWR"],
                A2_ENG_CR_TOT_SH_EXP = (dynamic)reader["A2_ENG_CR_TOT_SH_EXP"],
                A2_ENG_NET_ENG = (dynamic)reader["A2_ENG_NET_ENG"],
                A2_ENG_USP_FEED_FUEL_AMM2 = (dynamic)reader["A2_ENG_USP_FEED_FUEL_AMM2"],
                A2_ENG_USP_FUEL_AB = (dynamic)reader["A2_ENG_USP_FUEL_AB"],
                A2_SPE_ALLOC_EQ_NAP_PWR_UTIL = (dynamic)reader["A2_SPE_ALLOC_EQ_NAP_PWR_UTIL"],
                A2_ENG_NET_UREA = (dynamic)reader["A2_ENG_NET_UREA"],
                DIS_TOT_AMM_STOCK = (dynamic)reader["DIS_TOT_AMM_STOCK"],
                DIS_AMM1_LSTOCK = (dynamic)reader["DIS_AMM1_LSTOCK"],
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (decimal)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<PAS212Model> putData(string IN_DATE,char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPV_AM2_AMMONIA_DAILY_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS212Model response = null;
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
