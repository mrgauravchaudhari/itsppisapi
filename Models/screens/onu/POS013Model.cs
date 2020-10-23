namespace itsppisapi.Models
{
    public class POS013Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string OU1_TRANS_DATE { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public string OU1_DATE_MOD { get; set; }
        public dynamic OU1_USER_ID { get; set; }
        public string OU1_USER_NAME { get; set; }

        public decimal OU1_SERVICE_AIR_PROD_INT { get; set; }
        public decimal OU1_SERVICE_AIR_PROD_INT_DIFF { get; set; }
        public decimal OU1_SERVICE_AIR_PRODUCTION { get; set; }
        public decimal OU1_NITROGEN_PROD_INT { get; set; }
        public decimal OU1_NITROGEN_PROD_INT_DIFF { get; set; }
        public decimal OU1_NITROGEN_PRODUCTION { get; set; }
        public decimal OU1_INST_AIR_CONS_UNIT1_INT { get; set; }
        public decimal OU1_INST_AIR_CONS_UNIT1_INT_DIF { get; set; }
        public decimal OU1_INST_AIR_CONS_UNIT1 { get; set; }
        public decimal OU1_N2_CONSP_UNIT1_INT { get; set; }
        public decimal OU1_N2_CONSP_UNIT1_INT_DIFF { get; set; }
        public decimal OU1_N2_CONSP_UNIT1 { get; set; }
        public decimal OU1_SERVICE_AIR_EXPORTT_UNIT2 { get; set; }
        public decimal OU1_N2_CONSP_UNIT2_INT { get; set; }
        public decimal OU1_N2_CONSP_UNIT2_INT_DIFF { get; set; }
        public decimal OU1_NITROGEN_EXPORTT_UNIT2 { get; set; }
        public decimal OU1_INST_AIR_CONS_UNIT2_INT { get; set; }
        public decimal OU1_INST_AIR_CONS_UNIT2_INT_DIF { get; set; }
        public decimal OU1_INST_AIR_CONS_UNIT2 { get; set; }
        public decimal OU1_AUX_COMP_RHRS_UNIT2 { get; set; }
        public decimal OU1_MAIN_COMP_RHRS_UNIT2 { get; set; }
        public decimal OU1_NO_AB_SU_SD { get; set; }
        public decimal OU1_NO_GT_SU_SD { get; set; }
        public decimal OU1_NO_2GTG_HRS { get; set; }
        public decimal OU1_OLD_BOTTLE_STRG_LVL { get; set; }
        public decimal OU1_OLD_BOTTLE_STOCK { get; set; }
        public decimal OU1_NEW_BOTTLE_STRG_LVL { get; set; }
        public decimal OU1_NEW_BOTTLE_STOCK { get; set; }
        public decimal OU1_N2_BOTTLE_STOCK { get; set; }
        public decimal OU1_OLD_BOTTLE_LVL_BF_CONSP { get; set; }
        public decimal OU1_OLD_BOTTLE_LVL_AF_CONSP { get; set; }
        public decimal OU1_OLD_BOTTLE_CONSP { get; set; }
        public decimal OU1_NEW_BOTTLE_LVL_BF_CONSP { get; set; }
        public decimal OU1_NEW_BOTTLE_LVL_AF_CONSP { get; set; }
        public decimal OU1_NEW_BOTTLE_CONSP { get; set; }
        public decimal OU1_TOTAL_N2_BOTTLE_CONSP { get; set; }
        public decimal OU1_OLD_BOTTLE_LVL_BF_UNLDG { get; set; }
        public decimal OU1_OLD_BOTTLE_LVL_AF_UNLDG { get; set; }
        public decimal OU1_OLD_BOTTLE_UNLD_QTY { get; set; }
        public decimal OU1_NEW_BOTTLE_LVL_BF_UNLDG { get; set; }
        public decimal OU1_NEW_BOTTLE_LVL_AF_UNLDG { get; set; }
        public decimal OU1_NEW_BOTTLE_UNLD_QTY { get; set; }
        public decimal OU1_TOTAL_N2_UNLD_QTY { get; set; }

        // --------------------------PRV-------------------------------
        // public string PRV_OU_TRANS_DATE { get; set; }
        public decimal PRV_OU1_SERVICE_AIR_PROD_INT { get; set; }
        public decimal PRV_OU1_SERVICE_AIR_PROD_INT_DIFF { get; set; }
        public decimal PRV_OU1_SERVICE_AIR_PRODUCTION { get; set; }
        public decimal PRV_OU1_NITROGEN_PROD_INT { get; set; }
        public decimal PRV_OU1_NITROGEN_PROD_INT_DIFF { get; set; }
        public decimal PRV_OU1_NITROGEN_PRODUCTION { get; set; }
        public decimal PRV_OU1_INST_AIR_CONS_UNIT1_INT { get; set; }
        public decimal PRV_OU1_INST_AIR_CONS_UNIT1_INT_DIF { get; set; }
        public decimal PRV_OU1_INST_AIR_CONS_UNIT1 { get; set; }
        public decimal PRV_OU1_N2_CONSP_UNIT1_INT { get; set; }
        public decimal PRV_OU1_N2_CONSP_UNIT1_INT_DIFF { get; set; }
        public decimal PRV_OU1_N2_CONSP_UNIT1 { get; set; }
        public decimal PRV_OU1_SERVICE_AIR_EXPORTT_UNIT2 { get; set; }
        public decimal PRV_OU1_N2_CONSP_UNIT2_INT { get; set; }
        public decimal PRV_OU1_N2_CONSP_UNIT2_INT_DIFF { get; set; }
        public decimal PRV_OU1_NITROGEN_EXPORTT_UNIT2 { get; set; }
        public decimal PRV_OU1_INST_AIR_CONS_UNIT2_INT { get; set; }
        public decimal PRV_OU1_INST_AIR_CONS_UNIT2_INT_DIF { get; set; }
        public decimal PRV_OU1_INST_AIR_CONS_UNIT2 { get; set; }
        public decimal PRV_OU1_AUX_COMP_RHRS_UNIT2 { get; set; }
        public decimal PRV_OU1_MAIN_COMP_RHRS_UNIT2 { get; set; }
        public decimal PRV_OU1_NO_AB_SU_SD { get; set; }
        public decimal PRV_OU1_NO_GT_SU_SD { get; set; }
        public decimal PRV_OU1_NO_2GTG_HRS { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_STRG_LVL { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_STOCK { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_STRG_LVL { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_STOCK { get; set; }
        public decimal PRV_OU1_N2_BOTTLE_STOCK { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_LVL_BF_CONSP { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_LVL_AF_CONSP { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_CONSP { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_LVL_BF_CONSP { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_LVL_AF_CONSP { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_CONSP { get; set; }
        public decimal PRV_OU1_TOTAL_N2_BOTTLE_CONSP { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_LVL_BF_UNLDG { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_LVL_AF_UNLDG { get; set; }
        public decimal PRV_OU1_OLD_BOTTLE_UNLD_QTY { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_LVL_BF_UNLDG { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_LVL_AF_UNLDG { get; set; }
        public decimal PRV_OU1_NEW_BOTTLE_UNLD_QTY { get; set; }
        public decimal PRV_OU1_TOTAL_N2_UNLD_QTY { get; set; }

        // --------------------------DV-------------------------------
        public decimal parm_n2_density { get; set; }
        public decimal parm_mf_old_bottle { get; set; }
        public decimal parm_new_bottle_scale { get; set; }
        public decimal parm_new_bottle_cap { get; set; }
    }
}
