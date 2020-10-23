namespace itsppisapi.Models
{
    public class PUS202Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string U2_TRANS_DATE { get; set; }
        public string U2_DATE_MOD { get; set; }
        public string USER_NAME { get; set; }
        public dynamic U2_USER_ID { get; set; }

        public dynamic U2_BRKDWN_ID { get; set; }
        public string U2_UREA_UNIT { get; set; }
        public string U2_DATE_TIME_FROM { get; set; }
        public string U2_DATE_TIME_TO { get; set; }
        public dynamic U2_DOWNTIME_HRS { get; set; }
        public dynamic U2_NO_MAJOR_INTRP_TRAIN { get; set; }
        public dynamic U2_NO_MAJOR_INTRP_PLANT { get; set; }
        public string U2_REASON { get; set; }
    }
}
