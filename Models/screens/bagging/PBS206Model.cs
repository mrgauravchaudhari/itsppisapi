namespace itsppisapi.Models {
    public class BagDailyDlts {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string B_TRANS_DATE { get; set; }
        public string B_UNIT_ID { get; set; }

        public decimal B_BAGG_QTY_PF1 { get; set; }
        public decimal B_BAGG_QTY_PF2 { get; set; }
        public decimal B_BAGG_QTY { get; set; }
        public decimal B_BAG_DESP_RAIL_PF1 { get; set; }
        public decimal B_BAG_DESP_RAIL_PF2 { get; set; }
        public decimal B_BAG_DESP_RAIL { get; set; }
        public decimal B_BAG_DESP_ROAD_PF1 { get; set; }
        public decimal B_BAG_DESP_ROAD_PF2 { get; set; }
        public decimal B_BAG_DESP_ROAD { get; set; }
        public decimal B_BAGG_STOCK_PF1 { get; set; }
        public decimal B_BAGG_STOCK_PF2 { get; set; }
        public decimal B_BAGG_STOCK { get; set; }
        public decimal B_BAG_DAMAGED { get; set; }
        public decimal B_BAG_RUPTURES { get; set; }
        public decimal B_EMPTY_BAG_RECD { get; set; }
        public decimal B_EMPTY_BAG_MARKT { get; set; }
        public decimal B_EMPTY_BAG_TESTING { get; set; }
        public decimal B_EMPTY_BAG_STND { get; set; }
        public decimal B_EMPTY_BAG_STOCK_ADJ { get; set; }
        public decimal B_EMPTY_BAG_CONSP { get; set; }
        public decimal B_EMPTY_BAG_STOCK { get; set; }

        public decimal B_BAG_TYPE_ID { get; set; }
        public string TXT_BAG_TYPE { get; set; }
        public decimal TXT_BAG_SIZE { get; set; }

        public decimal TXT_UREA_PROD { get; set; }
        public decimal parm_empty_bag_stk { get; set; }
        public decimal parm_bag_stock { get; set; }
        public decimal parm_bag_stock_pf1 { get; set; }
        public decimal parm_bag_stock_pf2 { get; set; }
        public decimal PF1_STOCK_ADJST_CONST { get; set; }
        public decimal PF2_STOCK_ADJST_CONST { get; set; }
        public decimal STOCK_ADJST_CONST { get; set; }
    }
    public class BagTypeNSize {
        public string B_BAG_TYPE { get; set; }
        public string B_BAG_SIZE { get; set; }
    }
    public class BagDlts {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string B_TRANS_DATE { get; set; }
        public decimal B_USER_ID { get; set; }
        public string B_USER_NAME { get; set; }
        public string B_DATE_MOD { get; set; }

        public decimal B_NC_DESP_RAIL { get; set; }
        public decimal B_DESP_RAIL { get; set; }
        public decimal B_NC_DESP_ROAD { get; set; }
        public decimal B_DESP_ROAD { get; set; }
        public decimal B_NC_DESP_TOTAL { get; set; }
        public decimal B_DESP_TOTAL { get; set; }
        public decimal B_NC_BAGG_QTY { get; set; }
        public decimal B_TOTAL_BAGG_QTY { get; set; }
        public decimal B_TOTAL_BAGG_STOCK { get; set; }
        public decimal B_NC_TRUCK_LOAD { get; set; }
        public decimal B_NO_TRUCK_LOAD { get; set; }
        public decimal B_DIRECT_LDG_QTY_PF1 { get; set; }
        public decimal B_DIRECT_LDG_QTY { get; set; }
        public decimal B_STACK_LDG_QTY_PF1 { get; set; }
        public decimal B_STACK_LDG_QTY { get; set; }

        public decimal B_RET_FRM_DISPATCH { get; set; }
        public decimal B_UREA_RECD_MKTG { get; set; }
        public decimal B_TOTAL_STOCK { get; set; }
        public decimal B_NO_OPEN_RAKES { get; set; }
        public decimal B_NO_CLOSE_RAKES { get; set; }
        public decimal B_NO_TOTAL_RAKES { get; set; }
        public decimal B_ECA_QTY { get; set; }
        public decimal B_NC_ECA_QTY { get; set; }
        public decimal B_NONECA_QTY { get; set; }
        public decimal B_NC_NONECA_QTY { get; set; }
        public decimal B_BULK_STOCK { get; set; }
        public decimal B_NC_BAGG_STOCK { get; set; }
        public decimal B_NC_INPROCESS_QTY { get; set; }

        public decimal B_DESP_RAIL_PF2 { get; set; }
        public decimal B_DESP_RAIL_PF1 { get; set; }
        public decimal B_DESP_ROAD_PF1 { get; set; }
        public decimal B_DESP_ROAD_PF2 { get; set; }
        public decimal B_DESP_TOTAL_PF1 { get; set; }
        public decimal B_DESP_TOTAL_PF2 { get; set; }
        public decimal B_TOTAL_BAGG_QTY_PF1 { get; set; }
        public decimal B_TOTAL_BAGG_QTY_PF2 { get; set; }
        public decimal B_TOTAL_BAGG_STOCK_PF1 { get; set; }
        public decimal B_TOTAL_BAGG_STOCK_PF2 { get; set; }
        public decimal B_NO_TRUCK_LOAD_PF1 { get; set; }
        public decimal B_NO_TRUCK_LOAD_PF2 { get; set; }

        public string B_REMARKS_D { get; set; }
        public string B_REMARKS_M { get; set; }
        public decimal parm_b_bulk_stock { get; set; }
        public decimal parm_b_nc_bagg_stock { get; set; }
        public decimal parm_b_nc_inprocess_qty { get; set; }
    }
}