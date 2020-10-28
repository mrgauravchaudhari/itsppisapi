using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS213Repository
    {
        private readonly string _connectionString;
        public PAS213Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS213Model MapToValue(SqlDataReader reader)
        {
            return new PAS213Model()
            {
                MINMONTH = reader["MINMONTH"].ToString(),
                MINYEAR = (decimal)reader["MINYEAR"],
                MAXMONTH = reader["MAXMONTH"].ToString(),
                MAXYEAR = (decimal)reader["MAXYEAR"],
                A2_YEAR = (decimal)reader["A2_YEAR"],
                A2_MONTH = reader["A2_MONTH"].ToString(),
                A2_USER_ID = (decimal)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_AMM_STREAM_DAYS = (decimal)reader["A2_AMM_STREAM_DAYS"],
                A2_AB_STREAM_DAYS = (decimal)reader["A2_AB_STREAM_DAYS"],
                A2_PGRU_PROD = (decimal)reader["A2_PGRU_PROD"],
                A2_FRONT_END_LOAD = (decimal)reader["A2_FRONT_END_LOAD"],
                A2_AMM_PROD = (decimal)reader["A2_AMM_PROD"],
                A2_UREA_PROD = (decimal)reader["A2_UREA_PROD"],

                // DV
                A2_BASE_SP_CONSP_NG_AMM = (decimal)reader["A2_BASE_SP_CONSP_NG_AMM"],
                A2_BASE_SP_CONSP_AMM_UREA = (decimal)reader["A2_BASE_SP_CONSP_AMM_UREA"],
                A2_BASE_SP_CONSP_NG_STM = (decimal)reader["A2_BASE_SP_CONSP_NG_STM"],
                A2_BASE_AB_LOAD = (decimal)reader["A2_BASE_AB_LOAD"],
                A2_BASE_SP_DIRECT_POWER_PD = (decimal)reader["A2_BASE_SP_DIRECT_POWER_PD"],
                A2_BASE_SP_ALLOC_POWER_PD = (decimal)reader["A2_BASE_SP_ALLOC_POWER_PD"],
                A2_BASE_SP_CONSP_NAP_POWER = (decimal)reader["A2_BASE_SP_CONSP_NAP_POWER"],
                A2_BASE_SP_CONSP_GAS_POWER = (decimal)reader["A2_BASE_SP_CONSP_GAS_POWER"],
                A2_NG_CV = (decimal)reader["A2_NG_CV"],
                A2_NAP_CV = (decimal)reader["A2_NAP_CV"],
                A2_BASE_SP_CONSP_STM_UREA = (decimal)reader["A2_BASE_SP_CONSP_STM_UREA"],
                A2_REMARKS = reader["A2_REMARKS"].ToString(),
                A2_AMM_PROD_NG = (decimal)reader["A2_AMM_PROD_NG"],
                A2_AB_PROD_NG = (decimal)reader["A2_AB_PROD_NG"],
                A2_AMM_SD_NG = (decimal)reader["A2_AMM_SD_NG"],
                A2_AB_UNPROD_NG = (decimal)reader["A2_AB_UNPROD_NG"],
                A2_AMM_TOTAL_NG = (decimal)reader["A2_AMM_TOTAL_NG"],
                A2_AB_TOTAL_NG = (decimal)reader["A2_AB_TOTAL_NG"],
                A2_DIRECT_POWER = (decimal)reader["A2_DIRECT_POWER"],
                A2_ALLOC_NAP_FOR_POWER = (decimal)reader["A2_ALLOC_NAP_FOR_POWER"],
                A2_ALLOC_POWER = (decimal)reader["A2_ALLOC_POWER"],
                A2_ALLOC_GAS_FOR_POWER = (decimal)reader["A2_ALLOC_GAS_FOR_POWER"],
                A2_TOTAL_POWER = (decimal)reader["A2_TOTAL_POWER"],
                A2_EQ_ALLOC_NG_FOR_POWER = (decimal)reader["A2_EQ_ALLOC_NG_FOR_POWER"],
                A2_TOTAL_NG_CONSP_GPII = (decimal)reader["A2_TOTAL_NG_CONSP_GPII"],
                A2_AMM_SP_CONSP_NG_FEED_FUEL = (decimal)reader["A2_AMM_SP_CONSP_NG_FEED_FUEL"],
                A2_UR_SP_CONSP_NG_AB_FUEL = (decimal)reader["A2_UR_SP_CONSP_NG_AB_FUEL"],
                A2_UR_SP_ALLOC_NAP_POWER = (decimal)reader["A2_UR_SP_ALLOC_NAP_POWER"],
                A2_UR_SP_ALLOC_GAS_POWER = (decimal)reader["A2_UR_SP_ALLOC_GAS_POWER"],
                A2_UR_SP_ALLOC_EQ_NG_POWER = (decimal)reader["A2_UR_SP_ALLOC_EQ_NG_POWER"],
                A2_UR_SP_NG_AB_POWER = (decimal)reader["A2_UR_SP_NG_AB_POWER"],
                A2_UR_SP_CONSP_NG_FEED_FUEL = (decimal)reader["A2_UR_SP_CONSP_NG_FEED_FUEL"],
                A2_AMM_SPE_NAP_FEED_FUEL = (decimal)reader["A2_AMM_SPE_NAP_FEED_FUEL"],
                A2_UR_SP_TOTAL_NG = (decimal)reader["A2_UR_SP_TOTAL_NG"],
                A2_UR_SPE_NAP_OVERALL = (decimal)reader["A2_UR_SPE_NAP_OVERALL"],
                TXT_YEAR = (decimal)reader["TXT_YEAR"],
                TXT_MONTH = reader["TXT_MONTH"].ToString(),
                A2_SD_STEAM_AMM = (decimal)reader["A2_SD_STEAM_AMM"],
                A2_INPUT_PROD_LOSS_NG_LIMIT_AM = (decimal)reader["A2_INPUT_PROD_LOSS_NG_LIMIT_AM"],
                A2_NG_OTH_CONSP_AM = (decimal)reader["A2_NG_OTH_CONSP_AM"],
                A2_UNPROD_NG_AM = (decimal)reader["A2_UNPROD_NG_AM"],
                TXT_UNPROD_NG = (double)reader["TXT_UNPROD_NG"],
                A2_NG_OTH_CONSP_AB = (decimal)reader["A2_NG_OTH_CONSP_AB"],
                A2_NO_AB_STARTUP = (decimal)reader["A2_NO_AB_STARTUP"],
                A2_SD_STEAM_UREA = (decimal)reader["A2_SD_STEAM_UREA"],
                A2_NO_UREA_STARTUP = (decimal)reader["A2_NO_UREA_STARTUP"],
                A2_REMARKS_1 = reader["A2_REMARKS_1"].ToString(),
                A2_REMARKS_2 = reader["A2_REMARKS_2"].ToString()
            };
        }

        public async Task<PAS213Model> putData(string MONTH, decimal YEAR)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_PRODUCTION_PLAN", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MONTH", MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_YEAR", YEAR));
                    PAS213Model response = null;
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

        private PAS213Model2 MapToValue2(SqlDataReader reader)
        {
            return new PAS213Model2()
            {
                MSG = (string)reader["MSG"],
            };
        }

        public async Task<PAS213Model2> calAmmVar(string MONTH, string YEAR, string DELETE_FLG, decimal USER_ID)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_CALC_AMM_VARIANCE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MONTH", MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_YEAR", YEAR));
                    cmd.Parameters.Add(new SqlParameter("@DELETE_FLG", DELETE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@USER_ID", USER_ID));
                    PAS213Model2 response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue2(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PAS213SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_PRODUCTION_PLAN", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MONTH", value.A2_MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_YEAR", value.A2_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_PROD", value.A2_AMM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UREA_PROD", value.A2_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PGRU_PROD", value.A2_PGRU_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_STREAM_DAYS", value.A2_AMM_STREAM_DAYS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FRONT_END_LOAD", value.A2_FRONT_END_LOAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_STREAM_DAYS", value.A2_AB_STREAM_DAYS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DIRECT_POWER", value.A2_DIRECT_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ALLOC_POWER", value.A2_ALLOC_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOTAL_POWER", value.A2_TOTAL_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ALLOC_NAP_FOR_POWER", value.A2_ALLOC_NAP_FOR_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ALLOC_GAS_FOR_POWER", value.A2_ALLOC_GAS_FOR_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_CONSP_AMM_UREA", value.A2_BASE_SP_CONSP_AMM_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_AB_LOAD", value.A2_BASE_AB_LOAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_DIRECT_POWER_PD", value.A2_BASE_SP_DIRECT_POWER_PD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_ALLOC_POWER_PD", value.A2_BASE_SP_ALLOC_POWER_PD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_CONSP_NAP_POWER", value.A2_BASE_SP_CONSP_NAP_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_CONSP_GAS_POWER", value.A2_BASE_SP_CONSP_GAS_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_ALLOC_NAP_POWER", value.A2_UR_SP_ALLOC_NAP_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_ALLOC_GAS_POWER", value.A2_UR_SP_ALLOC_GAS_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_SPE_NAP_FEED_FUEL", value.A2_AMM_SPE_NAP_FEED_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SPE_NAP_OVERALL", value.A2_UR_SPE_NAP_OVERALL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_CV", value.A2_NG_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CV", value.A2_NAP_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NO_AB_STARTUP", value.A2_NO_AB_STARTUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NO_UREA_STARTUP", value.A2_NO_UREA_STARTUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS_1", value.A2_REMARKS_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS_2", value.A2_REMARKS_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SD_STEAM_AMM", value.A2_SD_STEAM_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SD_STEAM_UREA", value.A2_SD_STEAM_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_CONSP_STM_UREA", value.A2_BASE_SP_CONSP_STM_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_SP_CONSP_NG_FEED_FUEL", value.A2_AMM_SP_CONSP_NG_FEED_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_PROD_NG", value.A2_AMM_PROD_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_SD_NG", value.A2_AMM_SD_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_PROD_NG", value.A2_AB_PROD_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_UNPROD_NG", value.A2_AB_UNPROD_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_TOTAL_NG", value.A2_AMM_TOTAL_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_TOTAL_NG", value.A2_AB_TOTAL_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_EQ_ALLOC_NG_FOR_POWER", value.A2_EQ_ALLOC_NG_FOR_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_CONSP_NG_AMM", value.A2_BASE_SP_CONSP_NG_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BASE_SP_CONSP_NG_STM", value.A2_BASE_SP_CONSP_NG_STM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_CONSP_NG_AB_FUEL", value.A2_UR_SP_CONSP_NG_AB_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_ALLOC_EQ_NG_POWER", value.A2_UR_SP_ALLOC_EQ_NG_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_NG_AB_POWER", value.A2_UR_SP_NG_AB_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_CONSP_NG_FEED_FUEL", value.A2_UR_SP_CONSP_NG_FEED_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UR_SP_TOTAL_NG", value.A2_UR_SP_TOTAL_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_INPUT_PROD_LOSS_NG_LIMIT_AM", value.A2_INPUT_PROD_LOSS_NG_LIMIT_AM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_OTH_CONSP_AM", value.A2_NG_OTH_CONSP_AM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UNPROD_NG_AM", value.A2_UNPROD_NG_AM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_OTH_CONSP_AB", value.A2_NG_OTH_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOTAL_NG_CONSP_GPII", value.A2_TOTAL_NG_CONSP_GPII));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
