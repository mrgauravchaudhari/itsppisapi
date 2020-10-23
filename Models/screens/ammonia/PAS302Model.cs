namespace itsppisapi.Models
{
    public class PAS302Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string TDATE { get; set; }
        public string A3_DATE_MOD { get; set; }
        public decimal A3_USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string A3_DATE_TIME_FROM { get; set; }
        public string A3_DATE_TIME_TO { get; set; }
        public string A3_TRIP_CLASS { get; set; }
        public decimal A3_DOWNTIME_HRS { get; set; }
        public decimal A3_MAJOR_INTRP_FLG { get; set; }
        public decimal A3_UNPROD_HRS { get; set; }
        public decimal A3_COM_SHUT_HRS { get; set; }
        public string A3_EQUIP_BRKDOWN { get; set; }
        public decimal A3_PROD_LOSS { get; set; }
        public decimal A3_UNPROD_NAP { get; set; }
        public decimal A3_UNPROD_NG { get; set; }
        public string A3_BRKDOWN_REASON { get; set; }
        public decimal TXT_ON_STREAM_HSR { get; set; }
        public string TXT_TRIP_TYPE_DESC { get; set; }
        public decimal A3_TRIP_TYPE_ID { get; set; }

    }

    public class PAS302_2Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string TDATE { get; set; }
        public string A3_DATE_MOD { get; set; }
        public decimal TXT_TOT_BRKDWN_HRS { get; set; }
        public string A3_DATE_TIME_FROM { get; set; }
        public decimal A3_USER_ID { get; set; }
        public string TXT_BRKDWN_CAUSE_DESC { get; set; }
        public decimal A3_BRKDWN_CAUSE_ID { get; set; }
        public decimal A3_BRKDWN_HRS { get; set; }
    }
}
