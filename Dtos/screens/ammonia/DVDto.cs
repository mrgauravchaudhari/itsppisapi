namespace itsppisapi.Dtos
{
    public class AMM1DVDto
    {
        public decimal ou1_pw_consp_unit1 { get; set; }
        public decimal OU1_PW_CONSP_SPG { get; set; }
        public decimal OU1_PW_CONSP_AMM { get; set; }
        public decimal OU1_APC_PROD { get; set; }
        public decimal OU1_HS_CONSP_AMM { get; set; }
        public decimal parm_eff { get; set; } // As ln_eff
        public decimal parm_cf_nh3_sm3 { get; set; }
        public decimal parm_ks_enthalpy { get; set; }
        public decimal parm_hs_enthalpy { get; set; }
        public decimal parm_ls_enthalpy { get; set; }
        public decimal parm_eng_eq_power { get; set; }
        public decimal parm_temp_rise_bfw { get; set; }
        public decimal parm_amm_daily_inst_cap { get; set; }

        public decimal parm_k_surplus_gas { get; set; }
        public decimal parm_amm_prs_const { get; set; }
        public decimal parm_kelvin_temp { get; set; }
        public decimal parm_dsgnd_mw_surplus_gas { get; set; }
        public decimal parm_z_surplus_gas { get; set; }
        public decimal parm_k_co2 { get; set; }
        public decimal parm_dsgnd_mw_co2 { get; set; }
        public decimal parm_z_co2 { get; set; }

        public decimal a_vpr1_to_amm2 { get; set; }
        public decimal a_recvfrom_amm2_stock { get; set; }
        public decimal a_tfrto_amm2_stock { get; set; }
        public decimal a_amm2_logical_stock { get; set; }
        public decimal A_NG_EXPORTT_UNIT1 { get; set; }
        public decimal u_tot_urea_prod { get; set; }
        public decimal a_ng_alloc_revamp { get; set; }
        public decimal A_ALLOC_NG_SH_EXP_GP1 { get; set; }
        public decimal a_ng_alloc_pwr_amm_tr_gpi { get; set; }
        public decimal A_ALLOC_NAP_SH_EXP_GP1 { get; set; }
        public decimal a_nap_net_cv { get; set; }
        public decimal a_ioc_rlng_lcv { get; set; }
        public decimal A3_STK_TRSFER_FROM_GP3_TO_GP1 { get; set; } // As A3_PDR_T9
        public decimal A3_STK_TRSFER_FROM_GP1_TO_GP3 { get; set; } // As A3_PDR_T11
        public decimal A3_AMM_3_LOGICAL_STK { get; set; } // As A3_PDR_T15_CV
        public decimal CALC_DAILY_NG_CV { get; set; }

        public decimal parm_mf_amm_tank { get; set; }
        public decimal ln_log_stk2 { get; set; }
        public decimal a_am_ng_alloc_feed_gp2 { get; set; }
        public decimal a_am_ng_alloc_fuel_gp2 { get; set; }
        public decimal a_am_nap_alloc { get; set; }
        public decimal ou_import_ks_consp_amm { get; set; }
        public decimal ou_hs_consp_act { get; set; }
        public decimal ou_pw_consp_unit1 { get; set; }
        public decimal ou_pw_consp_spg { get; set; }
        public decimal ou_pw_consp_amm { get; set; }
        public decimal ou_apc_prod { get; set; }
        public decimal txt_a_ng_alloc_gp2 { get; set; }
        public decimal txt_a_nap_alloc_gp2 { get; set; }
        public decimal a_nap_alloc_revamp { get; set; }
        public decimal parm_dsgnd_nap_cv { get; set; }
        public decimal txt_ou_hs_consp_ctt { get; set; }
        public decimal txt_ou_pw_consp_spg { get; set; }

        public decimal ln_amm_op_stk { get; set; }
        public decimal ln_vpr1_amm { get; set; }
        public decimal ln_amm_tfrto_amm2_stk { get; set; }
        public decimal ln_amm_tfrto_amm1_stk { get; set; }
        public decimal G_K_NG_FUEL_SSHEATER { get; set; }
        public decimal G_Z_NG_FUEL_SSHEATER { get; set; }
        public decimal G_AMM_PRS_CONST { get; set; }
        public decimal G_KELVIN_TEMP { get; set; }
        public decimal G_Z_NG_FUEL_REFMR { get; set; }
        public decimal G_K_NG_FUEL_REFMR { get; set; }
        public decimal G_K_NG_FEED_REFMR { get; set; }
        public decimal G_Z_NG_FEED_REFMR { get; set; }
        public decimal TXT_MAX_PRODUCTION { get; set; }
        public string TXT_MAX_PROD_DATE { get; set; }
    }
}
