namespace itsppisapi.Dtos
{
    public class POS019SaveDto
    {
        public string OU1_TRANS_DATE { get; set; }
        public string OU1_TIME { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public string OU1_RAKE_NO { get; set; }
        public decimal OU1_USER_ID { get; set; }
        public decimal OU1_TEMP { get; set; }
        public decimal OU1_DENSITY { get; set; }
        public decimal OU1_DENSITY_15C { get; set; }
        public decimal OU1_BR_NO { get; set; }
        public decimal OU1_OLEFINES { get; set; }
        public decimal OU1_AROMATICS { get; set; }
        public decimal OU1_IBP { get; set; }
        public decimal OU1_NRA_50 { get; set; }
        public decimal OU1_NRA_95 { get; set; }
        public decimal OU1_FBP { get; set; }
        public decimal OU1_CH_RATIO { get; set; }
        public decimal OU1_NAP_NET_CV { get; set; }
        public decimal OU1_NAP_GROSS_CV { get; set; }
        public decimal OU1_SULPHUR { get; set; }
        public decimal OU1_RESIDUE { get; set; }
        public decimal OU1_RECOVERY { get; set; }
        public decimal OU1_LIQ_REMAIN { get; set; }
        public decimal OU1_LOSS { get; set; }
        public decimal OU1_NAP_IOC_CV { get; set; }
        public decimal OU1_NRA_5 { get; set; }
        public decimal OU1_NRA_10 { get; set; }
        public decimal OU1_NRA_90 { get; set; }
        public decimal OU1_VAPOR_PRESSURE { get; set; }
        public decimal OU1_CHLORIDE { get; set; }
        public decimal OU1_GCV_CALCULATE { get; set; }
        public decimal OU1_H_CALCULATE { get; set; }
        public decimal OU1_NCV_CALCULATE { get; set; }
        public decimal OU1_NCV_CORRECT { get; set; }
    }

    public class POS019ParamDto
    {
        public string IN_DATE { get; set; }
        public string IN_UNIT { get; set; }
        public string Btn { get; set; }
    }
}
