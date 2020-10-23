namespace itsppisapi.Dtos
{
    public class PBS203ParamDto
    {
        public string IN_DATE { get; set; }
        public string B_SHIFT_NO { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_CONTR_CODE { get; set; }
    }
    public class PBS203Dto
    {
        public string B_UNIT_ID { get; set; }
        public string B_TRANS_DATE { get; set; }
        public string B_SHIFT_NO { get; set; }
        public string B_CONTR_CODE { get; set; }
        public string B_WORK_CODE { get; set; }
        public decimal B_BAGG_QTY { get; set; }
        public decimal B_PRINT_SEQ { get; set; }
        public decimal B_BAGG_QTY_PF1 { get; set; }
        public decimal B_BAGG_QTY_PF2 { get; set; }
    }
}
