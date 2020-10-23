using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS002Repository
    {
        private readonly string _connectionString;
        public PUS002Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS002Model MapToValue(SqlDataReader reader)
        {
            return new PUS002Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                U1_TRANS_DATE = reader["U1_TRANS_DATE"].ToString(),
                U1_TOT_UREA_PROD = (decimal)reader["U1_TOT_UREA_PROD"],
                U1_EFF_FACTOR = (decimal)reader["U1_EFF_FACTOR"],
                U1_UREA_CAP_UTIL = (decimal)reader["U1_UREA_CAP_UTIL"],
                U1_U11_CO2_CONSP_INT = (decimal)reader["U1_U11_CO2_CONSP_INT"],
                U1_U11_CO2_CONSP = (decimal)reader["U1_U11_CO2_CONSP"],
                U1_U11_STREAM_HRS = (decimal)reader["U1_U11_STREAM_HRS"],
                U1_U11_P1_RPM = (decimal)reader["U1_U11_P1_RPM"],
                U1_U11_AMM_CONSP = (decimal)reader["U1_U11_AMM_CONSP"],
                U1_U11_UREA_PROD = (decimal)reader["U1_U11_UREA_PROD"],
                U1_U11_CAP_UTIL = (decimal)reader["U1_U11_CAP_UTIL"],
                U1_VAM_RUN_HRS = (decimal)reader["U1_VAM_RUN_HRS"],
                U1_VAM_POWER = (decimal)reader["U1_VAM_POWER"],
                U1_U21_CO2_CONSP_INT = (decimal)reader["U1_U21_CO2_CONSP_INT"],
                U1_U21_CO2_CONSP = (decimal)reader["U1_U21_CO2_CONSP"],
                U1_U21_STREAM_HRS = (decimal)reader["U1_U21_STREAM_HRS"],
                U1_U21_P1_RPM = (decimal)reader["U1_U21_P1_RPM"],
                U1_U21_AMM_CONSP = (decimal)reader["U1_U21_AMM_CONSP"],
                U1_U21_UREA_PROD = (decimal)reader["U1_U21_UREA_PROD"],
                U1_U21_CAP_UTIL = (decimal)reader["U1_U21_CAP_UTIL"],
                U1_REMARKS_D = reader["U1_REMARKS_D"].ToString(),
                U1_REMARKS_M = reader["U1_REMARKS_M"].ToString(),
                U1_NO_UREA_SU_SD = (decimal)reader["U1_NO_UREA_SU_SD"],
                U1_UTC_PROD_U11_INT = (decimal)reader["U1_UTC_PROD_U11_INT"],
                U1_UTC_PROD_U11 = (decimal)reader["U1_UTC_PROD_U11"],
                U1_PW_CONSP_U11_INT = (decimal)reader["U1_PW_CONSP_U11_INT"],
                U1_PW_CONSP_U11 = (decimal)reader["U1_PW_CONSP_U11"],
                U1_UTC_PROD_U21_INT = (decimal)reader["U1_UTC_PROD_U21_INT"],
                U1_UTC_PROD_U21 = (decimal)reader["U1_UTC_PROD_U21"],
                U1_PW_CONSP_U21_INT = (decimal)reader["U1_PW_CONSP_U21_INT"],
                U1_PW_CONSP_U21 = (decimal)reader["U1_PW_CONSP_U21"],
                U1_USC_PROD_INT = (decimal)reader["U1_USC_PROD_INT"],
                U1_USC_PROD = (decimal)reader["U1_USC_PROD"],
                U1_UPC_PROD_INT = (decimal)reader["U1_UPC_PROD_INT"],
                U1_UPC_PROD = (decimal)reader["U1_UPC_PROD"],
                U1_PW_CONSP_UREA = (decimal)reader["U1_PW_CONSP_UREA"],
                U1_UTC_PROD = (decimal)reader["U1_UTC_PROD"],
                U1_EFF_WATER_EXP = (decimal)reader["U1_EFF_WATER_EXP"],
                U1_KS_CONSP_U11_INT = (decimal)reader["U1_KS_CONSP_U11_INT"],
                U1_KS_CONSP_U11 = (decimal)reader["U1_KS_CONSP_U11"],
                U1_KS_CONSP_U21_INT = (decimal)reader["U1_KS_CONSP_U21_INT"],
                U1_KS_CONSP_U21 = (decimal)reader["U1_KS_CONSP_U21"],
                U1_KS_CONSP_DISOLVE = (decimal)reader["U1_KS_CONSP_DISOLVE"],
                U1_HS_CONSP_UREA_INT = (decimal)reader["U1_HS_CONSP_UREA_INT"],
                U1_HS_CONSP_UREA = (decimal)reader["U1_HS_CONSP_UREA"],
                U1_LS_CONSP_STRIPPER = (decimal)reader["U1_LS_CONSP_STRIPPER"],
                U1_KS_CONSP_UREA = (decimal)reader["U1_KS_CONSP_UREA"],
                U1_SP_CONSP_KS = (decimal)reader["U1_SP_CONSP_KS"],
                U1_SP_CONSP_HS = (decimal)reader["U1_SP_CONSP_HS"],
                U1_SP_CONSP_LS = (decimal)reader["U1_SP_CONSP_LS"],
                U1_SP_CONSP_BFW = (decimal)reader["U1_SP_CONSP_BFW"],
                U1_SP_CONSP_TC = (decimal)reader["U1_SP_CONSP_TC"],
                U1_SP_CONSP_SC = (decimal)reader["U1_SP_CONSP_SC"],
                U1_SP_CONSP_PC = (decimal)reader["U1_SP_CONSP_PC"],
                E_U11_CONSP = (decimal)reader["E_U11_CONSP"],
                E_U21_CONSP = (decimal)reader["E_U21_CONSP"],
                E_UCT_CONSP = (decimal)reader["E_UCT_CONSP"],
                U1_KS_EQ_ENG = (decimal)reader["U1_KS_EQ_ENG"],
                U1_HS_EQ_ENG = (decimal)reader["U1_HS_EQ_ENG"],
                U1_LS_EQ_ENG = (decimal)reader["U1_LS_EQ_ENG"],
                U1_BFW_EQ_ENG = (decimal)reader["U1_BFW_EQ_ENG"],
                U1_U11_ELECTC_EQ_ENG = (decimal)reader["U1_U11_ELECTC_EQ_ENG"],
                U1_U21_ELECTC_EQ_ENG = (decimal)reader["U1_U21_ELECTC_EQ_ENG"],
                U1_UCT_ELECTC_EQ_ENG = (decimal)reader["U1_UCT_ELECTC_EQ_ENG"],
                U1_TOTAL_ENG_IN = (decimal)reader["U1_TOTAL_ENG_IN"],
                U1_USC_EQ_ENG = (decimal)reader["U1_USC_EQ_ENG"],
                U1_UTC_EQ_ENG = (decimal)reader["U1_UTC_EQ_ENG"],
                U1_TOTAL_ENG_OUT = (decimal)reader["U1_TOTAL_ENG_OUT"],
                U1_NET_ENG_WITH_CT = (decimal)reader["U1_NET_ENG_WITH_CT"],
                U1_NET_ENG_WITHOUT_CT = (decimal)reader["U1_NET_ENG_WITHOUT_CT"],
                U1_SP_ENG_WITH_CT = (decimal)reader["U1_SP_ENG_WITH_CT"],
                U1_SP_ENG_WITHOUT_CT = (decimal)reader["U1_SP_ENG_WITHOUT_CT"],
                U1_ENG_REMARKS = reader["U1_ENG_REMARKS"].ToString(),
                TXT_AMM_SUPPLY = (decimal)reader["TXT_AMM_SUPPLY"],
                TXT_LS_CONSP_UREA = (decimal)reader["TXT_LS_CONSP_UREA"],
                DATE_MOD = reader["U1_DATE_MOD"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                //PRV
                PRV_U1_TRANS_DATE = reader["PRV_U1_TRANS_DATE"].ToString(),
                PRV_U1_TOT_UREA_PROD = (decimal)reader["PRV_U1_TOT_UREA_PROD"],
                PRV_U1_EFF_FACTOR = (decimal)reader["PRV_U1_EFF_FACTOR"],
                PRV_U1_UREA_CAP_UTIL = (decimal)reader["PRV_U1_UREA_CAP_UTIL"],
                PRV_U1_U11_CO2_CONSP_INT = (decimal)reader["PRV_U1_U11_CO2_CONSP_INT"],
                PRV_U1_U11_CO2_CONSP = (decimal)reader["PRV_U1_U11_CO2_CONSP"],
                PRV_U1_U11_STREAM_HRS = (decimal)reader["PRV_U1_U11_STREAM_HRS"],
                PRV_U1_U11_P1_RPM = (decimal)reader["PRV_U1_U11_P1_RPM"],
                PRV_U1_U11_AMM_CONSP = (decimal)reader["PRV_U1_U11_AMM_CONSP"],
                PRV_U1_U11_UREA_PROD = (decimal)reader["PRV_U1_U11_UREA_PROD"],
                PRV_U1_U11_CAP_UTIL = (decimal)reader["PRV_U1_U11_CAP_UTIL"],
                PRV_U1_VAM_RUN_HRS = (decimal)reader["PRV_U1_VAM_RUN_HRS"],
                PRV_U1_VAM_POWER = (decimal)reader["PRV_U1_VAM_POWER"],
                PRV_U1_U21_CO2_CONSP_INT = (decimal)reader["PRV_U1_U21_CO2_CONSP_INT"],
                PRV_U1_U21_CO2_CONSP = (decimal)reader["PRV_U1_U21_CO2_CONSP"],
                PRV_U1_U21_STREAM_HRS = (decimal)reader["PRV_U1_U21_STREAM_HRS"],
                PRV_U1_U21_P1_RPM = (decimal)reader["PRV_U1_U21_P1_RPM"],
                PRV_U1_U21_AMM_CONSP = (decimal)reader["PRV_U1_U21_AMM_CONSP"],
                PRV_U1_U21_UREA_PROD = (decimal)reader["PRV_U1_U21_UREA_PROD"],
                PRV_U1_U21_CAP_UTIL = (decimal)reader["PRV_U1_U21_CAP_UTIL"],
                PRV_U1_UTC_PROD_U11_INT = (decimal)reader["PRV_U1_UTC_PROD_U11_INT"],
                PRV_U1_UTC_PROD_U11 = (decimal)reader["PRV_U1_UTC_PROD_U11"],
                PRV_U1_PW_CONSP_U11_INT = (decimal)reader["PRV_U1_PW_CONSP_U11_INT"],
                PRV_U1_PW_CONSP_U11 = (decimal)reader["PRV_U1_PW_CONSP_U11"],
                PRV_U1_UTC_PROD_U21_INT = (decimal)reader["PRV_U1_UTC_PROD_U21_INT"],
                PRV_U1_UTC_PROD_U21 = (decimal)reader["PRV_U1_UTC_PROD_U21"],
                PRV_U1_PW_CONSP_U21_INT = (decimal)reader["PRV_U1_PW_CONSP_U21_INT"],
                PRV_U1_PW_CONSP_U21 = (decimal)reader["PRV_U1_PW_CONSP_U21"],
                PRV_U1_USC_PROD_INT = (decimal)reader["PRV_U1_USC_PROD_INT"],
                PRV_U1_USC_PROD = (decimal)reader["PRV_U1_USC_PROD"],
                PRV_U1_UPC_PROD_INT = (decimal)reader["PRV_U1_UPC_PROD_INT"],
                PRV_U1_UPC_PROD = (decimal)reader["PRV_U1_UPC_PROD"],
                PRV_U1_PW_CONSP_UREA = (decimal)reader["PRV_U1_PW_CONSP_UREA"],
                PRV_U1_UTC_PROD = (decimal)reader["PRV_U1_UTC_PROD"],
                PRV_U1_EFF_WATER_EXP = (decimal)reader["PRV_U1_EFF_WATER_EXP"],
                PRV_U1_KS_CONSP_U11_INT = (decimal)reader["PRV_U1_KS_CONSP_U11_INT"],
                PRV_U1_KS_CONSP_U11 = (decimal)reader["PRV_U1_KS_CONSP_U11"],
                PRV_U1_KS_CONSP_U21_INT = (decimal)reader["PRV_U1_KS_CONSP_U21_INT"],
                PRV_U1_KS_CONSP_U21 = (decimal)reader["PRV_U1_KS_CONSP_U21"],
                PRV_U1_KS_CONSP_DISOLVE = (decimal)reader["PRV_U1_KS_CONSP_DISOLVE"],
                PRV_U1_HS_CONSP_UREA_INT = (decimal)reader["PRV_U1_HS_CONSP_UREA_INT"],
                PRV_U1_HS_CONSP_UREA = (decimal)reader["PRV_U1_HS_CONSP_UREA"],
                PRV_U1_LS_CONSP_STRIPPER = (decimal)reader["PRV_U1_LS_CONSP_STRIPPER"],
                PRV_U1_KS_CONSP_UREA = (decimal)reader["PRV_U1_KS_CONSP_UREA"],
                PRV_U1_SP_CONSP_KS = (decimal)reader["PRV_U1_SP_CONSP_KS"],
                PRV_U1_SP_CONSP_HS = (decimal)reader["PRV_U1_SP_CONSP_HS"],
                PRV_U1_SP_CONSP_LS = (decimal)reader["PRV_U1_SP_CONSP_LS"],
                PRV_U1_SP_CONSP_BFW = (decimal)reader["PRV_U1_SP_CONSP_BFW"],
                PRV_U1_SP_CONSP_TC = (decimal)reader["PRV_U1_SP_CONSP_TC"],
                PRV_U1_SP_CONSP_SC = (decimal)reader["PRV_U1_SP_CONSP_SC"],
                PRV_U1_SP_CONSP_PC = (decimal)reader["PRV_U1_SP_CONSP_PC"],
                PRV_E_U11_CONSP = (decimal)reader["PRV_E_U11_CONSP"],
                PRV_E_U21_CONSP = (decimal)reader["PRV_E_U21_CONSP"],
                PRV_E_UCT_CONSP = (decimal)reader["PRV_E_UCT_CONSP"],
                PRV_U1_KS_EQ_ENG = (decimal)reader["PRV_U1_KS_EQ_ENG"],
                PRV_U1_HS_EQ_ENG = (decimal)reader["PRV_U1_HS_EQ_ENG"],
                PRV_U1_LS_EQ_ENG = (decimal)reader["PRV_U1_LS_EQ_ENG"],
                PRV_U1_BFW_EQ_ENG = (decimal)reader["PRV_U1_BFW_EQ_ENG"],
                PRV_U1_U11_ELECTC_EQ_ENG = (decimal)reader["PRV_U1_U11_ELECTC_EQ_ENG"],
                PRV_U1_U21_ELECTC_EQ_ENG = (decimal)reader["PRV_U1_U21_ELECTC_EQ_ENG"],
                PRV_U1_UCT_ELECTC_EQ_ENG = (decimal)reader["PRV_U1_UCT_ELECTC_EQ_ENG"],
                PRV_U1_TOTAL_ENG_IN = (decimal)reader["PRV_U1_TOTAL_ENG_IN"],
                PRV_U1_USC_EQ_ENG = (decimal)reader["PRV_U1_USC_EQ_ENG"],
                PRV_U1_UTC_EQ_ENG = (decimal)reader["PRV_U1_UTC_EQ_ENG"],
                PRV_U1_TOTAL_ENG_OUT = (decimal)reader["PRV_U1_TOTAL_ENG_OUT"],
                PRV_U1_NET_ENG_WITH_CT = (decimal)reader["PRV_U1_NET_ENG_WITH_CT"],
                PRV_U1_NET_ENG_WITHOUT_CT = (decimal)reader["PRV_U1_NET_ENG_WITHOUT_CT"],
                PRV_U1_SP_ENG_WITH_CT = (decimal)reader["PRV_U1_SP_ENG_WITH_CT"],
                PRV_U1_SP_ENG_WITHOUT_CT = (decimal)reader["PRV_U1_SP_ENG_WITHOUT_CT"]
            };
        }

        private PUS002DVDto MapToValueDV1(SqlDataReader reader)
        {
            return new PUS002DVDto()
            {
                PROD_TO_DATE = reader["PROD_TO_DATE"].ToString(),
                HIGHEST_MONTHLY_PROD_DATE = (dynamic)reader["HIGHEST_MONTHLY_PROD_DATE"],
                HIGHEST_MONTHLY_PROD = (decimal)reader["HIGHEST_MONTHLY_PROD"],
                HIGHEST_UREA_PROD = (decimal)reader["HIGHEST_UREA_PROD"],
                HIGHEST_UREA_PROD_DATE = reader["HIGHEST_UREA_PROD_DATE"].ToString(),
                HIGHEST_U11_PROD_DATE = reader["HIGHEST_U11_PROD_DATE"].ToString(),
                HIGHEST_U11_PROD = (decimal)reader["HIGHEST_U11_PROD"],
                HIGHEST_U21_PROD_DATE = reader["HIGHEST_U21_PROD_DATE"].ToString(),
                HIGHEST_U21_PROD = (decimal)reader["HIGHEST_U21_PROD"],
                PARM_EFF = reader["PARM_EFF"].ToString(),
                PARM_UREA_CAPACITY = reader["PARM_UREA_CAPACITY"].ToString(),
                PARM_CONST_LS_CONSP = reader["PARM_CONST_LS_CONSP"].ToString(),
                PARM_CF_KS_ENG = reader["PARM_CF_KS_ENG"].ToString(),
                PARM_CF_HS_ENG = reader["PARM_CF_HS_ENG"].ToString(),
                PARM_CF_LS_ENG = reader["PARM_CF_LS_ENG"].ToString(),
                PARM_CF_BFW_ENG = reader["PARM_CF_BFW_ENG"].ToString(),
                PARM_CF_POWER_ENG = reader["PARM_CF_POWER_ENG"].ToString(),
                PARM_CF_SC_ENG = reader["PARM_CF_SC_ENG"].ToString(),
                PARM_CF_TC_ENG = reader["PARM_CF_TC_ENG"].ToString(),
                PARM_PROJECT_START_DATE = reader["PARM_PROJECT_START_DATE"].ToString(),
                HIGHEST_YEARLY_PROD_DATE = reader["HIGHEST_YEARLY_PROD_DATE"].ToString(),
                HIGHEST_YEARLY_PROD = (decimal)reader["HIGHEST_YEARLY_PROD"],
                PRAM_DT = reader["PRAM_DT"].ToString(),
                PARM_VAM_MCH_PWR_CONSP = reader["PARM_VAM_MCH_PWR_CONSP"].ToString(),
            };
        }

        public async Task<PUS002Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPT_UR_UREA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PUS002Model response = null;
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

        public async Task<PUS002DVDto> putDataDV1(string IN_DATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPT_UR_UREA_DETAILS_DV", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    // cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PUS002DVDto response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValueDV1(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PUS002Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPT_UR_UREA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TRANS_DATE", value.U1_TRANS_DATE));
                    // cmd.Parameters.Add(new SqlParameter("@IN_U1_UNIT_ID", value.UNIT_ID));
                    // cmd.Parameters.Add(new SqlParameter("@IN_U1_DMY_FLG", value.U1_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_USER_ID", value.U1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_UREA_PROD", value.U1_U11_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_UREA_PROD", value.U1_U21_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_STREAM_HRS", value.U1_U11_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_STREAM_HRS", value.U1_U21_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_CO2_CONSP_INT", value.U1_U11_CO2_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_CO2_CONSP", value.U1_U11_CO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_CO2_CONSP_INT", value.U1_U21_CO2_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_CO2_CONSP", value.U1_U21_CO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_AMM_CONSP", value.U1_U11_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_AMM_CONSP", value.U1_U21_AMM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_CAP_UTIL", value.U1_U11_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_CAP_UTIL", value.U1_U21_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UREA_CAP_UTIL", value.U1_UREA_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_EQ_ENG", value.U1_KS_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_HS_EQ_ENG", value.U1_HS_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_LS_EQ_ENG", value.U1_LS_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_BFW_EQ_ENG", value.U1_BFW_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_ELECTC_EQ_ENG", value.U1_U11_ELECTC_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_ELECTC_EQ_ENG", value.U1_U21_ELECTC_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UCT_ELECTC_EQ_ENG", value.U1_UCT_ELECTC_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_USC_EQ_ENG", value.U1_USC_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UTC_EQ_ENG", value.U1_UTC_EQ_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_KS", value.U1_SP_CONSP_KS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_HS", value.U1_SP_CONSP_HS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_LS", value.U1_SP_CONSP_LS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_BFW", value.U1_SP_CONSP_BFW));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_TC", value.U1_SP_CONSP_TC));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_SC", value.U1_SP_CONSP_SC));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_CONSP_PC", value.U1_SP_CONSP_PC));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U11_P1_RPM", value.U1_U11_P1_RPM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_U21_P1_RPM", value.U1_U21_P1_RPM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TOTAL_ENG_IN", value.U1_TOTAL_ENG_IN));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TOTAL_ENG_OUT", value.U1_TOTAL_ENG_OUT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_NET_ENG_WITH_CT", value.U1_NET_ENG_WITH_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_NET_ENG_WITHOUT_CT", value.U1_NET_ENG_WITHOUT_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_ENG_WITH_CT", value.U1_SP_ENG_WITH_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_SP_ENG_WITHOUT_CT", value.U1_SP_ENG_WITHOUT_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TOT_UREA_PROD", value.U1_TOT_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UTC_PROD_U11_INT", value.U1_UTC_PROD_U11_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UTC_PROD_U11", value.U1_UTC_PROD_U11));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UTC_PROD_U21_INT", value.U1_UTC_PROD_U21_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UTC_PROD_U21", value.U1_UTC_PROD_U21));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UTC_PROD", value.U1_UTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_USC_PROD_INT", value.U1_USC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_USC_PROD", value.U1_USC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UPC_PROD_INT", value.U1_UPC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UPC_PROD", value.U1_UPC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_PW_CONSP_U11_INT", value.U1_PW_CONSP_U11_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_PW_CONSP_U11", value.U1_PW_CONSP_U11));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_PW_CONSP_U21_INT", value.U1_PW_CONSP_U21_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_PW_CONSP_U21", value.U1_PW_CONSP_U21));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_PW_CONSP_UREA", value.U1_PW_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_CONSP_U11_INT", value.U1_KS_CONSP_U11_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_CONSP_U11", value.U1_KS_CONSP_U11));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_CONSP_U21_INT", value.U1_KS_CONSP_U21_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_CONSP_U21", value.U1_KS_CONSP_U21));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_CONSP_UREA", value.U1_KS_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_HS_CONSP_UREA_INT", value.U1_HS_CONSP_UREA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_HS_CONSP_UREA", value.U1_HS_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_LS_CONSP_UREA", value.U1_LS_CONSP_UREA));
                    //cmd.Parameters.Add(new SqlParameter("@IN_U1_FREEZE_FLG", value.U1_FREEZE_FLG));
                    //cmd.Parameters.Add(new SqlParameter("@IN_U1_FREEZE_TIME", value.U1_FREEZE_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_REMARKS_D", value.U1_REMARKS_D));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_REMARKS_M", value.U1_REMARKS_M));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_EFF_FACTOR", value.U1_EFF_FACTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_NO_UREA_SU_SD", value.U1_NO_UREA_SU_SD));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_ENG_REMARKS", value.U1_ENG_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_KS_CONSP_DISOLVE", value.U1_KS_CONSP_DISOLVE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_LS_CONSP_STRIPPER", value.U1_LS_CONSP_STRIPPER));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_LS_CONSP_INT", value.U1_LS_CONSP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_VAM_RUN_HRS", value.U1_VAM_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_VAM_POWER", value.U1_VAM_POWER));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_EFF_WATER_EXP", value.U1_EFF_WATER_EXP));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TOT_UREA_PROD_SHIFT_A", value.U1_TOT_UREA_PROD_SHIFT_A));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TOT_UREA_PROD_SHIFT_B", value.U1_TOT_UREA_PROD_SHIFT_B));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TOT_UREA_PROD_SHIFT_C", value.U1_TOT_UREA_PROD_SHIFT_C));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
