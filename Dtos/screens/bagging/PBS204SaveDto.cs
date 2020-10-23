namespace itsppisapi.Dtos
{
    public class PBS204Dto
    {
        public string TransactionDate { get; set; }
        //public string ContractorCode { get; set; }
        //public string UnitId { get; set; }
        public char Btn { get; set; }
    }
    public class PBS204SaveDto
    {
        public string B_TRANS_DATE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_USER_ID { get; set; }
        public string B_RAKE_NO { get; set; }
        public string B_CONTR_CODE { get; set; }
        public string B_WORK_CODE { get; set; }
        public decimal B_BAGG_QTY { get; set; }
        public decimal B_PRINT_SEQ { get; set; }
        public decimal B_BAGG_QTY_PF1 { get; set; }
    }
}
