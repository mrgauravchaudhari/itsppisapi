namespace itsppisapi.Dtos
{
    public class BagTypeDto
    {
        public string B_BAG_TYPE { get; set; }
        public decimal B_BAG_SIZE { get; set; }
        public string B_BAG_DESC { get; set; }
        public decimal B_SERVICE_CONST { get; set; }
        public decimal B_BAG_WEIGHT { get; set; }
        public decimal B_USER_ID { get; set; }
        public char B_BAG_ACTIVE_FLAG { get; set; }
    }
    public class DefectTypeDto
    {
        public string B_DEFECT_TYPE_NAME { get; set; }
        public decimal B_USER_ID { get; set; }
        public decimal B_DEFECT_GROUP { get; set; }
    }
    public class ContractorDto
    {
        public string B_CONTR_CODE { get; set; }
        public string B_UNIT_ID { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_CONTR_NAME { get; set; }
        public string B_CONTR_ADD { get; set; }
    }
    public class WorkDto
    {
        public string B_WORK_CODE { get; set; }
        public string B_CONTR_CODE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_WORK_DESC { get; set; }
        public string B_LOADING_TYPE { get; set; }
        public decimal B_PRINT_SEQ { get; set; }
        public string B_ACTIVE_FLG { get; set; }
        public decimal B_WORK_RATE { get; set; }
        public string B_UOM { get; set; }
        public decimal B_USER_ID { get; set; }
    }
    public class WagonTypeDto
    {
        public string B_WAGON_TYPE { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_WAGON_DESC { get; set; }
    }
}
