namespace itsppisapi.Dtos
{
    public class POS002SaveDto
    {
        public string OU1_TRANS_DATE { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public decimal OU1_USER_ID { get; set; }
        public string OU1_DEPT_CODE { get; set; }

        public string OU1_MACH_NAME { get; set; }
        public string OU1_CATG_NAME { get; set; }
        public string OU1_PUMP_UNIT_FLG { get; set; }
        public decimal OU1_MACH_RUNHRS { get; set; }
    }
    public class POS002Dto
    {
        public string TransactionDate { get; set; }
        public string DeptCode { get; set; }
        public string UnitId { get; set; }
        public string Btn { get; set; }
    }
}
