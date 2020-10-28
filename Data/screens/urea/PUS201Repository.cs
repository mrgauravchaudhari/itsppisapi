using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS201Repository
    {
        private readonly string _connectionString;
        public PUS201Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS201Model MapToValue(SqlDataReader reader)
        {
            return new PUS201Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                U2_TRANS_DATE = reader["U2_TRANS_DATE"].ToString(),
                U2_TOT_AMM_CONSP_INT = (decimal)reader["U2_TOT_AMM_CONSP_INT"],
                U2_TOT_AMM_CONSP = (decimal)reader["U2_TOT_AMM_CONSP"],
                U2_TOT_UREA_PROD = (decimal)reader["U2_TOT_UREA_PROD"],
                U2_EFF_FACTOR = (decimal)reader["U2_EFF_FACTOR"],
                U2_UREA_CAP_UTIL = (decimal)reader["U2_UREA_CAP_UTIL"],
                U2_TA_CO2_CONSP_INT = (decimal)reader["U2_TA_CO2_CONSP_INT"],
                U2_TA_CO2_CONSP = (decimal)reader["U2_TA_CO2_CONSP"],
                U2_TA_STREAM_HRS = (decimal)reader["U2_TA_STREAM_HRS"],
                U2_TA_AMM_CONSP = (decimal)reader["U2_TA_AMM_CONSP"],
                U2_TA_UREA_PROD = (decimal)reader["U2_TA_UREA_PROD"],
                U2_TA_CAP_UTIL = (decimal)reader["U2_TA_CAP_UTIL"],
                U2_TB_CO2_CONSP_INT = (decimal)reader["U2_TB_CO2_CONSP_INT"],
                U2_TB_CO2_CONSP = (decimal)reader["U2_TB_CO2_CONSP"],
                U2_TB_STREAM_HRS = (decimal)reader["U2_TB_STREAM_HRS"],
                U2_TB_AMM_CONSP = (decimal)reader["U2_TB_AMM_CONSP"],
                U2_TB_UREA_PROD = (decimal)reader["U2_TB_UREA_PROD"],
                U2_TB_CAP_UTIL = (decimal)reader["U2_TB_CAP_UTIL"],
                U2_REMARKS_D = reader["U2_REMARKS_D"].ToString(),
                U2_REMARKS_M = reader["U2_REMARKS_M"].ToString(),
                U2_TA_BFW_CONSP_INT = (decimal)reader["U2_TA_BFW_CONSP_INT"],
                U2_TA_BFW_CONSP = (decimal)reader["U2_TA_BFW_CONSP"],
                U2_TB_BFW_CONSP = (decimal)reader["U2_TB_BFW_CONSP"],
                U2_FIRE_CONSP_UCT2_INT = (decimal)reader["U2_FIRE_CONSP_UCT2_INT"],
                U2_FIRE_CONSP_UCT2 = (decimal)reader["U2_FIRE_CONSP_UCT2"],
                U2_FW_CONSP_SW_GPI_INT = (decimal)reader["U2_FW_CONSP_SW_GPI_INT"],
                U2_FW_CONSP_SW_GPI_INT_DIFF = (decimal)reader["U2_FW_CONSP_SW_GPI_INT_DIFF"],
                U2_FW_CONSP_SW_GPI = (decimal)reader["U2_FW_CONSP_SW_GPI"],
                U2_FW_CONSP_SW_GPII_INT = (decimal)reader["U2_FW_CONSP_SW_GPII_INT"],
                U2_FW_CONSP_SW_GPII_INT_DIFF = (decimal)reader["U2_FW_CONSP_SW_GPII_INT_DIFF"],
                U2_FW_CONSP_SW_GPII = (decimal)reader["U2_FW_CONSP_SW_GPII"],
                U2_TA_UTC_PROD_INT = (decimal)reader["U2_TA_UTC_PROD_INT"],
                U2_TA_UTC_PROD = (decimal)reader["U2_TA_UTC_PROD"],
                U2_TB_UTC_PROD_INT = (decimal)reader["U2_TB_UTC_PROD_INT"],
                U2_TB_UTC_PROD = (decimal)reader["U2_TB_UTC_PROD"],
                U2_USC_PROD_INT = (decimal)reader["U2_USC_PROD_INT"],
                U2_USC_PROD = (decimal)reader["U2_USC_PROD"],
                U2_UPC_PROD_INT = (decimal)reader["U2_UPC_PROD_INT"],
                U2_UPC_PROD = (decimal)reader["U2_UPC_PROD"],
                U2_TOT_CONDENSATE_PROD = (decimal)reader["U2_TOT_CONDENSATE_PROD"],
                U2_EFF_WATER_EXP = (decimal)reader["U2_EFF_WATER_EXP"],
                U2_TOT_SH_CONSP_INT = (decimal)reader["U2_TOT_SH_CONSP_INT"],
                U2_TOT_SH_CONSP = (decimal)reader["U2_TOT_SH_CONSP"],
                U2_TA_SH_CONSP = (decimal)reader["U2_TA_SH_CONSP"],
                U2_TB_SH_CONSP = (decimal)reader["U2_TB_SH_CONSP"],
                U2_CO2_SALES_INT = (decimal)reader["U2_CO2_SALES_INT"],
                U2_CO2_SALES = (decimal)reader["U2_CO2_SALES"],
                TXT_AMM_CONSP = (decimal)reader["TXT_AMM_CONSP"],
                TXT_AMM_STORAGE = (decimal)reader["TXT_AMM_STORAGE"],
                TXT_CO2_CONSP = (decimal)reader["TXT_CO2_CONSP"],
                TXT_TOT_BFW_CONSP = (decimal)reader["TXT_TOT_BFW_CONSP"],
                TXT_PW_UCT = (decimal)reader["TXT_PW_UCT"],
                TXT_SM_CONSP_UCT = (decimal)reader["TXT_SM_CONSP_UCT"],
                TXT_TA_PWR_CONSP = (decimal)reader["TXT_TA_PWR_CONSP"],
                TXT_TB_PWR_CONSP = (decimal)reader["TXT_TB_PWR_CONSP"],
                TXT_UCT_PWR_CONSP = (decimal)reader["TXT_UCT_PWR_CONSP"],
                TXT_TOT_PWR_CONSP = (decimal)reader["TXT_TOT_PWR_CONSP"],
                TXT_SP_TA_SH_CONSP = (decimal)reader["TXT_SP_TA_SH_CONSP"],
                TXT_SP_TB_SH_CONSP = (decimal)reader["TXT_SP_TB_SH_CONSP"],
                TXT_SP_TOT_SH_CONSP = (decimal)reader["TXT_SP_TOT_SH_CONSP"],
                TXT_SP_TA_AMM_CONSP = (decimal)reader["TXT_SP_TA_AMM_CONSP"],
                TXT_SP_TB_AMM_CONSP = (decimal)reader["TXT_SP_TB_AMM_CONSP"],
                TXT_SP_TOT_AMM_CONSP = (decimal)reader["TXT_SP_TOT_AMM_CONSP"],
                TXT_SP_TA_CO2_CONSP = (decimal)reader["TXT_SP_TA_CO2_CONSP"],
                TXT_SP_TB_CO2_CONSP = (decimal)reader["TXT_SP_TB_CO2_CONSP"],
                TXT_SP_TOT_CO2_CONSP = (decimal)reader["TXT_SP_TOT_CO2_CONSP"],
                TXT_SP_TA_BFW_CONSP = (decimal)reader["TXT_SP_TA_BFW_CONSP"],
                TXT_SP_TB_BFW_CONSP = (decimal)reader["TXT_SP_TB_BFW_CONSP"],
                TXT_SP_TOT_BFW_CONSP = (decimal)reader["TXT_SP_TOT_BFW_CONSP"],
                TXT_SP_TA_PWR_CONSP = (decimal)reader["TXT_SP_TA_PWR_CONSP"],
                TXT_SP_TB_PWR_CONSP = (decimal)reader["TXT_SP_TB_PWR_CONSP"],
                TXT_SP_TOT_PWR_CONSP = (decimal)reader["TXT_SP_TOT_PWR_CONSP"],
                TXT_SP_TA_UTC_PROD = (decimal)reader["TXT_SP_TA_UTC_PROD"],
                TXT_SP_TB_UTC_PROD = (decimal)reader["TXT_SP_TB_UTC_PROD"],
                TXT_SP_USC_CONSP = (decimal)reader["TXT_SP_USC_CONSP"],
                TXT_SP_UPC_CONSP = (decimal)reader["TXT_SP_UPC_CONSP"],
                TXT_SP_UCT_PWR_CONSP = (decimal)reader["TXT_SP_UCT_PWR_CONSP"],
                TXT_SP_TOT_UTC_PROD = (decimal)reader["TXT_SP_TOT_UTC_PROD"],
                DATE_MOD = reader["U2_DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV 

                PRV_U2_TRANS_DATE = reader["PRV_U2_TRANS_DATE"].ToString(),
                PRV_U2_TOT_AMM_CONSP_INT = (decimal)reader["PRV_U2_TOT_AMM_CONSP_INT"],
                PRV_U2_TOT_AMM_CONSP = (decimal)reader["PRV_U2_TOT_AMM_CONSP"],
                PRV_U2_TOT_UREA_PROD = (decimal)reader["PRV_U2_TOT_UREA_PROD"],
                PRV_U2_EFF_FACTOR = (decimal)reader["PRV_U2_EFF_FACTOR"],
                PRV_U2_UREA_CAP_UTIL = (decimal)reader["PRV_U2_UREA_CAP_UTIL"],
                PRV_U2_TA_CO2_CONSP_INT = (decimal)reader["PRV_U2_TA_CO2_CONSP_INT"],
                PRV_U2_TA_CO2_CONSP = (decimal)reader["PRV_U2_TA_CO2_CONSP"],
                PRV_U2_TA_STREAM_HRS = (decimal)reader["PRV_U2_TA_STREAM_HRS"],
                PRV_U2_TA_AMM_CONSP = (decimal)reader["PRV_U2_TA_AMM_CONSP"],
                PRV_U2_TA_UREA_PROD = (decimal)reader["PRV_U2_TA_UREA_PROD"],
                PRV_U2_TA_CAP_UTIL = (decimal)reader["PRV_U2_TA_CAP_UTIL"],
                PRV_U2_TB_CO2_CONSP_INT = (decimal)reader["PRV_U2_TB_CO2_CONSP_INT"],
                PRV_U2_TB_CO2_CONSP = (decimal)reader["PRV_U2_TB_CO2_CONSP"],
                PRV_U2_TB_STREAM_HRS = (decimal)reader["PRV_U2_TB_STREAM_HRS"],
                PRV_U2_TB_AMM_CONSP = (decimal)reader["PRV_U2_TB_AMM_CONSP"],
                PRV_U2_TB_UREA_PROD = (decimal)reader["PRV_U2_TB_UREA_PROD"],
                PRV_U2_TB_CAP_UTIL = (decimal)reader["PRV_U2_TB_CAP_UTIL"],
                PRV_U2_TA_BFW_CONSP_INT = (decimal)reader["PRV_U2_TA_BFW_CONSP_INT"],
                PRV_U2_TA_BFW_CONSP = (decimal)reader["PRV_U2_TA_BFW_CONSP"],
                PRV_U2_TB_BFW_CONSP = (decimal)reader["PRV_U2_TB_BFW_CONSP"],
                PRV_U2_FIRE_CONSP_UCT2_INT = (decimal)reader["PRV_U2_FIRE_CONSP_UCT2_INT"],
                PRV_U2_FIRE_CONSP_UCT2 = (decimal)reader["PRV_U2_FIRE_CONSP_UCT2"],
                PRV_U2_FW_CONSP_SW_GPI_INT = (decimal)reader["PRV_U2_FW_CONSP_SW_GPI_INT"],
                PRV_U2_FW_CONSP_SW_GPI_INT_DIFF = (decimal)reader["PRV_U2_FW_CONSP_SW_GPI_INT_DIFF"],
                PRV_U2_FW_CONSP_SW_GPI = (decimal)reader["PRV_U2_FW_CONSP_SW_GPI"],
                PRV_U2_FW_CONSP_SW_GPII_INT = (decimal)reader["PRV_U2_FW_CONSP_SW_GPII_INT"],
                PRV_U2_FW_CONSP_SW_GPII_INT_DIFF = (decimal)reader["PRV_U2_FW_CONSP_SW_GPII_INT_DIFF"],
                PRV_U2_FW_CONSP_SW_GPII = (decimal)reader["PRV_U2_FW_CONSP_SW_GPII"],
                PRV_U2_TA_UTC_PROD_INT = (decimal)reader["PRV_U2_TA_UTC_PROD_INT"],
                PRV_U2_TA_UTC_PROD = (decimal)reader["PRV_U2_TA_UTC_PROD"],
                PRV_U2_TB_UTC_PROD_INT = (decimal)reader["PRV_U2_TB_UTC_PROD_INT"],
                PRV_U2_TB_UTC_PROD = (decimal)reader["PRV_U2_TB_UTC_PROD"],
                PRV_U2_USC_PROD_INT = (decimal)reader["PRV_U2_USC_PROD_INT"],
                PRV_U2_USC_PROD = (decimal)reader["PRV_U2_USC_PROD"],
                PRV_U2_UPC_PROD_INT = (decimal)reader["PRV_U2_UPC_PROD_INT"],
                PRV_U2_UPC_PROD = (decimal)reader["PRV_U2_UPC_PROD"],
                PRV_U2_TOT_CONDENSATE_PROD = (decimal)reader["PRV_U2_TOT_CONDENSATE_PROD"],
                PRV_U2_EFF_WATER_EXP = (decimal)reader["PRV_U2_EFF_WATER_EXP"],
                PRV_U2_TOT_SH_CONSP_INT = (decimal)reader["PRV_U2_TOT_SH_CONSP_INT"],
                PRV_U2_TOT_SH_CONSP = (decimal)reader["PRV_U2_TOT_SH_CONSP"],
                PRV_U2_TA_SH_CONSP = (decimal)reader["PRV_U2_TA_SH_CONSP"],
                PRV_U2_TB_SH_CONSP = (decimal)reader["PRV_U2_TB_SH_CONSP"],
                PRV_U2_CO2_SALES_INT = (decimal)reader["PRV_U2_CO2_SALES_INT"],
                PRV_U2_CO2_SALES = (decimal)reader["PRV_U2_CO2_SALES"]
            };
        }

        private PUS201DVDto MapToValueDV2(SqlDataReader reader)
        {
            return new PUS201DVDto()
            {
                PARM_EFF = reader["PARM_EFF"].ToString(),
                PARM_UREA_CAPACITY = reader["PARM_UREA_CAPACITY"].ToString(),
                PARM_G_MF_SW = reader["PARM_G_MF_SW"].ToString(),
                PROD_TO_DATE = reader["PROD_TO_DATE"].ToString(),
                HIGHEST_YEARLY_PROD_DATE = reader["HIGHEST_YEARLY_PROD_DATE"].ToString(),
                HIGHEST_YEARLY_PROD = (decimal)reader["HIGHEST_YEARLY_PROD"],
                HIGHEST_MONTHLY_PROD_DATE = reader["HIGHEST_MONTHLY_PROD_DATE"].ToString(),
                HIGHEST_MONTHLY_PROD = (decimal)reader["HIGHEST_MONTHLY_PROD"],
                HIGHEST_UREA_PROD = (decimal)reader["HIGHEST_UREA_PROD"],
                HIGHEST_UREA_PROD_DATE = reader["HIGHEST_UREA_PROD_DATE"].ToString(),
                HIGHEST_TA_PROD = (decimal)reader["HIGHEST_TA_PROD"],
                HIGHEST_TA_PROD_DATE = reader["HIGHEST_TA_PROD_DATE"].ToString(),
                HIGHEST_TB_PROD = (decimal)reader["HIGHEST_TB_PROD"],
                HIGHEST_TB_PROD_DATE = reader["HIGHEST_TB_PROD_DATE"].ToString(),
            };
        }

        public async Task<PUS201Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_GET_PPT_UR2_UREA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PUS201Model response = null;
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

        public async Task<PUS201DVDto> putDataDV2(string IN_DATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_GET_PPT_UR_UREA_DETAILS_DV", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    // cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PUS201DVDto response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValueDV2(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PUS201Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_SAVE_PPT_UR2_UREA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TRANS_DATE", value.U2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DMY_FLG", value.U2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_USER_ID", value.U2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FREEZE_FLG", value.U2_FREEZE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_AMM_CONSP_INT", value.U2_TOT_AMM_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_AMM_CONSP", value.U2_TOT_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_CO2_CONSP_INT", value.U2_TA_CO2_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_CO2_CONSP", value.U2_TA_CO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_CO2_CONSP_INT", value.U2_TB_CO2_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_CO2_CONSP", value.U2_TB_CO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_STREAM_HRS", value.U2_TA_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_STREAM_HRS", value.U2_TB_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_AMM_CONSP", value.U2_TA_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_AMM_CONSP", value.U2_TB_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_UREA_PROD", value.U2_TA_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_UREA_PROD", value.U2_TB_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_UREA_PROD", value.U2_TOT_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_CAP_UTIL", value.U2_TA_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_CAP_UTIL", value.U2_TB_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_UREA_CAP_UTIL", value.U2_UREA_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_EFF_FACTOR", value.U2_EFF_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_BFW_CONSP_INT", value.U2_TA_BFW_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_BFW_CONSP", value.U2_TA_BFW_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_BFW_CONSP", value.U2_TB_BFW_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_UTC_PROD_INT", value.U2_TA_UTC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_UTC_PROD", value.U2_TA_UTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_UTC_PROD_INT", value.U2_TB_UTC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_UTC_PROD", value.U2_TB_UTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_USC_PROD_INT", value.U2_USC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_USC_PROD", value.U2_USC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_UPC_PROD_INT", value.U2_UPC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_UPC_PROD", value.U2_UPC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_CONDENSATE_PROD", value.U2_TOT_CONDENSATE_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_SH_CONSP_INT", value.U2_TOT_SH_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_SH_CONSP", value.U2_TOT_SH_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TA_SH_CONSP", value.U2_TA_SH_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TB_SH_CONSP", value.U2_TB_SH_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_REMARKS_D", value.U2_REMARKS_D));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_REMARKS_M", value.U2_REMARKS_M));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_CO2_SALES_INT", value.U2_CO2_SALES_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_CO2_SALES", value.U2_CO2_SALES));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FW_CONSP_SW_GPI_INT", value.U2_FW_CONSP_SW_GPI_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FW_CONSP_SW_GPI_INT_DIFF", value.U2_FW_CONSP_SW_GPI_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FW_CONSP_SW_GPI", value.U2_FW_CONSP_SW_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FW_CONSP_SW_GPII_INT", value.U2_FW_CONSP_SW_GPII_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FW_CONSP_SW_GPII_INT_DIFF", value.U2_FW_CONSP_SW_GPII_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FW_CONSP_SW_GPII", value.U2_FW_CONSP_SW_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FIRE_CONSP_UCT2_INT", value.U2_FIRE_CONSP_UCT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_FIRE_CONSP_UCT2", value.U2_FIRE_CONSP_UCT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_EFF_WATER_EXP", value.U2_EFF_WATER_EXP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_UREA_PROD_SHIFT_A", value.U2_TOT_UREA_PROD_SHIFT_A));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_UREA_PROD_SHIFT_B", value.U2_TOT_UREA_PROD_SHIFT_B));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TOT_UREA_PROD_SHIFT_C", value.U2_TOT_UREA_PROD_SHIFT_C));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
