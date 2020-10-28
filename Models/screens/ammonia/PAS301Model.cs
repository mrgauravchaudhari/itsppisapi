namespace itsppisapi.Models
{
    public class PAS301Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string A3_TRANS_DATE { get; set; }
        public decimal A3_USER_ID { get; set; }
        public string ENTERED_BY { get; set; }
        public string MODIFIED_BY { get; set; }
        public string ENTERED_DATETIME { get; set; }
        public string MODIFY_DATETIME { get; set; }

        // ---------------------PPT_AM3_ACT_UCT--------------------------
        public decimal A3_ACT_CIRC_FLOW { get; set; }
        public decimal A3_ACT_MAKEUP { get; set; }
        public decimal A3_ACT_SUPPLY_TEMP { get; set; }
        public decimal A3_ACT_RETURN_TEMP { get; set; }
        public decimal A3_ACT_DRY_BULB_TEMP { get; set; }
        public decimal A3_ACT_WET_BULB_TEMP { get; set; }
        public decimal A3_ACT_WET_APPWACH { get; set; }
        public decimal A3_ACT_RANGE { get; set; }
        public decimal A3_ACT_HEAT_DUTY { get; set; }
        public decimal A3_ACT_THERMAL_EFF { get; set; }
        public decimal A3_UCT_CIRC_FLOW { get; set; }
        public decimal A3_UCT_MAKEUP { get; set; }
        public decimal A3_UCT_SUPPLY_TEMP { get; set; }
        public decimal A3_UCT_RETURN_TEMP { get; set; }
        public decimal A3_UCT_DRY_BULB_TEMP { get; set; }
        public decimal A3_UCT_WET_BULB_TEMP { get; set; }
        public decimal A3_UCT_WET_APPWACH { get; set; }
        public decimal A3_UCT_RANGE { get; set; }
        public decimal A3_UCT_HEAT_DUTY { get; set; }
        public decimal A3_UCT_THERMAL_EFF { get; set; }

        // ---------------------AM3_CHEMICAL_CONS_DTL---------------------
        public decimal A3_HSD_RECEIPT { get; set; }
        public decimal A3_H2SO4_RECEIPT { get; set; }
        public decimal A3_HCL_RECEIPT { get; set; }
        public decimal A3_NAOCL_RECEIPT { get; set; }
        public decimal A3_NaClO2_RECEIPT { get; set; }
        public decimal A3_aMDEA_RECEIPT { get; set; }
        public decimal A3_Antifoam_RECEIPT { get; set; }
        public decimal A3_O2_SCAVENGER_RECEIPT { get; set; }
        public decimal A3_PH_BOOSTER_RECEIPT { get; set; }
        public decimal A3_PHOF_PHAPE_RECEIPT { get; set; }
        public string A3_CHEMICAL_REMARK { get; set; }
        public decimal A3_HSD_TANK { get; set; }
        public decimal A3_H2SO4_TANK { get; set; }
        public decimal A3_HCL_TANK { get; set; }
        public decimal A3_NAOCL_TANK { get; set; }
        public decimal A3_NaClO2_TANK { get; set; }
        public decimal A3_HSD_STK { get; set; }
        public decimal A3_H2SO4_STK { get; set; }
        public decimal A3_HCL_STK { get; set; }
        public decimal A3_NAOCL_STK { get; set; }
        public decimal A3_NaClO2_STK { get; set; }
        public decimal A3_aMDEA_STK { get; set; }
        public decimal A3_Antifoam_STK { get; set; }
        public decimal A3_O2_SCAVENGER_STK { get; set; }
        public decimal A3_PH_BOOSTER_STK { get; set; }
        public decimal A3_PHOF_PHAPE_STK { get; set; }
        public decimal A3_HSD_CONSP { get; set; }
        public decimal A3_H2SO4_CONSP { get; set; }
        public decimal A3_HCL_CONSP { get; set; }
        public decimal A3_NAOCL_CONSP { get; set; }
        public decimal A3_NaClO2_CONSP { get; set; }
        public decimal A3_aMDEA_CONSP { get; set; }
        public decimal A3_Antifoam_CONSP { get; set; }
        public decimal A3_O2_SCAVENGER_CONSP { get; set; }
        public decimal A3_PH_BOOSTER_CONSP { get; set; }
        public decimal A3_PHOF_PHAPE_CONSP { get; set; }
        public decimal A3_HSD_OUTSIDE_RECEIPT { get; set; }
        public decimal A3_HSD_OUTSIDE_TANK { get; set; }
        public decimal A3_HSD_OUTSIDE_STK { get; set; }
        public decimal A3_HSD_OUTSIDE_CONSP { get; set; }
        public decimal A3_PH_BOOSTER_B5780M_RECEIPT { get; set; }
        public decimal A3_PH_BOOSTER_B5780M_STK { get; set; }
        public decimal A3_PH_BOOSTER_B5780M_CONSP { get; set; }

        // -------------PRV--------AM3_CHEMICAL_CONS_DTL-------------
        public decimal PRV_A3_HSD_STK { get; set; }
        public decimal PRV_A3_H2SO4_STK { get; set; }
        public decimal PRV_A3_HCL_STK { get; set; }
        public decimal PRV_A3_NAOCL_STK { get; set; }
        public decimal PRV_A3_NaClO2_STK { get; set; }
        public decimal PRV_A3_aMDEA_STK { get; set; }
        public decimal PRV_A3_Antifoam_STK { get; set; }
        public decimal PRV_A3_O2_SCAVENGER_STK { get; set; }
        public decimal PRV_A3_PH_BOOSTER_STK { get; set; }
        public decimal PRV_A3_PHOF_PHAPE_STK { get; set; }
        public decimal PRV_A3_HSD_OUTSIDE_STK { get; set; }
        public decimal PRV_A3_PH_BOOSTER_B5780M_STK { get; set; }

        // -------------------PPT_AM3_CO2_SHEET--------------------
        public decimal A3_PRS_CO2_TO_UR_INT { get; set; }
        public decimal A3_TEMP_CO2_TO_UR_INT { get; set; }
        public decimal A3_TOT_CO2_TO_UR_INT { get; set; }
        public decimal A3_PRS_SURPLUS_SYN_GAS_INT { get; set; }
        public decimal A3_TEMP_SURPLUS_SYN_GAS_INT { get; set; }
        public decimal A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT { get; set; }
        public decimal A3_SYNGAS_EXPORT_TO_GP1_GP2 { get; set; }
        public decimal A3_CO2_EXPORT_TO_GP1 { get; set; }
        public decimal A3_CO2_EXPORT_TO_GP2 { get; set; }
        public decimal A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT { get; set; }
        public decimal A3_PASSIVATION_AIR_TO_UR_INT { get; set; }
        public decimal A3_PRS_WASTE_FUEL_GAS_INT { get; set; }
        public decimal A3_TEMP_WASTE_FUEL_GAS_INT { get; set; }
        public decimal A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT { get; set; }
        public decimal A3_PRS_CO2_TO_UR_INT_DIFF { get; set; }
        public decimal A3_TEMP_CO2_TO_UR_INT_DIFF { get; set; }
        public decimal A3_TOT_CO2_TO_UR_INT_DIFF { get; set; }
        public decimal A3_PRS_SURPLUS_SYN_GAS_INT_DIFF { get; set; }
        public decimal A3_TEMP_SURPLUS_SYN_GAS_INT_DIFF { get; set; }
        public decimal A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT_DIFF { get; set; }
        public decimal A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT_DIFF { get; set; }
        public decimal A3_PASSIVATION_AIR_TO_UR_INT_DIFF { get; set; }
        public decimal A3_PRS_WASTE_FUEL_GAS_INT_DIFF { get; set; }
        public decimal A3_TEMP_WASTE_FUEL_GAS_INT_DIFF { get; set; }
        public decimal A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT_DIFF { get; set; }

        // -------------PRV--------------PPT_AM3_CO2_SHEET------------------------------
        public decimal PRV_A3_PRS_CO2_TO_UR_INT { get; set; }
        public decimal PRV_A3_TEMP_CO2_TO_UR_INT { get; set; }
        public decimal PRV_A3_TOT_CO2_TO_UR_INT { get; set; }
        public decimal PRV_A3_PRS_SURPLUS_SYN_GAS_INT { get; set; }
        public decimal PRV_A3_TEMP_SURPLUS_SYN_GAS_INT { get; set; }
        public decimal PRV_A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT { get; set; }
        public decimal PRV_A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT { get; set; }
        public decimal PRV_A3_PASSIVATION_AIR_TO_UR_INT { get; set; }
        public decimal PRV_A3_PRS_WASTE_FUEL_GAS_INT { get; set; }
        public decimal PRV_A3_TEMP_WASTE_FUEL_GAS_INT { get; set; }
        public decimal PRV_A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT { get; set; }

        // -------------------------PPT_AM3_ELE_POWER_RECEIPT-----------------------
        public decimal A3_SL_SLN_PUMP_A_INT { get; set; }
        public decimal A3_SL_SLN_PUMP_B_INT { get; set; }
        public decimal A3_SL_SLN_PUMP_C_INT { get; set; }
        public decimal A3_LS_PUMP_A_INT { get; set; }
        public decimal A3_LS_PUMP_B_INT { get; set; }
        public decimal A3_HP_BFW_PUMP_A_INT { get; set; }
        public decimal A3_ID_FAN_MOTOR_A_INT { get; set; }
        public decimal A3_ID_FAN_MOTOR_B_INT { get; set; }
        public decimal A3_LTS_SU_BLOWER_INT { get; set; }
        public decimal A3_SL_SLN_CIRCULATING_PUMP_A_INT { get; set; }
        public decimal A3_SL_SLN_CIRCULATING_PUMP_B_INT { get; set; }
        public decimal A3_FEED_GAS_COMP_VFD_INT { get; set; }
        public decimal A3_FEED_GAS_COMP_DOL_INT { get; set; }
        public decimal A3_FEED_GAS_COMP { get; set; }
        public decimal A3_STANDBY_AIR_COMP_INT { get; set; }
        public decimal A3_101_JTG_JM11_INT { get; set; }
        public decimal A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT { get; set; }
        public decimal A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT { get; set; }
        public decimal A3_PURIFIER_EXPANDER_GEN_INT { get; set; }
        public decimal A3_SL_SLN_PUMP_A_INT_DIFF { get; set; }
        public decimal A3_SL_SLN_PUMP_B_INT_DIFF { get; set; }
        public decimal A3_SL_SLN_PUMP_C_INT_DIFF { get; set; }
        public decimal A3_LS_PUMP_A_INT_DIFF { get; set; }
        public decimal A3_LS_PUMP_B_INT_DIFF { get; set; }
        public decimal A3_HP_BFW_PUMP_A_INT_DIFF { get; set; }
        public decimal A3_ID_FAN_MOTOR_A_INT_DIFF { get; set; }
        public decimal A3_ID_FAN_MOTOR_B_INT_DIFF { get; set; }
        public decimal A3_LTS_SU_BLOWER_INT_DIFF { get; set; }
        public decimal A3_SL_SLN_CIRCULATING_PUMP_A_INT_DIFF { get; set; }
        public decimal A3_SL_SLN_CIRCULATING_PUMP_B_INT_DIFF { get; set; }
        public decimal A3_FEED_GAS_COMP_VFD_INT_DIFF { get; set; }
        public decimal A3_FEED_GAS_COMP_DOL_INT_DIFF { get; set; }
        public decimal A3_STANDBY_AIR_COMP_INT_DIFF { get; set; }
        public decimal A3_101_JTG_JM11_INT_DIFF { get; set; }
        public decimal A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT_DIFF { get; set; }
        public decimal A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT_DIFF { get; set; }
        public decimal A3_PURIFIER_EXPANDER_GEN_INT_DIFF { get; set; }
        public decimal DIS_TOT_AMM_POWER { get; set; }

        // -------------PRV-----------------PPT_AM3_ELE_POWER_RECEIPT---------------------------
        public decimal PRV_A3_SL_SLN_PUMP_A_INT { get; set; }
        public decimal PRV_A3_SL_SLN_PUMP_B_INT { get; set; }
        public decimal PRV_A3_SL_SLN_PUMP_C_INT { get; set; }
        public decimal PRV_A3_LS_PUMP_A_INT { get; set; }
        public decimal PRV_A3_LS_PUMP_B_INT { get; set; }
        public decimal PRV_A3_HP_BFW_PUMP_A_INT { get; set; }
        public decimal PRV_A3_ID_FAN_MOTOR_A_INT { get; set; }
        public decimal PRV_A3_ID_FAN_MOTOR_B_INT { get; set; }
        public decimal PRV_A3_LTS_SU_BLOWER_INT { get; set; }
        public decimal PRV_A3_SL_SLN_CIRCULATING_PUMP_A_INT { get; set; }
        public decimal PRV_A3_SL_SLN_CIRCULATING_PUMP_B_INT { get; set; }
        public decimal PRV_A3_FEED_GAS_COMP_VFD_INT { get; set; }
        public decimal PRV_A3_FEED_GAS_COMP_DOL_INT { get; set; }
        public decimal PRV_A3_STANDBY_AIR_COMP_INT { get; set; }
        public decimal PRV_A3_101_JTG_JM11_INT { get; set; }
        public decimal PRV_A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT { get; set; }
        public decimal PRV_A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT { get; set; }
        public decimal PRV_A3_PURIFIER_EXPANDER_GEN_INT { get; set; }

        // ----------------------PPT_AM3_MACHINERY_RUNNING_HR-----------------------------------
        public decimal A3_MRH_101_JGT_FIRED_HRS_INT { get; set; }
        public decimal A3_MRH_SL_SLN_PUMP_A_INT { get; set; }
        public decimal A3_MRH_SL_SLN_PUMP_B_INT { get; set; }
        public decimal A3_MRH_SL_SLN_PUMP_C_INT { get; set; }
        public decimal A3_MRH_LS_PUMP_A_INT { get; set; }
        public decimal A3_MRH_LS_PUMP_B_INT { get; set; }
        public decimal A3_MRH_HP_BFW_PUMP_TURBINE { get; set; }
        public decimal A3_MRH_HP_BFW_PUMP_A_INT { get; set; }
        public decimal A3_MRH_ID_FAN_MOTOR_A_INT { get; set; }
        public decimal A3_MRH_ID_FAN_MOTOR_B_INT { get; set; }
        public decimal A3_SYN_GAS_COMP_INT { get; set; }
        public decimal A3_MRH_REFRIGERATION_COMP { get; set; }
        public decimal A3_MRH_FEED_GAS_COMP_VFD_INT { get; set; }
        public decimal A3_MRH_FEED_GAS_COMP_DOL_INT { get; set; }
        public decimal A3_MRH_STANDBY_AIR_COMP_INT { get; set; }
        public decimal A3_MRH_ACT_PUMP_7801A_INT { get; set; }
        public decimal A3_MRH_ACT_PUMP_7801B_INT { get; set; }
        public decimal A3_MRH_UCT_PUMP_7808A_INT { get; set; }
        public decimal A3_MRH_UCT_PUMP_7808B_INT { get; set; }
        public decimal A3_MRH_PURIFIER_EXPANDER_GEN { get; set; }

        // --------------------PPT_AM3_NG_SHEET1-----------------------------------------
        public decimal A3_PRS_NG_INT { get; set; }
        public decimal A3_TEMP_NG_INT { get; set; }
        public decimal A3_TOT_NG_INT { get; set; }
        public decimal A3_PRS_NG_AS_GT_FUEL_INT { get; set; }
        public decimal A3_TEMP_NG_AS_GT_FUEL_INT { get; set; }
        public decimal A3_GT_FUEL_NG_INT { get; set; }
        public decimal A3_PRS_NG_AS_REFMR_FUEL_INT { get; set; }
        public decimal A3_TEMP_NG_AS_REFMR_FUEL_INT { get; set; }
        public decimal A3_NG_FUEL_TO_PRIMRY_REFMR_INT { get; set; }
        public decimal A3_PRS_NG_AS_SUPRHEATER_FUEL_INT { get; set; }
        public decimal A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT { get; set; }
        public decimal A3_NG_FUEL_TO_SUPRHEATER_INT { get; set; }
        public decimal A3_NG_FUEL_TO_STATUPHEATER_INT { get; set; }
        public decimal A3_NG_FEED_INT { get; set; }
        public decimal A3_PRS_NG_INT_DIFF { get; set; }
        public decimal A3_TEMP_NG_INT_DIFF { get; set; }
        public decimal A3_TOT_NG_INT_DIFF { get; set; }
        public decimal A3_PRS_NG_AS_GT_FUEL_INT_DIFF { get; set; }
        public decimal A3_TEMP_NG_AS_GT_FUEL_INT_DIFF { get; set; }
        public decimal A3_GT_FUEL_NG_INT_DIFF { get; set; }
        public decimal A3_PRS_NG_AS_REFMR_FUEL_INT_DIFF { get; set; }
        public decimal A3_TEMP_NG_AS_REFMR_FUEL_INT_DIFF { get; set; }
        public decimal A3_NG_FUEL_TO_PRIMRY_REFMR_INT_DIFF { get; set; }
        public decimal A3_PRS_NG_AS_SUPRHEATER_FUEL_INT_DIFF { get; set; }
        public decimal A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT_DIFF { get; set; }
        public decimal A3_NG_FUEL_TO_SUPRHEATER_INT_DIFF { get; set; }
        public decimal A3_NG_FUEL_TO_STATUPHEATER_INT_DIFF { get; set; }
        public decimal A3_NG_FEED_INT_DIFF { get; set; }
        public decimal A3_TOT_NG_CONSP { get; set; }
        public decimal A3_GT_FUEL_NG_CONSP { get; set; }
        public decimal A3_NG_FUEL_TO_PRIMRY_REFMR_CONSP { get; set; }
        public decimal A3_NG_FUEL_TO_SUPRHEATER_CONSP { get; set; }
        public decimal A3_NG_FUEL_TO_STATUPHEATER_CONSP { get; set; }
        public decimal A3_NG_FUEL_TO_FLARE_STACK_CONSP { get; set; }
        public decimal A3_NG_FEED_CONSP { get; set; }
        public decimal A3_TOT_FUEL_CONSP { get; set; }

        // -------------PRV----------PPT_AM3_NG_SHEET1----------------------------------
        public decimal PRV_A3_PRS_NG_INT { get; set; }
        public decimal PRV_A3_TEMP_NG_INT { get; set; }
        public decimal PRV_A3_TOT_NG_INT { get; set; }
        public decimal PRV_A3_PRS_NG_AS_GT_FUEL_INT { get; set; }
        public decimal PRV_A3_TEMP_NG_AS_GT_FUEL_INT { get; set; }
        public decimal PRV_A3_GT_FUEL_NG_INT { get; set; }
        public decimal PRV_A3_PRS_NG_AS_REFMR_FUEL_INT { get; set; }
        public decimal PRV_A3_TEMP_NG_AS_REFMR_FUEL_INT { get; set; }
        public decimal PRV_A3_NG_FUEL_TO_PRIMRY_REFMR_INT { get; set; }
        public decimal PRV_A3_PRS_NG_AS_SUPRHEATER_FUEL_INT { get; set; }
        public decimal PRV_A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT { get; set; }
        public decimal PRV_A3_NG_FUEL_TO_SUPRHEATER_INT { get; set; }
        public decimal PRV_A3_NG_FUEL_TO_STATUPHEATER_INT { get; set; }
        public decimal PRV_A3_NG_FEED_INT { get; set; }

        // ------------------------------PPT_AM3_NG_SHEET2---------------------------------------
        public decimal A3_GAIL_METER_A_INT { get; set; }
        public decimal A3_GAIL_METER_B_INT { get; set; }
        public decimal A3_NG_MOLECULAR_WT { get; set; }
        public decimal A3_NG_GCV { get; set; }
        public decimal A3_NG_CARBON_NUMBER { get; set; }
        public decimal A3_NG_LCV { get; set; }
        public decimal A3_GSPN_SPOT_RLING_MMBTU { get; set; }
        public decimal A3_GAIL_LT_RLING_1_9_MMBTU { get; set; }
        public decimal A3_GAIL_LT_RLING_0_5_MMBTU { get; set; }
        public decimal A3_IOCL_LT_RLING_MMBTU { get; set; }
        public decimal A3_SPOT_GAS_GSPC_MMBTU { get; set; }
        public decimal A3_NG_EXPORT_TO_GP_I { get; set; }
        public decimal A3_NG_EXPORT_TO_GP_II { get; set; }
        public decimal A3_LCV_AS_PER_CFCL_LAB { get; set; }
        public decimal A3_IOCL_SPOT_GAS_MMBTU { get; set; }
        public decimal A3_FALL_BACK_GAS_MMBTU { get; set; }
        public decimal A3_TOT_NG_RECV { get; set; }
        public decimal A3_GSPN_SPOT_RLING_ALLOC { get; set; }
        public decimal A3_GAIL_LT_RLING_1_9_ALLOC { get; set; }
        public decimal A3_GAIL_LT_RLING_0_5_ALLOC { get; set; }
        public decimal A3_IOCL_LT_RLING_ALLOC { get; set; }
        public decimal A3_SPOT_GAS_GSPC_ALLOC { get; set; }
        public decimal A3_NG_AMM { get; set; }
        public decimal A3_AMM_FUEL { get; set; }
        public decimal A3_AMM_FEED_BY_BALANCE { get; set; }
        public decimal A3_NG_IMPORT_FROM_GP_I { get; set; }
        public decimal A3_NG_IMPORT_FROM_GP_II { get; set; }
        public decimal A3_IOCL_SPOT_GAS_ALLOC { get; set; }
        public decimal A3_FALL_BACK_GAS_ALLOC { get; set; }
        public decimal A3_GSPN_SPOT_RLING_RECEIPT { get; set; }
        public decimal A3_GAIL_LT_RLING_1_9_RECEIPT { get; set; }
        public decimal A3_GAIL_LT_RLING_0_5_RECEIPT { get; set; }
        public decimal A3_IOCL_LT_RLING_RECEIPT { get; set; }
        public decimal A3_SPOT_GAS_GSPC_RECEIPT { get; set; }
        public decimal A3_IOCL_SPOT_GAS_RECEIPT { get; set; }
        public decimal A3_FALL_BACK_GAS_RECEIPT { get; set; }
        public decimal DIS_NG_CONS_GTG3_HRSG3 { get; set; }

        // --------PRIORITY-------------------
        public string A3_GSPN_SPOT_RLING_MMBTU_PRIORITY { get; set; }
        public string A3_GAIL_LT_RLING_1_9_MMBTU_PRIORITY { get; set; }
        public string A3_GAIL_LT_RLING_0_5_MMBTU_PRIORITY { get; set; }
        public string A3_IOCL_LT_RLING_MMBTU_PRIORITY { get; set; }
        public string A3_SPOT_GAS_GSPC_MMBTU_PRIORITY { get; set; }
        public string A3_IOCL_SPOT_GAS_MMBTU_PRIORITY { get; set; }
        public string A3_FALL_BACK_GAS_MMBTU_PRIORITY { get; set; }

        public string PRIORITY_TAG1 { get; set; }
        public string PRIORITY_TAG2 { get; set; }
        public string PRIORITY_TAG3 { get; set; }
        public string PRIORITY_TAG4 { get; set; }
        public string PRIORITY_TAG5 { get; set; }
        public string PRIORITY_TAG6 { get; set; }
        public string PRIORITY_TAG7 { get; set; }

        // -----------------------PPT_AM3_NITROGEN_PROD---------------------------
        public decimal A3_HPN_INT { get; set; }
        public decimal A3_PSA_NITROGEN_GEN_INT { get; set; }
        public decimal A3_PSA_NITROGEN_TO_AMM_3_INT { get; set; }
        public decimal A3_PSA_NITROGEN_TO_UR_3_INT { get; set; }
        public decimal A3_PSA_NITROGEN_TO_OSBL { get; set; }
        public decimal A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT { get; set; }
        public decimal A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT { get; set; }
        public decimal A3_HPN_INT_DIFF { get; set; }
        public decimal A3_PSA_NITROGEN_GEN_INT_DIFF { get; set; }
        public decimal A3_PSA_NITROGEN_TO_AMM_3_INT_DIFF { get; set; }
        public decimal A3_PSA_NITROGEN_TO_UR_3_INT_DIFF { get; set; }
        public decimal A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT_DIFF { get; set; }
        public decimal A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT_DIFF { get; set; }
        public decimal A3_PSA_NITROGEN_TO_AMM_I { get; set; }
        public decimal A3_PSA_NITROGEN_TO_AMM_II { get; set; }
        public decimal A3_IA_FROM_ONU_GP_III { get; set; }

        // -------------PRV-------PPT_AM3_NITROGEN_PROD-------------------------------------
        public decimal PRV_A3_HPN_INT { get; set; }
        public decimal PRV_A3_PSA_NITROGEN_GEN_INT { get; set; }
        public decimal PRV_A3_PSA_NITROGEN_TO_AMM_3_INT { get; set; }
        public decimal PRV_A3_PSA_NITROGEN_TO_UR_3_INT { get; set; }
        public decimal PRV_A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT { get; set; }
        public decimal PRV_A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT { get; set; }

        //---------------------PPT_AM3_PRODUCTION_SHEET--------------------------------
        public decimal A3_ON_STREAM_HRS { get; set; }
        public decimal A3_AMM_SALE { get; set; }
        public decimal A3_HOT_AMM_TO_UR_INT { get; set; }
        public decimal A3_HOT_AMM_TO_UR_INT_DIFF { get; set; }
        public decimal A3_COLD_AMM_TO_AMM_STORAGE_INT { get; set; }
        public decimal A3_COLD_AMM_TO_AMM_STORAGE_INT_DIFF { get; set; }
        public decimal A3_AMM_VAPOR_FROM_STORAGE_INT { get; set; }
        public decimal A3_AMM_VAPOR_FROM_STORAGE_INT_DIFF { get; set; }
        public decimal A3_AMM_PROD { get; set; }
        public decimal A3_COLD_SUPPLY_TO_UR { get; set; }
        public decimal A3_TOT_AMM_TO_UR { get; set; }
        public decimal A3_STK_TRSFER_FROM_GP3_TO_GP1 { get; set; }
        public decimal A3_STK_TRSFER_FROM_GP3_TO_GP2 { get; set; }
        public decimal A3_STK_TRSFER_FROM_GP1_TO_GP3 { get; set; }
        public decimal A3_STK_TRSFER_FROM_GP2_TO_GP3 { get; set; }
        public decimal A3_AMM_3_LOGICAL_STK { get; set; }
        public decimal A3_CAPACITY_UTILIZATION { get; set; }
        public string A3_REMARK { get; set; }
        public string A3_MON_REMARK { get; set; }
        public decimal DIS_AMMI_LOGICAL_STK { get; set; }
        public decimal DIS_AMMII_LOGICAL_STK { get; set; }
        public decimal DIS_TOT_AMM_STK { get; set; }

        // -------------PRV----------------PPT_AM3_PRODUCTION_SHEET--------------------------
        public decimal PRV_A3_HOT_AMM_TO_UR_INT { get; set; }
        public decimal PRV_A3_COLD_AMM_TO_AMM_STORAGE_INT { get; set; }
        public decimal PRV_A3_AMM_VAPOR_FROM_STORAGE_INT { get; set; }

        // ------------------------PPT_AM3_SPECIFIC_CONS-------------------------------------
        public decimal A3_AMM_SP_CONSP_FEED_GAS { get; set; }
        public decimal A3_AMM_SP_CONSP_FUEL_GAS { get; set; }
        public decimal A3_AMM_SP_CONSP_TOT_GAS { get; set; }
        public decimal A3_AMM_SP_CONSP_MP_STEAM_EXPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_IP_STEAM_EXPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_LP_STEAM_IMPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_POLISHED_WATER_IMPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_APC_EXPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_TURBINE_COND_EXPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_TOT_COND_EXPORT { get; set; }
        public decimal A3_AMM_SP_CONSP_PWR_CONSP_ACT { get; set; }
        public decimal A3_AMM_SP_CONSP_GROSS_PWR_AMM { get; set; }
        public decimal A3_AMM_SP_CONSP_ACT_CT_MAKEUP { get; set; }
        public decimal A3_AMM_SP_CONSP_SPECIFIC_AMM { get; set; }
        public decimal A3_UR_SP_CONSP_SPECIFIC_FEED { get; set; }
        public decimal A3_UR_SP_CONSP_SPECIFIC_FUEL { get; set; }
        public decimal A3_UR_SP_CONSP_SPECIFIC_TOT_FEED_FUEL { get; set; }
        public decimal A3_UR_SP_CONSP_ONU_FUEL { get; set; }
        public decimal A3_UR_SP_CONSP_TOT_GAS { get; set; }
        public decimal A3_UR_SP_CONSP_MP_STEAM { get; set; }
        public decimal A3_UR_SP_CONSP_IP_STEAM { get; set; }
        public decimal A3_UR_SP_CONSP_LP_STEAM { get; set; }
        public decimal A3_UR_SP_CONSP_PWR_CONSP_UCT { get; set; }
        public decimal A3_UR_SP_CONSP_NET_PWR_UR { get; set; }
        public decimal A3_UR_SP_CONSP_UCT_CT_MAKEUP { get; set; }
        public decimal A3_UR_SP_CONSP_POLISH_WATER { get; set; }

        // ---------------------PPT_AM3_SPECIFIC_ENERGY----------------------------
        public decimal A3_SP_ENG_FEED_GAS { get; set; }
        public decimal A3_SP_ENG_FUEL_GAS { get; set; }
        public decimal A3_SP_ENG_TOT_FEED_FUEL { get; set; }
        public decimal A3_SP_ENG_CREDIT_FOR_MP_STEAM_EXPORT { get; set; }
        public decimal A3_SP_ENG_CREDIT_FOR_IP_STEAM_EXPORT { get; set; }
        public decimal A3_SP_ENG_LP_STEAM { get; set; }
        public decimal A3_SP_ENG_PWR_AMM { get; set; }
        public decimal A3_SP_ENG_ACT_ENG { get; set; }
        public decimal A3_SP_ENG_NET_ENG_AMM { get; set; }
        public decimal A3_SP_ENG_UR_ENG_FEED_FUEL { get; set; }
        public decimal A3_SP_ENG_CREDIT_FOR_KS_STEAM_TO_GP1 { get; set; }
        public decimal A3_SP_ENG_CREDIT_FOR_PWR_EXPORT_VCU { get; set; }
        public decimal A3_SP_ENG_UR { get; set; }
        public decimal A3_SP_ENG_ALLOC_FOR_CV_UR_ENG { get; set; }
        public decimal A3_SP_ENG_NET_ENG_UR { get; set; }
        public decimal A3_SP_ENG_RSEB_PWR_CONSP { get; set; }

        // --------------------PPT_AM3_STEAM-----------------------------------
        public decimal A3_MP_STEAM_EXPORT_TO_UR_INT { get; set; }
        public decimal A3_MP_STEAM_EXPORT_TO_OSBL_INT { get; set; }
        public decimal A3_MP_STEAM_TO_ACT_TP7801A_INT { get; set; }
        public decimal A3_RUN_HRS_FOR_ACT_TA_INT { get; set; }
        public decimal A3_MP_STEAM_TO_ACT_TP7801B_INT { get; set; }
        public decimal A3_RUN_HRS_FOR_ACT_TB_INT { get; set; }
        public decimal A3_MP_STEAM_TO_UCT_TP7808A_INT { get; set; }
        public decimal A3_RUN_HRS_FOR_UCT_TA_INT { get; set; }
        public decimal A3_MP_STEAM_TO_UCT_TP7808B_INT { get; set; }
        public decimal A3_RUN_HRS_FOR_UCT_TB_INT { get; set; }
        public decimal A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT { get; set; }
        public decimal A3_IP_STEAM_EXPORT_TO_CT_INT { get; set; }
        public decimal A3_MP_STEAM_EXPORT_TO_UR_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_EXPORT_TO_OSBL_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_ACT_TP7801A_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_ACT_TP7801B_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_UCT_TP7808A_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_UCT_TP7808B_INT_DIFF { get; set; }
        public decimal A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT_DIFF { get; set; }
        public decimal A3_IP_STEAM_EXPORT_TO_CT_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_IMPORT_FROM_OSBL { get; set; }
        public decimal A3_MP_STEAM_IMPORT_FROM_OSBL_INT { get; set; }
        public decimal A3_MP_STEAM_IMPORT_FROM_OSBL_INT_DIFF { get; set; }
        public decimal A3_NET_MP_STEAM_EXPORT_TO_OSBL { get; set; }
        public decimal A3_TOT_MP_STEAM_EXPORT { get; set; }
        public decimal A3_ACT_T_COND { get; set; }
        public decimal A3_UCT_MP_STEAM_CONSP { get; set; }
        public decimal A3_UCT_T_COND { get; set; }
        public decimal A3_NET_IP_STEAM_EXPORT { get; set; }
        public decimal A3_LP_STEAM_TO_RO_ZLD { get; set; }
        public decimal A3_ACT_CONSP { get; set; }
        public decimal A3_UCT_CONSP { get; set; }
        public decimal A3_TOT_CT_STEAM_CONSP { get; set; }
        public decimal DIS_IP_STEAM_ROZLD { get; set; }

        // -------------PRV---------PPT_AM3_STEAM-----------------------------------
        public decimal PRV_A3_MP_STEAM_EXPORT_TO_UR_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_EXPORT_TO_OSBL_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_ACT_TP7801A_INT { get; set; }
        public decimal PRV_A3_RUN_HRS_FOR_ACT_TA_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_ACT_TP7801B_INT { get; set; }
        public decimal PRV_A3_RUN_HRS_FOR_ACT_TB_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_UCT_TP7808A_INT { get; set; }
        public decimal PRV_A3_RUN_HRS_FOR_UCT_TA_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_UCT_TP7808B_INT { get; set; }
        public decimal PRV_A3_RUN_HRS_FOR_UCT_TB_INT { get; set; }
        public decimal PRV_A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT { get; set; }
        public decimal PRV_A3_IP_STEAM_EXPORT_TO_CT_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_IMPORT_FROM_OSBL_INT { get; set; }

        // ----------------------PPT_AM3_STEAM_CONS----------------------------
        public decimal A3_GEN_FROM_141_D_INT { get; set; }
        public decimal A3_BFW_TO_ATTEMPERATOR_INT { get; set; }
        public decimal A3_TOT_HP_STEAM { get; set; }
        public decimal A3_HP_STEAM_TO_103_JT_INT { get; set; }
        public decimal A3_HP_STEAM_TO_105_JT_INT { get; set; }
        public decimal A3_HP_STEAM_TO_172_C_INT { get; set; }
        public decimal A3_HP_STEAM_TO_LETDOWN { get; set; }
        public decimal A3_GEN_FROM_103_JT_INT { get; set; }
        public decimal A3_BFW_TO_HP_MP_PRDS { get; set; }
        public decimal A3_NET_MP_STEAM_GEN_BY_AMM { get; set; }
        public decimal A3_STEAM_TO_PRIMRY_REFMR_INT { get; set; }
        public decimal A3_MP_STEAM_TO_104_JT_INT { get; set; }
        public decimal A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT { get; set; }
        public decimal A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT { get; set; }
        public decimal A3_MP_STEAM_TO_EXCHANGERS_INT { get; set; }
        public decimal A3_MP_STEAM_TO_IP_LETDOWN { get; set; }
        public decimal A3_GEN_FROM_130_L_INT { get; set; }
        public decimal A3_DESUPERHEAT_WATER { get; set; }
        public decimal A3_TOT_IP_STEAM { get; set; }
        public decimal A3_IP_CONSP { get; set; }
        public decimal A3_GEN_FROM_141_D_INT_DIFF { get; set; }
        public decimal A3_BFW_TO_ATTEMPERATOR_INT_DIFF { get; set; }
        public decimal A3_HP_STEAM_TO_103_JT_INT_DIFF { get; set; }
        public decimal A3_HP_STEAM_TO_105_JT_INT_DIFF { get; set; }
        public decimal A3_GEN_FROM_103_JT_INT_DIFF { get; set; }
        public decimal A3_STEAM_TO_PRIMRY_REFMR_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_104_JT_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT_DIFF { get; set; }
        public decimal A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT_DIFF { get; set; }
        public decimal A3_GEN_FROM_130_L_INT_DIFF { get; set; }
        public decimal DIS_GEN_105_JT { get; set; }
        public decimal DIS_FORM_MP_LETDOWN { get; set; }
        public decimal DIS_FROM_HP_MP_PRDS { get; set; }

        // -------------PRV--------------PPT_AM3_STEAM_CONS------------------------------
        public decimal PRV_A3_GEN_FROM_141_D_INT { get; set; }
        public decimal PRV_A3_BFW_TO_ATTEMPERATOR_INT { get; set; }
        public decimal PRV_A3_HP_STEAM_TO_103_JT_INT { get; set; }
        public decimal PRV_A3_HP_STEAM_TO_105_JT_INT { get; set; }
        public decimal PRV_A3_GEN_FROM_103_JT_INT { get; set; }
        public decimal PRV_A3_STEAM_TO_PRIMRY_REFMR_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_104_JT_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT { get; set; }
        public decimal PRV_A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT { get; set; }
        public decimal PRV_A3_GEN_FROM_130_L_INT { get; set; }

        // ---------------------PPT_AM3_WATER_DIS---------------------------------
        public decimal A3_ACT_MAKEUP_INT { get; set; }
        public decimal A3_ACT_MAKEUP_FROM_RO { get; set; }
        public decimal A3_UCT_MAKEUP_INT { get; set; }
        public decimal A3_POLISHED_WATER_TO_AMM_INT { get; set; }
        public decimal A3_ACT_TO_OSBL { get; set; }
        public decimal A3_ACT_TO_OSBL_INT { get; set; }
        public decimal A3_ACT_TO_OSBL_INT_DIFF { get; set; }
        public decimal A3_ACT_CIRC_FLOW_INT { get; set; }
        public decimal A3_ACT_CIRC_FLOW_INT_DIFF { get; set; }
        public decimal A3_UCT_CIRC_FLOW_INT { get; set; }
        public decimal A3_UCT_CIRC_FLOW_INT_DIFF { get; set; }
        public decimal A3_ACT_BLOWDOWN_INT { get; set; }
        public decimal A3_UCT_BLOWDOWN_INT { get; set; }
        public decimal A3_TOT_BLOWDOWN { get; set; }
        public decimal A3_SSF_PIT_PUMP_RUN_HRS { get; set; }
        public decimal A3_EFFL_FROM_SSF_PIT { get; set; }
        public decimal A3_OILY_WATER_PUMP_RUN_HRS { get; set; }
        public decimal A3_OILY_WATER_TO_OSBL { get; set; }
        public decimal A3_ACT_MAKEUP_INT_DIFF { get; set; }
        public decimal A3_NET_ACT_MAKEUP { get; set; }
        public decimal A3_UCT_MAKEUP_INT_DIFF { get; set; }
        public decimal A3_UCT_MAKEUP_FROM_RO { get; set; }
        public decimal A3_NET_UCT_MAKEUP { get; set; }
        public decimal A3_POLISHED_WATER_TO_AMM_INT_DIFF { get; set; }
        public decimal A3_ACT_BLOWDOWN_INT_DIFF { get; set; }
        public decimal A3_UCT_BLOWDOWN_INT_DIFF { get; set; }
        public decimal DIS_PERMEATE_REC_RO { get; set; }
        public decimal A3_SSP_PIT_TOT_EFF_TRSFER_INT { get; set; }
        public decimal A3_SSP_PIT_TOT_EFF_TRSFER_INT_DIFF { get; set; }

        // -------------PRV------------PPT_AM3_WATER_DIS-----------------------------------
        public decimal PRV_A3_ACT_MAKEUP_INT { get; set; }
        public decimal PRV_A3_UCT_MAKEUP_INT { get; set; }
        public decimal PRV_A3_POLISHED_WATER_TO_AMM_INT { get; set; }
        public decimal PRV_A3_ACT_TO_OSBL_INT { get; set; }
        public decimal PRV_A3_ACT_CIRC_FLOW_INT { get; set; }
        public decimal PRV_A3_UCT_CIRC_FLOW_INT { get; set; }
        public decimal PRV_A3_ACT_BLOWDOWN_INT { get; set; }
        public decimal PRV_A3_UCT_BLOWDOWN_INT { get; set; }
        public decimal PRV_A3_SSP_PIT_TOT_EFF_TRSFER_INT { get; set; }
    }
    public class PAS301ModelDV
    {
        public dynamic O3_KS_TO_MP_LETDOWN_DIFF { get; set; }
        public dynamic O3_MP_STEAM_HRSG3_BFW_TP7601A_DIFF { get; set; }
        public dynamic U3_COLD_AMM_RECV_INT_DIFF { get; set; }
        public dynamic UN_TCD_CONS { get; set; }
        public dynamic U3_IP_STEAM_IMPORT_INT_DIFF { get; set; }
        public dynamic O3_PERMEATE_GP3 { get; set; }
        public dynamic U3_TC_EXPORT_INT_DIFF { get; set; }
        public dynamic O3_TURBINE_COND_DIFF { get; set; }
        public dynamic E3_TOT_11_KV_SUPPLY_TO_CT { get; set; }
        public dynamic E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF { get; set; }
        public dynamic E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF { get; set; }
        public dynamic E3_AMM_415_V_PMCC_1_INT_DIFF { get; set; }
        public dynamic E3_AMM_415_V_PMCC_2_INT_DIFF { get; set; }
        public dynamic E3_3_3_KV_UNACCOUNTED { get; set; }
        public dynamic E3_11_KV_PWR_GP3_UNACCOUNTED { get; set; }
        public dynamic E3_TOT_AMM_PWR_CONSP { get; set; }
        public dynamic O3_GP3_ONU_TOTAL_CONSP { get; set; }
        public dynamic U3_TOT_UR_PROD { get; set; }
        public dynamic UN_MPSE_CONS { get; set; }
        public dynamic UN_IPSE_CONS { get; set; }
        public dynamic Eq_NG_Per_MWh_of_Power { get; set; }
        public dynamic O3_NG_RECV_GP1_FOR_GTG3_HRSG3_CONSP { get; set; }
        public dynamic O3_NG_RECV_GP3_FOR_GTG3_HRSG4_CONSP { get; set; }
        public dynamic GPI_NCV { get; set; }
        public dynamic GPII_NCV { get; set; }
        public dynamic Total_ng_alloc { get; set; }
        public dynamic A3_HSDLS_CONS { get; set; }
        public dynamic A3_SALS_CONS { get; set; }
        public dynamic A3_HALS_CONS { get; set; }
        public dynamic A3_SHCLS_CONS { get; set; }
        public dynamic A3_SCLS_CONS { get; set; }
        public dynamic A3_BFWD_CONS { get; set; }
        public dynamic A3_HPMPL_CONS { get; set; }
        public dynamic A3_MPIPL_CONS { get; set; }
        public dynamic A3_SGBD_CONS { get; set; }
        public dynamic A3_IPBD_CONS { get; set; }
        public dynamic A3_TTVL_CONS { get; set; }
        public dynamic A3_SSF_RC_CONS { get; set; }
        public dynamic A3_OWP_RC_CONS { get; set; }
        public dynamic A3_SP_ENG_ALLOC_FOR_CV_UR_ENG_CV { get; set; }
        public dynamic A3_SP_ENG_RSEB_PWR_CONSP_CV { get; set; }
        public dynamic A3_AMM_3_LOGICAL_OP_STK { get; set; }
    }
    public class FuncNCVModel
    {
        public dynamic NCV_GP3 { get; set; }
    }
    public class FuncNcvOnuNgModel
    {
        public dynamic NCV_ONU_NG { get; set; }
    }
}
