namespace itsppisapi.Dtos
{
    public class PUS301SaveDto
    {
        public string TDATE { get; set; }

        // -------------PPT_UR3_MACHINERY_RUNNING_HOUR-------------------------------
        public decimal U3_MRH_TA_AMM_FEED_PUMP_A_INT { get; set; }
        public decimal U3_MRH_TA_AMM_FEED_PUMP_B_INT { get; set; }
        public decimal U3_MRH_TA_CARB_FEED_PUMP_A_INT { get; set; }
        public decimal U3_MRH_TA_CARB_FEED_PUMP_B_INT { get; set; }
        public decimal U3_MRH_TA_CO2_COMP_INT { get; set; }
        public decimal U3_MRH_TB_AMM_FEED_PUMP_A_INT { get; set; }
        public decimal U3_MRH_TB_AMM_FEED_PUMP_B_INT { get; set; }
        public decimal U3_MRH_TB_CARB_FEED_PUMP_A_INT { get; set; }
        public decimal U3_MRH_TB_CARB_FEED_PUMP_B_INT { get; set; }
        public decimal U3_MRH_TB_CO2_COMP_INT { get; set; }
        public decimal U3_MRH_TA_AMM_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_MRH_TA_AMM_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_MRH_TA_CARB_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_MRH_TA_CARB_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_MRH_TA_CO2_COMP_INT_DIFF { get; set; }
        public decimal U3_MRH_TB_AMM_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_MRH_TB_AMM_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_MRH_TB_CARB_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_MRH_TB_CARB_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_MRH_TB_CO2_COMP_INT_DIFF { get; set; }

        // ------------------------PPT_UR3_RECORD_OF_SPILLED_UREA---------------------------------
        public decimal U3_SOLUTION_RECV_FROM_UPH { get; set; }
        public decimal U3_SPILLED_DISSOLVED { get; set; }
        public decimal U3_OILY_WATER_PUMP_RUN_HRS { get; set; }

        // ---------------------PPT_UR3_SPECIFIC_CONSUMPTION-------------------------------------------
        public decimal U3_TA_SP_CONSP_MP_STEAM { get; set; }
        public decimal U3_TA_SP_CONSP_IP_STEAM { get; set; }
        public decimal U3_TA_SP_CONSP_LP_STEAM { get; set; }
        public decimal U3_TA_SP_CONSP_T_COND_EXPORT { get; set; }
        public decimal U3_TA_SP_CONSP_P_COND_EXPORT { get; set; }
        public decimal U3_TA_SP_CONSP_STEAM_COND_EXPORT { get; set; }
        public decimal U3_TA_SP_CONSP_NPC_UR { get; set; }
        public decimal U3_TA_SP_CONSP_PWR_CONSP_UCT { get; set; }
        public decimal U3_TA_SP_CONSP_MP_UCT_CWM { get; set; }
        public decimal U3_TB_SP_CONSP_MP_STEAM { get; set; }
        public decimal U3_TB_SP_CONSP_IP_STEAM { get; set; }
        public decimal U3_TB_SP_CONSP_LP_STEAM { get; set; }
        public decimal U3_TB_SP_CONSP_T_COND_EXPORT { get; set; }
        public decimal U3_TB_SP_CONSP_P_COND_EXPORT { get; set; }
        public decimal U3_TB_SP_CONSP_STEAM_COND_EXPORT { get; set; }
        public decimal U3_TB_SP_CONSP_NPC_UR { get; set; }
        public decimal U3_TB_SP_CONSP_PWR_CONSP_UCT { get; set; }
        public decimal U3_TB_SP_CONSP_MP_UCT_CWM { get; set; }
        public decimal U3_TOT_SP_CONSP_MP_STEAM { get; set; }
        public decimal U3_TOT_SP_CONSP_IP_STEAM { get; set; }
        public decimal U3_TOT_SP_CONSP_LP_STEAM { get; set; }
        public decimal U3_TOT_SP_CONSP_T_COND_EXPORT { get; set; }
        public decimal U3_TOT_SP_CONSP_P_COND_EXPORT { get; set; }
        public decimal U3_TOT_SP_CONSP_STEAM_COND_EXPORT { get; set; }
        public decimal U3_TOT_SP_CONSP_NPC_UR { get; set; }
        public decimal U3_TOT_SP_CONSP_PWR_CONSP_UCT { get; set; }
        public decimal U3_TOT_SP_CONSP_MP_UCT_CWM { get; set; }

        // ------------------------- PPT_UR3_SPECIFIC_ENERGY -----------------------
        public decimal U3_SP_ENG_MP_STEAM { get; set; }
        public decimal U3_SP_ENG_IP_STEAM { get; set; }
        public decimal U3_SP_ENG_LP_STEAM { get; set; }
        public decimal U3_SP_ENG_PWR_CONSP_INCLUDING_UCT { get; set; }
        public decimal U3_SP_ENG_COMMON_FACILITIES { get; set; }
        public decimal U3_SP_ENG { get; set; }
        public decimal U3_SP_ENG_CREDIT_FOR_MP_STEAM { get; set; }
        public decimal U3_SP_ENG_CREDIT_FOR_LP_STEAM { get; set; }

