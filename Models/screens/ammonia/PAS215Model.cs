namespace itsppisapi.Models
{
    public class PAS215Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string A2_TRANS_DATE { get; set; }
        public string DSP_DEPT_NAME { get; set; }
        public string DSP_MAINT_DEPT_DESC { get; set; }
        public string A2_TAG_NO { get; set; }
        public string A2_DATE_TIME_FROM { get; set; }
        public string A2_DATE_TIME_TO { get; set; }
        public dynamic A2_MAINT_HRS { get; set; }
        public dynamic A2_MAINT_TYPE { get; set; }
        public dynamic A2_DOWNTIME_HRS { get; set; }
        public string A2_JOB_DESC { get; set; }
        public string A2_MONTH_FLG { get; set; }
        public string A2_YEAR_FLG { get; set; }
        public string A2_DATE_MOD { get; set; }
        public dynamic A2_USER_ID { get; set; }
        public string USER_NAME { get; set; }

        // PRV
        public string PRV_A2_TRANS_DATE { get; set; }
        public string PRV_DSP_DEPT_NAME { get; set; }
        public string PRV_DSP_MAINT_DEPT_DESC { get; set; }
        public string PRV_A2_TAG_NO { get; set; }
        public string PRV_A2_DATE_TIME_FROM { get; set; }
        public string PRV_A2_DATE_TIME_TO { get; set; }
        public dynamic PRV_A2_MAINT_HRS { get; set; }
        public dynamic PRV_A2_MAINT_TYPE { get; set; }
        public dynamic PRV_A2_DOWNTIME_HRS { get; set; }
        public string PRV_A2_JOB_DESC { get; set; }
        public string PRV_A2_MONTH_FLG { get; set; }
        public string PRV_A2_YEAR_FLG { get; set; }
    }
}
