using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS301Repository
    {
        private readonly string _connectionString;
        public PAS301Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        // GET DATA
        private PAS301Model MapToValue(SqlDataReader reader)
        {
            return new PAS301Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A3_TRANS_DATE = reader["A3_TRANS_DATE"].ToString(),
                A3_USER_ID = (decimal)reader["A3_USER_ID"],
                ENTERED_BY = reader["ENTERED_BY"].ToString(),
                MODIFIED_BY = reader["MODIFIED_BY"].ToString(),
                ENTERED_DATETIME = reader["ENTERED_DATETIME"].ToString(),
                MODIFY_DATETIME = reader["MODIFY_DATETIME"].ToString(),

                // ---------------------PPT_AM3_ACT_UCT--------------------------
                A3_ACT_CIRC_FLOW = (decimal)reader["A3_ACT_CIRC_FLOW"],
                A3_ACT_MAKEUP = (decimal)reader["A3_ACT_MAKEUP"],
                A3_ACT_SUPPLY_TEMP = (decimal)reader["A3_ACT_SUPPLY_TEMP"],
                A3_ACT_RETURN_TEMP = (decimal)reader["A3_ACT_RETURN_TEMP"],
                A3_ACT_DRY_BULB_TEMP = (decimal)reader["A3_ACT_DRY_BULB_TEMP"],
                A3_ACT_WET_BULB_TEMP = (decimal)reader["A3_ACT_WET_BULB_TEMP"],
                A3_ACT_WET_APPWACH = (decimal)reader["A3_ACT_WET_APPWACH"],
                A3_ACT_RANGE = (decimal)reader["A3_ACT_RANGE"],
                A3_ACT_HEAT_DUTY = (decimal)reader["A3_ACT_HEAT_DUTY"],
                A3_ACT_THERMAL_EFF = (decimal)reader["A3_ACT_THERMAL_EFF"],
                A3_UCT_CIRC_FLOW = (decimal)reader["A3_UCT_CIRC_FLOW"],
                A3_UCT_MAKEUP = (decimal)reader["A3_UCT_MAKEUP"],
                A3_UCT_SUPPLY_TEMP = (decimal)reader["A3_UCT_SUPPLY_TEMP"],
                A3_UCT_RETURN_TEMP = (decimal)reader["A3_UCT_RETURN_TEMP"],
                A3_UCT_DRY_BULB_TEMP = (decimal)reader["A3_UCT_DRY_BULB_TEMP"],
                A3_UCT_WET_BULB_TEMP = (decimal)reader["A3_UCT_WET_BULB_TEMP"],
                A3_UCT_WET_APPWACH = (decimal)reader["A3_UCT_WET_APPWACH"],
                A3_UCT_RANGE = (decimal)reader["A3_UCT_RANGE"],
                A3_UCT_HEAT_DUTY = (decimal)reader["A3_UCT_HEAT_DUTY"],
                A3_UCT_THERMAL_EFF = (decimal)reader["A3_UCT_THERMAL_EFF"],

                // ---------------------AM3_CHEMICAL_CONS_DTL---------------------
                A3_HSD_RECEIPT = (decimal)reader["A3_HSD_RECEIPT"],
                A3_H2SO4_RECEIPT = (decimal)reader["A3_H2SO4_RECEIPT"],
                A3_HCL_RECEIPT = (decimal)reader["A3_HCL_RECEIPT"],
                A3_NAOCL_RECEIPT = (decimal)reader["A3_NAOCL_RECEIPT"],
                A3_NaClO2_RECEIPT = (decimal)reader["A3_NaClO2_RECEIPT"],
                A3_aMDEA_RECEIPT = (decimal)reader["A3_aMDEA_RECEIPT"],
                A3_Antifoam_RECEIPT = (decimal)reader["A3_Antifoam_RECEIPT"],
                A3_O2_SCAVENGER_RECEIPT = (decimal)reader["A3_O2_SCAVENGER_RECEIPT"],
                A3_PH_BOOSTER_RECEIPT = (decimal)reader["A3_PH_BOOSTER_RECEIPT"],
                A3_PHOF_PHAPE_RECEIPT = (decimal)reader["A3_PHOF_PHAPE_RECEIPT"],
                A3_CHEMICAL_REMARK = reader["A3_CHEMICAL_REMARK"].ToString(),
                A3_HSD_TANK = (decimal)reader["A3_HSD_TANK"],
                A3_H2SO4_TANK = (decimal)reader["A3_H2SO4_TANK"],
                A3_HCL_TANK = (decimal)reader["A3_HCL_TANK"],
                A3_NAOCL_TANK = (decimal)reader["A3_NAOCL_TANK"],
                A3_NaClO2_TANK = (decimal)reader["A3_NaClO2_TANK"],
                A3_HSD_STK = (decimal)reader["A3_HSD_STK"],
                A3_H2SO4_STK = (decimal)reader["A3_H2SO4_STK"],
                A3_HCL_STK = (decimal)reader["A3_HCL_STK"],
                A3_NAOCL_STK = (decimal)reader["A3_NAOCL_STK"],
                A3_NaClO2_STK = (decimal)reader["A3_NaClO2_STK"],
                A3_aMDEA_STK = (decimal)reader["A3_aMDEA_STK"],
                A3_Antifoam_STK = (decimal)reader["A3_Antifoam_STK"],
                A3_O2_SCAVENGER_STK = (decimal)reader["A3_O2_SCAVENGER_STK"],
                A3_PH_BOOSTER_STK = (decimal)reader["A3_PH_BOOSTER_STK"],
                A3_PHOF_PHAPE_STK = (decimal)reader["A3_PHOF_PHAPE_STK"],
                A3_HSD_CONSP = (decimal)reader["A3_HSD_CONSP"],
                A3_H2SO4_CONSP = (decimal)reader["A3_H2SO4_CONSP"],
                A3_HCL_CONSP = (decimal)reader["A3_HCL_CONSP"],
                A3_NAOCL_CONSP = (decimal)reader["A3_NAOCL_CONSP"],
                A3_NaClO2_CONSP = (decimal)reader["A3_NaClO2_CONSP"],
                A3_aMDEA_CONSP = (decimal)reader["A3_aMDEA_CONSP"],
                A3_Antifoam_CONSP = (decimal)reader["A3_Antifoam_CONSP"],
                A3_O2_SCAVENGER_CONSP = (decimal)reader["A3_O2_SCAVENGER_CONSP"],
                A3_PH_BOOSTER_CONSP = (decimal)reader["A3_PH_BOOSTER_CONSP"],
                A3_PHOF_PHAPE_CONSP = (decimal)reader["A3_PHOF_PHAPE_CONSP"],
                A3_HSD_OUTSIDE_RECEIPT = (decimal)reader["A3_HSD_OUTSIDE_RECEIPT"],
                A3_HSD_OUTSIDE_TANK = (decimal)reader["A3_HSD_OUTSIDE_TANK"],
                A3_HSD_OUTSIDE_STK = (decimal)reader["A3_HSD_OUTSIDE_STK"],
                A3_HSD_OUTSIDE_CONSP = (decimal)reader["A3_HSD_OUTSIDE_CONSP"],
                A3_PH_BOOSTER_B5780M_RECEIPT = (decimal)reader["A3_PH_BOOSTER_B5780M_RECEIPT"],
                A3_PH_BOOSTER_B5780M_STK = (decimal)reader["A3_PH_BOOSTER_B5780M_STK"],
                A3_PH_BOOSTER_B5780M_CONSP = (decimal)reader["A3_PH_BOOSTER_B5780M_CONSP"],

                // -------------PRV--------AM3_CHEMICAL_CONS_DTL-------------
                PRV_A3_HSD_STK = (decimal)reader["PRV_A3_HSD_STK"],
                PRV_A3_H2SO4_STK = (decimal)reader["PRV_A3_H2SO4_STK"],
                PRV_A3_HCL_STK = (decimal)reader["PRV_A3_HCL_STK"],
                PRV_A3_NAOCL_STK = (decimal)reader["PRV_A3_NAOCL_STK"],
                PRV_A3_NaClO2_STK = (decimal)reader["PRV_A3_NaClO2_STK"],
                PRV_A3_aMDEA_STK = (decimal)reader["PRV_A3_aMDEA_STK"],
                PRV_A3_Antifoam_STK = (decimal)reader["PRV_A3_Antifoam_STK"],
                PRV_A3_O2_SCAVENGER_STK = (decimal)reader["PRV_A3_O2_SCAVENGER_STK"],
                PRV_A3_PH_BOOSTER_STK = (decimal)reader["PRV_A3_PH_BOOSTER_STK"],
                PRV_A3_PHOF_PHAPE_STK = (decimal)reader["PRV_A3_PHOF_PHAPE_STK"],
                PRV_A3_HSD_OUTSIDE_STK = (decimal)reader["PRV_A3_HSD_OUTSIDE_STK"],
                PRV_A3_PH_BOOSTER_B5780M_STK = (decimal)reader["PRV_A3_PH_BOOSTER_B5780M_STK"],

                // -------------------PPT_AM3_CO2_SHEET--------------------
                A3_PRS_CO2_TO_UR_INT = (decimal)reader["A3_PRS_CO2_TO_UR_INT"],
                A3_TEMP_CO2_TO_UR_INT = (decimal)reader["A3_TEMP_CO2_TO_UR_INT"],
                A3_TOT_CO2_TO_UR_INT = (decimal)reader["A3_TOT_CO2_TO_UR_INT"],
                A3_PRS_SURPLUS_SYN_GAS_INT = (decimal)reader["A3_PRS_SURPLUS_SYN_GAS_INT"],
                A3_TEMP_SURPLUS_SYN_GAS_INT = (decimal)reader["A3_TEMP_SURPLUS_SYN_GAS_INT"],
                A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT = (decimal)reader["A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT"],
                A3_SYNGAS_EXPORT_TO_GP1_GP2 = (decimal)reader["A3_SYNGAS_EXPORT_TO_GP1_GP2"],
                A3_CO2_EXPORT_TO_GP1 = (decimal)reader["A3_CO2_EXPORT_TO_GP1"],
                A3_CO2_EXPORT_TO_GP2 = (decimal)reader["A3_CO2_EXPORT_TO_GP2"],
                A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT = (decimal)reader["A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT"],
                A3_PASSIVATION_AIR_TO_UR_INT = (decimal)reader["A3_PASSIVATION_AIR_TO_UR_INT"],
                A3_PRS_WASTE_FUEL_GAS_INT = (decimal)reader["A3_PRS_WASTE_FUEL_GAS_INT"],
                A3_TEMP_WASTE_FUEL_GAS_INT = (decimal)reader["A3_TEMP_WASTE_FUEL_GAS_INT"],
                A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT = (decimal)reader["A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT"],
                A3_PRS_CO2_TO_UR_INT_DIFF = (decimal)reader["A3_PRS_CO2_TO_UR_INT_DIFF"],
                A3_TEMP_CO2_TO_UR_INT_DIFF = (decimal)reader["A3_TEMP_CO2_TO_UR_INT_DIFF"],
                A3_TOT_CO2_TO_UR_INT_DIFF = (decimal)reader["A3_TOT_CO2_TO_UR_INT_DIFF"],
                A3_PRS_SURPLUS_SYN_GAS_INT_DIFF = (decimal)reader["A3_PRS_SURPLUS_SYN_GAS_INT_DIFF"],
                A3_TEMP_SURPLUS_SYN_GAS_INT_DIFF = (decimal)reader["A3_TEMP_SURPLUS_SYN_GAS_INT_DIFF"],
                A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT_DIFF = (decimal)reader["A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT_DIFF"],
                A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT_DIFF = (decimal)reader["A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT_DIFF"],
                A3_PASSIVATION_AIR_TO_UR_INT_DIFF = (decimal)reader["A3_PASSIVATION_AIR_TO_UR_INT_DIFF"],
                A3_PRS_WASTE_FUEL_GAS_INT_DIFF = (decimal)reader["A3_PRS_WASTE_FUEL_GAS_INT_DIFF"],
                A3_TEMP_WASTE_FUEL_GAS_INT_DIFF = (decimal)reader["A3_TEMP_WASTE_FUEL_GAS_INT_DIFF"],
                A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT_DIFF = (decimal)reader["A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT_DIFF"],

                // -------------PRV--------------PPT_AM3_CO2_SHEET------------------------------
                PRV_A3_PRS_CO2_TO_UR_INT = (decimal)reader["PRV_A3_PRS_CO2_TO_UR_INT"],
                PRV_A3_TEMP_CO2_TO_UR_INT = (decimal)reader["PRV_A3_TEMP_CO2_TO_UR_INT"],
                PRV_A3_TOT_CO2_TO_UR_INT = (decimal)reader["PRV_A3_TOT_CO2_TO_UR_INT"],
                PRV_A3_PRS_SURPLUS_SYN_GAS_INT = (decimal)reader["PRV_A3_PRS_SURPLUS_SYN_GAS_INT"],
                PRV_A3_TEMP_SURPLUS_SYN_GAS_INT = (decimal)reader["PRV_A3_TEMP_SURPLUS_SYN_GAS_INT"],
                PRV_A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT = (decimal)reader["PRV_A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT"],
                PRV_A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT = (decimal)reader["PRV_A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT"],
                PRV_A3_PASSIVATION_AIR_TO_UR_INT = (decimal)reader["PRV_A3_PASSIVATION_AIR_TO_UR_INT"],
                PRV_A3_PRS_WASTE_FUEL_GAS_INT = (decimal)reader["PRV_A3_PRS_WASTE_FUEL_GAS_INT"],
                PRV_A3_TEMP_WASTE_FUEL_GAS_INT = (decimal)reader["PRV_A3_TEMP_WASTE_FUEL_GAS_INT"],
                PRV_A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT = (decimal)reader["PRV_A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT"],

                // -------------------------PPT_AM3_ELE_POWER_RECEIPT-----------------------
                A3_SL_SLN_PUMP_A_INT = (decimal)reader["A3_SL_SLN_PUMP_A_INT"],
                A3_SL_SLN_PUMP_B_INT = (decimal)reader["A3_SL_SLN_PUMP_B_INT"],
                A3_SL_SLN_PUMP_C_INT = (decimal)reader["A3_SL_SLN_PUMP_C_INT"],
                A3_LS_PUMP_A_INT = (decimal)reader["A3_LS_PUMP_A_INT"],
                A3_LS_PUMP_B_INT = (decimal)reader["A3_LS_PUMP_B_INT"],
                A3_HP_BFW_PUMP_A_INT = (decimal)reader["A3_HP_BFW_PUMP_A_INT"],
                A3_ID_FAN_MOTOR_A_INT = (decimal)reader["A3_ID_FAN_MOTOR_A_INT"],
                A3_ID_FAN_MOTOR_B_INT = (decimal)reader["A3_ID_FAN_MOTOR_B_INT"],
                A3_LTS_SU_BLOWER_INT = (decimal)reader["A3_LTS_SU_BLOWER_INT"],
                A3_SL_SLN_CIRCULATING_PUMP_A_INT = (decimal)reader["A3_SL_SLN_CIRCULATING_PUMP_A_INT"],
                A3_SL_SLN_CIRCULATING_PUMP_B_INT = (decimal)reader["A3_SL_SLN_CIRCULATING_PUMP_B_INT"],
                A3_FEED_GAS_COMP_VFD_INT = (decimal)reader["A3_FEED_GAS_COMP_VFD_INT"],
                A3_FEED_GAS_COMP_DOL_INT = (decimal)reader["A3_FEED_GAS_COMP_DOL_INT"],
                A3_FEED_GAS_COMP = (decimal)reader["A3_FEED_GAS_COMP"],
                A3_STANDBY_AIR_COMP_INT = (decimal)reader["A3_STANDBY_AIR_COMP_INT"],
                A3_101_JTG_JM11_INT = (decimal)reader["A3_101_JTG_JM11_INT"],
                A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT = (decimal)reader["A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT"],
                A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT = (decimal)reader["A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT"],
                A3_PURIFIER_EXPANDER_GEN_INT = (decimal)reader["A3_PURIFIER_EXPANDER_GEN_INT"],
                A3_SL_SLN_PUMP_A_INT_DIFF = (decimal)reader["A3_SL_SLN_PUMP_A_INT_DIFF"],
                A3_SL_SLN_PUMP_B_INT_DIFF = (decimal)reader["A3_SL_SLN_PUMP_B_INT_DIFF"],
                A3_SL_SLN_PUMP_C_INT_DIFF = (decimal)reader["A3_SL_SLN_PUMP_C_INT_DIFF"],
                A3_LS_PUMP_A_INT_DIFF = (decimal)reader["A3_LS_PUMP_A_INT_DIFF"],
                A3_LS_PUMP_B_INT_DIFF = (decimal)reader["A3_LS_PUMP_B_INT_DIFF"],
                A3_HP_BFW_PUMP_A_INT_DIFF = (decimal)reader["A3_HP_BFW_PUMP_A_INT_DIFF"],
                A3_ID_FAN_MOTOR_A_INT_DIFF = (decimal)reader["A3_ID_FAN_MOTOR_A_INT_DIFF"],
                A3_ID_FAN_MOTOR_B_INT_DIFF = (decimal)reader["A3_ID_FAN_MOTOR_B_INT_DIFF"],
                A3_LTS_SU_BLOWER_INT_DIFF = (decimal)reader["A3_LTS_SU_BLOWER_INT_DIFF"],
                A3_SL_SLN_CIRCULATING_PUMP_A_INT_DIFF = (decimal)reader["A3_SL_SLN_CIRCULATING_PUMP_A_INT_DIFF"],
                A3_SL_SLN_CIRCULATING_PUMP_B_INT_DIFF = (decimal)reader["A3_SL_SLN_CIRCULATING_PUMP_B_INT_DIFF"],
                A3_FEED_GAS_COMP_VFD_INT_DIFF = (decimal)reader["A3_FEED_GAS_COMP_VFD_INT_DIFF"],
                A3_FEED_GAS_COMP_DOL_INT_DIFF = (decimal)reader["A3_FEED_GAS_COMP_DOL_INT_DIFF"],
                A3_STANDBY_AIR_COMP_INT_DIFF = (decimal)reader["A3_STANDBY_AIR_COMP_INT_DIFF"],
                A3_101_JTG_JM11_INT_DIFF = (decimal)reader["A3_101_JTG_JM11_INT_DIFF"],
                A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT_DIFF = (decimal)reader["A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT_DIFF"],
                A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT_DIFF = (decimal)reader["A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT_DIFF"],
                A3_PURIFIER_EXPANDER_GEN_INT_DIFF = (decimal)reader["A3_PURIFIER_EXPANDER_GEN_INT_DIFF"],
                DIS_TOT_AMM_POWER = (decimal)reader["DIS_TOT_AMM_POWER"],

                // -------------PRV-----------------PPT_AM3_ELE_POWER_RECEIPT---------------------------
                PRV_A3_SL_SLN_PUMP_A_INT = (decimal)reader["PRV_A3_SL_SLN_PUMP_A_INT"],
                PRV_A3_SL_SLN_PUMP_B_INT = (decimal)reader["PRV_A3_SL_SLN_PUMP_B_INT"],
                PRV_A3_SL_SLN_PUMP_C_INT = (decimal)reader["PRV_A3_SL_SLN_PUMP_C_INT"],
                PRV_A3_LS_PUMP_A_INT = (decimal)reader["PRV_A3_LS_PUMP_A_INT"],
                PRV_A3_LS_PUMP_B_INT = (decimal)reader["PRV_A3_LS_PUMP_B_INT"],
                PRV_A3_HP_BFW_PUMP_A_INT = (decimal)reader["PRV_A3_HP_BFW_PUMP_A_INT"],
                PRV_A3_ID_FAN_MOTOR_A_INT = (decimal)reader["PRV_A3_ID_FAN_MOTOR_A_INT"],
                PRV_A3_ID_FAN_MOTOR_B_INT = (decimal)reader["PRV_A3_ID_FAN_MOTOR_B_INT"],
                PRV_A3_LTS_SU_BLOWER_INT = (decimal)reader["PRV_A3_LTS_SU_BLOWER_INT"],
                PRV_A3_SL_SLN_CIRCULATING_PUMP_A_INT = (decimal)reader["PRV_A3_SL_SLN_CIRCULATING_PUMP_A_INT"],
                PRV_A3_SL_SLN_CIRCULATING_PUMP_B_INT = (decimal)reader["PRV_A3_SL_SLN_CIRCULATING_PUMP_B_INT"],
                PRV_A3_FEED_GAS_COMP_VFD_INT = (decimal)reader["PRV_A3_FEED_GAS_COMP_VFD_INT"],
                PRV_A3_FEED_GAS_COMP_DOL_INT = (decimal)reader["PRV_A3_FEED_GAS_COMP_DOL_INT"],
                PRV_A3_STANDBY_AIR_COMP_INT = (decimal)reader["PRV_A3_STANDBY_AIR_COMP_INT"],
                PRV_A3_101_JTG_JM11_INT = (decimal)reader["PRV_A3_101_JTG_JM11_INT"],
                PRV_A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT = (decimal)reader["PRV_A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT"],
                PRV_A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT = (decimal)reader["PRV_A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT"],
                PRV_A3_PURIFIER_EXPANDER_GEN_INT = (decimal)reader["PRV_A3_PURIFIER_EXPANDER_GEN_INT"],

                // ----------------------PPT_AM3_MACHINERY_RUNNING_HR-----------------------------------
                A3_MRH_101_JGT_FIRED_HRS_INT = (decimal)reader["A3_MRH_101_JGT_FIRED_HRS_INT"],
                A3_MRH_SL_SLN_PUMP_A_INT = (decimal)reader["A3_MRH_SL_SLN_PUMP_A_INT"],
                A3_MRH_SL_SLN_PUMP_B_INT = (decimal)reader["A3_MRH_SL_SLN_PUMP_B_INT"],
                A3_MRH_SL_SLN_PUMP_C_INT = (decimal)reader["A3_MRH_SL_SLN_PUMP_C_INT"],
                A3_MRH_LS_PUMP_A_INT = (decimal)reader["A3_MRH_LS_PUMP_A_INT"],
                A3_MRH_LS_PUMP_B_INT = (decimal)reader["A3_MRH_LS_PUMP_B_INT"],
                A3_MRH_HP_BFW_PUMP_TURBINE = (decimal)reader["A3_MRH_HP_BFW_PUMP_TURBINE"],
                A3_MRH_HP_BFW_PUMP_A_INT = (decimal)reader["A3_MRH_HP_BFW_PUMP_A_INT"],
                A3_MRH_ID_FAN_MOTOR_A_INT = (decimal)reader["A3_MRH_ID_FAN_MOTOR_A_INT"],
                A3_MRH_ID_FAN_MOTOR_B_INT = (decimal)reader["A3_MRH_ID_FAN_MOTOR_B_INT"],
                A3_SYN_GAS_COMP_INT = (decimal)reader["A3_SYN_GAS_COMP_INT"],
                A3_MRH_REFRIGERATION_COMP = (decimal)reader["A3_MRH_REFRIGERATION_COMP"],
                A3_MRH_FEED_GAS_COMP_VFD_INT = (decimal)reader["A3_MRH_FEED_GAS_COMP_VFD_INT"],
                A3_MRH_FEED_GAS_COMP_DOL_INT = (decimal)reader["A3_MRH_FEED_GAS_COMP_DOL_INT"],
                A3_MRH_STANDBY_AIR_COMP_INT = (decimal)reader["A3_MRH_STANDBY_AIR_COMP_INT"],
                A3_MRH_ACT_PUMP_7801A_INT = (decimal)reader["A3_MRH_ACT_PUMP_7801A_INT"],
                A3_MRH_ACT_PUMP_7801B_INT = (decimal)reader["A3_MRH_ACT_PUMP_7801B_INT"],
                A3_MRH_UCT_PUMP_7808A_INT = (decimal)reader["A3_MRH_UCT_PUMP_7808A_INT"],
                A3_MRH_UCT_PUMP_7808B_INT = (decimal)reader["A3_MRH_UCT_PUMP_7808B_INT"],
                A3_MRH_PURIFIER_EXPANDER_GEN = (decimal)reader["A3_MRH_PURIFIER_EXPANDER_GEN"],

                // --------------------PPT_AM3_NG_SHEET1-----------------------------------------
                A3_PRS_NG_INT = (decimal)reader["A3_PRS_NG_INT"],
                A3_TEMP_NG_INT = (decimal)reader["A3_TEMP_NG_INT"],
                A3_TOT_NG_INT = (decimal)reader["A3_TOT_NG_INT"],
                A3_PRS_NG_AS_GT_FUEL_INT = (decimal)reader["A3_PRS_NG_AS_GT_FUEL_INT"],
                A3_TEMP_NG_AS_GT_FUEL_INT = (decimal)reader["A3_TEMP_NG_AS_GT_FUEL_INT"],
                A3_GT_FUEL_NG_INT = (decimal)reader["A3_GT_FUEL_NG_INT"],
                A3_PRS_NG_AS_REFMR_FUEL_INT = (decimal)reader["A3_PRS_NG_AS_REFMR_FUEL_INT"],
                A3_TEMP_NG_AS_REFMR_FUEL_INT = (decimal)reader["A3_TEMP_NG_AS_REFMR_FUEL_INT"],
                A3_NG_FUEL_TO_PRIMRY_REFMR_INT = (decimal)reader["A3_NG_FUEL_TO_PRIMRY_REFMR_INT"],
                A3_PRS_NG_AS_SUPRHEATER_FUEL_INT = (decimal)reader["A3_PRS_NG_AS_SUPRHEATER_FUEL_INT"],
                A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT = (decimal)reader["A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT"],
                A3_NG_FUEL_TO_SUPRHEATER_INT = (decimal)reader["A3_NG_FUEL_TO_SUPRHEATER_INT"],
                A3_NG_FUEL_TO_STATUPHEATER_INT = (decimal)reader["A3_NG_FUEL_TO_STATUPHEATER_INT"],
                A3_NG_FEED_INT = (decimal)reader["A3_NG_FEED_INT"],
                A3_PRS_NG_INT_DIFF = (decimal)reader["A3_PRS_NG_INT_DIFF"],
                A3_TEMP_NG_INT_DIFF = (decimal)reader["A3_TEMP_NG_INT_DIFF"],
                A3_TOT_NG_INT_DIFF = (decimal)reader["A3_TOT_NG_INT_DIFF"],
                A3_PRS_NG_AS_GT_FUEL_INT_DIFF = (decimal)reader["A3_PRS_NG_AS_GT_FUEL_INT_DIFF"],
                A3_TEMP_NG_AS_GT_FUEL_INT_DIFF = (decimal)reader["A3_TEMP_NG_AS_GT_FUEL_INT_DIFF"],
                A3_GT_FUEL_NG_INT_DIFF = (decimal)reader["A3_GT_FUEL_NG_INT_DIFF"],
                A3_PRS_NG_AS_REFMR_FUEL_INT_DIFF = (decimal)reader["A3_PRS_NG_AS_REFMR_FUEL_INT_DIFF"],
                A3_TEMP_NG_AS_REFMR_FUEL_INT_DIFF = (decimal)reader["A3_TEMP_NG_AS_REFMR_FUEL_INT_DIFF"],
                A3_NG_FUEL_TO_PRIMRY_REFMR_INT_DIFF = (decimal)reader["A3_NG_FUEL_TO_PRIMRY_REFMR_INT_DIFF"],
                A3_PRS_NG_AS_SUPRHEATER_FUEL_INT_DIFF = (decimal)reader["A3_PRS_NG_AS_SUPRHEATER_FUEL_INT_DIFF"],
                A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT_DIFF = (decimal)reader["A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT_DIFF"],
                A3_NG_FUEL_TO_SUPRHEATER_INT_DIFF = (decimal)reader["A3_NG_FUEL_TO_SUPRHEATER_INT_DIFF"],
                A3_NG_FUEL_TO_STATUPHEATER_INT_DIFF = (decimal)reader["A3_NG_FUEL_TO_STATUPHEATER_INT_DIFF"],
                A3_NG_FEED_INT_DIFF = (decimal)reader["A3_NG_FEED_INT_DIFF"],
                A3_TOT_NG_CONSP = (decimal)reader["A3_TOT_NG_CONSP"],
                A3_GT_FUEL_NG_CONSP = (decimal)reader["A3_GT_FUEL_NG_CONSP"],
                A3_NG_FUEL_TO_PRIMRY_REFMR_CONSP = (decimal)reader["A3_NG_FUEL_TO_PRIMRY_REFMR_CONSP"],
                A3_NG_FUEL_TO_SUPRHEATER_CONSP = (decimal)reader["A3_NG_FUEL_TO_SUPRHEATER_CONSP"],
                A3_NG_FUEL_TO_STATUPHEATER_CONSP = (decimal)reader["A3_NG_FUEL_TO_STATUPHEATER_CONSP"],
                A3_NG_FUEL_TO_FLARE_STACK_CONSP = (decimal)reader["A3_NG_FUEL_TO_FLARE_STACK_CONSP"],
                A3_NG_FEED_CONSP = (decimal)reader["A3_NG_FEED_CONSP"],
                A3_TOT_FUEL_CONSP = (decimal)reader["A3_TOT_FUEL_CONSP"],

                // -------------PRV----------PPT_AM3_NG_SHEET1----------------------------------
                PRV_A3_PRS_NG_INT = (decimal)reader["PRV_A3_PRS_NG_INT"],
                PRV_A3_TEMP_NG_INT = (decimal)reader["PRV_A3_TEMP_NG_INT"],
                PRV_A3_TOT_NG_INT = (decimal)reader["PRV_A3_TOT_NG_INT"],
                PRV_A3_PRS_NG_AS_GT_FUEL_INT = (decimal)reader["PRV_A3_PRS_NG_AS_GT_FUEL_INT"],
                PRV_A3_TEMP_NG_AS_GT_FUEL_INT = (decimal)reader["PRV_A3_TEMP_NG_AS_GT_FUEL_INT"],
                PRV_A3_GT_FUEL_NG_INT = (decimal)reader["PRV_A3_GT_FUEL_NG_INT"],
                PRV_A3_PRS_NG_AS_REFMR_FUEL_INT = (decimal)reader["PRV_A3_PRS_NG_AS_REFMR_FUEL_INT"],
                PRV_A3_TEMP_NG_AS_REFMR_FUEL_INT = (decimal)reader["PRV_A3_TEMP_NG_AS_REFMR_FUEL_INT"],
                PRV_A3_NG_FUEL_TO_PRIMRY_REFMR_INT = (decimal)reader["PRV_A3_NG_FUEL_TO_PRIMRY_REFMR_INT"],
                PRV_A3_PRS_NG_AS_SUPRHEATER_FUEL_INT = (decimal)reader["PRV_A3_PRS_NG_AS_SUPRHEATER_FUEL_INT"],
                PRV_A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT = (decimal)reader["PRV_A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT"],
                PRV_A3_NG_FUEL_TO_SUPRHEATER_INT = (decimal)reader["PRV_A3_NG_FUEL_TO_SUPRHEATER_INT"],
                PRV_A3_NG_FUEL_TO_STATUPHEATER_INT = (decimal)reader["PRV_A3_NG_FUEL_TO_STATUPHEATER_INT"],
                PRV_A3_NG_FEED_INT = (decimal)reader["PRV_A3_NG_FEED_INT"],

                // ------------------------------PPT_AM3_NG_SHEET2---------------------------------------
                A3_GAIL_METER_A_INT = (decimal)reader["A3_GAIL_METER_A_INT"],
                A3_GAIL_METER_B_INT = (decimal)reader["A3_GAIL_METER_B_INT"],
                A3_NG_MOLECULAR_WT = (decimal)reader["A3_NG_MOLECULAR_WT"],
                A3_NG_GCV = (decimal)reader["A3_NG_GCV"],
                A3_NG_CARBON_NUMBER = (decimal)reader["A3_NG_CARBON_NUMBER"],
                A3_NG_LCV = (decimal)reader["A3_NG_LCV"],
                A3_GSPN_SPOT_RLING_MMBTU = (decimal)reader["A3_GSPN_SPOT_RLING_MMBTU"],
                A3_GAIL_LT_RLING_1_9_MMBTU = (decimal)reader["A3_GAIL_LT_RLING_1_9_MMBTU"],
                A3_GAIL_LT_RLING_0_5_MMBTU = (decimal)reader["A3_GAIL_LT_RLING_0_5_MMBTU"],
                A3_IOCL_LT_RLING_MMBTU = (decimal)reader["A3_IOCL_LT_RLING_MMBTU"],
                A3_SPOT_GAS_GSPC_MMBTU = (decimal)reader["A3_SPOT_GAS_GSPC_MMBTU"],
                A3_NG_EXPORT_TO_GP_I = (decimal)reader["A3_NG_EXPORT_TO_GP_I"],
                A3_NG_EXPORT_TO_GP_II = (decimal)reader["A3_NG_EXPORT_TO_GP_II"],
                A3_LCV_AS_PER_CFCL_LAB = (decimal)reader["A3_LCV_AS_PER_CFCL_LAB"],
                A3_IOCL_SPOT_GAS_MMBTU = (decimal)reader["A3_IOCL_SPOT_GAS_MMBTU"],
                A3_FALL_BACK_GAS_MMBTU = (decimal)reader["A3_FALL_BACK_GAS_MMBTU"],
                A3_TOT_NG_RECV = (decimal)reader["A3_TOT_NG_RECV"],
                A3_GSPN_SPOT_RLING_ALLOC = (decimal)reader["A3_GSPN_SPOT_RLING_ALLOC"],
                A3_GAIL_LT_RLING_1_9_ALLOC = (decimal)reader["A3_GAIL_LT_RLING_1_9_ALLOC"],
                A3_GAIL_LT_RLING_0_5_ALLOC = (decimal)reader["A3_GAIL_LT_RLING_0_5_ALLOC"],
                A3_IOCL_LT_RLING_ALLOC = (decimal)reader["A3_IOCL_LT_RLING_ALLOC"],
                A3_SPOT_GAS_GSPC_ALLOC = (decimal)reader["A3_SPOT_GAS_GSPC_ALLOC"],
                A3_NG_AMM = (decimal)reader["A3_NG_AMM"],
                A3_AMM_FUEL = (decimal)reader["A3_AMM_FUEL"],
                A3_AMM_FEED_BY_BALANCE = (decimal)reader["A3_AMM_FEED_BY_BALANCE"],
                A3_NG_IMPORT_FROM_GP_I = (decimal)reader["A3_NG_IMPORT_FROM_GP_I"],
                A3_NG_IMPORT_FROM_GP_II = (decimal)reader["A3_NG_IMPORT_FROM_GP_II"],
                A3_IOCL_SPOT_GAS_ALLOC = (decimal)reader["A3_IOCL_SPOT_GAS_ALLOC"],
                A3_FALL_BACK_GAS_ALLOC = (decimal)reader["A3_FALL_BACK_GAS_ALLOC"],
                A3_GSPN_SPOT_RLING_RECEIPT = (decimal)reader["A3_GSPN_SPOT_RLING_RECEIPT"],
                A3_GAIL_LT_RLING_1_9_RECEIPT = (decimal)reader["A3_GAIL_LT_RLING_1_9_RECEIPT"],
                A3_GAIL_LT_RLING_0_5_RECEIPT = (decimal)reader["A3_GAIL_LT_RLING_0_5_RECEIPT"],
                A3_IOCL_LT_RLING_RECEIPT = (decimal)reader["A3_IOCL_LT_RLING_RECEIPT"],
                A3_SPOT_GAS_GSPC_RECEIPT = (decimal)reader["A3_SPOT_GAS_GSPC_RECEIPT"],
                A3_IOCL_SPOT_GAS_RECEIPT = (decimal)reader["A3_IOCL_SPOT_GAS_RECEIPT"],
                A3_FALL_BACK_GAS_RECEIPT = (decimal)reader["A3_FALL_BACK_GAS_RECEIPT"],
                DIS_NG_CONS_GTG3_HRSG3 = (decimal)reader["DIS_NG_CONS_GTG3_HRSG3"],

                // --------PRIORITY-------------------
                A3_GSPN_SPOT_RLING_MMBTU_PRIORITY = reader["A3_GSPN_SPOT_RLING_MMBTU_PRIORITY"].ToString(),
                A3_GAIL_LT_RLING_1_9_MMBTU_PRIORITY = reader["A3_GAIL_LT_RLING_1_9_MMBTU_PRIORITY"].ToString(),
                A3_GAIL_LT_RLING_0_5_MMBTU_PRIORITY = reader["A3_GAIL_LT_RLING_0_5_MMBTU_PRIORITY"].ToString(),
                A3_IOCL_LT_RLING_MMBTU_PRIORITY = reader["A3_IOCL_LT_RLING_MMBTU_PRIORITY"].ToString(),
                A3_SPOT_GAS_GSPC_MMBTU_PRIORITY = reader["A3_SPOT_GAS_GSPC_MMBTU_PRIORITY"].ToString(),
                A3_IOCL_SPOT_GAS_MMBTU_PRIORITY = reader["A3_IOCL_SPOT_GAS_MMBTU_PRIORITY"].ToString(),
                A3_FALL_BACK_GAS_MMBTU_PRIORITY = reader["A3_FALL_BACK_GAS_MMBTU_PRIORITY"].ToString(),

                PRIORITY_TAG1 = reader["PRIORITY_TAG1"].ToString(),
                PRIORITY_TAG2 = reader["PRIORITY_TAG2"].ToString(),
                PRIORITY_TAG3 = reader["PRIORITY_TAG3"].ToString(),
                PRIORITY_TAG4 = reader["PRIORITY_TAG4"].ToString(),
                PRIORITY_TAG5 = reader["PRIORITY_TAG5"].ToString(),
                PRIORITY_TAG6 = reader["PRIORITY_TAG6"].ToString(),
                PRIORITY_TAG7 = reader["PRIORITY_TAG7"].ToString(),

                // -----------------------PPT_AM3_NITROGEN_PROD---------------------------
                A3_HPN_INT = (decimal)reader["A3_HPN_INT"],
                A3_PSA_NITROGEN_GEN_INT = (decimal)reader["A3_PSA_NITROGEN_GEN_INT"],
                A3_PSA_NITROGEN_TO_AMM_3_INT = (decimal)reader["A3_PSA_NITROGEN_TO_AMM_3_INT"],
                A3_PSA_NITROGEN_TO_UR_3_INT = (decimal)reader["A3_PSA_NITROGEN_TO_UR_3_INT"],
                A3_PSA_NITROGEN_TO_OSBL = (decimal)reader["A3_PSA_NITROGEN_TO_OSBL"],
                A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT = (decimal)reader["A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT"],
                A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT = (decimal)reader["A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT"],
                A3_HPN_INT_DIFF = (decimal)reader["A3_HPN_INT_DIFF"],
                A3_PSA_NITROGEN_GEN_INT_DIFF = (decimal)reader["A3_PSA_NITROGEN_GEN_INT_DIFF"],
                A3_PSA_NITROGEN_TO_AMM_3_INT_DIFF = (decimal)reader["A3_PSA_NITROGEN_TO_AMM_3_INT_DIFF"],
                A3_PSA_NITROGEN_TO_UR_3_INT_DIFF = (decimal)reader["A3_PSA_NITROGEN_TO_UR_3_INT_DIFF"],
                A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT_DIFF = (decimal)reader["A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT_DIFF"],
                A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT_DIFF = (decimal)reader["A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT_DIFF"],
                A3_PSA_NITROGEN_TO_AMM_I = (decimal)reader["A3_PSA_NITROGEN_TO_AMM_I"],
                A3_PSA_NITROGEN_TO_AMM_II = (decimal)reader["A3_PSA_NITROGEN_TO_AMM_II"],
                A3_IA_FROM_ONU_GP_III = (decimal)reader["A3_IA_FROM_ONU_GP_III"],

                // -------------PRV-------PPT_AM3_NITROGEN_PROD-------------------------------------
                PRV_A3_HPN_INT = (decimal)reader["PRV_A3_HPN_INT"],
                PRV_A3_PSA_NITROGEN_GEN_INT = (decimal)reader["PRV_A3_PSA_NITROGEN_GEN_INT"],
                PRV_A3_PSA_NITROGEN_TO_AMM_3_INT = (decimal)reader["PRV_A3_PSA_NITROGEN_TO_AMM_3_INT"],
                PRV_A3_PSA_NITROGEN_TO_UR_3_INT = (decimal)reader["PRV_A3_PSA_NITROGEN_TO_UR_3_INT"],
                PRV_A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT = (decimal)reader["PRV_A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT"],
                PRV_A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT = (decimal)reader["PRV_A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT"],

                //---------------------PPT_AM3_PRODUCTION_SHEET--------------------------------
                A3_ON_STREAM_HRS = (decimal)reader["A3_ON_STREAM_HRS"],
                A3_AMM_SALE = (decimal)reader["A3_AMM_SALE"],
                A3_HOT_AMM_TO_UR_INT = (decimal)reader["A3_HOT_AMM_TO_UR_INT"],
                A3_HOT_AMM_TO_UR_INT_DIFF = (decimal)reader["A3_HOT_AMM_TO_UR_INT_DIFF"],
                A3_COLD_AMM_TO_AMM_STORAGE_INT = (decimal)reader["A3_COLD_AMM_TO_AMM_STORAGE_INT"],
                A3_COLD_AMM_TO_AMM_STORAGE_INT_DIFF = (decimal)reader["A3_COLD_AMM_TO_AMM_STORAGE_INT_DIFF"],
                A3_AMM_VAPOR_FROM_STORAGE_INT = (decimal)reader["A3_AMM_VAPOR_FROM_STORAGE_INT"],
                A3_AMM_VAPOR_FROM_STORAGE_INT_DIFF = (decimal)reader["A3_AMM_VAPOR_FROM_STORAGE_INT_DIFF"],
                A3_AMM_PROD = (decimal)reader["A3_AMM_PROD"],
                A3_COLD_SUPPLY_TO_UR = (decimal)reader["A3_COLD_SUPPLY_TO_UR"],
                A3_TOT_AMM_TO_UR = (decimal)reader["A3_TOT_AMM_TO_UR"],
                A3_STK_TRSFER_FROM_GP3_TO_GP1 = (decimal)reader["A3_STK_TRSFER_FROM_GP3_TO_GP1"],
                A3_STK_TRSFER_FROM_GP3_TO_GP2 = (decimal)reader["A3_STK_TRSFER_FROM_GP3_TO_GP2"],
                A3_STK_TRSFER_FROM_GP1_TO_GP3 = (decimal)reader["A3_STK_TRSFER_FROM_GP1_TO_GP3"],
                A3_STK_TRSFER_FROM_GP2_TO_GP3 = (decimal)reader["A3_STK_TRSFER_FROM_GP2_TO_GP3"],
                A3_AMM_3_LOGICAL_STK = (decimal)reader["A3_AMM_3_LOGICAL_STK"],
                A3_CAPACITY_UTILIZATION = (decimal)reader["A3_CAPACITY_UTILIZATION"],
                A3_REMARK = reader["A3_REMARK"].ToString(),
                A3_MON_REMARK = reader["A3_MON_REMARK"].ToString(),
                DIS_AMMI_LOGICAL_STK = (decimal)reader["DIS_AMMI_LOGICAL_STK"],
                DIS_AMMII_LOGICAL_STK = (decimal)reader["DIS_AMMII_LOGICAL_STK"],
                DIS_TOT_AMM_STK = (decimal)reader["DIS_TOT_AMM_STK"],

                // -------------PRV----------------PPT_AM3_PRODUCTION_SHEET--------------------------
                PRV_A3_HOT_AMM_TO_UR_INT = (decimal)reader["PRV_A3_HOT_AMM_TO_UR_INT"],
                PRV_A3_COLD_AMM_TO_AMM_STORAGE_INT = (decimal)reader["PRV_A3_COLD_AMM_TO_AMM_STORAGE_INT"],
                PRV_A3_AMM_VAPOR_FROM_STORAGE_INT = (decimal)reader["PRV_A3_AMM_VAPOR_FROM_STORAGE_INT"],

                // ------------------------PPT_AM3_SPECIFIC_CONS-------------------------------------
                A3_AMM_SP_CONSP_FEED_GAS = (decimal)reader["A3_AMM_SP_CONSP_FEED_GAS"],
                A3_AMM_SP_CONSP_FUEL_GAS = (decimal)reader["A3_AMM_SP_CONSP_FUEL_GAS"],
                A3_AMM_SP_CONSP_TOT_GAS = (decimal)reader["A3_AMM_SP_CONSP_TOT_GAS"],
                A3_AMM_SP_CONSP_MP_STEAM_EXPORT = (decimal)reader["A3_AMM_SP_CONSP_MP_STEAM_EXPORT"],
                A3_AMM_SP_CONSP_IP_STEAM_EXPORT = (decimal)reader["A3_AMM_SP_CONSP_IP_STEAM_EXPORT"],
                A3_AMM_SP_CONSP_LP_STEAM_IMPORT = (decimal)reader["A3_AMM_SP_CONSP_LP_STEAM_IMPORT"],
                A3_AMM_SP_CONSP_POLISHED_WATER_IMPORT = (decimal)reader["A3_AMM_SP_CONSP_POLISHED_WATER_IMPORT"],
                A3_AMM_SP_CONSP_APC_EXPORT = (decimal)reader["A3_AMM_SP_CONSP_APC_EXPORT"],
                A3_AMM_SP_CONSP_TURBINE_COND_EXPORT = (decimal)reader["A3_AMM_SP_CONSP_TURBINE_COND_EXPORT"],
                A3_AMM_SP_CONSP_TOT_COND_EXPORT = (decimal)reader["A3_AMM_SP_CONSP_TOT_COND_EXPORT"],
                A3_AMM_SP_CONSP_PWR_CONSP_ACT = (decimal)reader["A3_AMM_SP_CONSP_PWR_CONSP_ACT"],
                A3_AMM_SP_CONSP_GROSS_PWR_AMM = (decimal)reader["A3_AMM_SP_CONSP_GROSS_PWR_AMM"],
                A3_AMM_SP_CONSP_ACT_CT_MAKEUP = (decimal)reader["A3_AMM_SP_CONSP_ACT_CT_MAKEUP"],
                A3_AMM_SP_CONSP_SPECIFIC_AMM = (decimal)reader["A3_AMM_SP_CONSP_SPECIFIC_AMM"],
                A3_UR_SP_CONSP_SPECIFIC_FEED = (decimal)reader["A3_UR_SP_CONSP_SPECIFIC_FEED"],
                A3_UR_SP_CONSP_SPECIFIC_FUEL = (decimal)reader["A3_UR_SP_CONSP_SPECIFIC_FUEL"],
                A3_UR_SP_CONSP_SPECIFIC_TOT_FEED_FUEL = (decimal)reader["A3_UR_SP_CONSP_SPECIFIC_TOT_FEED_FUEL"],
                A3_UR_SP_CONSP_ONU_FUEL = (decimal)reader["A3_UR_SP_CONSP_ONU_FUEL"],
                A3_UR_SP_CONSP_TOT_GAS = (decimal)reader["A3_UR_SP_CONSP_TOT_GAS"],
                A3_UR_SP_CONSP_MP_STEAM = (decimal)reader["A3_UR_SP_CONSP_MP_STEAM"],
                A3_UR_SP_CONSP_IP_STEAM = (decimal)reader["A3_UR_SP_CONSP_IP_STEAM"],
                A3_UR_SP_CONSP_LP_STEAM = (decimal)reader["A3_UR_SP_CONSP_LP_STEAM"],
                A3_UR_SP_CONSP_PWR_CONSP_UCT = (decimal)reader["A3_UR_SP_CONSP_PWR_CONSP_UCT"],
                A3_UR_SP_CONSP_NET_PWR_UR = (decimal)reader["A3_UR_SP_CONSP_NET_PWR_UR"],
                A3_UR_SP_CONSP_UCT_CT_MAKEUP = (decimal)reader["A3_UR_SP_CONSP_UCT_CT_MAKEUP"],
                A3_UR_SP_CONSP_POLISH_WATER = (decimal)reader["A3_UR_SP_CONSP_POLISH_WATER"],

                // ---------------------PPT_AM3_SPECIFIC_ENERGY----------------------------
                A3_SP_ENG_FEED_GAS = (decimal)reader["A3_SP_ENG_FEED_GAS"],
                A3_SP_ENG_FUEL_GAS = (decimal)reader["A3_SP_ENG_FUEL_GAS"],
                A3_SP_ENG_TOT_FEED_FUEL = (decimal)reader["A3_SP_ENG_TOT_FEED_FUEL"],
                A3_SP_ENG_CREDIT_FOR_MP_STEAM_EXPORT = (decimal)reader["A3_SP_ENG_CREDIT_FOR_MP_STEAM_EXPORT"],
                A3_SP_ENG_CREDIT_FOR_IP_STEAM_EXPORT = (decimal)reader["A3_SP_ENG_CREDIT_FOR_IP_STEAM_EXPORT"],
                A3_SP_ENG_LP_STEAM = (decimal)reader["A3_SP_ENG_LP_STEAM"],
                A3_SP_ENG_PWR_AMM = (decimal)reader["A3_SP_ENG_PWR_AMM"],
                A3_SP_ENG_ACT_ENG = (decimal)reader["A3_SP_ENG_ACT_ENG"],
                A3_SP_ENG_NET_ENG_AMM = (decimal)reader["A3_SP_ENG_NET_ENG_AMM"],
                A3_SP_ENG_UR_ENG_FEED_FUEL = (decimal)reader["A3_SP_ENG_UR_ENG_FEED_FUEL"],
                A3_SP_ENG_CREDIT_FOR_KS_STEAM_TO_GP1 = (decimal)reader["A3_SP_ENG_CREDIT_FOR_KS_STEAM_TO_GP1"],
                A3_SP_ENG_CREDIT_FOR_PWR_EXPORT_VCU = (decimal)reader["A3_SP_ENG_CREDIT_FOR_PWR_EXPORT_VCU"],
                A3_SP_ENG_UR = (decimal)reader["A3_SP_ENG_UR"],
                A3_SP_ENG_ALLOC_FOR_CV_UR_ENG = (decimal)reader["A3_SP_ENG_ALLOC_FOR_CV_UR_ENG"],
                A3_SP_ENG_NET_ENG_UR = (decimal)reader["A3_SP_ENG_NET_ENG_UR"],
                A3_SP_ENG_RSEB_PWR_CONSP = (decimal)reader["A3_SP_ENG_RSEB_PWR_CONSP"],

                // --------------------PPT_AM3_STEAM-----------------------------------
                A3_MP_STEAM_EXPORT_TO_UR_INT = (decimal)reader["A3_MP_STEAM_EXPORT_TO_UR_INT"],
                A3_MP_STEAM_EXPORT_TO_OSBL_INT = (decimal)reader["A3_MP_STEAM_EXPORT_TO_OSBL_INT"],
                A3_MP_STEAM_TO_ACT_TP7801A_INT = (decimal)reader["A3_MP_STEAM_TO_ACT_TP7801A_INT"],
                A3_RUN_HRS_FOR_ACT_TA_INT = (decimal)reader["A3_RUN_HRS_FOR_ACT_TA_INT"],
                A3_MP_STEAM_TO_ACT_TP7801B_INT = (decimal)reader["A3_MP_STEAM_TO_ACT_TP7801B_INT"],
                A3_RUN_HRS_FOR_ACT_TB_INT = (decimal)reader["A3_RUN_HRS_FOR_ACT_TB_INT"],
                A3_MP_STEAM_TO_UCT_TP7808A_INT = (decimal)reader["A3_MP_STEAM_TO_UCT_TP7808A_INT"],
                A3_RUN_HRS_FOR_UCT_TA_INT = (decimal)reader["A3_RUN_HRS_FOR_UCT_TA_INT"],
                A3_MP_STEAM_TO_UCT_TP7808B_INT = (decimal)reader["A3_MP_STEAM_TO_UCT_TP7808B_INT"],
                A3_RUN_HRS_FOR_UCT_TB_INT = (decimal)reader["A3_RUN_HRS_FOR_UCT_TB_INT"],
                A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT = (decimal)reader["A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT"],
                A3_IP_STEAM_EXPORT_TO_CT_INT = (decimal)reader["A3_IP_STEAM_EXPORT_TO_CT_INT"],
                A3_MP_STEAM_EXPORT_TO_UR_INT_DIFF = (decimal)reader["A3_MP_STEAM_EXPORT_TO_UR_INT_DIFF"],
                A3_MP_STEAM_EXPORT_TO_OSBL_INT_DIFF = (decimal)reader["A3_MP_STEAM_EXPORT_TO_OSBL_INT_DIFF"],
                A3_MP_STEAM_TO_ACT_TP7801A_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_ACT_TP7801A_INT_DIFF"],
                A3_MP_STEAM_TO_ACT_TP7801B_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_ACT_TP7801B_INT_DIFF"],
                A3_MP_STEAM_TO_UCT_TP7808A_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_UCT_TP7808A_INT_DIFF"],
                A3_MP_STEAM_TO_UCT_TP7808B_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_UCT_TP7808B_INT_DIFF"],
                A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT_DIFF = (decimal)reader["A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT_DIFF"],
                A3_IP_STEAM_EXPORT_TO_CT_INT_DIFF = (decimal)reader["A3_IP_STEAM_EXPORT_TO_CT_INT_DIFF"],
                A3_MP_STEAM_IMPORT_FROM_OSBL = (decimal)reader["A3_MP_STEAM_IMPORT_FROM_OSBL"],
                A3_MP_STEAM_IMPORT_FROM_OSBL_INT = (decimal)reader["A3_MP_STEAM_IMPORT_FROM_OSBL_INT"],
                A3_MP_STEAM_IMPORT_FROM_OSBL_INT_DIFF = (decimal)reader["A3_MP_STEAM_IMPORT_FROM_OSBL_INT_DIFF"],
                A3_NET_MP_STEAM_EXPORT_TO_OSBL = (decimal)reader["A3_NET_MP_STEAM_EXPORT_TO_OSBL"],
                A3_TOT_MP_STEAM_EXPORT = (decimal)reader["A3_TOT_MP_STEAM_EXPORT"],
                A3_ACT_T_COND = (decimal)reader["A3_ACT_T_COND"],
                A3_UCT_MP_STEAM_CONSP = (decimal)reader["A3_UCT_MP_STEAM_CONSP"],
                A3_UCT_T_COND = (decimal)reader["A3_UCT_T_COND"],
                A3_NET_IP_STEAM_EXPORT = (decimal)reader["A3_NET_IP_STEAM_EXPORT"],
                A3_LP_STEAM_TO_RO_ZLD = (decimal)reader["A3_LP_STEAM_TO_RO_ZLD"],
                A3_ACT_CONSP = (decimal)reader["A3_ACT_CONSP"],
                A3_UCT_CONSP = (decimal)reader["A3_UCT_CONSP"],
                A3_TOT_CT_STEAM_CONSP = (decimal)reader["A3_TOT_CT_STEAM_CONSP"],
                DIS_IP_STEAM_ROZLD = (decimal)reader["DIS_IP_STEAM_ROZLD"],

                // -------------PRV---------PPT_AM3_STEAM-----------------------------------
                PRV_A3_MP_STEAM_EXPORT_TO_UR_INT = (decimal)reader["PRV_A3_MP_STEAM_EXPORT_TO_UR_INT"],
                PRV_A3_MP_STEAM_EXPORT_TO_OSBL_INT = (decimal)reader["PRV_A3_MP_STEAM_EXPORT_TO_OSBL_INT"],
                PRV_A3_MP_STEAM_TO_ACT_TP7801A_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_ACT_TP7801A_INT"],
                PRV_A3_RUN_HRS_FOR_ACT_TA_INT = (decimal)reader["PRV_A3_RUN_HRS_FOR_ACT_TA_INT"],
                PRV_A3_MP_STEAM_TO_ACT_TP7801B_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_ACT_TP7801B_INT"],
                PRV_A3_RUN_HRS_FOR_ACT_TB_INT = (decimal)reader["PRV_A3_RUN_HRS_FOR_ACT_TB_INT"],
                PRV_A3_MP_STEAM_TO_UCT_TP7808A_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_UCT_TP7808A_INT"],
                PRV_A3_RUN_HRS_FOR_UCT_TA_INT = (decimal)reader["PRV_A3_RUN_HRS_FOR_UCT_TA_INT"],
                PRV_A3_MP_STEAM_TO_UCT_TP7808B_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_UCT_TP7808B_INT"],
                PRV_A3_RUN_HRS_FOR_UCT_TB_INT = (decimal)reader["PRV_A3_RUN_HRS_FOR_UCT_TB_INT"],
                PRV_A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT = (decimal)reader["PRV_A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT"],
                PRV_A3_IP_STEAM_EXPORT_TO_CT_INT = (decimal)reader["PRV_A3_IP_STEAM_EXPORT_TO_CT_INT"],
                PRV_A3_MP_STEAM_IMPORT_FROM_OSBL_INT = (decimal)reader["PRV_A3_MP_STEAM_IMPORT_FROM_OSBL_INT"],

                // ----------------------PPT_AM3_STEAM_CONS----------------------------
                A3_GEN_FROM_141_D_INT = (decimal)reader["A3_GEN_FROM_141_D_INT"],
                A3_BFW_TO_ATTEMPERATOR_INT = (decimal)reader["A3_BFW_TO_ATTEMPERATOR_INT"],
                A3_TOT_HP_STEAM = (decimal)reader["A3_TOT_HP_STEAM"],
                A3_HP_STEAM_TO_103_JT_INT = (decimal)reader["A3_HP_STEAM_TO_103_JT_INT"],
                A3_HP_STEAM_TO_105_JT_INT = (decimal)reader["A3_HP_STEAM_TO_105_JT_INT"],
                A3_HP_STEAM_TO_172_C_INT = (decimal)reader["A3_HP_STEAM_TO_172_C_INT"],
                A3_HP_STEAM_TO_LETDOWN = (decimal)reader["A3_HP_STEAM_TO_LETDOWN"],
                A3_GEN_FROM_103_JT_INT = (decimal)reader["A3_GEN_FROM_103_JT_INT"],
                A3_BFW_TO_HP_MP_PRDS = (decimal)reader["A3_BFW_TO_HP_MP_PRDS"],
                A3_NET_MP_STEAM_GEN_BY_AMM = (decimal)reader["A3_NET_MP_STEAM_GEN_BY_AMM"],
                A3_STEAM_TO_PRIMRY_REFMR_INT = (decimal)reader["A3_STEAM_TO_PRIMRY_REFMR_INT"],
                A3_MP_STEAM_TO_104_JT_INT = (decimal)reader["A3_MP_STEAM_TO_104_JT_INT"],
                A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT = (decimal)reader["A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT"],
                A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT = (decimal)reader["A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT"],
                A3_MP_STEAM_TO_EXCHANGERS_INT = (decimal)reader["A3_MP_STEAM_TO_EXCHANGERS_INT"],
                A3_MP_STEAM_TO_IP_LETDOWN = (decimal)reader["A3_MP_STEAM_TO_IP_LETDOWN"],
                A3_GEN_FROM_130_L_INT = (decimal)reader["A3_GEN_FROM_130_L_INT"],
                A3_DESUPERHEAT_WATER = (decimal)reader["A3_DESUPERHEAT_WATER"],
                A3_TOT_IP_STEAM = (decimal)reader["A3_TOT_IP_STEAM"],
                A3_IP_CONSP = (decimal)reader["A3_IP_CONSP"],
                A3_GEN_FROM_141_D_INT_DIFF = (decimal)reader["A3_GEN_FROM_141_D_INT_DIFF"],
                A3_BFW_TO_ATTEMPERATOR_INT_DIFF = (decimal)reader["A3_BFW_TO_ATTEMPERATOR_INT_DIFF"],
                A3_HP_STEAM_TO_103_JT_INT_DIFF = (decimal)reader["A3_HP_STEAM_TO_103_JT_INT_DIFF"],
                A3_HP_STEAM_TO_105_JT_INT_DIFF = (decimal)reader["A3_HP_STEAM_TO_105_JT_INT_DIFF"],
                A3_GEN_FROM_103_JT_INT_DIFF = (decimal)reader["A3_GEN_FROM_103_JT_INT_DIFF"],
                A3_STEAM_TO_PRIMRY_REFMR_INT_DIFF = (decimal)reader["A3_STEAM_TO_PRIMRY_REFMR_INT_DIFF"],
                A3_MP_STEAM_TO_104_JT_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_104_JT_INT_DIFF"],
                A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT_DIFF"],
                A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT_DIFF = (decimal)reader["A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT_DIFF"],
                A3_GEN_FROM_130_L_INT_DIFF = (decimal)reader["A3_GEN_FROM_130_L_INT_DIFF"],
                DIS_GEN_105_JT = (decimal)reader["DIS_GEN_105_JT"],
                DIS_FORM_MP_LETDOWN = (decimal)reader["DIS_FORM_MP_LETDOWN"],
                DIS_FROM_HP_MP_PRDS = (decimal)reader["DIS_FROM_HP_MP_PRDS"],

                // -------------PRV--------------PPT_AM3_STEAM_CONS------------------------------
                PRV_A3_GEN_FROM_141_D_INT = (decimal)reader["PRV_A3_GEN_FROM_141_D_INT"],
                PRV_A3_BFW_TO_ATTEMPERATOR_INT = (decimal)reader["PRV_A3_BFW_TO_ATTEMPERATOR_INT"],
                PRV_A3_HP_STEAM_TO_103_JT_INT = (decimal)reader["PRV_A3_HP_STEAM_TO_103_JT_INT"],
                PRV_A3_HP_STEAM_TO_105_JT_INT = (decimal)reader["PRV_A3_HP_STEAM_TO_105_JT_INT"],
                PRV_A3_GEN_FROM_103_JT_INT = (decimal)reader["PRV_A3_GEN_FROM_103_JT_INT"],
                PRV_A3_STEAM_TO_PRIMRY_REFMR_INT = (decimal)reader["PRV_A3_STEAM_TO_PRIMRY_REFMR_INT"],
                PRV_A3_MP_STEAM_TO_104_JT_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_104_JT_INT"],
                PRV_A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT"],
                PRV_A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT = (decimal)reader["PRV_A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT"],
                PRV_A3_GEN_FROM_130_L_INT = (decimal)reader["PRV_A3_GEN_FROM_130_L_INT"],

                // ---------------------PPT_AM3_WATER_DIS---------------------------------
                A3_ACT_MAKEUP_INT = (decimal)reader["A3_ACT_MAKEUP_INT"],
                A3_ACT_MAKEUP_FROM_RO = (decimal)reader["A3_ACT_MAKEUP_FROM_RO"],
                A3_UCT_MAKEUP_INT = (decimal)reader["A3_UCT_MAKEUP_INT"],
                A3_POLISHED_WATER_TO_AMM_INT = (decimal)reader["A3_POLISHED_WATER_TO_AMM_INT"],
                A3_ACT_TO_OSBL = (decimal)reader["A3_ACT_TO_OSBL"],
                A3_ACT_TO_OSBL_INT = (decimal)reader["A3_ACT_TO_OSBL_INT"],
                A3_ACT_TO_OSBL_INT_DIFF = (decimal)reader["A3_ACT_TO_OSBL_INT_DIFF"],
                A3_ACT_CIRC_FLOW_INT = (decimal)reader["A3_ACT_CIRC_FLOW_INT"],
                A3_ACT_CIRC_FLOW_INT_DIFF = (decimal)reader["A3_ACT_CIRC_FLOW_INT_DIFF"],
                A3_UCT_CIRC_FLOW_INT = (decimal)reader["A3_UCT_CIRC_FLOW_INT"],
                A3_UCT_CIRC_FLOW_INT_DIFF = (decimal)reader["A3_UCT_CIRC_FLOW_INT_DIFF"],
                A3_ACT_BLOWDOWN_INT = (decimal)reader["A3_ACT_BLOWDOWN_INT"],
                A3_UCT_BLOWDOWN_INT = (decimal)reader["A3_UCT_BLOWDOWN_INT"],
                A3_TOT_BLOWDOWN = (decimal)reader["A3_TOT_BLOWDOWN"],
                A3_SSF_PIT_PUMP_RUN_HRS = (decimal)reader["A3_SSF_PIT_PUMP_RUN_HRS"],
                A3_EFFL_FROM_SSF_PIT = (decimal)reader["A3_EFFL_FROM_SSF_PIT"],
                A3_OILY_WATER_PUMP_RUN_HRS = (decimal)reader["A3_OILY_WATER_PUMP_RUN_HRS"],
                A3_OILY_WATER_TO_OSBL = (decimal)reader["A3_OILY_WATER_TO_OSBL"],
                A3_ACT_MAKEUP_INT_DIFF = (decimal)reader["A3_ACT_MAKEUP_INT_DIFF"],
                A3_NET_ACT_MAKEUP = (decimal)reader["A3_NET_ACT_MAKEUP"],
                A3_UCT_MAKEUP_INT_DIFF = (decimal)reader["A3_UCT_MAKEUP_INT_DIFF"],
                A3_UCT_MAKEUP_FROM_RO = (decimal)reader["A3_UCT_MAKEUP_FROM_RO"],
                A3_NET_UCT_MAKEUP = (decimal)reader["A3_NET_UCT_MAKEUP"],
                A3_POLISHED_WATER_TO_AMM_INT_DIFF = (decimal)reader["A3_POLISHED_WATER_TO_AMM_INT_DIFF"],
                A3_ACT_BLOWDOWN_INT_DIFF = (decimal)reader["A3_ACT_BLOWDOWN_INT_DIFF"],
                A3_UCT_BLOWDOWN_INT_DIFF = (decimal)reader["A3_UCT_BLOWDOWN_INT_DIFF"],
                DIS_PERMEATE_REC_RO = (decimal)reader["DIS_PERMEATE_REC_RO"],
                A3_SSP_PIT_TOT_EFF_TRSFER_INT = (decimal)reader["A3_SSP_PIT_TOT_EFF_TRSFER_INT"],
                A3_SSP_PIT_TOT_EFF_TRSFER_INT_DIFF = (decimal)reader["A3_SSP_PIT_TOT_EFF_TRSFER_INT_DIFF"],

                // -------------PRV------------PPT_AM3_WATER_DIS-----------------------------------
                PRV_A3_ACT_MAKEUP_INT = (decimal)reader["PRV_A3_ACT_MAKEUP_INT"],
                PRV_A3_UCT_MAKEUP_INT = (decimal)reader["PRV_A3_UCT_MAKEUP_INT"],
                PRV_A3_POLISHED_WATER_TO_AMM_INT = (decimal)reader["PRV_A3_POLISHED_WATER_TO_AMM_INT"],
                PRV_A3_ACT_TO_OSBL_INT = (decimal)reader["PRV_A3_ACT_TO_OSBL_INT"],
                PRV_A3_ACT_CIRC_FLOW_INT = (decimal)reader["PRV_A3_ACT_CIRC_FLOW_INT"],
                PRV_A3_UCT_CIRC_FLOW_INT = (decimal)reader["PRV_A3_UCT_CIRC_FLOW_INT"],
                PRV_A3_ACT_BLOWDOWN_INT = (decimal)reader["PRV_A3_ACT_BLOWDOWN_INT"],
                PRV_A3_UCT_BLOWDOWN_INT = (decimal)reader["PRV_A3_UCT_BLOWDOWN_INT"],
                PRV_A3_SSP_PIT_TOT_EFF_TRSFER_INT = (decimal)reader["PRV_A3_SSP_PIT_TOT_EFF_TRSFER_INT"],
            };
        }

        public async Task<PAS301Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM3_GET_PPT_AM3_AMMONIA_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PAS301Model response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    return response;
                }
            }
        }

        // GET DV DATA
        private PAS301ModelDV MapToValue2(SqlDataReader reader)
        {
            return new PAS301ModelDV()
            {
                O3_KS_TO_MP_LETDOWN_DIFF = (dynamic)reader["O3_KS_TO_MP_LETDOWN_DIFF"],
                O3_MP_STEAM_HRSG3_BFW_TP7601A_DIFF = (dynamic)reader["O3_MP_STEAM_HRSG3_BFW_TP7601A_DIFF"],
                U3_COLD_AMM_RECV_INT_DIFF = (dynamic)reader["U3_COLD_AMM_RECV_INT_DIFF"],
                UN_TCD_CONS = (dynamic)reader["UN_TCD_CONS"],
                U3_IP_STEAM_IMPORT_INT_DIFF = (dynamic)reader["U3_IP_STEAM_IMPORT_INT_DIFF"],
                O3_PERMEATE_GP3 = (dynamic)reader["O3_PERMEATE_GP3"],
                U3_TC_EXPORT_INT_DIFF = (dynamic)reader["U3_TC_EXPORT_INT_DIFF"],
                O3_TURBINE_COND_DIFF = (dynamic)reader["O3_TURBINE_COND_DIFF"],
                E3_TOT_11_KV_SUPPLY_TO_CT = (dynamic)reader["E3_TOT_11_KV_SUPPLY_TO_CT"],
                E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF = (dynamic)reader["E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF"],
                E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF = (dynamic)reader["E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF"],
                E3_AMM_415_V_PMCC_1_INT_DIFF = (dynamic)reader["E3_AMM_415_V_PMCC_1_INT_DIFF"],
                E3_AMM_415_V_PMCC_2_INT_DIFF = (dynamic)reader["E3_AMM_415_V_PMCC_2_INT_DIFF"],
                E3_3_3_KV_UNACCOUNTED = (dynamic)reader["E3_3_3_KV_UNACCOUNTED"],
                E3_11_KV_PWR_GP3_UNACCOUNTED = (dynamic)reader["E3_11_KV_PWR_GP3_UNACCOUNTED"],
                E3_TOT_AMM_PWR_CONSP = (dynamic)reader["E3_TOT_AMM_PWR_CONSP"],
                O3_GP3_ONU_TOTAL_CONSP = (dynamic)reader["O3_GP3_ONU_TOTAL_CONSP"],
                U3_TOT_UR_PROD = (dynamic)reader["U3_TOT_UR_PROD"],
                UN_MPSE_CONS = (dynamic)reader["UN_MPSE_CONS"],
                UN_IPSE_CONS = (dynamic)reader["UN_IPSE_CONS"],
                Eq_NG_Per_MWh_of_Power = (dynamic)reader["Eq_NG_Per_MWh_of_Power"],
                O3_NG_RECV_GP1_FOR_GTG3_HRSG3_CONSP = (dynamic)reader["O3_NG_RECV_GP1_FOR_GTG3_HRSG3_CONSP"],
                O3_NG_RECV_GP3_FOR_GTG3_HRSG4_CONSP = (dynamic)reader["O3_NG_RECV_GP3_FOR_GTG3_HRSG4_CONSP"],
                GPI_NCV = (dynamic)reader["GPI_NCV"],
                GPII_NCV = (dynamic)reader["GPII_NCV"],
                Total_ng_alloc = (dynamic)reader["Total_ng_alloc"],
                A3_HSDLS_CONS = (dynamic)reader["A3_HSDLS_CONS"],
                A3_SALS_CONS = (dynamic)reader["A3_SALS_CONS"],
                A3_HALS_CONS = (dynamic)reader["A3_HALS_CONS"],
                A3_SHCLS_CONS = (dynamic)reader["A3_SHCLS_CONS"],
                A3_SCLS_CONS = (dynamic)reader["A3_SCLS_CONS"],
                A3_BFWD_CONS = (dynamic)reader["A3_BFWD_CONS"],
                A3_HPMPL_CONS = (dynamic)reader["A3_HPMPL_CONS"],
                A3_MPIPL_CONS = (dynamic)reader["A3_MPIPL_CONS"],
                A3_SGBD_CONS = (dynamic)reader["A3_SGBD_CONS"],
                A3_IPBD_CONS = (dynamic)reader["A3_IPBD_CONS"],
                A3_TTVL_CONS = (dynamic)reader["A3_TTVL_CONS"],
                A3_SSF_RC_CONS = (dynamic)reader["A3_SSF_RC_CONS"],
                A3_OWP_RC_CONS = (dynamic)reader["A3_OWP_RC_CONS"],
                A3_SP_ENG_ALLOC_FOR_CV_UR_ENG_CV = (dynamic)reader["A3_SP_ENG_ALLOC_FOR_CV_UR_ENG_CV"],
                A3_SP_ENG_RSEB_PWR_CONSP_CV = (dynamic)reader["A3_SP_ENG_RSEB_PWR_CONSP_CV"],
                A3_AMM_3_LOGICAL_OP_STK = (dynamic)reader["A3_AMM_3_LOGICAL_OP_STK"],
            };
        }

        public async Task<PAS301ModelDV> putData2(TransactionDateDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM3_GET_PPT_AM3_AMMONIA_DETAILS_DV", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    PAS301ModelDV response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue2(reader);
                        }
                    }
                    return response;
                }
            }
        }

        // SAVE DATA
        public async Task saveData(PAS301SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_AM3_SAVE_PPT_AM3_AMMONIA_DETAILS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_TDATE", value.A3_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_USER_ID", value.A3_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_BY", value.ENTERED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODIFIED_BY", value.MODIFIED_BY));

                    // --------------------PPT_AM3_NG_SHEET1-----------------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_INT", value.A3_PRS_NG_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_INT", value.A3_TEMP_NG_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_NG_INT", value.A3_TOT_NG_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_AS_GT_FUEL_INT", value.A3_PRS_NG_AS_GT_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_AS_GT_FUEL_INT", value.A3_TEMP_NG_AS_GT_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GT_FUEL_NG_INT", value.A3_GT_FUEL_NG_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_AS_REFMR_FUEL_INT", value.A3_PRS_NG_AS_REFMR_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_AS_REFMR_FUEL_INT", value.A3_TEMP_NG_AS_REFMR_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_PRIMRY_REFMR_INT", value.A3_NG_FUEL_TO_PRIMRY_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_AS_SUPRHEATER_FUEL_INT", value.A3_PRS_NG_AS_SUPRHEATER_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT", value.A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_SUPRHEATER_INT", value.A3_NG_FUEL_TO_SUPRHEATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_STATUPHEATER_INT", value.A3_NG_FUEL_TO_STATUPHEATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FEED_INT", value.A3_NG_FEED_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_INT_DIFF", value.A3_PRS_NG_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_INT_DIFF", value.A3_TEMP_NG_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_NG_INT_DIFF", value.A3_TOT_NG_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_AS_GT_FUEL_INT_DIFF", value.A3_PRS_NG_AS_GT_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_AS_GT_FUEL_INT_DIFF", value.A3_TEMP_NG_AS_GT_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GT_FUEL_NG_INT_DIFF", value.A3_GT_FUEL_NG_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_AS_REFMR_FUEL_INT_DIFF", value.A3_PRS_NG_AS_REFMR_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_AS_REFMR_FUEL_INT_DIFF", value.A3_TEMP_NG_AS_REFMR_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_PRIMRY_REFMR_INT_DIFF", value.A3_NG_FUEL_TO_PRIMRY_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_NG_AS_SUPRHEATER_FUEL_INT_DIFF", value.A3_PRS_NG_AS_SUPRHEATER_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT_DIFF", value.A3_TEMP_NG_AS_SUPRHEATER_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_SUPRHEATER_INT_DIFF", value.A3_NG_FUEL_TO_SUPRHEATER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_STATUPHEATER_INT_DIFF", value.A3_NG_FUEL_TO_STATUPHEATER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FEED_INT_DIFF", value.A3_NG_FEED_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_NG_CONSP", value.A3_TOT_NG_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GT_FUEL_NG_CONSP", value.A3_GT_FUEL_NG_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_PRIMRY_REFMR_CONSP", value.A3_NG_FUEL_TO_PRIMRY_REFMR_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_SUPRHEATER_CONSP", value.A3_NG_FUEL_TO_SUPRHEATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_STATUPHEATER_CONSP", value.A3_NG_FUEL_TO_STATUPHEATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FEED_CONSP", value.A3_NG_FEED_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_FUEL_CONSP", value.A3_TOT_FUEL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_FUEL_TO_FLARE_STACK_CONSP", value.A3_NG_FUEL_TO_FLARE_STACK_CONSP));

                    // ------------------------------PPT_AM3_NG_SHEET2---------------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_METER_A_INT", value.A3_GAIL_METER_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_METER_B_INT", value.A3_GAIL_METER_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_MOLECULAR_WT", value.A3_NG_MOLECULAR_WT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_GCV", value.A3_NG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_CARBON_NUMBER", value.A3_NG_CARBON_NUMBER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_LCV", value.A3_NG_LCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GSPN_SPOT_RLING_MMBTU", value.A3_GSPN_SPOT_RLING_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_LT_RLING_1_9_MMBTU", value.A3_GAIL_LT_RLING_1_9_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_LT_RLING_0_5_MMBTU", value.A3_GAIL_LT_RLING_0_5_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IOCL_LT_RLING_MMBTU", value.A3_IOCL_LT_RLING_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SPOT_GAS_GSPC_MMBTU", value.A3_SPOT_GAS_GSPC_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_EXPORT_TO_GP_I", value.A3_NG_EXPORT_TO_GP_I));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_EXPORT_TO_GP_II", value.A3_NG_EXPORT_TO_GP_II));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_NG_RECV", value.A3_TOT_NG_RECV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GSPN_SPOT_RLING_ALLOC", value.A3_GSPN_SPOT_RLING_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_LT_RLING_1_9_ALLOC", value.A3_GAIL_LT_RLING_1_9_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_LT_RLING_0_5_ALLOC", value.A3_GAIL_LT_RLING_0_5_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IOCL_LT_RLING_ALLOC", value.A3_IOCL_LT_RLING_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SPOT_GAS_GSPC_ALLOC", value.A3_SPOT_GAS_GSPC_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_AMM", value.A3_NG_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_FUEL", value.A3_AMM_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_FEED_BY_BALANCE", value.A3_AMM_FEED_BY_BALANCE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_IMPORT_FROM_GP_I", value.A3_NG_IMPORT_FROM_GP_I));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NG_IMPORT_FROM_GP_II", value.A3_NG_IMPORT_FROM_GP_II));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GSPN_SPOT_RLING_RECEIPT", value.A3_GSPN_SPOT_RLING_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_LT_RLING_1_9_RECEIPT", value.A3_GAIL_LT_RLING_1_9_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GAIL_LT_RLING_0_5_RECEIPT", value.A3_GAIL_LT_RLING_0_5_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IOCL_LT_RLING_RECEIPT", value.A3_IOCL_LT_RLING_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SPOT_GAS_GSPC_RECEIPT", value.A3_SPOT_GAS_GSPC_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LCV_AS_PER_CFCL_LAB", value.A3_LCV_AS_PER_CFCL_LAB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IOCL_SPOT_GAS_MMBTU", value.A3_IOCL_SPOT_GAS_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IOCL_SPOT_GAS_ALLOC", value.A3_IOCL_SPOT_GAS_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IOCL_SPOT_GAS_RECEIPT", value.A3_IOCL_SPOT_GAS_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FALL_BACK_GAS_MMBTU", value.A3_FALL_BACK_GAS_MMBTU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FALL_BACK_GAS_ALLOC", value.A3_FALL_BACK_GAS_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FALL_BACK_GAS_RECEIPT", value.A3_FALL_BACK_GAS_RECEIPT));

                    // -------------------PPT_AM3_CO2_SHEET--------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_CO2_TO_UR_INT", value.A3_PRS_CO2_TO_UR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_CO2_TO_UR_INT", value.A3_TEMP_CO2_TO_UR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_CO2_TO_UR_INT", value.A3_TOT_CO2_TO_UR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_SURPLUS_SYN_GAS_INT", value.A3_PRS_SURPLUS_SYN_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_SURPLUS_SYN_GAS_INT", value.A3_TEMP_SURPLUS_SYN_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT", value.A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SYNGAS_EXPORT_TO_GP1_GP2", value.A3_SYNGAS_EXPORT_TO_GP1_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_CO2_EXPORT_TO_GP1", value.A3_CO2_EXPORT_TO_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_CO2_EXPORT_TO_GP2", value.A3_CO2_EXPORT_TO_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT", value.A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PASSIVATION_AIR_TO_UR_INT", value.A3_PASSIVATION_AIR_TO_UR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_WASTE_FUEL_GAS_INT", value.A3_PRS_WASTE_FUEL_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_WASTE_FUEL_GAS_INT", value.A3_TEMP_WASTE_FUEL_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT", value.A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_CO2_TO_UR_INT_DIFF", value.A3_PRS_CO2_TO_UR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_CO2_TO_UR_INT_DIFF", value.A3_TEMP_CO2_TO_UR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_CO2_TO_UR_INT_DIFF", value.A3_TOT_CO2_TO_UR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_SURPLUS_SYN_GAS_INT_DIFF", value.A3_PRS_SURPLUS_SYN_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_SURPLUS_SYN_GAS_INT_DIFF", value.A3_TEMP_SURPLUS_SYN_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT_DIFF", value.A3_TOT_SURPLUS_SYN_GAS_TO_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT_DIFF", value.A3_SYNGAS_IMPORT_FROM_GP1_GP2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PASSIVATION_AIR_TO_UR_INT_DIFF", value.A3_PASSIVATION_AIR_TO_UR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PRS_WASTE_FUEL_GAS_INT_DIFF", value.A3_PRS_WASTE_FUEL_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TEMP_WASTE_FUEL_GAS_INT_DIFF", value.A3_TEMP_WASTE_FUEL_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT_DIFF", value.A3_TOT_WASTE_FUEL_TO_PRIMRY_REFMR_INT_DIFF));

                    //---------------------PPT_AM3_PRODUCTION_SHEET--------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ON_STREAM_HRS", value.A3_ON_STREAM_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SALE", value.A3_AMM_SALE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HOT_AMM_TO_UR_INT", value.A3_HOT_AMM_TO_UR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HOT_AMM_TO_UR_INT_DIFF", value.A3_HOT_AMM_TO_UR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_COLD_AMM_TO_AMM_STORAGE_INT", value.A3_COLD_AMM_TO_AMM_STORAGE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_VAPOR_FROM_STORAGE_INT", value.A3_AMM_VAPOR_FROM_STORAGE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_PROD", value.A3_AMM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_COLD_SUPPLY_TO_UR", value.A3_COLD_SUPPLY_TO_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_AMM_TO_UR", value.A3_TOT_AMM_TO_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STK_TRSFER_FROM_GP3_TO_GP1", value.A3_STK_TRSFER_FROM_GP3_TO_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STK_TRSFER_FROM_GP3_TO_GP2", value.A3_STK_TRSFER_FROM_GP3_TO_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STK_TRSFER_FROM_GP1_TO_GP3", value.A3_STK_TRSFER_FROM_GP1_TO_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STK_TRSFER_FROM_GP2_TO_GP3", value.A3_STK_TRSFER_FROM_GP2_TO_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_3_LOGICAL_STK", value.A3_AMM_3_LOGICAL_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_CAPACITY_UTILIZATION", value.A3_CAPACITY_UTILIZATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_COLD_AMM_TO_AMM_STORAGE_INT_DIFF", value.A3_COLD_AMM_TO_AMM_STORAGE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_VAPOR_FROM_STORAGE_INT_DIFF", value.A3_AMM_VAPOR_FROM_STORAGE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_REMARK", value.A3_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MON_REMARK", value.A3_MON_REMARK));

                    // --------------------PPT_AM3_STEAM-----------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_EXPORT_TO_UR_INT", value.A3_MP_STEAM_EXPORT_TO_UR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_EXPORT_TO_OSBL_INT", value.A3_MP_STEAM_EXPORT_TO_OSBL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_ACT_TP7801A_INT", value.A3_MP_STEAM_TO_ACT_TP7801A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_RUN_HRS_FOR_ACT_TA_INT", value.A3_RUN_HRS_FOR_ACT_TA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_ACT_TP7801B_INT", value.A3_MP_STEAM_TO_ACT_TP7801B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_RUN_HRS_FOR_ACT_TB_INT", value.A3_RUN_HRS_FOR_ACT_TB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_UCT_TP7808A_INT", value.A3_MP_STEAM_TO_UCT_TP7808A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_RUN_HRS_FOR_UCT_TA_INT", value.A3_RUN_HRS_FOR_UCT_TA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_UCT_TP7808B_INT", value.A3_MP_STEAM_TO_UCT_TP7808B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_RUN_HRS_FOR_UCT_TB_INT", value.A3_RUN_HRS_FOR_UCT_TB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT", value.A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IP_STEAM_EXPORT_TO_CT_INT", value.A3_IP_STEAM_EXPORT_TO_CT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LP_STEAM_TO_RO_ZLD", value.A3_LP_STEAM_TO_RO_ZLD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_EXPORT_TO_UR_INT_DIFF", value.A3_MP_STEAM_EXPORT_TO_UR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_EXPORT_TO_OSBL_INT_DIFF", value.A3_MP_STEAM_EXPORT_TO_OSBL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_ACT_TP7801A_INT_DIFF", value.A3_MP_STEAM_TO_ACT_TP7801A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_ACT_TP7801B_INT_DIFF", value.A3_MP_STEAM_TO_ACT_TP7801B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_MP_STEAM_EXPORT", value.A3_TOT_MP_STEAM_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_T_COND", value.A3_ACT_T_COND));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_UCT_TP7808A_INT_DIFF", value.A3_MP_STEAM_TO_UCT_TP7808A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_UCT_TP7808B_INT_DIFF", value.A3_MP_STEAM_TO_UCT_TP7808B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_MP_STEAM_CONSP", value.A3_UCT_MP_STEAM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_T_COND", value.A3_UCT_T_COND));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT_DIFF", value.A3_IP_STEAM_EXPORT_TO_UR_PLUS_ROZLD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IP_STEAM_EXPORT_TO_CT_INT_DIFF", value.A3_IP_STEAM_EXPORT_TO_CT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NET_IP_STEAM_EXPORT", value.A3_NET_IP_STEAM_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_CONSP", value.A3_ACT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_CONSP", value.A3_UCT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_IMPORT_FROM_OSBL", value.A3_MP_STEAM_IMPORT_FROM_OSBL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_CT_STEAM_CONSP", value.A3_TOT_CT_STEAM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_IMPORT_FROM_OSBL_INT", value.A3_MP_STEAM_IMPORT_FROM_OSBL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_IMPORT_FROM_OSBL_INT_DIFF", value.A3_MP_STEAM_IMPORT_FROM_OSBL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NET_MP_STEAM_EXPORT_TO_OSBL", value.A3_NET_MP_STEAM_EXPORT_TO_OSBL));

                    // ---------------------PPT_AM3_WATER_DIS---------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_MAKEUP_INT", value.A3_ACT_MAKEUP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_MAKEUP_FROM_RO", value.A3_ACT_MAKEUP_FROM_RO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_MAKEUP_INT", value.A3_UCT_MAKEUP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_POLISHED_WATER_TO_AMM_INT", value.A3_POLISHED_WATER_TO_AMM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_TO_OSBL", value.A3_ACT_TO_OSBL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_TO_OSBL_INT", value.A3_ACT_TO_OSBL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_CIRC_FLOW_INT", value.A3_ACT_CIRC_FLOW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_CIRC_FLOW_INT", value.A3_UCT_CIRC_FLOW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_BLOWDOWN_INT", value.A3_ACT_BLOWDOWN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_BLOWDOWN_INT", value.A3_UCT_BLOWDOWN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_BLOWDOWN", value.A3_TOT_BLOWDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SSF_PIT_PUMP_RUN_HRS", value.A3_SSF_PIT_PUMP_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_EFFL_FROM_SSF_PIT", value.A3_EFFL_FROM_SSF_PIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_OILY_WATER_PUMP_RUN_HRS", value.A3_OILY_WATER_PUMP_RUN_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_OILY_WATER_TO_OSBL", value.A3_OILY_WATER_TO_OSBL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_MAKEUP_INT_DIFF", value.A3_ACT_MAKEUP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NET_ACT_MAKEUP", value.A3_NET_ACT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_MAKEUP_INT_DIFF", value.A3_UCT_MAKEUP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_MAKEUP_FROM_RO", value.A3_UCT_MAKEUP_FROM_RO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NET_UCT_MAKEUP", value.A3_NET_UCT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_POLISHED_WATER_TO_AMM_INT_DIFF", value.A3_POLISHED_WATER_TO_AMM_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_BLOWDOWN_INT_DIFF", value.A3_ACT_BLOWDOWN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_BLOWDOWN_INT_DIFF", value.A3_UCT_BLOWDOWN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_TO_OSBL_INT_DIFF", value.A3_ACT_TO_OSBL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_CIRC_FLOW_INT_DIFF", value.A3_ACT_CIRC_FLOW_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_CIRC_FLOW_INT_DIFF", value.A3_UCT_CIRC_FLOW_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SSP_PIT_TOT_EFF_TRSFER_INT", value.A3_SSP_PIT_TOT_EFF_TRSFER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SSP_PIT_TOT_EFF_TRSFER_INT_DIFF", value.A3_SSP_PIT_TOT_EFF_TRSFER_INT_DIFF));

                    // ------------------------PPT_AM3_SPECIFIC_CONS-------------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_FEED_GAS", value.A3_AMM_SP_CONSP_FEED_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_FUEL_GAS", value.A3_AMM_SP_CONSP_FUEL_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_TOT_GAS", value.A3_AMM_SP_CONSP_TOT_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_MP_STEAM_EXPORT", value.A3_AMM_SP_CONSP_MP_STEAM_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_IP_STEAM_EXPORT", value.A3_AMM_SP_CONSP_IP_STEAM_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_LP_STEAM_IMPORT", value.A3_AMM_SP_CONSP_LP_STEAM_IMPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_POLISHED_WATER_IMPORT", value.A3_AMM_SP_CONSP_POLISHED_WATER_IMPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_APC_EXPORT", value.A3_AMM_SP_CONSP_APC_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_TURBINE_COND_EXPORT", value.A3_AMM_SP_CONSP_TURBINE_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_TOT_COND_EXPORT", value.A3_AMM_SP_CONSP_TOT_COND_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_PWR_CONSP_ACT", value.A3_AMM_SP_CONSP_PWR_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_GROSS_PWR_AMM", value.A3_AMM_SP_CONSP_GROSS_PWR_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_ACT_CT_MAKEUP", value.A3_AMM_SP_CONSP_ACT_CT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_AMM_SP_CONSP_SPECIFIC_AMM", value.A3_AMM_SP_CONSP_SPECIFIC_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_SPECIFIC_FEED", value.A3_UR_SP_CONSP_SPECIFIC_FEED));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_SPECIFIC_FUEL", value.A3_UR_SP_CONSP_SPECIFIC_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_SPECIFIC_TOT_FEED_FUEL", value.A3_UR_SP_CONSP_SPECIFIC_TOT_FEED_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_ONU_FUEL", value.A3_UR_SP_CONSP_ONU_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_TOT_GAS", value.A3_UR_SP_CONSP_TOT_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_MP_STEAM", value.A3_UR_SP_CONSP_MP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_IP_STEAM", value.A3_UR_SP_CONSP_IP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_LP_STEAM", value.A3_UR_SP_CONSP_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_PWR_CONSP_UCT", value.A3_UR_SP_CONSP_PWR_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_NET_PWR_UR", value.A3_UR_SP_CONSP_NET_PWR_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_UCT_CT_MAKEUP", value.A3_UR_SP_CONSP_UCT_CT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UR_SP_CONSP_POLISH_WATER", value.A3_UR_SP_CONSP_POLISH_WATER));

                    // ---------------------PPT_AM3_SPECIFIC_ENERGY----------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_FEED_GAS", value.A3_SP_ENG_FEED_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_FUEL_GAS", value.A3_SP_ENG_FUEL_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_TOT_FEED_FUEL", value.A3_SP_ENG_TOT_FEED_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_CREDIT_FOR_MP_STEAM_EXPORT", value.A3_SP_ENG_CREDIT_FOR_MP_STEAM_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_CREDIT_FOR_IP_STEAM_EXPORT", value.A3_SP_ENG_CREDIT_FOR_IP_STEAM_EXPORT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_LP_STEAM", value.A3_SP_ENG_LP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_PWR_AMM", value.A3_SP_ENG_PWR_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_ACT_ENG", value.A3_SP_ENG_ACT_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_NET_ENG_AMM", value.A3_SP_ENG_NET_ENG_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_UR_ENG_FEED_FUEL", value.A3_SP_ENG_UR_ENG_FEED_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_CREDIT_FOR_KS_STEAM_TO_GP1", value.A3_SP_ENG_CREDIT_FOR_KS_STEAM_TO_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_CREDIT_FOR_PWR_EXPORT_VCU", value.A3_SP_ENG_CREDIT_FOR_PWR_EXPORT_VCU));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_UR", value.A3_SP_ENG_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_ALLOC_FOR_CV_UR_ENG", value.A3_SP_ENG_ALLOC_FOR_CV_UR_ENG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_NET_ENG_UR", value.A3_SP_ENG_NET_ENG_UR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SP_ENG_RSEB_PWR_CONSP", value.A3_SP_ENG_RSEB_PWR_CONSP));

                    // ---------------------PPT_AM3_ACT_UCT--------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_CIRC_FLOW", value.A3_ACT_CIRC_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_MAKEUP", value.A3_ACT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_SUPPLY_TEMP", value.A3_ACT_SUPPLY_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_RETURN_TEMP", value.A3_ACT_RETURN_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_DRY_BULB_TEMP", value.A3_ACT_DRY_BULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_WET_BULB_TEMP", value.A3_ACT_WET_BULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_WET_APPWACH", value.A3_ACT_WET_APPWACH));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_RANGE", value.A3_ACT_RANGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_HEAT_DUTY", value.A3_ACT_HEAT_DUTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ACT_THERMAL_EFF", value.A3_ACT_THERMAL_EFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_CIRC_FLOW", value.A3_UCT_CIRC_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_MAKEUP", value.A3_UCT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_SUPPLY_TEMP", value.A3_UCT_SUPPLY_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_RETURN_TEMP", value.A3_UCT_RETURN_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_DRY_BULB_TEMP", value.A3_UCT_DRY_BULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_WET_BULB_TEMP", value.A3_UCT_WET_BULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_WET_APPWACH", value.A3_UCT_WET_APPWACH));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_RANGE", value.A3_UCT_RANGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_HEAT_DUTY", value.A3_UCT_HEAT_DUTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_UCT_THERMAL_EFF", value.A3_UCT_THERMAL_EFF));

                    // ---------------------AM3_CHEMICAL_CONS_DTL---------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_RECEIPT", value.A3_HSD_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_H2SO4_RECEIPT", value.A3_H2SO4_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HCL_RECEIPT", value.A3_HCL_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NAOCL_RECEIPT", value.A3_NAOCL_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NaClO2_RECEIPT", value.A3_NaClO2_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_aMDEA_RECEIPT", value.A3_aMDEA_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_Antifoam_RECEIPT", value.A3_Antifoam_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_O2_SCAVENGER_RECEIPT", value.A3_O2_SCAVENGER_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PH_BOOSTER_RECEIPT", value.A3_PH_BOOSTER_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PHOF_PHAPE_RECEIPT", value.A3_PHOF_PHAPE_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_CHEMICAL_REMARK", value.A3_CHEMICAL_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_TANK", value.A3_HSD_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_H2SO4_TANK", value.A3_H2SO4_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HCL_TANK", value.A3_HCL_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NAOCL_TANK", value.A3_NAOCL_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NaClO2_TANK", value.A3_NaClO2_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_STK", value.A3_HSD_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_H2SO4_STK", value.A3_H2SO4_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HCL_STK", value.A3_HCL_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NAOCL_STK", value.A3_NAOCL_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NaClO2_STK", value.A3_NaClO2_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_aMDEA_STK", value.A3_aMDEA_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_Antifoam_STK", value.A3_Antifoam_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_O2_SCAVENGER_STK", value.A3_O2_SCAVENGER_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PH_BOOSTER_STK", value.A3_PH_BOOSTER_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PHOF_PHAPE_STK", value.A3_PHOF_PHAPE_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_CONSP", value.A3_HSD_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_H2SO4_CONSP", value.A3_H2SO4_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HCL_CONSP", value.A3_HCL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NAOCL_CONSP", value.A3_NAOCL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NaClO2_CONSP", value.A3_NaClO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_aMDEA_CONSP", value.A3_aMDEA_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_Antifoam_CONSP", value.A3_Antifoam_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_O2_SCAVENGER_CONSP", value.A3_O2_SCAVENGER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PH_BOOSTER_CONSP", value.A3_PH_BOOSTER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PHOF_PHAPE_CONSP", value.A3_PHOF_PHAPE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_OUTSIDE_RECEIPT", value.A3_HSD_OUTSIDE_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_OUTSIDE_TANK", value.A3_HSD_OUTSIDE_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_OUTSIDE_STK", value.A3_HSD_OUTSIDE_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HSD_OUTSIDE_CONSP", value.A3_HSD_OUTSIDE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PH_BOOSTER_B5780M_RECEIPT", value.A3_PH_BOOSTER_B5780M_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PH_BOOSTER_B5780M_STK", value.A3_PH_BOOSTER_B5780M_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PH_BOOSTER_B5780M_CONSP", value.A3_PH_BOOSTER_B5780M_CONSP));

                    // ----------------------PPT_AM3_STEAM_CONS----------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GEN_FROM_141_D_INT", value.A3_GEN_FROM_141_D_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_BFW_TO_ATTEMPERATOR_INT", value.A3_BFW_TO_ATTEMPERATOR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_HP_STEAM", value.A3_TOT_HP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_STEAM_TO_103_JT_INT", value.A3_HP_STEAM_TO_103_JT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_STEAM_TO_105_JT_INT", value.A3_HP_STEAM_TO_105_JT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_STEAM_TO_172_C_INT", value.A3_HP_STEAM_TO_172_C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_STEAM_TO_LETDOWN", value.A3_HP_STEAM_TO_LETDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GEN_FROM_103_JT_INT", value.A3_GEN_FROM_103_JT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_BFW_TO_HP_MP_PRDS", value.A3_BFW_TO_HP_MP_PRDS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_NET_MP_STEAM_GEN_BY_AMM", value.A3_NET_MP_STEAM_GEN_BY_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STEAM_TO_PRIMRY_REFMR_INT", value.A3_STEAM_TO_PRIMRY_REFMR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_104_JT_INT", value.A3_MP_STEAM_TO_104_JT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT", value.A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT", value.A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_EXCHANGERS_INT", value.A3_MP_STEAM_TO_EXCHANGERS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_IP_LETDOWN", value.A3_MP_STEAM_TO_IP_LETDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GEN_FROM_130_L_INT", value.A3_GEN_FROM_130_L_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_DESUPERHEAT_WATER", value.A3_DESUPERHEAT_WATER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_TOT_IP_STEAM", value.A3_TOT_IP_STEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IP_CONSP", value.A3_IP_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GEN_FROM_141_D_INT_DIFF", value.A3_GEN_FROM_141_D_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_BFW_TO_ATTEMPERATOR_INT_DIFF", value.A3_BFW_TO_ATTEMPERATOR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_STEAM_TO_103_JT_INT_DIFF", value.A3_HP_STEAM_TO_103_JT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_STEAM_TO_105_JT_INT_DIFF", value.A3_HP_STEAM_TO_105_JT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GEN_FROM_103_JT_INT_DIFF", value.A3_GEN_FROM_103_JT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STEAM_TO_PRIMRY_REFMR_INT_DIFF", value.A3_STEAM_TO_PRIMRY_REFMR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_104_JT_INT_DIFF", value.A3_MP_STEAM_TO_104_JT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT_DIFF", value.A3_MP_STEAM_TO_GT_DE_NOX_SYSTEM_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT_DIFF", value.A3_MP_STEAM_TO_SECONDARY_REFMR_SEALING_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_GEN_FROM_130_L_INT_DIFF", value.A3_GEN_FROM_130_L_INT_DIFF));

                    // -----------------------PPT_AM3_NITROGEN_PROD---------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HPN_INT", value.A3_HPN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_GEN_INT", value.A3_PSA_NITROGEN_GEN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_AMM_3_INT", value.A3_PSA_NITROGEN_TO_AMM_3_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_UR_3_INT", value.A3_PSA_NITROGEN_TO_UR_3_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_AMM_I", value.A3_PSA_NITROGEN_TO_AMM_I));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_AMM_II", value.A3_PSA_NITROGEN_TO_AMM_II));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_OSBL", value.A3_PSA_NITROGEN_TO_OSBL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT", value.A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT", value.A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_IA_FROM_ONU_GP_III", value.A3_IA_FROM_ONU_GP_III));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HPN_INT_DIFF", value.A3_HPN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_GEN_INT_DIFF", value.A3_PSA_NITROGEN_GEN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_AMM_3_INT_DIFF", value.A3_PSA_NITROGEN_TO_AMM_3_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PSA_NITROGEN_TO_UR_3_INT_DIFF", value.A3_PSA_NITROGEN_TO_UR_3_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT_DIFF", value.A3_SERVICE_AIR_FROM_ONU_TO_PSA_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT_DIFF", value.A3_SERVICE_AIR_FROM_PSA_TO_ONU_INT_DIFF));

                    // -------------------------PPT_AM3_ELE_POWER_RECEIPT-----------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_PUMP_A_INT", value.A3_SL_SLN_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_PUMP_B_INT", value.A3_SL_SLN_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_PUMP_C_INT", value.A3_SL_SLN_PUMP_C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LS_PUMP_A_INT", value.A3_LS_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LS_PUMP_B_INT", value.A3_LS_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_BFW_PUMP_A_INT", value.A3_HP_BFW_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ID_FAN_MOTOR_A_INT", value.A3_ID_FAN_MOTOR_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ID_FAN_MOTOR_B_INT", value.A3_ID_FAN_MOTOR_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LTS_SU_BLOWER_INT", value.A3_LTS_SU_BLOWER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_CIRCULATING_PUMP_A_INT", value.A3_SL_SLN_CIRCULATING_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_CIRCULATING_PUMP_B_INT", value.A3_SL_SLN_CIRCULATING_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FEED_GAS_COMP_VFD_INT", value.A3_FEED_GAS_COMP_VFD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FEED_GAS_COMP_DOL_INT", value.A3_FEED_GAS_COMP_DOL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FEED_GAS_COMP", value.A3_FEED_GAS_COMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STANDBY_AIR_COMP_INT", value.A3_STANDBY_AIR_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_101_JTG_JM11_INT", value.A3_101_JTG_JM11_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT", value.A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT", value.A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PURIFIER_EXPANDER_GEN_INT", value.A3_PURIFIER_EXPANDER_GEN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_PUMP_A_INT_DIFF", value.A3_SL_SLN_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_PUMP_B_INT_DIFF", value.A3_SL_SLN_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_PUMP_C_INT_DIFF", value.A3_SL_SLN_PUMP_C_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LS_PUMP_A_INT_DIFF", value.A3_LS_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LS_PUMP_B_INT_DIFF", value.A3_LS_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_HP_BFW_PUMP_A_INT_DIFF", value.A3_HP_BFW_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ID_FAN_MOTOR_A_INT_DIFF", value.A3_ID_FAN_MOTOR_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_ID_FAN_MOTOR_B_INT_DIFF", value.A3_ID_FAN_MOTOR_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_LTS_SU_BLOWER_INT_DIFF", value.A3_LTS_SU_BLOWER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_CIRCULATING_PUMP_A_INT_DIFF", value.A3_SL_SLN_CIRCULATING_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SL_SLN_CIRCULATING_PUMP_B_INT_DIFF", value.A3_SL_SLN_CIRCULATING_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FEED_GAS_COMP_VFD_INT_DIFF", value.A3_FEED_GAS_COMP_VFD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_FEED_GAS_COMP_DOL_INT_DIFF", value.A3_FEED_GAS_COMP_DOL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_STANDBY_AIR_COMP_INT_DIFF", value.A3_STANDBY_AIR_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_101_JTG_JM11_INT_DIFF", value.A3_101_JTG_JM11_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT_DIFF", value.A3_SUPPLY_TO_PSA_MOTOR_MK7001A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT_DIFF", value.A3_SUPPLY_TO_PSA_MOTOR_MK7001B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_PURIFIER_EXPANDER_GEN_INT_DIFF", value.A3_PURIFIER_EXPANDER_GEN_INT_DIFF));

                    // ----------------------PPT_AM3_MACHINERY_RUNNING_HR-----------------------------------
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_101_JGT_FIRED_HRS_INT", value.A3_MRH_101_JGT_FIRED_HRS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_SL_SLN_PUMP_A_INT", value.A3_MRH_SL_SLN_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_SL_SLN_PUMP_B_INT", value.A3_MRH_SL_SLN_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_SL_SLN_PUMP_C_INT", value.A3_MRH_SL_SLN_PUMP_C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_LS_PUMP_A_INT", value.A3_MRH_LS_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_LS_PUMP_B_INT", value.A3_MRH_LS_PUMP_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_HP_BFW_PUMP_TURBINE", value.A3_MRH_HP_BFW_PUMP_TURBINE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_HP_BFW_PUMP_A_INT", value.A3_MRH_HP_BFW_PUMP_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ID_FAN_MOTOR_A_INT", value.A3_MRH_ID_FAN_MOTOR_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ID_FAN_MOTOR_B_INT", value.A3_MRH_ID_FAN_MOTOR_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SYN_GAS_COMP_INT", value.A3_SYN_GAS_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_REFRIGERATION_COMP", value.A3_MRH_REFRIGERATION_COMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_FEED_GAS_COMP_VFD_INT", value.A3_MRH_FEED_GAS_COMP_VFD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_FEED_GAS_COMP_DOL_INT", value.A3_MRH_FEED_GAS_COMP_DOL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_STANDBY_AIR_COMP_INT", value.A3_MRH_STANDBY_AIR_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ACT_PUMP_7801A_INT", value.A3_MRH_ACT_PUMP_7801A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ACT_PUMP_7801B_INT", value.A3_MRH_ACT_PUMP_7801B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_UCT_PUMP_7808A_INT", value.A3_MRH_UCT_PUMP_7808A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_UCT_PUMP_7808B_INT", value.A3_MRH_UCT_PUMP_7808B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_PURIFIER_EXPANDER_GEN", value.A3_MRH_PURIFIER_EXPANDER_GEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_101_JGT_FIRED_HRS_INT_DIFF", value.A3_101_JGT_FIRED_HRS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_SL_SLN_PUMP_A_INT_DIFF", value.A3_MRH_SL_SLN_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_SL_SLN_PUMP_B_INT_DIFF", value.A3_MRH_SL_SLN_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_SL_SLN_PUMP_C_INT_DIFF", value.A3_MRH_SL_SLN_PUMP_C_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_LS_PUMP_A_INT_DIFF", value.A3_MRH_LS_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_LS_PUMP_B_INT_DIFF", value.A3_MRH_LS_PUMP_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_HP_BFW_PUMP_A_INT_DIFF", value.A3_MRH_HP_BFW_PUMP_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ID_FAN_MOTOR_A_INT_DIFF", value.A3_MRH_ID_FAN_MOTOR_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ID_FAN_MOTOR_B_INT_DIFF", value.A3_MRH_ID_FAN_MOTOR_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_SYN_GAS_COMP_INT_DIFF", value.A3_SYN_GAS_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_FEED_GAS_COMP_VFD_INT_DIFF", value.A3_MRH_FEED_GAS_COMP_VFD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_FEED_GAS_COMP_DOL_INT_DIFF", value.A3_MRH_FEED_GAS_COMP_DOL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_STANDBY_AIR_COMP_INT_DIFF", value.A3_MRH_STANDBY_AIR_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ACT_PUMP_7801A_INT_DIFF", value.A3_MRH_ACT_PUMP_7801A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_ACT_PUMP_7801B_INT_DIFF", value.A3_MRH_ACT_PUMP_7801B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A3_MRH_UCT_PUMP_7808B_INT_DIFF", value.A3_MRH_UCT_PUMP_7808B_INT_DIFF));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
