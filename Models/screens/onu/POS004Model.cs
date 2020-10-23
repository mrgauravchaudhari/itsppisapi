namespace itsppisapi.Models
{
    public class POS004Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string A1_TRANS_DATE { get; set; }
        public decimal A1_NG_RECPT { get; set; }
        public decimal A1_AVG_PRS_NG_GT { get; set; }
        public decimal A1_AVG_TEMP_NG_GT { get; set; }
        public decimal A1_AVG_PRS_NG_HRSG { get; set; }
        public decimal A1_AVG_TEMP_NG_HRSG { get; set; }
        public decimal A1_MOL_WT_NG { get; set; }
        public decimal A1_NG_AB1_INT { get; set; }
        public decimal A1_NG_AB1_INT_DIFF { get; set; }
        public decimal A1_NG_CONSP_AB1 { get; set; }
        public decimal A1_NG_AB2_INT { get; set; }
        public decimal A1_NG_AB2_INT_DIFF { get; set; }
        public decimal A1_NG_CONSP_AB2 { get; set; }
        public decimal A1_NG_GT1_INT { get; set; }
        public decimal A1_NG_GT1_INT_DIFF { get; set; }
        public decimal A1_NG_CONSP_GT1 { get; set; }
        public decimal A1_NG_GT2_INT { get; set; }
        public decimal A1_NG_GT2_INT_DIFF { get; set; }
        public decimal A1_NG_CONSP_GT2 { get; set; }
        public decimal A1_NG_HRSG1_INT { get; set; }
        public decimal A1_NG_HRSG1_INT_DIFF { get; set; }
        public decimal A1_NG_CONSP_HRSG1 { get; set; }
        public decimal A1_NG_HRSG2_INT { get; set; }
        public decimal A1_NG_HRSG2_INT_DIFF { get; set; }
        public decimal A1_NG_CONSP_HRSG2 { get; set; }
        public decimal A1_NG_CONSP_SPG { get; set; }
        public decimal A1_NG_CONSP_AMM { get; set; }
        public string A1_DATE_MOD { get; set; }
        public decimal A1_USER_ID { get; set; }
        public string USER_NAME { get; set; }

        // PRV 
        public string PRV_A1_TRANS_DATE { get; set; }
        public decimal PRV_A1_NG_RECPT { get; set; }
        public decimal PRV_A1_AVG_PRS_NG_GT { get; set; }
        public decimal PRV_A1_AVG_TEMP_NG_GT { get; set; }
        public decimal PRV_A1_AVG_PRS_NG_HRSG { get; set; }
        public decimal PRV_A1_AVG_TEMP_NG_HRSG { get; set; }
        public decimal PRV_A1_MOL_WT_NG { get; set; }
        public decimal PRV_A1_NG_AB1_INT { get; set; }
        public decimal PRV_A1_NG_AB1_INT_DIFF { get; set; }
        public decimal PRV_A1_NG_CONSP_AB1 { get; set; }
        public decimal PRV_A1_NG_AB2_INT { get; set; }
        public decimal PRV_A1_NG_AB2_INT_DIFF { get; set; }
        public decimal PRV_A1_NG_CONSP_AB2 { get; set; }
        public decimal PRV_A1_NG_GT1_INT { get; set; }
        public decimal PRV_A1_NG_GT1_INT_DIFF { get; set; }
        public decimal PRV_A1_NG_CONSP_GT1 { get; set; }
        public decimal PRV_A1_NG_GT2_INT { get; set; }
        public decimal PRV_A1_NG_GT2_INT_DIFF { get; set; }
        public decimal PRV_A1_NG_CONSP_GT2 { get; set; }
        public decimal PRV_A1_NG_HRSG1_INT { get; set; }
        public decimal PRV_A1_NG_HRSG1_INT_DIFF { get; set; }
        public decimal PRV_A1_NG_CONSP_HRSG1 { get; set; }
        public decimal PRV_A1_NG_HRSG2_INT { get; set; }
        public decimal PRV_A1_NG_HRSG2_INT_DIFF { get; set; }
        public decimal PRV_A1_NG_CONSP_HRSG2 { get; set; }
        public decimal PRV_A1_NG_CONSP_SPG { get; set; }
        public decimal PRV_A1_NG_CONSP_AMM { get; set; }

        // DV
        public decimal parm_cf_nm3_sm3 { get; set; }
        public decimal parm_ng_dsg_comp_fact_ab { get; set; }
        public decimal parm_dsg_mol_wt { get; set; }
        public decimal parm_ng_act_comp_fact_ab { get; set; }
        public decimal parm_ng_dsg_comp_fact_gt { get; set; }
        public decimal parm_dsg_prs_gt { get; set; }
        public decimal parm_dsg_temp_gt { get; set; }
        public decimal parm_kelvin_temp { get; set; }
        public decimal parm_ng_act_comp_fact_gt { get; set; }
        public decimal parm_dsg_temp_hrsg { get; set; }
        public decimal parm_dsg_prs_hrsg { get; set; }

    }
}