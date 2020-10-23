namespace itsppisapi.Models
{
    public class PBS204Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string B_TRANS_DATE { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }
        public string B_WORK_DESC { get; set; }
        public string B_WORK_CODE { get; set; }
        public decimal B_PRINT_SEQ { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_CONTR_CODE { get; set; }
        public string B_RAKE_NO { get; set; }
        public dynamic B_BAGG_QTY_PF1 { get; set; }
        public dynamic B_BAGG_QTY { get; set; }
        public dynamic TXT_TOT_QTY_PF1 { get; set; }
        public dynamic TXT_TOT_QTY { get; set; }
    }
    public class RakeNoModel
    {
        public string B_RAKE_NO { get; set; }
        public string B_UNIT_ID { get; set; }
    }
}
