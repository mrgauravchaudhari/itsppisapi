namespace itsppisapi.Dtos
{
    public class POS301SaveDto
    {
        public string TDATE { get; set; }
        public string O3_DMY_FLG { get; set; }
        public decimal O3_USER_ID { get; set; }
        public decimal O3_PRS_NG_TO_GT3_INT { get; set; }
        public decimal O3_TEMP_NG_TO_GT3_INT { get; set; }
        public decimal O3_TOTAL_NG_TO_GT3_INT { get; set; }
        public decimal O3_PRS_NG_HRSG_FUEL_INT { get; set; }
        public decimal O3_TEMP_NG_HRSG_FUEL_INT { get; set; }
        public decimal O3_NG_HRSG_FUEL_INT { get; set; }
        public decimal O3_TOTAL_NG_GP3_ONU_METERED_INT { get; set; }
        public decimal O3_PRS_NG_TO_GT3_DIFF { get; set; }
        public decimal O3_TEMP_NG_TO_GT3_DIFF { get; set; }
        public decimal O3_TOTAL_NG_TO_GT3_DIFF { get; set; }
        public decimal O3_PRS_NG_HRSG_FUEL_DIFF { get; set; }
        public decimal O3_TEMP_NG_HRSG_FUEL_DIFF { get; set; }
        public decimal O3_NG_HRSG_FUEL_DIFF { get; set; }
        public decimal O3_TOTAL_NG_GP3_ONU_METERED_DIFF { get; set; }
        public decimal O3_TOTAL_NG_TO_GT3_CONSP { get; set; }
        public decimal O3_NG_HRSG_FUEL_CONSP { get; set; }
        public decimal O3_GP3_ONU_TOTAL_CONSP { get; set; }
        public decimal O3_NG_RECV_GP1_FOR_GTG3_HRSG3_CONSP { get; set; }
        public decimal O3_NG_RECV_GP3_FOR_GTG3_HRSG4_CONSP { get; set; }
        public decimal O3_TOTAL_NG_GP3_ONU_METERED_CONSP { get; set; }
        public decimal O3_RUN_HRS_INT { get; set; }
        public decimal O3_RW_32_LINE_INT { get; set; }
        public decimal O3_RW_24_LINE_INT { get; set; }
        public decimal O3_TOTAL_RW_RECEIPT { get; set; }
        public decimal O3_RWR4_LEVEL_INT { get; set; }
        public decimal O3_RWR4_STK { get; set; }
        public decimal O3_RW_SUPPLY_WPT3_INT { get; set; }
        public decimal O3_RWR_LOSS { get; set; }
        public decimal O3_IMPORT_FROM_RWR_II_III { get; set; }
        public decimal O3_TOTAL_RW_SUPPLY_WPT3 { get; set; }
        public decimal O3_RW_32_LINE_INT_DIFF { get; set; }
        public decimal O3_RW_24_LINE_INT_DIFF { get; set; }
        public decimal O3_RWR4_LEVEL_DIFF { get; set; }
        public decimal O3_RW_SUPPLY_WPT3_INT_DIFF { get; set; }
        public decimal O3_TOTAL_RW_RECEIPT_CONSP { get; set; }
        public decimal O3_RWR4_LEVEL_CONSP { get; set; }
        public decimal O3_RWR4_STK_CONSP { get; set; }
        public decimal O3_RW_SUPPLY_WPT3_INT_CONSP { get; set; }
        public decimal O3_RWR_LOSS_CONSP { get; set; }
        public decimal O3_TOTAL_RW_SUPPLY_WPT3_CONSP { get; set; }
        public decimal O3_RWR4_CALC_STK { get; set; }
        public decimal O3_FW_PUMP_A_RUN_HRS { get; set; }
        public decimal O3_FW_PUMP_B_RUN_HRS { get; set; }
        public decimal O3_FILTER_WATER_PROD { get; set; }
        public decimal O3_T7912_LEVEL_INT { get; set; }
        public decimal O3_MAKEUP_SPG_CT_INT { get; set; }
        public decimal O3_FILTER_WATER_DM_STREAM_D_INT { get; set; }
        public decimal O3_FILTER_BW_CONSP_WPT3_INT { get; set; }
        public decimal O3_BLOWDOWN_EFF_INT { get; set; }
        public decimal O3_FILTER_WATER_DM_STREAM_D_DIFF { get; set; }
        public decimal O3_T7912_LEVEL_STK { get; set; }
        public decimal O3_MAKEUP_SPG_CT_DIFF { get; set; }
        public decimal O3_FILTER_WATER_EXPORT { get; set; }
        public decimal O3_FILTER_WATER_CONSP { get; set; }
        public decimal O3_WPT3_FILTER_BW_ETP_INT { get; set; }
        public decimal O3_TANK_T7924_LEVEL_INT { get; set; }
        public decimal O3_AMM_PROCESS_COND_INT { get; set; }
        public decimal O3_UR_PROCESS_COND_INT { get; set; }
        public decimal O3_TURBINE_COND_INT { get; set; }
        public decimal O3_STEAM_COND_INT { get; set; }
        public decimal O3_TOTAL_COND { get; set; }
        public decimal O3_COND_DRAIN_INT { get; set; }
        public decimal O3_CPU_REG_LOSS_INT { get; set; }
        public decimal O3_DMW_TANK_T7928_LEVEL_INT { get; set; }
        public decimal O3_COND_TO_DM_TANK { get; set; }
        public decimal O3_DM_WATER_FROM_DM_STREAM_INT { get; set; }
        public decimal O3_TOTAL_DM_WATER_SUPPLY { get; set; }
        public decimal O3_DM_WATER_TO_GP3_MBS { get; set; }
        public decimal O3_UR_PROCESS_COND_DIFF { get; set; }
        public decimal O3_TURBINE_COND_DIFF { get; set; }
        public decimal O3_STEAM_COND_DIFF { get; set; }
        public decimal O3_DM_WATER_FROM_DM_STREAM_DIFF { get; set; }
        public decimal O3_TANK_T7924_STK { get; set; }
        public decimal O3_DMW_TANK_T7928_STK { get; set; }
        public decimal O3_AMM_PROCESS_COND_DIFF { get; set; }
        public decimal O3_DM_WATER_F7901B_FQI_407B_INT { get; set; }
        public decimal O3_DM_WATER_F7901A_FQI_407A_INT { get; set; }
        public decimal O3_CPU_DM_WATER_ERROR { get; set; }
        public decimal O3_DM_WATER_F7901C_FQI_407C_INT { get; set; }
        public decimal O3_DM_WATER_FROM_GP2 { get; set; }
        public decimal O3_DM_WATER_FROM_GP1 { get; set; }
        public decimal O3_DM_WATER_F7901A_FQI_407A_DIFF { get; set; }
        public decimal O3_DM_WATER_TO_GP2 { get; set; }
        public decimal O3_DM_WATER_TO_GP1 { get; set; }
        public decimal O3_DM_WATER_F7901B_FQI_407B_DIFF { get; set; }
        public decimal O3_DM_WATER_F7901D_FQI_407D_DIFF { get; set; }
        public decimal O3_DM_WATER_F7901D_FQI_407D_INT { get; set; }
        public decimal O3_DM_WATER_F7901C_FQI_407C_DIFF { get; set; }
        public decimal O3_COND_IMPORT_FROM_GP1_2_INT { get; set; }
        public decimal O3_DM_WATER_REG_LOSS_INT { get; set; }
        public decimal O3_PW_TANK_T7929_LEVEL_INT { get; set; }
        public decimal O3_DIRECT_TC_INTO_PWT_INT { get; set; }
        public decimal O3_PW_SUPPLY { get; set; }
        public decimal O3_PW_SUPPLY_GP3 { get; set; }
        public decimal O3_PW_HRSG3_DEAERATOR_T7929 { get; set; }
        public decimal O3_PW_HRSG3_DEAERATOR_UNIT1_INT { get; set; }
        public decimal O3_TOTAL_PW_HRSG3_DEAERATOR { get; set; }
        public decimal O3_PW_SUPPLY_GP3_DIFF { get; set; }
        public decimal O3_PW_TANK_T7929_STK { get; set; }
        public decimal O3_PW_EXPORT_GP1_2 { get; set; }
        public decimal O3_POLISH_WATER_ERROR { get; set; }
        public decimal O3_KS_STEAM_GEN_HRSG3_INT { get; set; }
        public decimal O3_KS_TO_MP_LETDOWN_INT { get; set; }
        public decimal O3_BFW_ATTEMPERATOR_INT { get; set; }
        public decimal O3_KS_STEAM_TO_VENT_INT { get; set; }
        public decimal O3_KS_STEAM_SUPPLY_GP1_2 { get; set; }
        public decimal O3_MP_STEAM_HRSG3_BFW_TP7601A_INT { get; set; }
        public decimal O3_MP_STEAM_VENT_INT { get; set; }
        public decimal O3_MP_STEAM_SUPPLY_GP1_2 { get; set; }
        public decimal O3_LP_STEAM_CBD_VESSEL { get; set; }
        public decimal O3_LP_STEAM_DEAERATOR_INT { get; set; }
        public decimal O3_LP_STEAM_GP1_2 { get; set; }
        public decimal O3_LP_STEAM_VAM_INT { get; set; }
        public decimal O3_LP_STEAM_GCS_INT { get; set; }
        public decimal O3_KS_STEAM_GEN_HRSG3_DIFF { get; set; }
        public decimal O3_KS_TO_MP_LETDOWN_DIFF { get; set; }
        public decimal O3_MP_STEAM_HRSG3_BFW_TP7601A_DIFF { get; set; }
        public decimal O3_LP_STEAM_GCS_DIFF { get; set; }
        public decimal O3_LP_STEAM_VAM_DIFF { get; set; }
        public decimal O3_BFW_ATTEMPERATOR_DIFF { get; set; }
        public decimal O3_WPT_ALUM_LEVEL { get; set; }
        public decimal O3_WPT_POLYEL_LEVEL { get; set; }
        public decimal O3_WPT_HCL_LEVEL { get; set; }
        public decimal O3_WPT_NACIO2_LEVEL { get; set; }
        public decimal O3_DM_HCL_LEVEL { get; set; }
        public decimal O3_DM_NAOH_LEVEL { get; set; }
        public decimal O3_ROZLD_HCL_LEVEL { get; set; }
        public decimal O3_ROZLD_NAOH_LEVEL { get; set; }
        public decimal O3_ROZLD_NAOCL_LEVEL { get; set; }
        public decimal O3_ROZLD_HNO3_LEVEL { get; set; }
        public decimal O3_WPT_ALUM_OS { get; set; }
        public decimal O3_WPT_PAC_OS { get; set; }
        public decimal O3_WPT_POLYE_OS { get; set; }
        public decimal O3_WPT_HCL_OS { get; set; }
        public decimal O3_WPT_NAOCL_OS { get; set; }
        public decimal O3_WPT_NACIO2_OS { get; set; }
        public decimal O3_DM_HCL_OS { get; set; }
        public decimal O3_DM_NAOH_OS { get; set; }
        public decimal O3_ROZLD_HCL_OS { get; set; }
        public decimal O3_ROZLD_NAOH_OS { get; set; }
        public decimal O3_ROZLD_NAOCL_OS { get; set; }
        public decimal O3_ROZLD_HNO3_OS { get; set; }
        public decimal O3_WPT_ALUM_RECEIPT { get; set; }
        public decimal O3_WPT_PAC_RECEIPT { get; set; }
        public decimal O3_WPT_POLYE_RECEIPT { get; set; }
        public decimal O3_WPT_HCL_RECEIPT { get; set; }
        public decimal O3_WPT_NAOCL_RECEIPT { get; set; }
        public decimal O3_WPT_NACIO2_RECEIPT { get; set; }
        public decimal O3_DM_HCL_RECEIPT { get; set; }
        public decimal O3_DM_NAOH_RECEIPT { get; set; }
        public decimal O3_ROZLD_HCL_RECEIPT { get; set; }
        public decimal O3_ROZLD_NAOH_RECEIPT { get; set; }
        public decimal O3_ROZLD_NAOCL_RECEIPT { get; set; }
        public decimal O3_ROZLD_HNO3_RECEIPT { get; set; }
        public decimal O3_WPT_ALUM_CONSP { get; set; }
        public decimal O3_WPT_PAC_CONSP { get; set; }
        public decimal O3_WPT_POLYE_CONSP { get; set; }
        public decimal O3_WPT_HCL_CONSP { get; set; }
        public decimal O3_WPT_NAOCL_CONSP { get; set; }
        public decimal O3_WPT_NACIO2_CONSP { get; set; }
        public decimal O3_DM_HCL_CONSP { get; set; }
        public decimal O3_DM_NAOH_CONSP { get; set; }
        public decimal O3_ROZLD_HCL_CONSP { get; set; }
        public decimal O3_ROZLD_NAOH_CONSP { get; set; }
        public decimal O3_ROZLD_NAOCL_CONSP { get; set; }
        public decimal O3_ROZLD_HNO3_CONSP { get; set; }
        public decimal O3_WPT_ALUM_CS { get; set; }
        public decimal O3_WPT_PAC_CS { get; set; }
        public decimal O3_WPT_POLYE_CS { get; set; }
        public decimal O3_WPT_HCL_CS { get; set; }
        public decimal O3_WPT_NAOCL_CS { get; set; }
        public decimal O3_WPT_NACIO2_CS { get; set; }
        public decimal O3_DM_HCL_CS { get; set; }
        public decimal O3_DM_NAOH_CS { get; set; }
        public decimal O3_ROZLD_HCL_CS { get; set; }
        public decimal O3_ROZLD_NAOH_CS { get; set; }
        public decimal O3_ROZLD_NAOCL_CS { get; set; }
        public decimal O3_ROZLD_HNO3_CS { get; set; }
        public decimal O3_SODA_ASH_RECEIPT { get; set; }
        public decimal O3_FECL3_RECEIPT { get; set; }
        public decimal O3_POLYE_RECEIPT { get; set; }
        public decimal O3_DOLAMITE_LIME_RECEIPT { get; set; }
        public decimal O3_DE_WATER_GRADE_POLYE_RECEIPT { get; set; }
        public decimal O3_ANTI_SCALANT_RECEIPT { get; set; }
        public decimal O3_SODIUM_META_BI_SULP_RECEIPT { get; set; }
        public decimal O3_BIOCIDE_RECEIPT { get; set; }
        public decimal O3_ANTIFOAM_RECEIPT { get; set; }
        public decimal O3_SODA_ASH { get; set; }
        public decimal O3_FECL3 { get; set; }
        public decimal O3_POLYE { get; set; }
        public decimal O3_DOLAMITE_LIME { get; set; }
        public decimal O3_DE_WATER_GRADE_POLYE { get; set; }
        public decimal O3_ANTI_SCALANT { get; set; }
        public decimal O3_SODIUM_META_BI_SULP { get; set; }
        public decimal O3_BIOCIDE { get; set; }
        public decimal O3_ANTIFOAM { get; set; }
        public decimal O3_SODA_ASH_STK { get; set; }
        public decimal O3_FECL3_STK { get; set; }
        public decimal O3_POLYE_STK { get; set; }
        public decimal O3_DOLAMITE_LIME_STK { get; set; }
        public decimal O3_DE_WATER_GRADE_POLYE_STK { get; set; }
        public decimal O3_ANTI_SCALANT_STK { get; set; }
        public decimal O3_SODIUM_META_BI_SULP_STK { get; set; }
        public decimal O3_BIOCIDE_STK { get; set; }
        public decimal O3_ANTIFOAM_STK { get; set; }
        public decimal O3_HRSG3_FEED_WATER_INT { get; set; }
        public decimal O3_HPN_TO_GP_III { get; set; }
        public decimal O3_SERVICE_AIR_GP3_INT { get; set; }
        public decimal O3_IA_GP3_INT { get; set; }
        public decimal O3_SPG_CT_BLOWDOWN_INT { get; set; }
        public decimal O3_HRSG3_FEED_WATER_DIFF { get; set; }
        public decimal O3_SERVICE_AIR_GP3_DIFF { get; set; }
        public decimal O3_IA_GP3_DIFF { get; set; }
        public decimal O3_SPG_CT_BLOWDOWN_DIFF { get; set; }
        public decimal O3_BFW_G1_DEAREATOR_MT_INT { get; set; }
        public decimal O3_BFW_MT_INT { get; set; }
        public decimal O3_EFFL_RO_PLANT_INT { get; set; }
        public decimal O3_UF_PERMEATE_TANK_INT { get; set; }
        public decimal O3_PERMEATE_RO1_B1_INT { get; set; }
        public decimal O3_PERMEATE_RO1_B2_INT { get; set; }
        public decimal O3_PERMEATE_RO2_INT { get; set; }
        public decimal O3_REJECT_RO1_B1_INT { get; set; }
        public decimal O3_REJECT_RO1_B2_INT { get; set; }
        public decimal O3_REJECT_RO2_INT { get; set; }
        public decimal O3_SLUDGE_RO_PLANT_INT { get; set; }
        public decimal O3_ZLD_FEED_INT { get; set; }
        public decimal O3_STEAM_ZLD_PLANT_INT { get; set; }
        public decimal O3_COND_EXPORT_INT { get; set; }
        public decimal O3_TOT_PERMEATE_EXPORT_ROZLD_INT { get; set; }
        public decimal O3_SALT_ZLD_INT { get; set; }
        public decimal O3_EFFL_RO_PLANT_DIFF { get; set; }
        public decimal O3_UF_PERMEATE_TANK_DIFF { get; set; }
        public decimal O3_PERMEATE_RO1_B1_DIFF { get; set; }
        public decimal O3_PERMEATE_RO1_B2_DIFF { get; set; }
        public decimal O3_PERMEATE_RO2_DIFF { get; set; }
        public decimal O3_REJECT_RO1_B1_DIFF { get; set; }
        public decimal O3_REJECT_RO1_B2_DIFF { get; set; }
        public decimal O3_REJECT_RO2_DIFF { get; set; }
        public decimal O3_ZLD_FEED_DIFF { get; set; }
        public decimal O3_STEAM_ZLD_PLANT_DIFF { get; set; }
        public decimal O3_COND_EXPORT_DIFF { get; set; }
        public decimal O3_TOT_PERMEATE_EXPORT_ROZLD_DIFF { get; set; }
        public decimal O3_DOMESTIC_EFFL_GREEN_BELT_INT { get; set; }
        public decimal O3_DOMESTIC_EFFL_INT { get; set; }
        public decimal O3_DOMESTIC_EFFL_GREEN_BELT_DIFF { get; set; }
        public decimal O3_PERMEATE_UR2_INT { get; set; }
        public decimal O3_PERMEATE_GP3 { get; set; }
        public decimal O3_GTG3_INT { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_A_K7602A_INT { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_B_K7602B_INT { get; set; }
        public decimal O3_HRSG3_SCAN_AIR_FAN_A_K7603A_INT { get; set; }
        public decimal O3_HRSG3_SCAN_AIR_FAN_B_K7603B_INT { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_A_K7604A_INT { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_B_K7604A_INT { get; set; }
        public decimal O3_HRSG3_BLOWDOWN_PUMP_A_INT { get; set; }
        public decimal O3_HRSG3_BLOWDOWN_PUMP_B_INT { get; set; }
        public decimal O3_ETP_BLOWER_INT { get; set; }
        public decimal O3_ETP_PUMP_INT { get; set; }
        public decimal O3_GTG3_CV { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_A_K7602A_CV { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_B_K7602B_CV { get; set; }
        public decimal O3_HRSG3_SCAN_AIR_FAN_A_K7603A_CV { get; set; }
        public decimal O3_HRSG3_SCAN_AIR_FAN_B_K7603B_CV { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_A_K7604A_CV { get; set; }
        public decimal O3_HRSG3_SEAL_AIR_FAN_B_K7604A_CV { get; set; }
        public decimal O3_HRSG3_BLOWDOWN_PUMP_A_CV { get; set; }
        public decimal O3_HRSG3_BLOWDOWN_PUMP_B_CV { get; set; }
        public decimal O3_ETP_BLOWER_CV { get; set; }
        public decimal O3_ETP_PUMP_CV { get; set; }
        public decimal O3_GTG3_VAM_CV { get; set; }
        public decimal O3_GTG3_VAM_INT { get; set; }
        public decimal O3_HRSG3_INT { get; set; }
        public decimal O3_HRSG3_BFW_PUMP_P7601A_INT { get; set; }
        public decimal O3_HRSG3_BFW_PUMP_P7601B_INT { get; set; }
        public decimal O3_SPG_CT_PUMP_P7811A_INT { get; set; }
        public decimal O3_SPG_CT_PUMP_P7811B_INT { get; set; }
        public decimal O3_SPG_CT_FAN_P7803A_INT { get; set; }
        public decimal O3_SPG_CT_FAN_P7803B_INT { get; set; }
        public decimal O3_RW_RESERVOIR_PUMP_P7902A_INT { get; set; }
        public decimal O3_RW_RESERVOIR_PUMP_P7902B_INT { get; set; }
        public decimal O3_POLISH_WATER_PUMP_P7933A_INT { get; set; }
        public decimal O3_POLISH_WATER_PUMP_P7933B_INT { get; set; }
        public decimal O3_POLISH_WATER_PUMP_P7933C_INT { get; set; }
        public decimal O3_MAIN_AIR_COMP_INT { get; set; }
        public decimal O3_FIRE_WATER_PUMP_INT { get; set; }
        public decimal O3_FIRE_WATER_DIESEL_PUMP_P8302A_INT { get; set; }
        public decimal O3_FIRE_WATER_DIESEL_PUMP_P8302B_INT { get; set; }
        public decimal O3_FIRE_WATER_DIESEL_PUMP_P8302C_INT { get; set; }
        public decimal O3_STP_EQU_EFFL_TRSFER_PUMP1_INT { get; set; }
        public decimal O3_STP_EQU_EFFL_TRSFER_PUMP2_INT { get; set; }
        public decimal O3_STP_AB1_EQU_CWT_MK7201A_INT { get; set; }
        public decimal O3_STP_AB2_EQU_CWT_MK7201B_INT { get; set; }
        public decimal O3_STP_FILTER_FEED_PUMP1_INT { get; set; }
        public decimal O3_STP_FILTER_FEED_PUMP2_INT { get; set; }
        public decimal O3_STP_SECOND_CLARIFIER_MECH1_INT { get; set; }
        public decimal O3_STP_AGITATOR_ANOXIC_TANK_INT { get; set; }
        public decimal O3_STP_AB_MBBR_TANK_MK7202A_INT { get; set; }
        public decimal O3_STP_AB_MBBR_TANK_MK7202B_INT { get; set; }
        public decimal O3_STP_INTERNAL_SLUDGE_RECIR_PUMP_A_INT { get; set; }
        public decimal O3_STP_INTERNAL_SLUDGE_RECIR_PUMP_B_INT { get; set; }
        public decimal O3_STP_SLUDGE_RECYCLE_PUMP1_INT { get; set; }
        public decimal O3_STP_SLUDGE_RECYCLE_PUMP2_INT { get; set; }
        public decimal O3_STP_PE_DOSING_PUMP_MP7213A_INT { get; set; }
        public decimal O3_STP_PE_DOSING_PUMP_MP7213B_INT { get; set; }
        public decimal O3_STP_AGITATOR_PE_DOSING_TANK_INT { get; set; }
        public decimal O3_STP_HYPO_DOSING_PUMP_MP7212A_INT { get; set; }
        public decimal O3_STP_HYPO_DOSING_PUMP_MP7212B_INT { get; set; }
        public decimal O3_STP_WATER_TRSFER_PUMP_MP7211A_INT { get; set; }
        public decimal O3_STP_WATER_TRSFER_PUMP_MP7211B_INT { get; set; }
        public decimal O3_STP_FILTER_PRESS_FEED_PUMP_MP7210A_INT { get; set; }
        public decimal O3_STP_FILTER_PRESS_FEED_PUMP_MP7210B_INT { get; set; }
        public decimal O3_STP_AGITATOR_SLUDGE_HOLD_TANK_INT { get; set; }
        public decimal O3_STP_UV_SYSTEM_INT { get; set; }
        public decimal O3_STP_FILTER_PRESS_INT { get; set; }
        public decimal O3_STP_TUBE_AXIAL_FAN_STP_MCC_ROOM_INT { get; set; }
        public decimal O3_STP_SEWAGE_PUMP1_MP7201A_INT { get; set; }
        public decimal O3_STP_SEWAGE_PUMP2_MP7201B_INT { get; set; }
        public decimal O3_STP_SEWAGE_PUMP1_MP7203A_INT { get; set; }
        public decimal O3_STP_SEWAGE_PUMP2_MP7203B_INT { get; set; }
        public decimal O3_STP_SEWAGE_PUMP1_MP7205A_INT { get; set; }
        public decimal O3_STP_SEWAGE_PUMP2_MP7205B_INT { get; set; }
        public decimal O3_STP_STP3_CV { get; set; }
        public decimal O3_STP_MP7206A_CV { get; set; }
        public decimal O3_STP_MP7206B_CV { get; set; }
        public decimal O3_STP_MK7201A_CV { get; set; }
        public decimal O3_STP_MK7201B_CV { get; set; }
        public decimal O3_STP_MP7209A_CV { get; set; }
        public decimal O3_STP_MP7209B_CV { get; set; }
        public decimal O3_STP_ME7204_CV { get; set; }
        public decimal O3_STP_ME7201_CV { get; set; }
        public decimal O3_STP_MK7202A_CV { get; set; }
        public decimal O3_STP_MK7202B_CV { get; set; }
        public decimal O3_STP_MP7207A_CV { get; set; }
        public decimal O3_STP_MP7207B_CV { get; set; }
        public decimal O3_STP_MP7208A_CV { get; set; }
        public decimal O3_STP_MP7208B_CV { get; set; }
        public decimal O3_STP_MP7213A_CV { get; set; }
        public decimal O3_STP_MP7213B_CV { get; set; }
        public decimal O3_STP_ME7203_CV { get; set; }
        public decimal O3_STP_MP7212A_CV { get; set; }
        public decimal O3_STP_MP7212B_CV { get; set; }
        public decimal O3_STP_MP7211A_CV { get; set; }
        public decimal O3_STP_MP7211B_CV { get; set; }
        public decimal O3_STP_MP7210A_CV { get; set; }
        public decimal O3_STP_MP7210B_CV { get; set; }
        public decimal O3_STP_ME7202_CV { get; set; }
        public decimal O3_STP_M7206_CV { get; set; }
        public decimal O3_STP_ME7205_CV { get; set; }
        public decimal O3_STP_AF7201_CV { get; set; }
        public decimal O3_STP_MP7201A_CV { get; set; }
        public decimal O3_STP_MP7201B_CV { get; set; }
        public decimal O3_STP_MP7203A_CV { get; set; }
        public decimal O3_STP_MP7203B_CV { get; set; }
        public decimal O3_STP_MP7205A_CV { get; set; }
        public decimal O3_STP_MP7205B_CV { get; set; }
        public string ENTERED_BY { get; set; }
        public string MODIFIED_BY { get; set; }
    }
}