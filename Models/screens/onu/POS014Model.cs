namespace itsppisapi.Models
{
    public class POS014Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string OU1_TRANS_DATE { get; set; }
        public string OU1_DMY_FLG { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public decimal OU1_AB1_FEED_WATER_INT { get; set; }
        public decimal OU1_AB1_FEED_WATER_CONSP { get; set; }
        public decimal OU1_AB2_FEED_WATER_INT { get; set; }
        public decimal OU1_AB2_FEED_WATER_CONSP { get; set; }
        public decimal OU1_HRSG1_FEED_WATER_INT { get; set; }
        public decimal OU1_HRSG1_FEED_WATER_CONSP { get; set; }
        public decimal OU1_HRSG2_FEED_WATER_INT { get; set; }
        public decimal OU1_HRSG2_FEED_WATER_CONSP { get; set; }
        public string OU1_DATE_MOD { get; set; }
        public decimal OU1_USER_ID { get; set; }
        public string USER_NAME { get; set; }

        // PRV
        public string PRV_OU1_TRANS_DATE { get; set; }
        public decimal PRV_OU1_AB1_FEED_WATER_INT { get; set; }
        public decimal PRV_OU1_AB2_FEED_WATER_INT { get; set; }
        public decimal PRV_OU1_HRSG1_FEED_WATER_INT { get; set; }
        public decimal PRV_OU1_HRSG2_FEED_WATER_INT { get; set; }
    }
}