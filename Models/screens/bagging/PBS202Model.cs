namespace itsppisapi.Models
{
    public class PBS202Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public dynamic TXT_TOT_DAMAGED { get; set; }
        public dynamic TXT_TOT_RUPTURED { get; set; }
        public string B_TRANS_DATE { get; set; }
        public decimal B_DEFCT_TYPE_ID { get; set; }
        public dynamic B_BAG_TYPE_ID { get; set; }
        public string B_BAG_TYPE { get; set; }
        public dynamic B_BAG_SIZE { get; set; }
        public dynamic B_NO_BAGS_PF1 { get; set; }
        public dynamic B_NO_BAGS_PF2 { get; set; }
        public dynamic B_NO_BAGS_PF3 { get; set; }
        public dynamic B_NO_BAGS { get; set; }
        public dynamic B_AMOUNT { get; set; }
        public dynamic B_DMY_FLG { get; set; }
        public dynamic TXT_DAMAGED { get; set; }
        public dynamic TXT_DAMAGED_PF2 { get; set; }
        public dynamic TXT_DAMAGED_PF3 { get; set; }
        public dynamic TXT_RUPTURED { get; set; }
        public dynamic TXT_RUPTURED_PF2 { get; set; }
        public dynamic TXT_RUPTURED_PF3 { get; set; }
        public string B_DATE_MOD { get; set; }
        public string B_USER_NAME { get; set; }
    }
}