        // --------------------- PPT_UR3_UREA_EL_PO_RECEIPT_CON ---------------------------
        public decimal U3_TA_AMM_FEED_PUMP_A_INT { get; set; }
        public decimal U3_TA_AMM_FEED_PUMP_B_INT { get; set; }
        public decimal U3_TA_CARB_FEED_PUMP_A_INT { get; set; }
        public decimal U3_TA_CARB_FEED_PUMP_B_INT { get; set; }
        public decimal U3_TB_AMM_FEED_PUMP_A_INT { get; set; }
        public decimal U3_TB_AMM_FEED_PUMP_B_INT { get; set; }
        public decimal U3_TB_CARB_FEED_PUMP_A_INT { get; set; }
        public decimal U3_TB_CARB_FEED_PUMP_B_INT { get; set; }
        public decimal U3_HYDR_PUMP_A_INT { get; set; }
        public decimal U3_HYDR_PUMP_B_INT { get; set; }
        public decimal U3_TOT_UR_PWR { get; set; }
        public decimal U3_UCT_PWR { get; set; }
        public decimal U3_NET_UR_PWR { get; set; }
        public decimal U3_TA_AMM_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_TA_AMM_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_TA_CARB_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_TA_CARB_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_TB_AMM_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_TB_AMM_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_TB_CARB_FEED_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_TB_CARB_FEED_PUMP_B_INT_DIFF { get; set; }
        public decimal U3_HYDR_PUMP_A_INT_DIFF { get; set; }
        public decimal U3_HYDR_PUMP_B_INT_DIFF { get; set; }

        // ------------------------------ PPT_UR3_UREA_PRODUCTION_REMARK ---------------------------------
        public decimal U3_TOT_UR_PROD { get; set; }
        public decimal U3_OVERALL_UR_CO2_CONSP { get; set; }
        public decimal U3_CO2_FACTOR { get; set; }
        public decimal U3_EFF_FACTOR { get; set; }
        public decimal U3_OVERALL_OPERATING_FACTOR { get; set; }
        public decimal U3_STREAM_3A_CO2_CONSP_INT { get; set; }
        public decimal U3_STREAM_3A_ON_STREAM_HRS { get; set; }
        public decimal U3_STREAM_3A_UR_PROD { get; set; }
        public decimal U3_STREAM_3A_AMM_CONSP { get; set; }
        public decimal U3_STREAM_3A_OPERATING_FACTOR { get; set; }
        public decimal U3_STREAM_3B_CO2_CONSP_INT { get; set; }
        public decimal U3_STREAM_3B_ON_STREAM_HRS { get; set; }
        public decimal U3_STREAM_3B_UR_PROD { get; set; }
        public decimal U3_STREAM_3B_AMM_CONSP { get; set; }
        public decimal U3_STREAM_3B_OPERATING_FACTOR { get; set; }
        public string U3_DAILY_REMARK { get; set; }
        public string U3_MONTHLY_REMARK { get; set; }
        public decimal U3_COLD_AMM_RECV { get; set; }
        public decimal U3_OVERALL_AMM_CONSP { get; set; }
        public decimal U3_STREAM_3A_CO2_CONSP_INT_DIFF { get; set; }
        public decimal U3_STREAM_3B_CO2_CONSP_INT_DIFF { get; set; }
        public decimal U3_COLD_AMM_RECV_INT_DIFF { get; set; }

        // -------------------------- PPT_UR3_WATER_N_STEAM_DETAILS -------------------
        public decimal U3_TC_EXPORT_INT { get; set; }
        public decimal U3_TOT_COND_EXPORT { get; set; }
        public decimal U3_MP_STEAM_TA_CO2_COMP_INT { get; set; }
        public decimal U3_MP_STEAM_TB_CO2_COMP_INT { get; set; }
        public decimal U3_TOTAL_MP_STEAM_CONSP { get; set; }
        public decimal U3_PWR_UCT { get; set; }
        public decimal U3_IP_STEAM_IMPORT_INT { get; set; }
        public decimal U3_MP_STEAM_UR_EFFL_HYDR_INT { get; set; }
        public decimal U3_LP_STEAM_STRIPPER_INT { get; set; }
        public decimal U3_MP_STEAM_CREDIT_GP1_ET_INT { get; set; }
        public decimal U3_MP_STEAM_CREDIT_GP2_ET_INT { get; set; }
        public decimal U3_LP_STEAM_CREDIT_GP1_ET_INT { get; set; }
        public decimal U3_LP_STEAM_CREDIT_GP2_ET_INT { get; set; }
        public decimal U3_WASTE_WATER_GUARD_POND_INT { get; set; }
        public decimal U3_WASTE_WATER_HOLDING_POND_INT { get; set; }
        public decimal U3_MP_STEAM_UR_HYDR { get; set; }
        public decimal U3_TC_EXPORT_INT_DIFF { get; set; }
        public decimal U3_MP_STEAM_TA_CO2_COMP_INT_DIFF { get; set; }
        public decimal U3_MP_STEAM_TB_CO2_COMP_INT_DIFF { get; set; }
        public decimal U3_IP_STEAM_IMPORT_INT_DIFF { get; set; }
        public decimal U3_MP_STEAM_UR_EFFL_HYDR_INT_DIFF { get; set; }
        public decimal U3_LP_STEAM_STRIPPER_INT_DIFF { get; set; }
        public decimal U3_WASTE_WATER_GUARD_POND_INT_DIFF { get; set; }
        public decimal U3_WASTE_WATER_HOLDING_POND_INT_DIFF { get; set; }
        public decimal U3_MP_STEAM_UR_HYDR_INT_DIFF { get; set; }

        public string ENTERED_BY { get; set; }
        public string MODIFIED_BY { get; set; }
    }
}
