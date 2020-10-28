using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS009Repository
    {
        private readonly string _connectionString;
        public POS009Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private Func_HS_CF_CALC_Model MapToValue2(SqlDataReader reader)
        {
            return new Func_HS_CF_CALC_Model()
            {
                IN_CF = (decimal)reader["IN_CF"],
            };
        }

        public async Task<Func_HS_CF_CALC_Model> putData(Func_HS_CF_CALC_Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PPIS.ppu_f_func_hs_cf_calc('" + value.IN_DATE + "', '" + value.ln_hs_press + "' , '" + value.ln_hs_temp + "', '" + value.lvch_eqp_cd + "') AS IN_CF", sql))
                {
                    Func_HS_CF_CALC_Model response = null;
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

        private POS009Model MapToValue(SqlDataReader reader)
        {
            return new POS009Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_AB1_KS_PROD_INT = (decimal)reader["OU1_AB1_KS_PROD_INT"],
                OU1_AB1_KS_PROD = (decimal)reader["OU1_AB1_KS_PROD"],
                OU1_AB2_KS_PROD_INT = (decimal)reader["OU1_AB2_KS_PROD_INT"],
                OU1_AB2_KS_PROD = (decimal)reader["OU1_AB2_KS_PROD"],
                OU1_KS_REC_HRSG3 = (decimal)reader["OU1_KS_REC_HRSG3"],
                OU1_TOTAL_KS_PROD = (decimal)reader["OU1_TOTAL_KS_PROD"],
                OU1_KS_IMPORTF_UNIT2 = (decimal)reader["OU1_KS_IMPORTF_UNIT2"],
                OU1_TOTAL_KS_AVAILABLE = (decimal)reader["OU1_TOTAL_KS_AVAILABLE"],
                OU1_KS_EXP_INT = (decimal)reader["OU1_KS_EXP_INT"],
                OU1_KS_EXP = (decimal)reader["OU1_KS_EXP"],
                OU1_KS_HS_LETDOWN = (decimal)reader["OU1_KS_HS_LETDOWN"],
                OU1_KS_EXPORTT_UNIT2_INT = (decimal)reader["OU1_KS_EXPORTT_UNIT2_INT"],
                OU1_KS_EXPORTT_UNIT2 = (decimal)reader["OU1_KS_EXPORTT_UNIT2"],
                OU1_KS_CONSP_VENTING = (decimal)reader["OU1_KS_CONSP_VENTING"],
                OU1_KS_CONSP_REVAMP_UNIT1 = (decimal)reader["OU1_KS_CONSP_REVAMP_UNIT1"],
                OU1_KS_CONSP_AMM = (decimal)reader["OU1_KS_CONSP_AMM"],
                OU1_KS_TOT_CONSP = (decimal)reader["OU1_KS_TOT_CONSP"],
                OU1_IMPORT_KS_CONSP_UREA = (decimal)reader["OU1_IMPORT_KS_CONSP_UREA"],
                OU1_IMPORT_KS_CONSP_AMM = (decimal)reader["OU1_IMPORT_KS_CONSP_AMM"],
                OU1_REMARKS_D = reader["OU1_REMARKS_D"].ToString(),
                OU1_REMARKS_M = reader["OU1_REMARKS_M"].ToString(),
                OU1_HS_PRS_MPBFP = (decimal)reader["OU1_HS_PRS_MPBFP"],
                OU1_HS_TEMP_MPBFP = (decimal)reader["OU1_HS_TEMP_MPBFP"],
                TXT_KS_CONSP_DISS = (decimal)reader["TXT_KS_CONSP_DISS"],
                OU1_KS_CONSP_UREA = (decimal)reader["OU1_KS_CONSP_UREA"],
                OU1_HS_CF_MPBFP = (decimal)reader["OU1_HS_CF_MPBFP"],
                OU1_HS_PRS_FD1 = (decimal)reader["OU1_HS_PRS_FD1"],
                OU1_HS_TEMP_FD1 = (decimal)reader["OU1_HS_TEMP_FD1"],
                OU1_HS_CF_FD1 = (decimal)reader["OU1_HS_CF_FD1"],
                OU1_HS_PRS_FD2 = (decimal)reader["OU1_HS_PRS_FD2"],
                OU1_HS_TEMP_FD2 = (decimal)reader["OU1_HS_TEMP_FD2"],
                OU1_HS_CF_FD2 = (decimal)reader["OU1_HS_CF_FD2"],
                OU1_HS_PRS_HPBFP = (decimal)reader["OU1_HS_PRS_HPBFP"],
                OU1_HS_TEMP_HPBFP = (decimal)reader["OU1_HS_TEMP_HPBFP"],
                OU1_HS_CF_HPBFP = (decimal)reader["OU1_HS_CF_HPBFP"],
                OU1_HS_PRS_TP801A = (decimal)reader["OU1_HS_PRS_TP801A"],
                OU1_HS_TEMP_TP801A = (decimal)reader["OU1_HS_TEMP_TP801A"],
                OU1_HS_CF_TP801A = (decimal)reader["OU1_HS_CF_TP801A"],
                OU1_HS_PRS_TP801B = (decimal)reader["OU1_HS_PRS_TP801B"],
                OU1_HS_TEMP_TP801B = (decimal)reader["OU1_HS_TEMP_TP801B"],
                OU1_HS_CF_TP801B = (decimal)reader["OU1_HS_CF_TP801B"],
                OU1_HS_PRS_TP933A = (decimal)reader["OU1_HS_PRS_TP933A"],
                OU1_HS_TEMP_TP933A = (decimal)reader["OU1_HS_TEMP_TP933A"],
                OU1_HS_CF_TP933A = (decimal)reader["OU1_HS_CF_TP933A"],
                OU1_HS_PRS_TP933B = (decimal)reader["OU1_HS_PRS_TP933B"],
                OU1_HS_TEMP_TP933B = (decimal)reader["OU1_HS_TEMP_TP933B"],
                OU1_HS_CF_TP933B = (decimal)reader["OU1_HS_CF_TP933B"],
                OU1_HS_PRS_TP5933C = (decimal)reader["OU1_HS_PRS_TP5933C"],
                OU1_HS_TEMP_TP5933C = (decimal)reader["OU1_HS_TEMP_TP5933C"],
                OU1_HS_CF_TP5933C = (decimal)reader["OU1_HS_CF_TP5933C"],
                OU1_HS_PRS_TP808B = (decimal)reader["OU1_HS_PRS_TP808B"],
                OU1_HS_TEMP_TP808B = (decimal)reader["OU1_HS_TEMP_TP808B"],
                OU1_HS_CF_TP808B = (decimal)reader["OU1_HS_CF_TP808B"],
                OU1_HS_PRS_TP808C = (decimal)reader["OU1_HS_PRS_TP808C"],
                OU1_HS_TEMP_TP808C = (decimal)reader["OU1_HS_TEMP_TP808C"],
                OU1_HS_CF_TP808C = (decimal)reader["OU1_HS_CF_TP808C"],
                OU1_HS_VAM_AVG_FLOW = (decimal)reader["OU1_HS_VAM_AVG_FLOW"],
                OU1_HS_VAM_RUN_HRS = (decimal)reader["OU1_HS_VAM_RUN_HRS"],
                OU1_HS_HRSG1_PROD_INT = (decimal)reader["OU1_HS_HRSG1_PROD_INT"],
                OU1_HS_PROD_INCL_VAM_CONSP = (decimal)reader["OU1_HS_PROD_INCL_VAM_CONSP"],
                OU1_HS_HRSG2_PROD_INT = (decimal)reader["OU1_HS_HRSG2_PROD_INT"],
                OU1_HS_HRSG2_PROD = (decimal)reader["OU1_HS_HRSG2_PROD"],
                OU1_HS_CONSP_VAM = (decimal)reader["OU1_HS_CONSP_VAM"],
                OU1_HS_HRSG1_PROD = (decimal)reader["OU1_HS_HRSG1_PROD"],
                TXT_KS_HS_PRDS = (decimal)reader["TXT_KS_HS_PRDS"],
                OU1_TOTAL_HS_PROD = (decimal)reader["OU1_TOTAL_HS_PROD"],
                OU1_HS_EXP_INT = (decimal)reader["OU1_HS_EXP_INT"],
                OU1_HS_EXP_SPG = (decimal)reader["OU1_HS_EXP_SPG"],
                OU1_HS_CONSP_MPBFW_INT = (decimal)reader["OU1_HS_CONSP_MPBFW_INT"],
                OU1_HS_CONSP_MPBFW_INT_DIFF = (decimal)reader["OU1_HS_CONSP_MPBFW_INT_DIFF"],
                OU1_HS_CONSP_MPBFW = (decimal)reader["OU1_HS_CONSP_MPBFW"],
                OU1_HS_CONSP_FD1_INT = (decimal)reader["OU1_HS_CONSP_FD1_INT"],
                OU1_HS_CONSP_FD1_INT_DIFF = (decimal)reader["OU1_HS_CONSP_FD1_INT_DIFF"],
                OU1_HS_CONSP_FD1 = (decimal)reader["OU1_HS_CONSP_FD1"],
                OU1_HS_CONSP_FD2_INT = (decimal)reader["OU1_HS_CONSP_FD2_INT"],
                OU1_HS_CONSP_FD2_INT_DIFF = (decimal)reader["OU1_HS_CONSP_FD2_INT_DIFF"],
                OU1_HS_CONSP_FD2 = (decimal)reader["OU1_HS_CONSP_FD2"],
                OU1_HS_LS_LETDOWN = (decimal)reader["OU1_HS_LS_LETDOWN"],
                OU1_HS_CONSP_NPT = (decimal)reader["OU1_HS_CONSP_NPT"],
                OU1_HS_CONSP_ATOMIZING = (decimal)reader["OU1_HS_CONSP_ATOMIZING"],
                OU1_HS_CONSP_MFT = (decimal)reader["OU1_HS_CONSP_MFT"],
                OU1_HS_CONSP_HPBFW_INT = (decimal)reader["OU1_HS_CONSP_HPBFW_INT"],
                OU1_HS_CONSP_HPBFW_INT_DIFF = (decimal)reader["OU1_HS_CONSP_HPBFW_INT_DIFF"],
                OU1_HS_CONSP_HPBFW = (decimal)reader["OU1_HS_CONSP_HPBFW"],
                OU1_HS_AVG_FLW_TP801A = (decimal)reader["OU1_HS_AVG_FLW_TP801A"],
                OU1_HS_CONSP_TP801A = (decimal)reader["OU1_HS_CONSP_TP801A"],
                OU1_HS_AVG_FLW_TP801B = (decimal)reader["OU1_HS_AVG_FLW_TP801B"],
                OU1_HS_CONSP_TP801B = (decimal)reader["OU1_HS_CONSP_TP801B"],
                OU1_HS_AVG_FLW_TP933A = (decimal)reader["OU1_HS_AVG_FLW_TP933A"],
                OU1_HS_CONSP_TP933A = (decimal)reader["OU1_HS_CONSP_TP933A"],
                OU1_HS_AVG_FLW_TP933B = (decimal)reader["OU1_HS_AVG_FLW_TP933B"],
                OU1_HS_CONSP_TP933B = (decimal)reader["OU1_HS_CONSP_TP933B"],
                OU1_HS_TP5933C_INT = (decimal)reader["OU1_HS_TP5933C_INT"],
                OU1_HS_TP5933C_INT_DIFF = (decimal)reader["OU1_HS_TP5933C_INT_DIFF"],
                OU1_HS_CONSP_PWT_GP2 = (decimal)reader["OU1_HS_CONSP_PWT_GP2"],
                OU1_HS_TP808B_INT = (decimal)reader["OU1_HS_TP808B_INT"],
                OU1_HS_TP808B_INT_DIFF = (decimal)reader["OU1_HS_TP808B_INT_DIFF"],
                OU1_HS_CONSP_TP808B = (decimal)reader["OU1_HS_CONSP_TP808B"],
                OU1_HS_TP808C_INT = (decimal)reader["OU1_HS_TP808C_INT"],
                OU1_HS_TP808C_INT_DIFF = (decimal)reader["OU1_HS_TP808C_INT_DIFF"],
                OU1_HS_CONSP_TP808C = (decimal)reader["OU1_HS_CONSP_TP808C"],
                OU1_HS_INTERNAL_CONSP = (decimal)reader["OU1_HS_INTERNAL_CONSP"],
                OU1_HS_CONSP_VENTING = (decimal)reader["OU1_HS_CONSP_VENTING"],
                OU1_HS_CONSP_REVAMP_UNIT1 = (decimal)reader["OU1_HS_CONSP_REVAMP_UNIT1"],
                OU1_HS_CONSP_UREA = (decimal)reader["OU1_HS_CONSP_UREA"],
                OU1_HS_CONSP_AMM = (decimal)reader["OU1_HS_CONSP_AMM"],
                OU1_HS_TOT_CONSP = (decimal)reader["OU1_HS_TOT_CONSP"],
                OU1_LS_INT_PROD_BF_BL = (decimal)reader["OU1_LS_INT_PROD_BF_BL"],
                OU1_LS_EXP_INT = (decimal)reader["OU1_LS_EXP_INT"],
                OU1_LS_EXP_INT_DIFF = (decimal)reader["OU1_LS_EXP_INT_DIFF"],
                OU1_LS_CONSP_DEARATOR = (decimal)reader["OU1_LS_CONSP_DEARATOR"],
                OU1_LS_INT_PROD_AF_BL = (decimal)reader["OU1_LS_INT_PROD_AF_BL"],
                OU1_TOTAL_LS_PROD = (decimal)reader["OU1_TOTAL_LS_PROD"],
                OU1_LS_EXPORTT_UNIT2_INT = (decimal)reader["OU1_LS_EXPORTT_UNIT2_INT"],
                OU1_LS_EXPORTT_UNIT2 = (decimal)reader["OU1_LS_EXPORTT_UNIT2"],
                OU1_LS_CONSP_VENTING = (decimal)reader["OU1_LS_CONSP_VENTING"],
                OU1_LS_EXPORT_GP3 = (decimal)reader["OU1_LS_EXPORT_GP3"],
                TXT_LS_CONSP_AMM = (decimal)reader["TXT_LS_CONSP_AMM"],
                OU1_LS_CONSP_UREA = (decimal)reader["OU1_LS_CONSP_UREA"],
                OU1_LS_TOT_CONSP = (decimal)reader["OU1_LS_TOT_CONSP"],
                OU1_LS_IMPORTF_UNIT2_INT = (decimal)reader["OU1_LS_IMPORTF_UNIT2_INT"],
                OU1_KS_GP3_EXPORTT_UNIT2 = (decimal)reader["OU1_KS_GP3_EXPORTT_UNIT2"],

                // --------------------PRV-----------------------------
                PRV_OU_TRANS_DATE = reader["PRV_OU_TRANS_DATE"].ToString(),
                PRV_OU_AB1_KS_PROD_INT = (decimal)reader["PRV_OU_AB1_KS_PROD_INT"],
                PRV_OU_AB2_KS_PROD_INT = (decimal)reader["PRV_OU_AB2_KS_PROD_INT"],
                PRV_OU_KS_EXP_INT = (decimal)reader["PRV_OU_KS_EXP_INT"],
                PRV_OU_KS_EXPORTT_UNIT2_INT = (decimal)reader["PRV_OU_KS_EXPORTT_UNIT2_INT"],
                PRV_OU_KS_CONSP_VENTING = (decimal)reader["PRV_OU_KS_CONSP_VENTING"],
                PRV_OU_KS_CONSP_REVAMP_UNIT1 = (decimal)reader["PRV_OU_KS_CONSP_REVAMP_UNIT1"],
                PRV_OU_IMPORT_KS_CONSP_UREA = (decimal)reader["PRV_OU_IMPORT_KS_CONSP_UREA"],
                PRV_OU_REMARKS = reader["PRV_OU_REMARKS"].ToString(),
                PRV_OU_HS_PRS_MPBFP = (decimal)reader["PRV_OU_HS_PRS_MPBFP"],
                PRV_OU_HS_TEMP_MPBFP = (decimal)reader["PRV_OU_HS_TEMP_MPBFP"],
                PRV_OU_HS_PRS_FD1 = (decimal)reader["PRV_OU_HS_PRS_FD1"],
                PRV_OU_HS_TEMP_FD1 = (decimal)reader["PRV_OU_HS_TEMP_FD1"],
                PRV_OU_HS_PRS_FD2 = (decimal)reader["PRV_OU_HS_PRS_FD2"],
                PRV_OU_HS_TEMP_FD2 = (decimal)reader["PRV_OU_HS_TEMP_FD2"],
                PRV_OU_HS_PRS_HPBFP = (decimal)reader["PRV_OU_HS_PRS_HPBFP"],
                PRV_OU_HS_TEMP_HPBFP = (decimal)reader["PRV_OU_HS_TEMP_HPBFP"],
                PRV_OU_HS_PRS_TP801A = (decimal)reader["PRV_OU_HS_PRS_TP801A"],
                PRV_OU_HS_TEMP_TP801A = (decimal)reader["PRV_OU_HS_TEMP_TP801A"],
                PRV_OU_HS_PRS_TP801B = (decimal)reader["PRV_OU_HS_PRS_TP801B"],
                PRV_OU_HS_TEMP_TP801B = (decimal)reader["PRV_OU_HS_TEMP_TP801B"],
                PRV_OU_HS_PRS_TP933A = (decimal)reader["PRV_OU_HS_PRS_TP933A"],
                PRV_OU_HS_TEMP_TP933A = (decimal)reader["PRV_OU_HS_TEMP_TP933A"],
                PRV_OU_HS_PRS_TP933B = (decimal)reader["PRV_OU_HS_PRS_TP933B"],
                PRV_OU_HS_TEMP_TP933B = (decimal)reader["PRV_OU_HS_TEMP_TP933B"],
                PRV_OU_HS_PRS_TP5933C = (decimal)reader["PRV_OU_HS_PRS_TP5933C"],
                PRV_OU_HS_TEMP_TP5933C = (decimal)reader["PRV_OU_HS_TEMP_TP5933C"],
                PRV_OU_HS_PRS_TP808B = (decimal)reader["PRV_OU_HS_PRS_TP808B"],
                PRV_OU_HS_TEMP_TP808B = (decimal)reader["PRV_OU_HS_TEMP_TP808B"],
                PRV_OU_HS_CF_TP808B = (decimal)reader["PRV_OU_HS_CF_TP808B"],
                PRV_OU_HS_PRS_TP808C = (decimal)reader["PRV_OU_HS_PRS_TP808C"],
                PRV_OU_HS_TEMP_TP808C = (decimal)reader["PRV_OU_HS_TEMP_TP808C"],
                PRV_OU_HS_VAM_AVG_FLOW = (decimal)reader["PRV_OU_HS_VAM_AVG_FLOW"],
                PRV_OU_HS_VAM_RUN_HRS = (decimal)reader["PRV_OU_HS_VAM_RUN_HRS"],
                PRV_OU_HS_HRSG1_PROD_INT = (decimal)reader["PRV_OU_HS_HRSG1_PROD_INT"],
                PRV_OU_HS_HRSG2_PROD_INT = (decimal)reader["PRV_OU_HS_HRSG2_PROD_INT"],
                PRV_OU_HS_EXP_INT = (decimal)reader["PRV_OU_HS_EXP_INT"],
                PRV_OU_HS_CONSP_MPBFW_INT = (decimal)reader["PRV_OU_HS_CONSP_MPBFW_INT"],
                PRV_OU_HS_CONSP_FD1_INT = (decimal)reader["PRV_OU_HS_CONSP_FD1_INT"],
                PRV_OU_HS_CONSP_FD2_INT = (decimal)reader["PRV_OU_HS_CONSP_FD2_INT"],
                PRV_OU_HS_LS_LETDOWN = (decimal)reader["PRV_OU_HS_LS_LETDOWN"],
                PRV_OU_HS_CONSP_HPBFW_INT = (decimal)reader["PRV_OU_HS_CONSP_HPBFW_INT"],
                PRV_OU_HS_AVG_FLW_TP801A = (decimal)reader["PRV_OU_HS_AVG_FLW_TP801A"],
                PRV_OU_HS_AVG_FLW_TP801B = (decimal)reader["PRV_OU_HS_AVG_FLW_TP801B"],
                PRV_OU_HS_AVG_FLW_TP933A = (decimal)reader["PRV_OU_HS_AVG_FLW_TP933A"],
                PRV_OU_HS_AVG_FLW_TP933B = (decimal)reader["PRV_OU_HS_AVG_FLW_TP933B"],
                PRV_OU_HS_TP5933C_INT = (decimal)reader["PRV_OU_HS_TP5933C_INT"],
                PRV_OU_HS_TP808B_INT = (decimal)reader["PRV_OU_HS_TP808B_INT"],
                PRV_OU_HS_TP808C_INT = (decimal)reader["PRV_OU_HS_TP808C_INT"],
                PRV_OU_HS_CONSP_VENTING = (decimal)reader["PRV_OU_HS_CONSP_VENTING"],
                PRV_OU_HS_CONSP_REVAMP_UNIT1 = (decimal)reader["PRV_OU_HS_CONSP_REVAMP_UNIT1"],
                PRV_OU_LS_EXP_INT = (decimal)reader["PRV_OU_LS_EXP_INT"],
                PRV_OU_LS_EXPORTT_UNIT2_INT = (decimal)reader["PRV_OU_LS_EXPORTT_UNIT2_INT"],
                PRV_OU_LS_CONSP_VENTING = (decimal)reader["PRV_OU_LS_CONSP_VENTING"],
                PRV_OU_LS_IMPORTF_UNIT2_INT = (decimal)reader["PRV_OU_LS_IMPORTF_UNIT2_INT"],

                // --------------------DV-----------------------------
                OU3_KS_STEAM_SUPPLY_GP1_2 = (decimal)reader["OU3_KS_STEAM_SUPPLY_GP1_2"],
                parm_aval_prs_hpbfw = (decimal)reader["parm_aval_prs_hpbfw"],
                parm_dsgnd_prs_hpbfw = (decimal)reader["parm_dsgnd_prs_hpbfw"],
                parm_aval_prs_mpbfw = (decimal)reader["parm_aval_prs_mpbfw"],
                parm_dsgnd_prs_mpbfw = (decimal)reader["parm_dsgnd_prs_mpbfw"],
                parm_aval_prs_fd = (decimal)reader["parm_aval_prs_fd"],
                parm_dsgnd_prs_fd = (decimal)reader["parm_dsgnd_prs_fd"],
                parm_hs_consp_ctt_ph = (decimal)reader["parm_hs_consp_ctt_ph"],
                parm_hs_consp_uct_ph = (decimal)reader["parm_hs_consp_uct_ph"],
                parm_hs_consp_pwt_gp2_ph = (decimal)reader["parm_hs_consp_pwt_gp2_ph"],
                parm_hs_consp_pwt_ph = (decimal)reader["parm_hs_consp_pwt_ph"],
                parm_hs_consp_npt_ph = (decimal)reader["parm_hs_consp_npt_ph"],
                parm_bfw_enthalpy = (decimal)reader["parm_bfw_enthalpy"],
                parm_bfw_temp = (decimal)reader["parm_bfw_temp"],
                parm_ls_stm_enthalpy = (decimal)reader["parm_ls_stm_enthalpy"],
                parm_cf_atomzing_stm = (decimal)reader["parm_cf_atomzing_stm"],
                parm_hs_consp_mft_ph = (decimal)reader["parm_hs_consp_mft_ph"],
                parm_npt_pump_run_hrs = (decimal)reader["parm_npt_pump_run_hrs"],
                parm_ou1_ab_nap = (decimal)reader["parm_ou1_ab_nap"],
                parm_mft_pump_run_hrs = (decimal)reader["parm_mft_pump_run_hrs"],
                parm_tp801a_pump_run_hrs = (decimal)reader["parm_tp801a_pump_run_hrs"],
                parm_tp801b_pump_run_hrs = (decimal)reader["parm_tp801b_pump_run_hrs"],
                parm_tp933a_pump_run_hrs = (decimal)reader["parm_tp933a_pump_run_hrs"],
                parm_tp933b_pump_run_hrs = (decimal)reader["parm_tp933b_pump_run_hrs"],
            };
        }

        public async Task<POS009Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_STEAM_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS009Model response = null;
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

        public async Task saveData(POS009SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_STEAM_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB1_KS_PROD_INT", value.OU1_AB1_KS_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB1_KS_PROD", value.OU1_AB1_KS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB2_KS_PROD_INT", value.OU1_AB2_KS_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB2_KS_PROD", value.OU1_AB2_KS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AB_KS_PROD", value.OU1_AB_KS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_IMPORTF_UNIT2_INT", value.OU1_KS_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_IMPORTF_UNIT2", value.OU1_KS_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_KS_PROD", value.OU1_TOTAL_KS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_HS_LETDOWN", value.OU1_KS_HS_LETDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_EXPORTT_PROCESS", value.OU1_KS_EXPORTT_PROCESS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_CONSP_AMM", value.OU1_KS_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_EXPORTT_UNIT2_INT", value.OU1_KS_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_EXPORTT_UNIT2", value.OU1_KS_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_TOT_CONSP", value.OU1_KS_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_HRSG1_PROD_INT", value.OU1_HS_HRSG1_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_HRSG1_PROD", value.OU1_HS_HRSG1_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_HRSG2_PROD_INT", value.OU1_HS_HRSG2_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_HRSG2_PROD", value.OU1_HS_HRSG2_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HRSG_HS_PROD", value.OU1_HRSG_HS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_IMPORTF_UNIT2_INT", value.OU1_HS_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_IMPORTF_UNIT2", value.OU1_HS_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_HS_PROD", value.OU1_TOTAL_HS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_HPBFW_INT", value.OU1_HS_CONSP_HPBFW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_HPBFW_INT_DIFF", value.OU1_HS_CONSP_HPBFW_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_HPBFW", value.OU1_HS_CONSP_HPBFW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_MPBFW_INT", value.OU1_HS_CONSP_MPBFW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_MPBFW_INT_DIFF", value.OU1_HS_CONSP_MPBFW_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_MPBFW", value.OU1_HS_CONSP_MPBFW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_FD1_INT", value.OU1_HS_CONSP_FD1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_FD1_INT_DIFF", value.OU1_HS_CONSP_FD1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_FD1", value.OU1_HS_CONSP_FD1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_FD2_INT", value.OU1_HS_CONSP_FD2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_FD2_INT_DIFF", value.OU1_HS_CONSP_FD2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_FD2", value.OU1_HS_CONSP_FD2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_CTT", value.OU1_HS_CONSP_CTT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_PWT", value.OU1_HS_CONSP_PWT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_NPT", value.OU1_HS_CONSP_NPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_ATOMIZING", value.OU1_HS_CONSP_ATOMIZING));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_LS_LETDOWN", value.OU1_HS_LS_LETDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_INTERNAL_CONSP", value.OU1_HS_INTERNAL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_EXPORTT_UNIT2_INT", value.OU1_HS_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_EXPORTT_UNIT2", value.OU1_HS_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_EXPORT_PROCESS", value.OU1_HS_EXPORT_PROCESS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_AMM", value.OU1_HS_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TOT_CONSP", value.OU1_HS_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_INTERNAL_PROD", value.OU1_LS_INTERNAL_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_IMPORTF_UNIT2_INT", value.OU1_LS_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_IMPORTF_UNIT2", value.OU1_LS_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_LS_PROD", value.OU1_TOTAL_LS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_CONSP_DEARATOR", value.OU1_LS_CONSP_DEARATOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_EXPORTT_UNIT2_INT", value.OU1_LS_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_EXPORTT_UNIT2", value.OU1_LS_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_EXPORTT_PROCESS", value.OU1_LS_EXPORTT_PROCESS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_CONSP_AMM", value.OU1_LS_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_TOT_CONSP", value.OU1_LS_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REMARKS_D", value.OU1_REMARKS_D));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REMARKS_M", value.OU1_REMARKS_M));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_UCT", value.OU1_HS_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_ACT", value.OU1_HS_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_PWT_GP2", value.OU1_HS_CONSP_PWT_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_CONSP_VENTING", value.OU1_KS_CONSP_VENTING));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_IMPORT_KS_CONSP_AMM", value.OU1_IMPORT_KS_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_IMPORT_KS_CONSP_UREA", value.OU1_IMPORT_KS_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_CONSP_STRIPPER", value.OU1_LS_CONSP_STRIPPER));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_INT_GEN_PWT_GP2", value.OU1_LS_INT_GEN_PWT_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_VENTING", value.OU1_HS_CONSP_VENTING));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_CONSP_VENTING", value.OU1_LS_CONSP_VENTING));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_EXP_INT", value.OU1_KS_EXP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_CONSP_UREA", value.OU1_LS_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_EXP", value.OU1_KS_EXP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_MPBFP", value.OU1_HS_PRS_MPBFP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_MPBFP", value.OU1_HS_TEMP_MPBFP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_MPBFP", value.OU1_HS_CF_MPBFP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_FD1", value.OU1_HS_PRS_FD1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_FD1", value.OU1_HS_TEMP_FD1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_FD1", value.OU1_HS_CF_FD1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_FD2", value.OU1_HS_PRS_FD2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_FD2", value.OU1_HS_TEMP_FD2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_FD2", value.OU1_HS_CF_FD2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_HPBFP", value.OU1_HS_PRS_HPBFP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_HPBFP", value.OU1_HS_TEMP_HPBFP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_HPBFP", value.OU1_HS_CF_HPBFP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP801A", value.OU1_HS_PRS_TP801A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP801A", value.OU1_HS_TEMP_TP801A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP801A", value.OU1_HS_CF_TP801A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP801B", value.OU1_HS_PRS_TP801B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP801B", value.OU1_HS_TEMP_TP801B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP801B", value.OU1_HS_CF_TP801B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP933A", value.OU1_HS_PRS_TP933A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP933A", value.OU1_HS_TEMP_TP933A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP933A", value.OU1_HS_CF_TP933A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP933B", value.OU1_HS_PRS_TP933B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP933B", value.OU1_HS_TEMP_TP933B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP933B", value.OU1_HS_CF_TP933B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP5933C", value.OU1_HS_PRS_TP5933C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP5933C", value.OU1_HS_TEMP_TP5933C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP5933C", value.OU1_HS_CF_TP5933C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP808B", value.OU1_HS_PRS_TP808B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP808B", value.OU1_HS_TEMP_TP808B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP808B", value.OU1_HS_CF_TP808B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PRS_TP808C", value.OU1_HS_PRS_TP808C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TEMP_TP808C", value.OU1_HS_TEMP_TP808C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CF_TP808C", value.OU1_HS_CF_TP808C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_EXP_INT", value.OU1_HS_EXP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_EXP_SPG", value.OU1_HS_EXP_SPG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_MFT", value.OU1_HS_CONSP_MFT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_AVG_FLW_TP801A", value.OU1_HS_AVG_FLW_TP801A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_TP801A", value.OU1_HS_CONSP_TP801A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_AVG_FLW_TP801B", value.OU1_HS_AVG_FLW_TP801B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_TP801B", value.OU1_HS_CONSP_TP801B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_AVG_FLW_TP933A", value.OU1_HS_AVG_FLW_TP933A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_TP933A", value.OU1_HS_CONSP_TP933A));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_AVG_FLW_TP933B", value.OU1_HS_AVG_FLW_TP933B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_TP933B", value.OU1_HS_CONSP_TP933B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TP5933C_INT", value.OU1_HS_TP5933C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TP5933C_INT_DIFF", value.OU1_HS_TP5933C_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TP808B_INT", value.OU1_HS_TP808B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TP808B_INT_DIFF", value.OU1_HS_TP808B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_TP808B", value.OU1_HS_CONSP_TP808B));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TP808C_INT", value.OU1_HS_TP808C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_TP808C_INT_DIFF", value.OU1_HS_TP808C_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_TP808C", value.OU1_HS_CONSP_TP808C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_EXP_INT", value.OU1_LS_EXP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_EXP_INT_DIFF", value.OU1_LS_EXP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_INT_PROD_BF_BL", value.OU1_LS_INT_PROD_BF_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_INT_PROD_AF_BL", value.OU1_LS_INT_PROD_AF_BL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_CONSP_REVAMP_UNIT1", value.OU1_KS_CONSP_REVAMP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_REVAMP_UNIT1", value.OU1_HS_CONSP_REVAMP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_CONSP_REVAMP_UNIT1", value.OU1_LS_CONSP_REVAMP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_VAM_AVG_FLOW", value.OU1_HS_VAM_AVG_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_VAM_RUN_HRS", value.OU1_HS_VAM_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_PROD_INCL_VAM_CONSP", value.OU1_HS_PROD_INCL_VAM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HS_CONSP_VAM", value.OU1_HS_CONSP_VAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_KS_AVAILABLE", value.OU1_TOTAL_KS_AVAILABLE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_REC_HRSG3", value.OU1_KS_REC_HRSG3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LS_EXPORT_GP3", value.OU1_LS_EXPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_KS_GP3_EXPORTT_UNIT2", value.OU1_KS_GP3_EXPORTT_UNIT2));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
