namespace itsppisapi.Models
{
    public class POS002Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string OU1_TRANS_DATE { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public dynamic OU1_USER_ID { get; set; }
        public string OU1_USER_NAME { get; set; }
        public string OU1_DATE_MOD { get; set; }
        public string OU1_DEPT_CODE { get; set; }

        public string OU1_CATG_NAME { get; set; }
        public string OU1_MACH_NAME { get; set; }
        public string OU1_PUMP_UNIT_FLG { get; set; }
        public dynamic OU1_MACH_RUNHRS { get; set; }
    }
}
