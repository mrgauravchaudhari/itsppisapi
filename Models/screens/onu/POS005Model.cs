namespace itsppisapi.Models
{
    public class POS005Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string OU1_NAP_RECPT_DATE { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public string OU1_DATE_MOD { get; set; }
        public dynamic OU1_USER_ID { get; set; }
        public string OU1_USER_NAME { get; set; }

        public string OU1_RAKE_WAGON_FLG { get; set; }
        public string OU1_NAP_TFR_TANK { get; set; }
        public string OU1_RAKE_NO { get; set; }
        public dynamic OU1_NO_WAGONS { get; set; }
        public dynamic OU1_QTY_NAP_RECD { get; set; }
        public dynamic OU1_NAP_CV_NET { get; set; }
        public dynamic OU1_NAP_CV_IOCL { get; set; }
        public string OU1_RAKE_LOAD_FROM { get; set; }
        public string OU1_RAKE_LOAD_DATE1 { get; set; }
        public string OU1_UNLOAD_TRACK { get; set; }
        public dynamic OU1_NAP_AR3A_QTY_MT { get; set; }
        public dynamic OU1_NAP_LEVEL_INITIAL { get; set; }
        public dynamic OU1_WTR_LEVEL_INITIAL { get; set; }
        public dynamic OU1_NAP_LEVEL_FINAL_ACTL { get; set; }
        public dynamic OU1_WTR_LEVEL_FINAL_ACTL { get; set; }
        public dynamic OU1_NAP_AR3A_QTY { get; set; }
        public string OU1_TANK_REMK { get; set; }
        public string TXT_RAKE_NO { get; set; }

        //---------------------- PRV ------------------------------------
        public string PRV_OU1_NAP_RECPT_DATE { get; set; }

        public string PRV_OU1_RAKE_WAGON_FLG { get; set; }
        public string PRV_OU1_NAP_TFR_TANK { get; set; }
        public dynamic PRV_OU1_RAKE_NO { get; set; }
        public dynamic PRV_OU1_NO_WAGONS { get; set; }
        public dynamic PRV_OU1_QTY_NAP_RECD { get; set; }
        public dynamic PRV_OU1_NAP_CV_NET { get; set; }
        public dynamic PRV_OU1_NAP_CV_IOCL { get; set; }
        public string PRV_OU1_RAKE_LOAD_FROM { get; set; }
        public string PRV_OU1_RAKE_LOAD_DATE1 { get; set; }
        public string PRV_OU1_UNLOAD_TRACK { get; set; }
        public dynamic PRV_OU1_NAP_AR3A_QTY_MT { get; set; }
        public dynamic PRV_OU1_NAP_LEVEL_INITIAL { get; set; }
        public dynamic PRV_OU1_WTR_LEVEL_INITIAL { get; set; }
        public dynamic PRV_OU1_NAP_LEVEL_FINAL_ACTL { get; set; }
        public dynamic PRV_OU1_WTR_LEVEL_FINAL_ACTL { get; set; }
        public string PRV_OU1_NAP_AR3A_QTY { get; set; }
        public string PRV_OU1_TANK_REMK { get; set; }
    }
}
