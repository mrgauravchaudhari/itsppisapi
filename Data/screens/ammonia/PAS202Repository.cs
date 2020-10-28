using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS202Repository
    {
        private readonly string _connectionString;
        public PAS202Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS202Model MapToValue(SqlDataReader reader)
        {
            return new PAS202Model()
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
                TXT_VAM_POWER = (dynamic)reader["TXT_VAM_POWER"],
                A2_CO2_SUPPLY_UREA2 = (dynamic)reader["A2_CO2_SUPPLY_UREA2"],
                A2_IA_PA_EXPORTT_GP1_INT = (dynamic)reader["A2_IA_PA_EXPORTT_GP1_INT"],
                A2_IA_PA_EXPORTT_GP1_INT_DIFF = (dynamic)reader["A2_IA_PA_EXPORTT_GP1_INT_DIFF"],
                A2_PRS_SURPLUS_GAS_INT = (dynamic)reader["A2_PRS_SURPLUS_GAS_INT"],
                A2_PRS_SURPLUS_GAS_INT_DIFF = (dynamic)reader["A2_PRS_SURPLUS_GAS_INT_DIFF"],
                A2_TEMP_SURPLUS_GAS_INT = (dynamic)reader["A2_TEMP_SURPLUS_GAS_INT"],
                A2_TEMP_SURPLUS_GAS_INT_DIFF = (dynamic)reader["A2_TEMP_SURPLUS_GAS_INT_DIFF"],
                A2_SURPLUS_GAS_INT = (dynamic)reader["A2_SURPLUS_GAS_INT"],
                A2_SURPLUS_GAS_INT_DIFF = (dynamic)reader["A2_SURPLUS_GAS_INT_DIFF"],
                A2_SURPLUS_GAS_PROD = (dynamic)reader["A2_SURPLUS_GAS_PROD"],
                A2_PRS_PERMEATE_INT = (dynamic)reader["A2_PRS_PERMEATE_INT"],
                A2_PRS_PERMEATE_INT_DIFF = (dynamic)reader["A2_PRS_PERMEATE_INT_DIFF"],
                A2_TEMP_PERMEATE_INT = (dynamic)reader["A2_TEMP_PERMEATE_INT"],
                A2_TEMP_PERMEATE_INT_DIFF = (dynamic)reader["A2_TEMP_PERMEATE_INT_DIFF"],
                A2_PERMEATE_INT = (dynamic)reader["A2_PERMEATE_INT"],
                A2_PERMEATE_INT_DIFF = (dynamic)reader["A2_PERMEATE_INT_DIFF"],
                A2_PERMEATE_FLOW = (dynamic)reader["A2_PERMEATE_FLOW"],
                A2_PROD_HRS = (dynamic)reader["A2_PROD_HRS"],
                A2_AB_RUN_HRS = (dynamic)reader["A2_AB_RUN_HRS"],
                A2_PGRU_RUN_HRS = (dynamic)reader["A2_PGRU_RUN_HRS"],
                A2_AMM_SALE = (dynamic)reader["A2_AMM_SALE"],
                A2_PGRU_PROD = (dynamic)reader["A2_PGRU_PROD"],
                A2_AMM_SUPP_UREA2_INT = (dynamic)reader["A2_AMM_SUPP_UREA2_INT"],
                A2_AMM_SUPP_UREA2 = (dynamic)reader["A2_AMM_SUPP_UREA2"],
                A2_AMM_TO_STORAGE_INT = (dynamic)reader["A2_AMM_TO_STORAGE_INT"],
                A2_AMM_TO_STORAGE = (dynamic)reader["A2_AMM_TO_STORAGE"],
                A2_PRS_VAPOUR_AMM_ACTL = (dynamic)reader["A2_PRS_VAPOUR_AMM_ACTL"],
                A2_TOT_VPR_TO_AMM2_INT = (dynamic)reader["A2_TOT_VPR_TO_AMM2_INT"],
                A2_TOT_VPR_TO_AMM2_INT_DIFF = (dynamic)reader["A2_TOT_VPR_TO_AMM2_INT_DIFF"],
                A2_TOT_VPR_TO_AMM2 = (dynamic)reader["A2_TOT_VPR_TO_AMM2"],
                A2_VPR1_TO_AMM2 = (dynamic)reader["A2_VPR1_TO_AMM2"],
                A2_VPR2_TO_AMM2 = (dynamic)reader["A2_VPR2_TO_AMM2"],
                A2_AMM_PROD = (dynamic)reader["A2_AMM_PROD"],
                DIS_TOT_AMM_STOCK = (dynamic)reader["DIS_TOT_AMM_STOCK"],
                A2_RECVFROM_AMM2_STOCK = (dynamic)reader["A2_RECVFROM_AMM2_STOCK"],
                A2_TFRTO_AMM2_STOCK = (dynamic)reader["A2_TFRTO_AMM2_STOCK"],
                A2_RECVFROM_AMM3_STOCK = (dynamic)reader["A2_RECVFROM_AMM3_STOCK"],
                A2_TFRTO_AMM3_STOCK = (dynamic)reader["A2_TFRTO_AMM3_STOCK"],
                A1_RECVFROM_AMM3_STOCK = (dynamic)reader["A1_RECVFROM_AMM3_STOCK"],
                A1_TFRTO_AMM3_STOCK = (dynamic)reader["A1_TFRTO_AMM3_STOCK"],
                DIS_AMM1_LSTOCK = (dynamic)reader["DIS_AMM1_LSTOCK"],
                A2_AMM2_LOGICAL_STOCK = (dynamic)reader["A2_AMM2_LOGICAL_STOCK"],
                A2_AMM3_LOGICAL_STOCK = (dynamic)reader["A2_AMM3_LOGICAL_STOCK"],
                A2_AMM_CAP_UTIL = (dynamic)reader["A2_AMM_CAP_UTIL"],
                A2_NAP_LIMITATION_FLG = reader["A2_NAP_LIMITATION_FLG"].ToString(),
                A2_REMARKS_D = reader["A2_REMARKS_D"].ToString(),
                A2_REMARKS_M = reader["A2_REMARKS_M"].ToString(),
                DIS_FEED_GAS = (dynamic)reader["DIS_FEED_GAS"],
                DIS_FUEL_NG = (dynamic)reader["DIS_FUEL_NG"],
                DIS_TOT_GAS = (dynamic)reader["DIS_TOT_GAS"],
                DIS_FEED_NAP = (dynamic)reader["DIS_FEED_NAP"],
                DIS_FUEL_NAP = (dynamic)reader["DIS_FUEL_NAP"],
                DIS_TOT_NAP = (dynamic)reader["DIS_TOT_NAP"],
                DIS_PW_AMM = (dynamic)reader["DIS_PW_AMM"],
                DIS_ATC_EXP = (dynamic)reader["DIS_ATC_EXP"],
                DIS_APC_EXP = (dynamic)reader["DIS_APC_EXP"],
                DIS_ASC_EXP = (dynamic)reader["DIS_ASC_EXP"],
                DIS_ACTTC_EXP = (dynamic)reader["DIS_ACTTC_EXP"],
                DIS_TOT_COND_EXP_AMM2 = (dynamic)reader["DIS_TOT_COND_EXP_AMM2"],
                DIS_PW_IMP_AMM2 = (dynamic)reader["DIS_PW_IMP_AMM2"],
                DIS_SH_STEAM_AMM2 = (dynamic)reader["DIS_SH_STEAM_AMM2"],
                DIS_SM_STEAM_EXP_ACT = (dynamic)reader["DIS_SM_STEAM_EXP_ACT"],
                DIS_PWR_CONSP_AMM2 = (dynamic)reader["DIS_PWR_CONSP_AMM2"],
                DIS_PWR_AMM2 = (dynamic)reader["DIS_PWR_AMM2"],
                DIS_PWR_CONSP_ACT = (dynamic)reader["DIS_PWR_CONSP_ACT"],
                DIS_COOL_WTR_AMM2 = (dynamic)reader["DIS_COOL_WTR_AMM2"],
                DIS_SPC_AMMONIA = (dynamic)reader["DIS_SPC_AMMONIA"],
                DIS_SPC_UR_FD_FL_AMM_EQ_NAP = (dynamic)reader["DIS_SPC_UR_FD_FL_AMM_EQ_NAP"],
                DIS_SPC_FL_STM_EQ_NAP = (dynamic)reader["DIS_SPC_FL_STM_EQ_NAP"],
                DIS_SPE_EQ_NAP_PWR_UTIL_GP1 = (dynamic)reader["DIS_SPE_EQ_NAP_PWR_UTIL_GP1"],
                DIS_SPC_TOT_EQ_NAP_UR = (dynamic)reader["DIS_SPC_TOT_EQ_NAP_UR"],
                DIS_SPC_CR_STU_STM_EXPTT_GP1 = (dynamic)reader["DIS_SPC_CR_STU_STM_EXPTT_GP1"],
                DIS_CF_SPC_NET_EQ_NAP_UR = (dynamic)reader["DIS_CF_SPC_NET_EQ_NAP_UR"],
                DIS_TOT_COOL_WTR = (dynamic)reader["DIS_TOT_COOL_WTR"],
                DIS_DMW_AMM2 = (dynamic)reader["DIS_DMW_AMM2"],
                DIS_SPC_UR_PWR_DIRECT = (dynamic)reader["DIS_SPC_UR_PWR_DIRECT"],
                DIS_ENG_FEED_GAS = (dynamic)reader["DIS_ENG_FEED_GAS"],
                DIS_ENG_FUEL_GAS = (dynamic)reader["DIS_ENG_FUEL_GAS"],
                DIS_ENG_TOT_GAS = (dynamic)reader["DIS_ENG_TOT_GAS"],
                DIS_ENG_FEED_NAP = (dynamic)reader["DIS_ENG_FEED_NAP"],
                DIS_ENG_FUEL_NAP = (dynamic)reader["DIS_ENG_FUEL_NAP"],
                DIS_ENG_TOT_NAP = (dynamic)reader["DIS_ENG_TOT_NAP"],
                DIS_ENG_TOT_GAS_NAP = (dynamic)reader["DIS_ENG_TOT_GAS_NAP"],
                DIS_ENG_SH_STEAM_AMM2 = (dynamic)reader["DIS_ENG_SH_STEAM_AMM2"],
                DIS_ENG_PWR_AMM2 = (dynamic)reader["DIS_ENG_PWR_AMM2"],
                DIS_ENG_TOT_AMM2 = (dynamic)reader["DIS_ENG_TOT_AMM2"],
                DIS_ENG_ACT_STEAM = (dynamic)reader["DIS_ENG_ACT_STEAM"],
                DIS_ENG_ACT_PWR = (dynamic)reader["DIS_ENG_ACT_PWR"],
                DIS_ENG_TOT_CT = (dynamic)reader["DIS_ENG_TOT_CT"],
                DIS_ENG_CR_BWF_PHEAT = (dynamic)reader["DIS_ENG_CR_BWF_PHEAT"],
                DIS_ENG_CR_BFW_PWR = (dynamic)reader["DIS_ENG_CR_BFW_PWR"],
                DIS_ENG_CR_TOT_SH_EXP = (dynamic)reader["DIS_ENG_CR_TOT_SH_EXP"],
                DIS_ENG_NET_ENG = (dynamic)reader["DIS_ENG_NET_ENG"],
                DIS_ENG_USP_FEED_FUEL_AMM2 = (dynamic)reader["DIS_ENG_USP_FEED_FUEL_AMM2"],
                DIS_ENG_USP_FUEL_AB = (dynamic)reader["DIS_ENG_USP_FUEL_AB"],
                DIS_SPE_ALLOC_EQ_NAP_PWR_UTIL = (dynamic)reader["DIS_SPE_ALLOC_EQ_NAP_PWR_UTIL"],
                DIS_ENG_USP_ALL_FF = (dynamic)reader["DIS_ENG_USP_ALL_FF"],
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_A2_TRANS_DATE = reader["PRV_A2_TRANS_DATE"].ToString(),
                PRV_A2_PRS_CO2_INT = (dynamic)reader["PRV_A2_PRS_CO2_INT"],
                PRV_A2_TEMP_CO2_INT = (dynamic)reader["PRV_A2_TEMP_CO2_INT"],
                PRV_A2_CO2_INT = (dynamic)reader["PRV_A2_CO2_INT"],
                PRV_A2_CO2_INT_DIFF = (dynamic)reader["PRV_A2_CO2_INT_DIFF"],
                PRV_A2_CO2_PROD = (dynamic)reader["PRV_A2_CO2_PROD"],
                PRV_A2_PRS_CO2_EXPORTT_GP1_INT = (dynamic)reader["PRV_A2_PRS_CO2_EXPORTT_GP1_INT"],
                PRV_A2_TEMP_CO2_EXPORTT_GP1_INT = (dynamic)reader["PRV_A2_TEMP_CO2_EXPORTT_GP1_INT"],
                PRV_A2_CO2_EXPORTT_GP1_INT = (dynamic)reader["PRV_A2_CO2_EXPORTT_GP1_INT"],
                PRV_A2_CO2_EXPORTT_GP1_INT_DIFF = (dynamic)reader["PRV_A2_CO2_EXPORTT_GP1_INT_DIFF"],
                PRV_A2_CO2_EXPORTT_GP1 = (dynamic)reader["PRV_A2_CO2_EXPORTT_GP1"],
                PRV_TXT_VAM_POWER = (dynamic)reader["PRV_TXT_VAM_POWER"],
                PRV_A2_CO2_SUPPLY_UREA2 = (dynamic)reader["PRV_A2_CO2_SUPPLY_UREA2"],
                PRV_A2_IA_PA_EXPORTT_GP1_INT = (dynamic)reader["PRV_A2_IA_PA_EXPORTT_GP1_INT"],
                PRV_A2_IA_PA_EXPORTT_GP1_INT_DIFF = (dynamic)reader["PRV_A2_IA_PA_EXPORTT_GP1_INT_DIFF"],
                PRV_A2_PRS_SURPLUS_GAS_INT = (dynamic)reader["PRV_A2_PRS_SURPLUS_GAS_INT"],
                PRV_A2_PRS_SURPLUS_GAS_INT_DIFF = (dynamic)reader["PRV_A2_PRS_SURPLUS_GAS_INT_DIFF"],
                PRV_A2_TEMP_SURPLUS_GAS_INT = (dynamic)reader["PRV_A2_TEMP_SURPLUS_GAS_INT"],
                PRV_A2_TEMP_SURPLUS_GAS_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_SURPLUS_GAS_INT_DIFF"],
                PRV_A2_SURPLUS_GAS_INT = (dynamic)reader["PRV_A2_SURPLUS_GAS_INT"],
                PRV_A2_SURPLUS_GAS_INT_DIFF = (dynamic)reader["PRV_A2_SURPLUS_GAS_INT_DIFF"],
                PRV_A2_SURPLUS_GAS_PROD = (dynamic)reader["PRV_A2_SURPLUS_GAS_PROD"],
                PRV_A2_PRS_PERMEATE_INT = (dynamic)reader["PRV_A2_PRS_PERMEATE_INT"],
                PRV_A2_PRS_PERMEATE_INT_DIFF = (dynamic)reader["PRV_A2_PRS_PERMEATE_INT_DIFF"],
                PRV_A2_TEMP_PERMEATE_INT = (dynamic)reader["PRV_A2_TEMP_PERMEATE_INT"],
                PRV_A2_TEMP_PERMEATE_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_PERMEATE_INT_DIFF"],
                PRV_A2_PERMEATE_INT = (dynamic)reader["PRV_A2_PERMEATE_INT"],
                PRV_A2_PERMEATE_INT_DIFF = (dynamic)reader["PRV_A2_PERMEATE_INT_DIFF"],
                PRV_A2_PERMEATE_FLOW = (dynamic)reader["PRV_A2_PERMEATE_FLOW"],
                PRV_A2_PROD_HRS = (dynamic)reader["PRV_A2_PROD_HRS"],
                PRV_A2_AB_RUN_HRS = (dynamic)reader["PRV_A2_AB_RUN_HRS"],
                PRV_A2_PGRU_RUN_HRS = (dynamic)reader["PRV_A2_PGRU_RUN_HRS"],
                PRV_A2_AMM_SALE = (dynamic)reader["PRV_A2_AMM_SALE"],
                PRV_A2_PGRU_PROD = (dynamic)reader["PRV_A2_PGRU_PROD"],
                PRV_A2_AMM_SUPP_UREA2_INT = (dynamic)reader["PRV_A2_AMM_SUPP_UREA2_INT"],
                PRV_A2_AMM_SUPP_UREA2 = (dynamic)reader["PRV_A2_AMM_SUPP_UREA2"],
                PRV_A2_AMM_TO_STORAGE_INT = (dynamic)reader["PRV_A2_AMM_TO_STORAGE_INT"],
                PRV_A2_AMM_TO_STORAGE = (dynamic)reader["PRV_A2_AMM_TO_STORAGE"],
                PRV_A2_PRS_VAPOUR_AMM_ACTL = (dynamic)reader["PRV_A2_PRS_VAPOUR_AMM_ACTL"],
                PRV_A2_TOT_VPR_TO_AMM2_INT = (dynamic)reader["PRV_A2_TOT_VPR_TO_AMM2_INT"],
                PRV_A2_TOT_VPR_TO_AMM2_INT_DIFF = (dynamic)reader["PRV_A2_TOT_VPR_TO_AMM2_INT_DIFF"],
                PRV_A2_TOT_VPR_TO_AMM2 = (dynamic)reader["PRV_A2_TOT_VPR_TO_AMM2"],
                PRV_A2_VPR1_TO_AMM2 = (dynamic)reader["PRV_A2_VPR1_TO_AMM2"],
                PRV_A2_VPR2_TO_AMM2 = (dynamic)reader["PRV_A2_VPR2_TO_AMM2"],
                PRV_A2_AMM_PROD = (dynamic)reader["PRV_A2_AMM_PROD"],
                PRV_A2_RECVFROM_AMM2_STOCK = (dynamic)reader["PRV_A2_RECVFROM_AMM2_STOCK"],
                PRV_A2_TFRTO_AMM2_STOCK = (dynamic)reader["PRV_A2_TFRTO_AMM2_STOCK"],
                PRV_A2_AMM2_LOGICAL_STOCK = (dynamic)reader["PRV_A2_AMM2_LOGICAL_STOCK"],
                PRV_A2_AMM_CAP_UTIL = (dynamic)reader["PRV_A2_AMM_CAP_UTIL"],
                PRV_A2_NAP_LIMITATION_FLG = reader["PRV_A2_NAP_LIMITATION_FLG"].ToString(),
                PRV_A2_REMARKS = reader["PRV_A2_REMARKS"].ToString(),

                // DV
                parm_dsgnd_temp_co2 = (dynamic)reader["parm_dsgnd_temp_co2"],
                parm_dsgnd_prs_co2 = (dynamic)reader["parm_dsgnd_prs_co2"],
                parm_cf_permeate_flow = (dynamic)reader["parm_cf_permeate_flow"],
                parm_amm2_daily_inst_cap = (dynamic)reader["parm_amm2_daily_inst_cap"],
                parm_permeate_pmt_amm = (dynamic)reader["parm_permeate_pmt_amm"],
                parm_CF_NM3_SM3 = (dynamic)reader["parm_CF_NM3_SM3"],
                parm_proj_sdate = reader["parm_proj_sdate"].ToString(),
                parm_sm_enthalpy = (dynamic)reader["parm_sm_enthalpy"],
                parm_sh_enthalpy = (dynamic)reader["parm_sh_enthalpy"],
                parm_pwr_factor = (dynamic)reader["parm_pwr_factor"],
                parm_temp_diff = (dynamic)reader["parm_temp_diff"],
                parm_mul_factor = (dynamic)reader["parm_mul_factor"],
                ln_dsgnd_prs = (dynamic)reader["ln_dsgnd_prs"],
                A3_STK_TRSFER_FROM_GP3_TO_GP2 = (dynamic)reader["A3_STK_TRSFER_FROM_GP3_TO_GP2"],
                A3_STK_TRSFER_FROM_GP2_TO_GP3 = (dynamic)reader["A3_STK_TRSFER_FROM_GP2_TO_GP3"],
                parm_amm2_logical_op_stock = (dynamic)reader["parm_amm2_logical_op_stock"],
                A3_AMM_3_LOGICAL_STK = (dynamic)reader["A3_AMM_3_LOGICAL_STK"],
                parm_ng_consp_feed_amm2 = (dynamic)reader["parm_ng_consp_feed_amm2"],
                parm_ng_tot_consp_amm2 = (dynamic)reader["parm_ng_tot_consp_amm2"],
                parm_ng_consp_ab = (dynamic)reader["parm_ng_consp_ab"],
                parm_ng_net_cv = (dynamic)reader["parm_ng_net_cv"],
                parm_TOT_CONSP_NG_FUEL = (dynamic)reader["parm_TOT_CONSP_NG_FUEL"],
                parm_pw_consp_amm2 = (dynamic)reader["parm_pw_consp_amm2"],
                parm_atc_prod = (dynamic)reader["parm_atc_prod"],
                parm_apc_prod = (dynamic)reader["parm_apc_prod"],
                parm_pw_consp_ab = (dynamic)reader["parm_pw_consp_ab"],
                parm_pw_consp_rgb = (dynamic)reader["parm_pw_consp_rgb"],
                parm_acttc_prod = (dynamic)reader["parm_acttc_prod"],
                parm_fw_consp_act = (dynamic)reader["parm_fw_consp_act"],
                parm_fw_consp_uct = (dynamic)reader["parm_fw_consp_uct"],
                parm_ab_sh_prod = (dynamic)reader["parm_ab_sh_prod"],
                parm_sh_consp_urea2 = (dynamic)reader["parm_sh_consp_urea2"],
                parm_sh_exportto_gp1 = (dynamic)reader["parm_sh_exportto_gp1"],
                parm_sm_consp_acwpumpa = (dynamic)reader["parm_sm_consp_acwpumpa"],
                parm_sm_consp_acwpumpb = (dynamic)reader["parm_sm_consp_acwpumpb"],
                parm_sm_consp_acwpumpc = (dynamic)reader["parm_sm_consp_acwpumpc"],
                parm_sm_consp_ucwpumpa = (dynamic)reader["parm_sm_consp_ucwpumpa"],
                parm_sm_consp_ucwpumpb = (dynamic)reader["parm_sm_consp_ucwpumpb"],
                parm_sm_consp_ucwpumpc = (dynamic)reader["parm_sm_consp_ucwpumpc"],
                parm_sm_consp_fdfan = (dynamic)reader["parm_sm_consp_fdfan"],
                parm_sm_consp_bfw_pumpa = (dynamic)reader["parm_sm_consp_bfw_pumpa"],
                parm_sm_consp_bfw_pumpb = (dynamic)reader["parm_sm_consp_bfw_pumpb"],
                parm_tot_urea_prod = (dynamic)reader["parm_tot_urea_prod"],
                parm_u_usc_prod = (dynamic)reader["parm_u_usc_prod"],
                parm_u_tot_amm_consp = (dynamic)reader["parm_u_tot_amm_consp"],

                parm_bal_nap_consp_pref = (dynamic)reader["parm_bal_nap_consp_pref"],
                parm_plant_consp_gross = (dynamic)reader["parm_plant_consp_gross"],
                parm_plant_consp_net = (dynamic)reader["parm_plant_consp_net"],
                parm_nap_net_cv = (dynamic)reader["parm_nap_net_cv"],
                parm_act_consp = (dynamic)reader["parm_act_consp"],
                parm_sc_importf_unit2 = (dynamic)reader["parm_sc_importf_unit2"],

                ln_cr_sm_fdfan_ab = (dynamic)reader["ln_cr_sm_fdfan_ab"],
                ln_sm_uct = (dynamic)reader["ln_sm_uct"],
                ln_sm_steam_bfw = (dynamic)reader["ln_sm_steam_bfw"]

            };
        }

        public async Task<PAS202Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_AMMONIA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS202Model response = null;
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

        public async Task saveData(PAS202SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_AMMONIA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_CO2_INT", value.A2_PRS_CO2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_CO2_INT", value.A2_TEMP_CO2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_INT", value.A2_CO2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_INT_DIFF", value.A2_CO2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_CO2_PROD", value.A2_CF_CO2_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_PROD", value.A2_CO2_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_CO2_EXPORTT_GP1_INT", value.A2_PRS_CO2_EXPORTT_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_CO2_EXPORTT_GP1_INT", value.A2_TEMP_CO2_EXPORTT_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_EXPORTT_GP1_INT", value.A2_CO2_EXPORTT_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_EXPORTT_GP1_INT_DIFF", value.A2_CO2_EXPORTT_GP1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_CO2_EXPORTT_GP1", value.A2_CF_CO2_EXPORTT_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_EXPORTT_GP1", value.A2_CO2_EXPORTT_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CO2_SUPPLY_UREA2", value.A2_CO2_SUPPLY_UREA2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_PERMEATE_INT", value.A2_PRS_PERMEATE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_PERMEATE_INT_DIFF", value.A2_PRS_PERMEATE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_PERMEATE_INT", value.A2_TEMP_PERMEATE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_PERMEATE_INT_DIFF", value.A2_TEMP_PERMEATE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PERMEATE_INT", value.A2_PERMEATE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PERMEATE_INT_DIFF", value.A2_PERMEATE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_PERMEATE_FLOW", value.A2_CF_PERMEATE_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PERMEATE_FLOW", value.A2_PERMEATE_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PROD_HRS", value.A2_PROD_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PGRU_RUN_HRS", value.A2_PGRU_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_PROD", value.A2_AMM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PGRU_PROD", value.A2_PGRU_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_SUPP_UREA2_INT", value.A2_AMM_SUPP_UREA2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_SUPP_UREA2", value.A2_AMM_SUPP_UREA2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_TO_STORAGE_INT", value.A2_AMM_TO_STORAGE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_TO_STORAGE", value.A2_AMM_TO_STORAGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_VPR_TO_AMM2_INT", value.A2_TOT_VPR_TO_AMM2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_VPR_TO_AMM2", value.A2_TOT_VPR_TO_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_VPR1_TO_AMM2", value.A2_VPR1_TO_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_VPR2_TO_AMM2", value.A2_VPR2_TO_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_SALE", value.A2_AMM_SALE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM2_LOGICAL_STOCK", value.A2_AMM2_LOGICAL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_CAP_UTIL", value.A2_AMM_CAP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS_D", value.A2_REMARKS_D));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS_M", value.A2_REMARKS_M));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_VPR_TO_AMM2_INT_DIFF", value.A2_TOT_VPR_TO_AMM2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_VAPOUR_AMM_ACTL", value.A2_PRS_VAPOUR_AMM_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_RUN_HRS", value.A2_AB_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IA_PA_EXPORTT_GP1_INT", value.A2_IA_PA_EXPORTT_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IA_PA_EXPORTT_GP1_INT_DIFF", value.A2_IA_PA_EXPORTT_GP1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_LIMITATION_FLG", value.A2_NAP_LIMITATION_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RECVFROM_AMM2_STOCK", value.A2_RECVFROM_AMM2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TFRTO_AMM2_STOCK", value.A2_TFRTO_AMM2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SURPLUS_GAS_INT", value.A2_SURPLUS_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SURPLUS_GAS_INT_DIFF", value.A2_SURPLUS_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SURPLUS_GAS_PROD", value.A2_SURPLUS_GAS_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_SURPLUS_GAS_INT", value.A2_PRS_SURPLUS_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_SURPLUS_GAS_INT_DIFF", value.A2_PRS_SURPLUS_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_SURPLUS_GAS_INT", value.A2_TEMP_SURPLUS_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_SURPLUS_GAS_INT_DIFF", value.A2_TEMP_SURPLUS_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_TRFT_UREA_SHIFT_A", value.A2_AMM_TRFT_UREA_SHIFT_A));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM_TRFT_UREA_SHIFT_B", value.A2_AMM_TRFT_UREA_SHIFT_B));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RECVFROM_AMM3_STOCK", value.A2_RECVFROM_AMM3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TFRTO_AMM3_STOCK", value.A2_TFRTO_AMM3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AMM3_LOGICAL_STOCK", value.A2_AMM3_LOGICAL_STOCK));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
