namespace itsppisapi.Models
{
    public class PGS205Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string AM2_TRANS_DATE { get; set; }
        public decimal AM2_AMM_PROD { get; set; }
        public decimal AM2A_VPR2_TO_AMM2 { get; set; }
        public decimal AM2_TOT_HOT_VAPOR { get; set; }
        public decimal AM2_COLD_AMM_TO_STORAGE { get; set; }
        public decimal AM2_AMM_SUPP_UREA2 { get; set; }
        public decimal AM2_TOT_COLD_HOT { get; set; }
        public dynamic AM2_OPENING_STOCK { get; set; }
        public dynamic AM2_LOGICAL_STOCK { get; set; }
        public decimal AM2_AMM_SALE { get; set; }
        public decimal AM2_RECD_AMM_STORAGE { get; set; }
        public decimal AM2_TFR_AMM_STORAGE { get; set; }
        public dynamic AM2_SILO_OPENING_STOCK { get; set; }
        public dynamic AM2_BAGGED_OPENING_STOCK { get; set; }
        public dynamic AM2_TOTAL_STOCK_SILO_BAGG { get; set; }
        public decimal AM2_TRAINA_PROD { get; set; }
        public decimal AM2_TRAINB_PROD { get; set; }
        public decimal AM2_TOT_TRAINA_TRAINB_PROD { get; set; }
        public decimal AM2_DESP_RAIL { get; set; }
        public decimal AM2_DESP_ROAD { get; set; }
        public decimal AM2_RAIL_ROAD { get; set; }
        public dynamic AM2_SIOL_CL_STK { get; set; }
        public dynamic AM2_BAGG_CL_STK { get; set; }
        public dynamic AM2_TOTAL_CL_BAG_SILO_STK { get; set; }
    }
}
