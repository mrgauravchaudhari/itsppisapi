namespace itsppisapi.Models
{
    public class PAS002Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string A1_TRANS_DATE { get; set; }
        public decimal RUNNING_HOURS { get; set; }
        public string A1_TRIP_TIME { get; set; }
        public string A1_RESUME_TIME { get; set; }
        public decimal A1_TRIP_TYPE_ID { get; set; }
        public decimal A1_NO_MAJOR_INTRP_FLG { get; set; }
        public decimal A1_UNPROD_HRS { get; set; }
        public decimal A1_SHUTDOWN_HRS { get; set; }
        public decimal A1_PROD_LOSS { get; set; }
        public decimal A1_UNPROD_NG { get; set; }
        public decimal A1_PREV_MAINT_HRS { get; set; }
        public decimal A1_INSTRUMENTATION_PROB_HRS { get; set; }
        public decimal A1_EQP_BAD_HRS { get; set; }
        public decimal A1_EXTER_POWER_HRS { get; set; }
        public decimal A1_RAW_MAT_SHORTAGE_HRS { get; set; }
        public decimal A1_MISC1_HRS { get; set; }
        public string A1_MISC1_REASON { get; set; }
        public decimal A1_MISC2_HRS { get; set; }
        public string A1_MISC2_REASON { get; set; }
        public decimal A1_MISC3_HRS { get; set; }
        public string A1_MISC3_REASON { get; set; }
        public string A1_BRKDOWN_REASON { get; set; }
        public string A1_DATE_MOD { get; set; }
        public decimal A1_USER_ID { get; set; }
        public string USER_NAME { get; set; }

        // PRV
        public string PRV_A1_TRANS_DATE { get; set; }
        public string PRV_A1_TRIP_TIME { get; set; }
        public string PRV_A1_RESUME_TIME { get; set; }
        public decimal PRV_A1_TRIP_TYPE_ID { get; set; }
        public decimal PRV_A1_NO_MAJOR_INTRP_FLG { get; set; }
        public decimal PRV_A1_UNPROD_HRS { get; set; }
        public decimal PRV_A1_SHUTDOWN_HRS { get; set; }
        public decimal PRV_A1_PREV_MAINT_HRS { get; set; }
        public decimal PRV_A1_INSTRUMENTATION_PROB_HRS { get; set; }
        public decimal PRV_A1_EQP_BAD_HRS { get; set; }
        public decimal PRV_A1_EXTER_POWER_HRS { get; set; }
        public decimal PRV_A1_RAW_MAT_SHORTAGE_HRS { get; set; }
        public decimal PRV_A1_MISC1_HRS { get; set; }
        public string PRV_A1_MISC1_REASON { get; set; }
        public dynamic PRV_A1_MISC2_HRS { get; set; }
        public string PRV_A1_MISC2_REASON { get; set; }
        public decimal PRV_A1_MISC3_HRS { get; set; }
        public string PRV_A1_MISC3_REASON { get; set; }
        public string PRV_A1_BRKDOWN_REASON { get; set; }
    }
}
