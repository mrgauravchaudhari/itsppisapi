namespace itsppisapi.Dtos
{
    public class RakeLoadingDeptSaveDto
    {
        public string B_TRANS_DATE { get; set; }
        public string B_RAKE_NO { get; set; }
        public string B_UNIT_ID { get; set; }
        public decimal B_USER_ID { get; set; }

        public string B_RAKE_DESTINATION { get; set; }
        public string B_PLACEMENT_DATE { get; set; }
        public string B_RAKE_DUE_COMPL_DATE { get; set; }
        public string B_COMPLETION_DATE { get; set; }
        public decimal B_ACT_TIME_TAKEN { get; set; }
        public decimal B_FORFEIT_WGN { get; set; }
        public decimal B_NO_REJECTED_WAGONS { get; set; }
        public decimal B_TIME_PLACE_TO_PLACE { get; set; }
        public string B_WAGON_TYPE { get; set; }
        public string B_RAKE_PLANNING_TIME { get; set; }
        public decimal B_TIME_COMP_TO_PLACE { get; set; }
        public decimal B_NO_JUTE_WAGONS_PF1 { get; set; }
        public decimal B_NO_JUTE_WAGONS { get; set; }
        public decimal B_JUTE_QTY_PF1 { get; set; }
        public decimal B_JUTE_QTY { get; set; }
        public decimal B_HDPE_QTY_PF1 { get; set; }
        public decimal B_HDPE_QTY { get; set; }
        public decimal B_QTY_LOADED_PF1 { get; set; }
        public decimal B_QTY_LOADED { get; set; }
        public decimal B_DEMG_HRS_PF1 { get; set; }
        public decimal B_DEMG_HRS { get; set; }
        public decimal B_CFCL_DEMG_HRS_PF1 { get; set; }
        public decimal B_CFCL_DEMG_HRS { get; set; }
        public decimal B_DEMG_AMT_PF1 { get; set; }
        public decimal B_DEMG_AMT { get; set; }
        public decimal B_CFCL_DEMG_AMT_PF1 { get; set; }
        public decimal B_CFCL_DEMG_AMT { get; set; }
        public decimal B_WAIVER_PERCENT_PF1 { get; set; }
        public decimal B_WAIVER_PERCENT { get; set; }
        public string B_DEMG_REMARK { get; set; }
    }
    public class RakeWagonDltsSaveDto
    {
        public string B_TRANS_DATE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_RAKE_NO { get; set; }
        public string B_WAGON_TYPE { get; set; }
        public decimal B_NO_WAGONS_PF1 { get; set; }
        public decimal B_NO_WAGONS { get; set; }
        public decimal TXT_RK_WGN_LDG_SUM_PF1 { get; set; }
        public decimal TXT_RK_WGN_LDG_SUM { get; set; }
    }
    public class ContrRKWgnDltsSaveDto
    {
        public string B_TRANS_DATE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_RAKE_NO { get; set; }
        public string B_CONTR_CODE { get; set; }
        public string B_WAGON_TYPE { get; set; }
        public decimal B_NO_WAGONS_PF1 { get; set; }
        public decimal B_NO_WAGONS { get; set; }
    }
    public class ContractorDemurrageSaveDto
    {
        public string B_TRANS_DATE { get; set; }
        public string B_UNIT_ID { get; set; }
        public string B_RAKE_NO { get; set; }
        public string B_CONTR_CODE { get; set; }
        public decimal B_DEMG_AMT { get; set; }
        public decimal B_DEMG_HRS { get; set; }
    }
}
