namespace itsppisapi.Models
{
    public class PAS203Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string A2_TRANS_DATE { get; set; }
        public string A2_DATE_TIME_FROM { get; set; }
        public string A2_DATE_TIME_TO { get; set; }
        public dynamic A2_TRIP_CLASS { get; set; }
        public dynamic A2_DOWNTIME_HRS { get; set; }
        public dynamic A2_MAJOR_INTRP_FLG { get; set; }
        public dynamic A2_UNPROD_HRS { get; set; }
        public dynamic A2_COM_SHUT_HRS { get; set; }
        public dynamic A2_EQUIP_BRKDOWN { get; set; }
        public dynamic A2_PROD_LOSS { get; set; }
        public dynamic A2_UNPROD_NAP { get; set; }
        public dynamic A2_UNPROD_NG { get; set; }
        public string A2_BRKDOWN_REASON { get; set; }
        public dynamic TXT_ON_STREAM_HSR { get; set; }
        public string A2_TRIP_TYPE_ID { get; set; }
        public string A2_DATE_MOD { get; set; }
        public dynamic A2_USER_ID { get; set; }
        public string USER_NAME { get; set; }

        // PRV
        public string PRV_A2_TRANS_DATE { get; set; }
        public string PRV_A2_DATE_TIME_FROM { get; set; }
        public string PRV_A2_DATE_TIME_TO { get; set; }
        public dynamic PRV_A2_TRIP_CLASS { get; set; }
        public dynamic PRV_A2_DOWNTIME_HRS { get; set; }
        public dynamic PRV_A2_MAJOR_INTRP_FLG { get; set; }
        public dynamic PRV_A2_UNPROD_HRS { get; set; }
        public dynamic PRV_A2_COM_SHUT_HRS { get; set; }
        public dynamic PRV_A2_EQUIP_BRKDOWN { get; set; }
        public dynamic PRV_A2_PROD_LOSS { get; set; }
        public dynamic PRV_A2_UNPROD_NAP { get; set; }
        public dynamic PRV_A2_UNPROD_NG { get; set; }
        public string PRV_A2_BRKDOWN_REASON { get; set; }
        public dynamic PRV_TXT_ON_STREAM_HSR { get; set; }
        public string PRV_A2_TRIP_TYPE_ID { get; set; }
    }

    public class PAS203_2Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string A2_TRANS_DATE { get; set; }
        public string A2_BRKDWN_CAUSE_ID { get; set; }
        public decimal A2_BRKDWN_HRS { get; set; }
        public decimal TXT_TOT_BRKDWN_HRS { get; set; }
        public string A2_DATE_TIME_FROM { get; set; }
        public string PRV_A2_DATE_TIME_FROM { get; set; }
        public string PRV_A2_BRKDWN_CAUSE_ID { get; set; }
        public decimal PRV_A2_BRKDWN_HRS { get; set; }
        public decimal PRV_TXT_TOT_BRKDWN_HRS { get; set; }
    }
}
