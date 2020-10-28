using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS214Repository
    {
        private readonly string _connectionString;
        public PAS214Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS214Model MapToValue(SqlDataReader reader)
        {
            return new PAS214Model()
            {
                MINMONTH = reader["MINMONTH"].ToString(),
                MINYEAR = (decimal)reader["MINYEAR"],
                MAXMONTH = reader["MAXMONTH"].ToString(),
                MAXYEAR = (decimal)reader["MAXYEAR"],
                A2_MONTH = reader["A2_MONTH"].ToString(),
                A2_YEAR = (decimal)reader["A2_YEAR"],
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (decimal)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                A2_AMM_BUDG_PROD = (decimal)reader["A2_AMM_BUDG_PROD"],
                A2_UREA_BUDG_PROD = (decimal)reader["A2_UREA_BUDG_PROD"],
                A2_AMM_ACTL_PROD = (decimal)reader["A2_AMM_ACTL_PROD"],
                A2_UREA_ACTL_PROD = (decimal)reader["A2_UREA_ACTL_PROD"],
                A2_AMM_VOL_VAR = (decimal)reader["A2_AMM_VOL_VAR"],
                A2_UREA_VOL_VAR = (decimal)reader["A2_UREA_VOL_VAR"],
                A2_AMM_BUDG_STREAM_DAYS = (decimal)reader["A2_AMM_BUDG_STREAM_DAYS"],
                A2_UREA_BUDG_STREAM_DAYS = (decimal)reader["A2_UREA_BUDG_STREAM_DAYS"],
                A2_AMM_ACTL_STREAM_DAYS = (decimal)reader["A2_AMM_ACTL_STREAM_DAYS"],
                A2_UREA_ACTL_STREAM_DAYS = (decimal)reader["A2_UREA_ACTL_STREAM_DAYS"],
                A2_AMM_STREAM_DAYS_LOST = (decimal)reader["A2_AMM_STREAM_DAYS_LOST"],
                A2_UREA_STREAM_DAYS_LOST = (decimal)reader["A2_UREA_STREAM_DAYS_LOST"],
                A2_AMM_PROD_LOST = (decimal)reader["A2_AMM_PROD_LOST"],
                A2_UREA_PROD_LOST = (decimal)reader["A2_UREA_PROD_LOST"],
                A2_AMM_PROD_LOST_NAP_LIMIT = (decimal)reader["A2_AMM_PROD_LOST_NAP_LIMIT"],
                A2_UREA_PROD_LOST_NAP_LIMIT = (decimal)reader["A2_UREA_PROD_LOST_NAP_LIMIT"],
                A2_AMM_TOT_ACC_PROD_LOST = (decimal)reader["A2_AMM_TOT_ACC_PROD_LOST"],
                A2_UREA_TOT_ACC_PROD_LOST = (decimal)reader["A2_UREA_TOT_ACC_PROD_LOST"],
                A2_AMM_BUDG_SP_NAP_2 = (decimal)reader["A2_AMM_BUDG_SP_NAP_2"],
                A2_AMM_ACTL_SP_NAP_2 = (decimal)reader["A2_AMM_ACTL_SP_NAP_2"],
                A2_AMM_CONSP_VAR_2 = (decimal)reader["A2_AMM_CONSP_VAR_2"],
                A2_AMM_ADD_FLARING = (decimal)reader["A2_AMM_ADD_FLARING"],
                A2_AMM_OTHERS = (decimal)reader["A2_AMM_OTHERS"],
                A2_AMM_NET_CONSP_VAR_2 = (decimal)reader["A2_AMM_NET_CONSP_VAR_2"],
                A2_AMM_NAP_LIMIT = (decimal)reader["A2_AMM_NAP_LIMIT"],
                A2_AMM_USAGE_CONSP_VAR = (decimal)reader["A2_AMM_USAGE_CONSP_VAR"],
                A2_AB_BUDG_SP_NAP = (decimal)reader["A2_AB_BUDG_SP_NAP"],
                A2_AB_ACTL_SP_NAP = (decimal)reader["A2_AB_ACTL_SP_NAP"],
                A2_AB_CONSP_VAR = (decimal)reader["A2_AB_CONSP_VAR"],
                A2_AB_AMM_ADD_STM_DEMAND = (decimal)reader["A2_AB_AMM_ADD_STM_DEMAND"],
                A2_AB_UR_ADD_STM_DEMAND = (decimal)reader["A2_AB_UR_ADD_STM_DEMAND"],
                A2_AB_NET_CONSP_VAR_2 = (decimal)reader["A2_AB_NET_CONSP_VAR_2"],
                A2_AB_OTHERS = (decimal)reader["A2_AB_OTHERS"],
                A2_AB_USAGE_CONSP_VAR = (decimal)reader["A2_AB_USAGE_CONSP_VAR"],
                A2_PWR_BUDG_SP_NAP = (decimal)reader["A2_PWR_BUDG_SP_NAP"],
                A2_PWR_ACTL_SP_NAP = (decimal)reader["A2_PWR_ACTL_SP_NAP"],
                A2_PWR_CONSP_VAR = (decimal)reader["A2_PWR_CONSP_VAR"],
                A2_PWR_ADD_DIRECT = (decimal)reader["A2_PWR_ADD_DIRECT"],
                A2_PWR_ADD_ALLOC_UTIL = (decimal)reader["A2_PWR_ADD_ALLOC_UTIL"],
                A2_PWR_NET_CONSP_VAR_2 = (decimal)reader["A2_PWR_NET_CONSP_VAR_2"],
                A2_PWR_USAGE_CONSP_VAR_SPG = (decimal)reader["A2_PWR_USAGE_CONSP_VAR_SPG"],
                A2_UREA_BUDG_OVERALL = (decimal)reader["A2_UREA_BUDG_OVERALL"],
                A2_UREA_ACTL_OVERALL = (decimal)reader["A2_UREA_ACTL_OVERALL"],
                A2_UREA_NET_VAR = (decimal)reader["A2_UREA_NET_VAR"],
                A2_AMM_FEED_FUEL = (decimal)reader["A2_AMM_FEED_FUEL"],
                A2_AB_FUEL = (decimal)reader["A2_AB_FUEL"],
                A2_TOT_ACCT_VAR = (decimal)reader["A2_TOT_ACCT_VAR"],
                A2_PWR_DEMAND_VAR = (decimal)reader["A2_PWR_DEMAND_VAR"],
                A2_TOT_USAGE_VAR = (decimal)reader["A2_TOT_USAGE_VAR"],
                A2_AMM_BUDG_UNPROD_NAP_3 = (decimal)reader["A2_AMM_BUDG_UNPROD_NAP_3"],
                A2_AMM_ACTL_UNPROD_NAP_3 = (decimal)reader["A2_AMM_ACTL_UNPROD_NAP_3"],
                A2_AMM_ADD_UNPROD_NAP_3 = (decimal)reader["A2_AMM_ADD_UNPROD_NAP_3"],
                A2_AB_ACTL_STM_3 = (decimal)reader["A2_AB_ACTL_STM_3"],
                A2_AB_BUDG_STM_3 = (decimal)reader["A2_AB_BUDG_STM_3"],
                A2_AB_ADD_STM_3 = (decimal)reader["A2_AB_ADD_STM_3"],
                A2_AB_ACTL_STM_AMM_3 = (decimal)reader["A2_AB_ACTL_STM_AMM_3"],
                A2_AB_BUDG_STM_AMM_3 = (decimal)reader["A2_AB_BUDG_STM_AMM_3"],
                A2_AB_ADD_STM_AMM_3 = (decimal)reader["A2_AB_ADD_STM_AMM_3"],
                A2_AB_ACTL_STM_UR_3 = (decimal)reader["A2_AB_ACTL_STM_UR_3"],
                A2_AB_BUDG_STM_UR_3 = (decimal)reader["A2_AB_BUDG_STM_UR_3"],
                A2_AB_ADD_STM_UR_3 = (decimal)reader["A2_AB_ADD_STM_UR_3"],
                A2_AB_ACTL_STM_SD_3 = (decimal)reader["A2_AB_ACTL_STM_SD_3"],
                A2_AB_BUDG_STM_SD_3 = (decimal)reader["A2_AB_BUDG_STM_SD_3"],
                A2_AB_ADD_STM_SD_3 = (decimal)reader["A2_AB_ADD_STM_SD_3"],
                A2_PWR_BUDG_DIRECT_4 = (decimal)reader["A2_PWR_BUDG_DIRECT_4"],
                A2_PWR_ACTL_DIRECT_4 = (decimal)reader["A2_PWR_ACTL_DIRECT_4"],
                A2_PWR_BUDG_UTIL_4 = (decimal)reader["A2_PWR_BUDG_UTIL_4"],
                A2_PWR_ACTL_UTIL_4 = (decimal)reader["A2_PWR_ACTL_UTIL_4"],
                A2_PWR_BUDG_ALLOC_4 = (decimal)reader["A2_PWR_BUDG_ALLOC_4"],
                A2_PWR_ACTL_ALLOC_4 = (decimal)reader["A2_PWR_ACTL_ALLOC_4"],
                A2_PWR_BUDG_ALLOC_SP_MW_4 = (decimal)reader["A2_PWR_BUDG_ALLOC_SP_MW_4"],
                A2_PWR_ACTL_ALLOC_SP_MW_4 = (decimal)reader["A2_PWR_ACTL_ALLOC_SP_MW_4"],
                TXT_AMM_BUDG_SP_NAP_2 = (decimal)reader["TXT_AMM_BUDG_SP_NAP_2"],
                TXT_AMM_ACTL_SP_NAP_2 = (decimal)reader["TXT_AMM_ACTL_SP_NAP_2"],
                TXT_AMM_CONSP_VAR_2 = (decimal)reader["TXT_AMM_CONSP_VAR_2"],
                TXT_AMM_ADD_FLARING = (decimal)reader["TXT_AMM_ADD_FLARING"],
                TXT_AMM_OTHERS = (decimal)reader["TXT_AMM_OTHERS"],
                TXT_AMM_NET_CONSP_VAR_2 = (decimal)reader["TXT_AMM_NET_CONSP_VAR_2"],
                TXT_AMM_NAP_LIMIT = (decimal)reader["TXT_AMM_NAP_LIMIT"],
                TXT_AMM_USAGE_CONSP_VAR = (decimal)reader["TXT_AMM_USAGE_CONSP_VAR"],
                TXT_AB_BUDG_SP_NAP = (decimal)reader["TXT_AB_BUDG_SP_NAP"],
                TXT_AB_ACTL_SP_NAP = (decimal)reader["TXT_AB_ACTL_SP_NAP"],
                TXT_AB_CONSP_VAR = (decimal)reader["TXT_AB_CONSP_VAR"],
                TXT_AB_AMM_ADD_STM_DEMAND = (decimal)reader["TXT_AB_AMM_ADD_STM_DEMAND"],
                TXT_AB_UR_ADD_STM_DEMAND = (decimal)reader["TXT_AB_UR_ADD_STM_DEMAND"],
                TXT_AB_NET_CONSP_VAR_2 = (decimal)reader["TXT_AB_NET_CONSP_VAR_2"],
                TXT_AB_OTHERS = (decimal)reader["TXT_AB_OTHERS"],
                TXT_AB_USAGE_CONSP_VAR = (decimal)reader["TXT_AB_USAGE_CONSP_VAR"],
                TXT_PWR_BUDG_SP_NAP = (decimal)reader["TXT_PWR_BUDG_SP_NAP"],
                TXT_PWR_ACTL_SP_NAP = (decimal)reader["TXT_PWR_ACTL_SP_NAP"],
                TXT_PWR_CONSP_VAR = (decimal)reader["TXT_PWR_CONSP_VAR"],
                TXT_PWR_ADD_DIRECT = (decimal)reader["TXT_PWR_ADD_DIRECT"],
                TXT_PWR_ADD_ALLOC_UTIL = (decimal)reader["TXT_PWR_ADD_ALLOC_UTIL"],
                TXT_PWR_NET_CONSP_VAR_2 = (decimal)reader["TXT_PWR_NET_CONSP_VAR_2"],
                TXT_PWR_USAGE_CONSP_VAR_SPG = (decimal)reader["TXT_PWR_USAGE_CONSP_VAR_SPG"],
                TXT_UREA_BUDG_OVERALL = (decimal)reader["TXT_UREA_BUDG_OVERALL"],
                TXT_UREA_ACTL_OVERALL = (decimal)reader["TXT_UREA_ACTL_OVERALL"],
                TXT_UREA_NET_VAR = (decimal)reader["TXT_UREA_NET_VAR"],
                TXT_AMM_FEED_FUEL = (decimal)reader["TXT_AMM_FEED_FUEL"],
                TXT_AB_FUEL = (decimal)reader["TXT_AB_FUEL"],
                TXT_TOT_ACCT_VAR = (decimal)reader["TXT_TOT_ACCT_VAR"],
                TXT_PWR_DEMAND_VAR = (decimal)reader["TXT_PWR_DEMAND_VAR"],
                TXT_TOT_USAGE_VAR = (decimal)reader["TXT_TOT_USAGE_VAR"],
            };
        }

        public async Task<PAS214Model> putData(MonthYearParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_VARIANCE_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MONTH", value.MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_YEAR", value.YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.BTN));
                    PAS214Model response = null;
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
