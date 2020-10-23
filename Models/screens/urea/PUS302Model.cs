namespace itsppisapi.Models
{
    public class PUS302Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string TDATE { get; set; }
        public string U3_DATE_MOD { get; set; }
        public string USER_NAME { get; set; }
        public dynamic U3_USER_ID { get; set; }

        public dynamic U3_BRKDWN_ID { get; set; }
        public string U3_UREA_UNIT { get; set; }
        public string U3_DATE_TIME_FROM { get; set; }
        public string U3_DATE_TIME_TO { get; set; }
        public dynamic U3_DOWNTIME_HRS { get; set; }
        public dynamic U3_NO_MAJOR_INTRP_TRAIN { get; set; }
        public dynamic U3_NO_MAJOR_INTRP_PLANT { get; set; }
        public string U3_REASON { get; set; }
    }
}
