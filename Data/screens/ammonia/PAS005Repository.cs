using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS005Repository
    {
        private readonly string _connectionString;
        public PAS005Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS005Model MapToValue(SqlDataReader reader)
        {
            return new PAS005Model()
            {
                MINMONTH = reader["MINMONTH"].ToString(),
                MINYEAR = (decimal)reader["MINYEAR"],
                MAXMONTH = reader["MAXMONTH"].ToString(),
                MAXYEAR = (decimal)reader["MAXYEAR"],
                A1_MONTH = reader["A1_MONTH"].ToString(),
                A1_YEAR = (decimal)reader["A1_YEAR"],
                A1_USER_ID = (decimal)reader["A1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                A1_DATE_MOD = reader["A1_DATE_MOD"].ToString(),

                A1_AMM_BUDG_SP_GAS_1 = (decimal)reader["A1_AMM_BUDG_SP_GAS_1"],
                A1_AMM_ACTL_SP_GAS_1 = (decimal)reader["A1_AMM_ACTL_SP_GAS_1"],
                A1_AMM_CONSP_VAR_1 = (decimal)reader["A1_AMM_CONSP_VAR_1"],
                A1_AMM_SGAS_BURNT_1 = (decimal)reader["A1_AMM_SGAS_BURNT_1"],
                A1_AMM_ADD_FLARING = (decimal)reader["A1_AMM_ADD_FLARING"],
                A1_AMM_USAGE_CONSP_VAR = (decimal)reader["A1_AMM_USAGE_CONSP_VAR"],
                A1_AMM_OTHERS = (decimal)reader["A1_AMM_OTHERS"],
                A1_AMM_NET_CONSP_VAR_1 = (decimal)reader["A1_AMM_NET_CONSP_VAR_1"],
                A1_SPG_BUDG_SP_GAS = (decimal)reader["A1_SPG_BUDG_SP_GAS"],
                A1_SPG_ACTL_SP_GAS = (decimal)reader["A1_SPG_ACTL_SP_GAS"],
                A1_SPG_CONSP_VAR = (decimal)reader["A1_SPG_CONSP_VAR"],
                A1_SPG_2GTG_VAR = (decimal)reader["A1_SPG_2GTG_VAR"],
                A1_SPG_SU_SD_VAR = (decimal)reader["A1_SPG_SU_SD_VAR"],
                A1_SPG_USAGE_CONSP_VAR = (decimal)reader["A1_SPG_USAGE_CONSP_VAR"],
                A1_SPG_UTILITY_DMD_VAR = (decimal)reader["A1_SPG_UTILITY_DMD_VAR"],
                A1_SPG_OTHERS = (decimal)reader["A1_SPG_OTHERS"],
                A1_SPG_NET_CONSP_VAR = (decimal)reader["A1_SPG_NET_CONSP_VAR"],
                A1_AMM_BUDG_PROD = (decimal)reader["A1_AMM_BUDG_PROD"],
                A1_AMM_ACTL_PROD = (decimal)reader["A1_AMM_ACTL_PROD"],
                A1_AMM_VOL_VAR = (decimal)reader["A1_AMM_VOL_VAR"],
                A1_AMM_PROD_ADJ_VOL_VAR = (decimal)reader["A1_AMM_PROD_ADJ_VOL_VAR"],
                A1_AMM_BUDG_STREAM_DAYS = (decimal)reader["A1_AMM_BUDG_STREAM_DAYS"],
                A1_AMM_ACTL_STREAM_DAYS = (decimal)reader["A1_AMM_ACTL_STREAM_DAYS"],
                A1_AMM_STREAM_DAYS_LOST = (decimal)reader["A1_AMM_STREAM_DAYS_LOST"],
                A1_AMM_PROD_LOST = (decimal)reader["A1_AMM_PROD_LOST"],
                A1_AMM_PROD_LOST_GAS_LIMIT = (decimal)reader["A1_AMM_PROD_LOST_GAS_LIMIT"],
                A1_AMM_PROD_LOST_SGAS = (decimal)reader["A1_AMM_PROD_LOST_SGAS"],
                A1_AMM_TOT_ACC_PROD_LOST = (decimal)reader["A1_AMM_TOT_ACC_PROD_LOST"],
                A1_UREA_BUDG_PROD = (decimal)reader["A1_UREA_BUDG_PROD"],
                A1_UREA_ACTL_PROD = (decimal)reader["A1_UREA_ACTL_PROD"],
                A1_UREA_VOL_VAR = (decimal)reader["A1_UREA_VOL_VAR"],
                A1_UREA_PROD_ADJ_VOL_VAR = (decimal)reader["A1_UREA_PROD_ADJ_VOL_VAR"],
                A1_UREA_BUDG_STREAM_DAYS = (decimal)reader["A1_UREA_BUDG_STREAM_DAYS"],
                A1_UREA_ACTL_STREAM_DAYS = (decimal)reader["A1_UREA_ACTL_STREAM_DAYS"],
                A1_UREA_STREAM_DAYS_LOST = (decimal)reader["A1_UREA_STREAM_DAYS_LOST"],
                A1_UREA_PROD_LOST = (decimal)reader["A1_UREA_PROD_LOST"],
                A1_UREA_PROD_LOST_GAS_LIMIT = (decimal)reader["A1_UREA_PROD_LOST_GAS_LIMIT"],
                A1_UREA_TOT_ACC_PROD_LOST = (decimal)reader["A1_UREA_TOT_ACC_PROD_LOST"],
                A1_AMM_BUDG_SP_GAS_2 = (decimal)reader["A1_AMM_BUDG_SP_GAS_2"],
                A1_AMM_ACTL_SP_GAS_2 = (decimal)reader["A1_AMM_ACTL_SP_GAS_2"],
                A1_AMM_ACTL_SP_GAS_AFTER_COMP = (decimal)reader["A1_AMM_ACTL_SP_GAS_AFTER_COMP"],
                A1_AMM_CONSP_VAR_2 = (decimal)reader["A1_AMM_CONSP_VAR_2"],
                A1_AMM_CONSP_VAR_PROD_ADJ = (decimal)reader["A1_AMM_CONSP_VAR_PROD_ADJ"],
                A1_AMM_NET_CONSP_VAR_2 = (decimal)reader["A1_AMM_NET_CONSP_VAR_2"],
                A1_AMM_SGAS_BURNT_2 = (decimal)reader["A1_AMM_SGAS_BURNT_2"],
                A1_AMM_BUDG_SGAS_BURNT = (decimal)reader["A1_AMM_BUDG_SGAS_BURNT"],
                A1_AMM_ADDL_SGAS_BURNT = (decimal)reader["A1_AMM_ADDL_SGAS_BURNT"],
                A1_AMM_EQ_FUEL_ADDL_SGAS = (decimal)reader["A1_AMM_EQ_FUEL_ADDL_SGAS"],
                A1_AMM_EQ_AMM_PROD_SGAS = (decimal)reader["A1_AMM_EQ_AMM_PROD_SGAS"],
                A1_AMM_GROSS_GAS_CONSP_SGAS = (decimal)reader["A1_AMM_GROSS_GAS_CONSP_SGAS"],
                A1_AMM_GROSS_AMM_PROD_SGAS = (decimal)reader["A1_AMM_GROSS_AMM_PROD_SGAS"],
                A1_AMM_SP_GAS_AFTER_SGAS = (decimal)reader["A1_AMM_SP_GAS_AFTER_SGAS"],
                A1_AMM_CONSP_VAR_SGAS = (decimal)reader["A1_AMM_CONSP_VAR_SGAS"],
                A1_AMM_UNPROD_GAS_FLARING = (decimal)reader["A1_AMM_UNPROD_GAS_FLARING"],
                A1_AMM_BUDG_UNPROD_GAS_FLARING = (decimal)reader["A1_AMM_BUDG_UNPROD_GAS_FLARING"],
                A1_AMM_NET_ADDL_UNPOROD_GAS = (decimal)reader["A1_AMM_NET_ADDL_UNPOROD_GAS"],
                A1_AMM_VAR_ADDL_FLARING = (decimal)reader["A1_AMM_VAR_ADDL_FLARING"],
                A1_AMM_TOT_ACCT_VAR_ADDL_FLR = (decimal)reader["A1_AMM_TOT_ACCT_VAR_ADDL_FLR"],
                A1_AMM_USAGE_VAR_ADDL_FLARING = (decimal)reader["A1_AMM_USAGE_VAR_ADDL_FLARING"],
                A1_SPG_BUDG_FUEL_SPG = (decimal)reader["A1_SPG_BUDG_FUEL_SPG"],
                A1_SPG_ACTL_FUEL_SPG = (decimal)reader["A1_SPG_ACTL_FUEL_SPG"],
                A1_SPG_EXTRA_FUEL_SPG = (decimal)reader["A1_SPG_EXTRA_FUEL_SPG"],
                A1_SPG_NET_VAR_AFTER_PROD_ADJ = (decimal)reader["A1_SPG_NET_VAR_AFTER_PROD_ADJ"],
                A1_SPG_HRS_2GTGS = (decimal)reader["A1_SPG_HRS_2GTGS"],
                A1_SPG_IDLE_GAS_CONSP_2GTGS = (decimal)reader["A1_SPG_IDLE_GAS_CONSP_2GTGS"],
                A1_SPG_2GTGS_VAR_PMT_UREA = (decimal)reader["A1_SPG_2GTGS_VAR_PMT_UREA"],
                A1_SPG_NO_GT_STARTUP = (decimal)reader["A1_SPG_NO_GT_STARTUP"],
                A1_SPG_GAS_GT_STARTUP = (decimal)reader["A1_SPG_GAS_GT_STARTUP"],
                A1_SPG_NO_AB_STARTUP = (decimal)reader["A1_SPG_NO_AB_STARTUP"],
                A1_SPG_GAS_AB_STARTUP = (decimal)reader["A1_SPG_GAS_AB_STARTUP"],
                A1_SPG_TOT_GAS_SU_SD = (decimal)reader["A1_SPG_TOT_GAS_SU_SD"],
                A1_UREA_NO_STARTUP = (decimal)reader["A1_UREA_NO_STARTUP"],
                A1_UREA_STEAM_STARTUP = (decimal)reader["A1_UREA_STEAM_STARTUP"],
                A1_UREA_GAS_STARTUP = (decimal)reader["A1_UREA_GAS_STARTUP"],
                A1_TOT_STARTUP_LOSSES = (decimal)reader["A1_TOT_STARTUP_LOSSES"],
                A1_VAR_STARTUP = (decimal)reader["A1_VAR_STARTUP"],
                A1_UREA_BUDG_STM_CONSP = (decimal)reader["A1_UREA_BUDG_STM_CONSP"],
                A1_UREA_ACTL_STM_CONSP = (decimal)reader["A1_UREA_ACTL_STM_CONSP"],
                A1_UREA_ADDL_STM_CONSP = (decimal)reader["A1_UREA_ADDL_STM_CONSP"],
                A1_UREA_TOT_ADDL_STM_CONSP = (decimal)reader["A1_UREA_TOT_ADDL_STM_CONSP"],
                A1_UREA_LESS_STM_CONSP = (decimal)reader["A1_UREA_LESS_STM_CONSP"],
                A1_UREA_NET_ADDL_STM_CONSP = (decimal)reader["A1_UREA_NET_ADDL_STM_CONSP"],
                A1_UREA_GAS_CONSP_ADDL_STM = (decimal)reader["A1_UREA_GAS_CONSP_ADDL_STM"],
                A1_UREA_ADDL_STM_CONSP_VAR = (decimal)reader["A1_UREA_ADDL_STM_CONSP_VAR"],
                A1_AMM_BUDG_STM_CONSP = (decimal)reader["A1_AMM_BUDG_STM_CONSP"],
                A1_AMM_ACTL_STM_CONSP = (decimal)reader["A1_AMM_ACTL_STM_CONSP"],
                A1_AMM_ADDL_STM_CONSP = (decimal)reader["A1_AMM_ADDL_STM_CONSP"],
                A1_AMM_TOT_ADDL_STM_CONSP = (decimal)reader["A1_AMM_TOT_ADDL_STM_CONSP"],
                A1_AMM_GAS_CONSP_ADDL_STM = (decimal)reader["A1_AMM_GAS_CONSP_ADDL_STM"],
                A1_AMM_ADDL_STM_CONSP_VAR = (decimal)reader["A1_AMM_ADDL_STM_CONSP_VAR"],
                A1_UREA_BUDG_PROD_PWR_CONSP = (decimal)reader["A1_UREA_BUDG_PROD_PWR_CONSP"],
                A1_UREA_TOT_PROD_PWR_DEMAND = (decimal)reader["A1_UREA_TOT_PROD_PWR_DEMAND"],
                A1_UREA_ACTL_PROD_PWR_CONSP = (decimal)reader["A1_UREA_ACTL_PROD_PWR_CONSP"],
                A1_UREA_ADDL_PWR_CONSP = (decimal)reader["A1_UREA_ADDL_PWR_CONSP"],
                A1_UREA_GAS_CONSP_ADDL_PWR = (decimal)reader["A1_UREA_GAS_CONSP_ADDL_PWR"],
                A1_UREA_PROD_PWR_CONSP_VAR = (decimal)reader["A1_UREA_PROD_PWR_CONSP_VAR"],
                A1_AMM_BUDG_PROD_PWR_CONSP = (decimal)reader["A1_AMM_BUDG_PROD_PWR_CONSP"],
                A1_AMM_TOT_PROD_PWR_DEMAND = (decimal)reader["A1_AMM_TOT_PROD_PWR_DEMAND"],
                A1_AMM_ACTL_PROD_PWR_CONSP = (decimal)reader["A1_AMM_ACTL_PROD_PWR_CONSP"],
                A1_AMM_ADDL_PWR_CONSP = (decimal)reader["A1_AMM_ADDL_PWR_CONSP"],
                A1_AMM_GAS_CONSP_ADDL_PWR = (decimal)reader["A1_AMM_GAS_CONSP_ADDL_PWR"],
                A1_AMM_PROD_PWR_CONSP_VAR = (decimal)reader["A1_AMM_PROD_PWR_CONSP_VAR"],
                A1_TOT_ACC_VAR_SPG_FUEL = (decimal)reader["A1_TOT_ACC_VAR_SPG_FUEL"],
                A1_TOT_USAGE_VAR_SPG_FUEL = (decimal)reader["A1_TOT_USAGE_VAR_SPG_FUEL"],
                A1_UREA_BUDG_OVERALL = (decimal)reader["A1_UREA_BUDG_OVERALL"],
                A1_UREA_ACTL_OVERALL = (decimal)reader["A1_UREA_ACTL_OVERALL"],
                A1_UREA_NET_VAR = (decimal)reader["A1_UREA_NET_VAR"],
                A1_AMM_FEED_FUEL = (decimal)reader["A1_AMM_FEED_FUEL"],
                A1_SPG_FUEL = (decimal)reader["A1_SPG_FUEL"],
                A1_TOT_ACCT_VAR = (decimal)reader["A1_TOT_ACCT_VAR"],
                A1_TOT_USAGE_VAR = (decimal)reader["A1_TOT_USAGE_VAR"]
            };
        }

        public async Task<PAS005Model> putData(MonthYearParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_GET_PPT_AM_VARIANCE_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MONTH", value.MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_YEAR", value.YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.BTN));
                    PAS005Model response = null;
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
