namespace itsppisapi.Dtos
{
    public class PAS203SaveDto
    {
        public string A2_TRANS_DATE { get; set; }
        public string A2_DMY_FLG { get; set; }
        public decimal A2_USER_ID { get; set; }
        public string A2_DATE_TIME_FROM { get; set; }
        public string A2_DATE_TIME_TO { get; set; }
        public decimal A2_TRIP_TYPE_ID { get; set; }
        public string A2_TRIP_CLASS { get; set; }
        public decimal A2_DOWNTIME_HRS { get; set; }
        public decimal A2_UNPROD_HRS { get; set; }
        public decimal A2_COM_SHUT_HRS { get; set; }
        public string A2_EQUIP_BRKDOWN { get; set; }
        public decimal A2_MAJOR_INTRP_FLG { get; set; }
        public string A2_BRKDOWN_REASON { get; set; }
        public decimal A2_PROD_LOSS { get; set; }
        public decimal A2_UNPROD_NAP { get; set; }
        public decimal A2_UNPROD_NG { get; set; }

    }

    public class PAS203_2SaveDto
    {
        public string A2_TRANS_DATE { get; set; }
        public string A2_DMY_FLG { get; set; }
        public string A2_DATE_TIME_FROM { get; set; }
        public decimal A2_BRKDWN_CAUSE_ID { get; set; }
        public decimal A2_BRKDWN_HRS { get; set; }
    }
}
