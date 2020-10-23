namespace itsppisapi.Models
{
    public class PUS204Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string U2_TRANS_DATE { get; set; }
        public decimal U2_TRAIN_A_FEEDER1_INT { get; set; }
        public decimal U2_TRAIN_A_FEEDER1_INT_DIFF { get; set; }
        public decimal U2_TRAIN_A_FEEDER2_INT { get; set; }
        public decimal U2_TRAIN_A_FEEDER2_INT_DIFF { get; set; }
        public decimal U2_TRAIN_B_FEEDER1_INT { get; set; }
        public decimal U2_TRAIN_B_FEEDER1_INT_DIFF { get; set; }
        public decimal U2_TRAIN_B_FEEDER2_INT { get; set; }
        public decimal U2_TRAIN_B_FEEDER2_INT_DIFF { get; set; }
        public decimal U2_PLANT_CONSP_GROSS { get; set; }
        public decimal U2_LIGHT_TRANSFMR_INT { get; set; }
        public decimal U2_LIGHT_TRANSFMR_INT_DIFF { get; set; }
        public decimal U2_PDB_INT { get; set; }
        public decimal U2_PDB_INT_DIFF { get; set; }
        public decimal U2_NON_PLANT_CONSP { get; set; }
        public decimal U2_NET_CONSP { get; set; }
        public string U2_REMARKS { get; set; }
        public decimal TXT_FDR1_CONSP { get; set; }
        public decimal TXT_FDR2_CONSP { get; set; }
        public decimal PARM_AM_GROSS { get; set; }
        public decimal TXT_LINE_TRANS_LOSS { get; set; }
        public decimal TXT_TOT_FDR { get; set; }
        public string TXT_TRANS_LOSS { get; set; }
        public string DATE_MOD { get; set; }
        public string USER_NAME { get; set; }

        //PRV
        public string PRV_U2_TRANS_DATE { get; set; }
        public decimal PRV_U2_TRAIN_A_FEEDER1_INT { get; set; }
        public decimal PRV_U2_TRAIN_A_FEEDER1_INT_DIFF { get; set; }
        public decimal PRV_U2_TRAIN_A_FEEDER2_INT { get; set; }
        public decimal PRV_U2_TRAIN_A_FEEDER2_INT_DIFF { get; set; }
        public decimal PRV_U2_TRAIN_B_FEEDER1_INT { get; set; }
        public decimal PRV_U2_TRAIN_B_FEEDER1_INT_DIFF { get; set; }
        public decimal PRV_U2_TRAIN_B_FEEDER2_INT { get; set; }
        public decimal PRV_U2_TRAIN_B_FEEDER2_INT_DIFF { get; set; }
        public decimal PRV_U2_PLANT_CONSP_GROSS { get; set; }
        public decimal PRV_U2_LIGHT_TRANSFMR_INT { get; set; }
        public decimal PRV_U2_LIGHT_TRANSFMR_INT_DIFF { get; set; }
        public decimal PRV_U2_PDB_INT { get; set; }
        public decimal PRV_U2_PDB_INT_DIFF { get; set; }
        public decimal PRV_U2_NON_PLANT_CONSP { get; set; }
        public decimal PRV_U2_NET_CONSP { get; set; }
        public string PRV_U2_REMARKS { get; set; }
    }
}
