namespace itsppisapi.Models
{
    public class BagTypeModel
    {
        public decimal B_BAG_TYPE_ID { get; set; }
        public string B_BAG_TYPE { get; set; }
        public decimal B_BAG_SIZE { get; set; }
        public decimal B_SERVICE_CONST { get; set; }
        public decimal B_BAG_WEIGHT { get; set; }
        public string B_BAG_DESC { get; set; }
        public string B_BAG_ACTIVE_FLAG { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }
    }

    public class DefectTypeModel
    {
        public decimal B_DEFECT_TYPE_ID { get; set; }
        public string B_DEFECT_TYPE_NAME { get; set; }
        public decimal B_DEFECT_GROUP { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }
    }

    public class ContractorModel
    {
        public string B_CONTR_CODE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_CONTR_NAME { get; set; }
        public string B_CONTR_ADD { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }
    }

    public class WorkModel
    {
        public string B_WORK_CODE { get; set; }
        public string B_WORK_DESC { get; set; }
        public string B_LOADING_TYPE { get; set; }
        public string B_CONTR_CODE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string DSP_B_CONTR_NAME { get; set; }
        public decimal B_PRINT_SEQ { get; set; }
        public string B_ACTIVE_FLG { get; set; }
        public string B_UOM { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }
    }

    public class WagonTypeModel
    {
        public string B_WAGON_TYPE { get; set; }
        public string B_WAGON_DESC { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }
    }
}
