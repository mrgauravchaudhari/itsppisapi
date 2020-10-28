using itsppisapi.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PES301Repository
    {
        private readonly string _connectionString;
        public PES301Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        public async Task<List<PES301Model>> getData(TransactionDateDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_EL3_GET_PPT_EL3_ETECTRICAL_DETAILS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", data.btn));
                    var response = new List<PES301Model>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task<List<PES301DVModel>> getDVData(TransactionDateDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_EL3_GET_PPT_EL3_ETECTRICAL_DETAILS_DV]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.TransactionDate));
                    var response = new List<PES301DVModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue2(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PES301SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_EL3_SAVE_PPT_EL3_ETECTRICAL_DETAILS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_TDATE", value.TDATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_DMY_FLG", "D"));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_GAS_TURBINE_GEN_INT", value.E3_GAS_TURBINE_GEN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_GAS_TURBINE_GEN_INT_DIFF", value.E3_GAS_TURBINE_GEN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_GEN", value.E3_TOT_GEN));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RECEIPT_FROM_JVVNL_GRID_INT", value.E3_RECEIPT_FROM_JVVNL_GRID_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RECEIPT_FROM_JVVNL_GRID_INT_DIFF", value.E3_RECEIPT_FROM_JVVNL_GRID_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_BUS_A_TO_ISBL_INT", value.E3_11_KV_BUS_A_TO_ISBL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_BUS_B_TO_ISBL_INT", value.E3_11_KV_BUS_B_TO_ISBL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_CT_FEEDER_1_INT", value.E3_CT_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_CT_FEEDER_2_INT", value.E3_CT_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_11_KV_SUPPLY_TO_CT", value.E3_TOT_11_KV_SUPPLY_TO_CT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDG_T7", value.E3_PDG_T7));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDG_T8", value.E3_PDG_T8));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_1_INT", value.E3_11_KV_SUPPLY_TO_UPH_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_2_INT", value.E3_11_KV_SUPPLY_TO_UPH_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_BUS_A_TO_ISBL_INT_DIFF", value.E3_11_KV_BUS_A_TO_ISBL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_BUS_B_TO_ISBL_INT_DIFF", value.E3_11_KV_BUS_B_TO_ISBL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_11_KV_SUPPLY_TO_ISBL", value.E3_TOT_11_KV_SUPPLY_TO_ISBL));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_CT_FEEDER_1_INT_DIFF", value.E3_CT_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_CT_FEEDER_2_INT_DIFF", value.E3_CT_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDG_T7_ID", value.E3_PDG_T7_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDG_T8_ID", value.E3_PDG_T8_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_11_KV_SUPPLY_TO_ONU_3", value.E3_TOT_11_KV_SUPPLY_TO_ONU_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_1_INT_DIFF", value.E3_11_KV_SUPPLY_TO_UPH_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_2_INT_DIFF", value.E3_11_KV_SUPPLY_TO_UPH_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_PWR_GP3_TOT_11_KV_SUPPLY", value.E3_11_KV_PWR_GP3_TOT_11_KV_SUPPLY));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_PWR_GP3_UNACCOUNTED", value.E3_11_KV_PWR_GP3_UNACCOUNTED));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PERCENTAGE_GEN", value.E3_PERCENTAGE_GEN));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT", value.E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT", value.E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_11_KV_SUPPLY_TO_UPH_3", value.E3_TOT_11_KV_SUPPLY_TO_UPH_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT", value.E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT", value.E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_11_KV_SUPPLY_TO_ROZLD", value.E3_TOT_11_KV_SUPPLY_TO_ROZLD));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDI11_T8", value.E3_PDI11_T8));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDI11_T9", value.E3_PDI11_T9));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_3_3_KV_TRSFER", value.E3_TOT_3_3_KV_TRSFER));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_AMM_11KV_MOTOR", value.E3_SUPPLY_TO_AMM_11KV_MOTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_PWR_ISBL_TOT_11_KV_SUPPLY", value.E3_11_KV_PWR_ISBL_TOT_11_KV_SUPPLY));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_PWR_ISBL_UNACCOUNTED", value.E3_11_KV_PWR_ISBL_UNACCOUNTED));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT_DIFF", value.E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT_DIFF", value.E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT_DIFF", value.E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT_DIFF", value.E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDI11_T8_ID", value.E3_PDI11_T8_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_PDI11_T9_ID", value.E3_PDI11_T9_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_AMM_415_V_PMCC_1_INT", value.E3_AMM_415_V_PMCC_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_AMM_415_V_PMCC_2_INT", value.E3_AMM_415_V_PMCC_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TA_PMCC_FEEDER_1_INT", value.E3_UR_TA_PMCC_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TA_PMCC_FEEDER_2_INT", value.E3_UR_TA_PMCC_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TB_PMCC_FEEDER_1_INT", value.E3_UR_TB_PMCC_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TB_PMCC_FEEDER_2_INT", value.E3_UR_TB_PMCC_FEEDER_2_INT));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_UR_3_3_KV_MOTOR", value.E3_SUPPLY_TO_UR_3_3_KV_MOTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_3_3_KV_SUPPLY", value.E3_TOT_3_3_KV_SUPPLY));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_UNACCOUNTED", value.E3_3_3_KV_UNACCOUNTED));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_415V_PWR_AVAILABLE", value.E3_TOT_415V_PWR_AVAILABLE));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_LIGHTING_TRANSFMR_1_INT", value.E3_LIGHTING_TRANSFMR_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_LIGHTING_TRANSFMR_2_INT", value.E3_LIGHTING_TRANSFMR_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_LIGHT_LOAD", value.E3_TOT_LIGHT_LOAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UPS_FEEDER_1_INT", value.E3_UPS_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UPS_FEEDER_2_INT", value.E3_UPS_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_UPS_LOAD", value.E3_TOT_UPS_LOAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_HVAC_INT", value.E3_HVAC_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_CCR_HVAC_INT", value.E3_CCR_HVAC_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_OTHER_LT_LOADS", value.E3_OTHER_LT_LOADS));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_AMM_PWR_CONSP", value.E3_TOT_AMM_PWR_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_UR_PWR_CONSP", value.E3_TOT_UR_PWR_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_AMM_415_V_PMCC_1_INT_DIFF", value.E3_AMM_415_V_PMCC_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_AMM_415_V_PMCC_2_INT_DIFF", value.E3_AMM_415_V_PMCC_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TA_PMCC_FEEDER_1_INT_DIFF", value.E3_UR_TA_PMCC_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TA_PMCC_FEEDER_2_INT_DIFF", value.E3_UR_TA_PMCC_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TB_PMCC_FEEDER_1_INT_DIFF", value.E3_UR_TB_PMCC_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UR_TB_PMCC_FEEDER_2_INT_DIFF", value.E3_UR_TB_PMCC_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_LIGHTING_TRANSFMR_1_INT_DIFF", value.E3_LIGHTING_TRANSFMR_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_LIGHTING_TRANSFMR_2_INT_DIFF", value.E3_LIGHTING_TRANSFMR_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UPS_FEEDER_1_INT_DIFF", value.E3_UPS_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UPS_FEEDER_2_INT_DIFF", value.E3_UPS_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_HVAC_INT_DIFF", value.E3_HVAC_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_CCR_HVAC_INT_DIFF", value.E3_CCR_HVAC_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_PSA_MOTORS", value.E3_SUPPLY_TO_PSA_MOTORS));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_MP_7801C_INT", value.E3_11_KV_SUPPLY_TO_MP_7801C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_MP_7808C_INT", value.E3_11_KV_SUPPLY_TO_MP_7808C_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_415V_TRANSFMR_1_INT", value.E3_SUPPLY_TO_415V_TRANSFMR_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_415V_TRANSFMR_2_INT", value.E3_SUPPLY_TO_415V_TRANSFMR_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_TOT_415V_AVAILABLE", value.E3_11_KV_TOT_415V_AVAILABLE));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_CT_UNACCOUNTED", value.E3_11_KV_CT_UNACCOUNTED));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_MP_7601B_INT", value.E3_3_3_KV_SUPPLY_TO_MP_7601B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_MP_7811A_INT", value.E3_3_3_KV_SUPPLY_TO_MP_7811A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_MP_7811B_INT", value.E3_3_3_KV_SUPPLY_TO_MP_7811B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT", value.E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT", value.E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT", value.E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TOT_SUPPLY_TO_UTIL", value.E3_TOT_SUPPLY_TO_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_FAN_A_INT", value.E3_3_3_KV_SUPPLY_TO_FAN_A_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_FAN_B_INT", value.E3_3_3_KV_SUPPLY_TO_FAN_B_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT", value.E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT", value.E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT", value.E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_415_KV_TOT_3_3_KV_SUPPLY", value.E3_415_KV_TOT_3_3_KV_SUPPLY));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_ONU_UNACCOUNTED", value.E3_ONU_UNACCOUNTED));

                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TO_MAIN_AIR_COMP_INT", value.E3_TO_MAIN_AIR_COMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT", value.E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT", value.E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UTIL_UNACCOUNTED", value.E3_UTIL_UNACCOUNTED));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UTIL_TOT_415V_AVAILABLE", value.E3_UTIL_TOT_415V_AVAILABLE));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RW_RESERVOIR_FEEDER_1_INT", value.E3_RW_RESERVOIR_FEEDER_1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_DM4_CONSP", value.E3_DM4_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_WPT3_CONSP", value.E3_WPT3_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_ETP_CONSP", value.E3_ETP_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF", value.E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF", value.E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_415V_TRANSFMR_1_INT_DIFF", value.E3_SUPPLY_TO_415V_TRANSFMR_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_SUPPLY_TO_415V_TRANSFMR_2_INT_DIFF", value.E3_SUPPLY_TO_415V_TRANSFMR_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_MP_7601B_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_MP_7601B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_MP_7811A_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_MP_7811A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_MP_7811B_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_MP_7811B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_FAN_A_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_FAN_A_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_3_3_KV_SUPPLY_TO_FAN_B_INT_DIFF", value.E3_3_3_KV_SUPPLY_TO_FAN_B_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT_DIFF", value.E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF", value.E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF", value.E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_TO_MAIN_AIR_COMP_INT_DIFF", value.E3_TO_MAIN_AIR_COMP_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF", value.E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF", value.E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RW_RESERVOIR_FEEDER_1_INT_DIFF", value.E3_RW_RESERVOIR_FEEDER_1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RW_RESERVOIR_FEEDER_2_INT", value.E3_RW_RESERVOIR_FEEDER_2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RW_RESERVOIR_FEEDER_2_INT_DIFF", value.E3_RW_RESERVOIR_FEEDER_2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_E3_RW_RESERVOIR_CONSP", value.E3_RW_RESERVOIR_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_BY", value.ENTERED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODIFIED_BY", value.MODIFIED_BY));
                    //cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_DATETIME", value.ENTERED_DATETIME));
                    //cmd.Parameters.Add(new SqlParameter("@IN_MODIFY_DATETIME", value.MODIFY_DATETIME));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        private PES301DVModel MapToValue2(SqlDataReader reader)
        {
            return new PES301DVModel()
            {
                DIS_E3_RECEIPT_GTG1 = (decimal)reader["DIS_E3_RECEIPT_GTG1"],

                DIS_E3_RECEIPT_GTG2 = (decimal)reader["DIS_E3_RECEIPT_GTG2"],

                E3_SUPPLY_TO_AMM_11KV_MOTOR_CV = (decimal)reader["E3_SUPPLY_TO_AMM_11KV_MOTOR_CV"],

                DIS_SUPPLY_AMM_3_3KV_MOTORS = (decimal)reader["DIS_SUPPLY_AMM_3_3KV_MOTORS"],

                E3_SUPPLY_TO_UR_3_3_KV_MOTOR_CV = (decimal)reader["E3_SUPPLY_TO_UR_3_3_KV_MOTOR_CV"],

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
                A3_FEED_GAS_COMP = (decimal)reader["A3_FEED_GAS_COMP"],
                A3_STANDBY_AIR_COMP_INT_DIFF = (decimal)reader["A3_STANDBY_AIR_COMP_INT_DIFF"],
                A3_101_JTG_JM11_INT_DIFF = (decimal)reader["A3_101_JTG_JM11_INT_DIFF"],
                A3_PURIFIER_EXPANDER_GEN_INT_DIFF = (decimal)reader["A3_PURIFIER_EXPANDER_GEN_INT_DIFF"],
                A3_AMM_PROD = (decimal)reader["A3_AMM_PROD"],

                U3_TA_AMM_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TA_AMM_FEED_PUMP_A_INT_DIFF"],
                U3_TA_AMM_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TA_AMM_FEED_PUMP_B_INT_DIFF"],
                U3_TA_CARB_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TA_CARB_FEED_PUMP_A_INT_DIFF"],
                U3_TA_CARB_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TA_CARB_FEED_PUMP_B_INT_DIFF"],
                U3_TB_AMM_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TB_AMM_FEED_PUMP_A_INT_DIFF"],
                U3_TB_AMM_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TB_AMM_FEED_PUMP_B_INT_DIFF"],
                U3_TB_CARB_FEED_PUMP_A_INT_DIFF = (decimal)reader["U3_TB_CARB_FEED_PUMP_A_INT_DIFF"],
                U3_TB_CARB_FEED_PUMP_B_INT_DIFF = (decimal)reader["U3_TB_CARB_FEED_PUMP_B_INT_DIFF"],
                U3_HYDR_PUMP_A_INT_DIFF = (decimal)reader["U3_HYDR_PUMP_A_INT_DIFF"],
                U3_HYDR_PUMP_B_INT_DIFF = (decimal)reader["U3_HYDR_PUMP_B_INT_DIFF"],

                E3_SUPPLY_TO_PSA_MOTORS_CV = (decimal)reader["E3_SUPPLY_TO_PSA_MOTORS_CV"],

                O3_COND_TO_DM_TANK = (decimal)reader["O3_COND_TO_DM_TANK"],
                O3_DM_WATER_FROM_DM_STREAM_DIFF = (decimal)reader["O3_DM_WATER_FROM_DM_STREAM_DIFF"],
                O3_DM_WATER_TO_GP3_MBS = (decimal)reader["O3_DM_WATER_TO_GP3_MBS"],
                O3_FILTER_WATER_PROD = (decimal)reader["O3_FILTER_WATER_PROD"],
                OU3_TOT_ETP3_ENERGY_ALLOC = (decimal)reader["OU3_TOT_ETP3_ENERGY_ALLOC"]
            };
        }

        private PES301Model MapToValue(SqlDataReader reader)
        {
            return new PES301Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),

                TDATE = reader["TDATE"].ToString(),
                E3_DMY_FLG = (string)reader["E3_DMY_FLG"],
                E3_GAS_TURBINE_GEN_INT = (decimal)reader["E3_GAS_TURBINE_GEN_INT"],
                E3_GAS_TURBINE_GEN_INT_DIFF = (decimal)reader["E3_GAS_TURBINE_GEN_INT_DIFF"],
                E3_TOT_GEN = (decimal)reader["E3_TOT_GEN"],

                E3_RECEIPT_FROM_JVVNL_GRID_INT = (decimal)reader["E3_RECEIPT_FROM_JVVNL_GRID_INT"],
                E3_RECEIPT_FROM_JVVNL_GRID_INT_DIFF = (decimal)reader["E3_RECEIPT_FROM_JVVNL_GRID_INT_DIFF"],
                E3_11_KV_BUS_A_TO_ISBL_INT = (decimal)reader["E3_11_KV_BUS_A_TO_ISBL_INT"],
                E3_11_KV_BUS_B_TO_ISBL_INT = (decimal)reader["E3_11_KV_BUS_B_TO_ISBL_INT"],
                E3_CT_FEEDER_1_INT = (decimal)reader["E3_CT_FEEDER_1_INT"],
                E3_CT_FEEDER_2_INT = (decimal)reader["E3_CT_FEEDER_2_INT"],
                E3_TOT_11_KV_SUPPLY_TO_CT = (decimal)reader["E3_TOT_11_KV_SUPPLY_TO_CT"],
                E3_PDG_T7 = (decimal)reader["E3_PDG_T7"],
                E3_PDG_T8 = (decimal)reader["E3_PDG_T8"],
                E3_11_KV_SUPPLY_TO_UPH_1_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_1_INT"],
                E3_11_KV_SUPPLY_TO_UPH_2_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_2_INT"],
                E3_11_KV_BUS_A_TO_ISBL_INT_DIFF = (decimal)reader["E3_11_KV_BUS_A_TO_ISBL_INT_DIFF"],
                E3_11_KV_BUS_B_TO_ISBL_INT_DIFF = (decimal)reader["E3_11_KV_BUS_B_TO_ISBL_INT_DIFF"],
                E3_TOT_11_KV_SUPPLY_TO_ISBL = (decimal)reader["E3_TOT_11_KV_SUPPLY_TO_ISBL"],
                E3_CT_FEEDER_1_INT_DIFF = (decimal)reader["E3_CT_FEEDER_1_INT_DIFF"],
                E3_CT_FEEDER_2_INT_DIFF = (decimal)reader["E3_CT_FEEDER_2_INT_DIFF"],
                E3_PDG_T7_ID = (decimal)reader["E3_PDG_T7_ID"],
                E3_PDG_T8_ID = (decimal)reader["E3_PDG_T8_ID"],
                E3_TOT_11_KV_SUPPLY_TO_ONU_3 = (decimal)reader["E3_TOT_11_KV_SUPPLY_TO_ONU_3"],
                E3_11_KV_SUPPLY_TO_UPH_1_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_1_INT_DIFF"],
                E3_11_KV_SUPPLY_TO_UPH_2_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_2_INT_DIFF"],
                E3_11_KV_PWR_GP3_TOT_11_KV_SUPPLY = (decimal)reader["E3_11_KV_PWR_GP3_TOT_11_KV_SUPPLY"],
                E3_11_KV_PWR_GP3_UNACCOUNTED = (decimal)reader["E3_11_KV_PWR_GP3_UNACCOUNTED"],
                E3_PERCENTAGE_GEN = (decimal)reader["E3_PERCENTAGE_GEN"],

                E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT"],
                E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT"],
                E3_TOT_11_KV_SUPPLY_TO_UPH_3 = (decimal)reader["E3_TOT_11_KV_SUPPLY_TO_UPH_3"],
                E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT"],
                E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT"],
                E3_TOT_11_KV_SUPPLY_TO_ROZLD = (decimal)reader["E3_TOT_11_KV_SUPPLY_TO_ROZLD"],
                E3_PDI11_T8 = (decimal)reader["E3_PDI11_T8"],
                E3_PDI11_T9 = (decimal)reader["E3_PDI11_T9"],
                E3_TOT_3_3_KV_TRSFER = (decimal)reader["E3_TOT_3_3_KV_TRSFER"],
                E3_SUPPLY_TO_AMM_11KV_MOTOR = (decimal)reader["E3_SUPPLY_TO_AMM_11KV_MOTOR"],
                E3_11_KV_PWR_ISBL_TOT_11_KV_SUPPLY = (decimal)reader["E3_11_KV_PWR_ISBL_TOT_11_KV_SUPPLY"],
                E3_11_KV_PWR_ISBL_UNACCOUNTED = (decimal)reader["E3_11_KV_PWR_ISBL_UNACCOUNTED"],
                E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT_DIFF"],
                E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT_DIFF"],
                E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT_DIFF"],
                E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT_DIFF"],
                E3_PDI11_T8_ID = (decimal)reader["E3_PDI11_T8_ID"],
                E3_PDI11_T9_ID = (decimal)reader["E3_PDI11_T9_ID"],

                E3_AMM_415_V_PMCC_1_INT = (decimal)reader["E3_AMM_415_V_PMCC_1_INT"],
                E3_AMM_415_V_PMCC_2_INT = (decimal)reader["E3_AMM_415_V_PMCC_2_INT"],
                E3_UR_TA_PMCC_FEEDER_1_INT = (decimal)reader["E3_UR_TA_PMCC_FEEDER_1_INT"],
                E3_UR_TA_PMCC_FEEDER_2_INT = (decimal)reader["E3_UR_TA_PMCC_FEEDER_2_INT"],
                E3_UR_TB_PMCC_FEEDER_1_INT = (decimal)reader["E3_UR_TB_PMCC_FEEDER_1_INT"],
                E3_UR_TB_PMCC_FEEDER_2_INT = (decimal)reader["E3_UR_TB_PMCC_FEEDER_2_INT"],

                E3_SUPPLY_TO_UR_3_3_KV_MOTOR = (decimal)reader["E3_SUPPLY_TO_UR_3_3_KV_MOTOR"],
                E3_TOT_3_3_KV_SUPPLY = (decimal)reader["E3_TOT_3_3_KV_SUPPLY"],
                E3_3_3_KV_UNACCOUNTED = (decimal)reader["E3_3_3_KV_UNACCOUNTED"],
                E3_TOT_415V_PWR_AVAILABLE = (decimal)reader["E3_TOT_415V_PWR_AVAILABLE"],
                E3_LIGHTING_TRANSFMR_1_INT = (decimal)reader["E3_LIGHTING_TRANSFMR_1_INT"],
                E3_LIGHTING_TRANSFMR_2_INT = (decimal)reader["E3_LIGHTING_TRANSFMR_2_INT"],
                E3_TOT_LIGHT_LOAD = (decimal)reader["E3_TOT_LIGHT_LOAD"],
                E3_UPS_FEEDER_1_INT = (decimal)reader["E3_UPS_FEEDER_1_INT"],
                E3_UPS_FEEDER_2_INT = (decimal)reader["E3_UPS_FEEDER_2_INT"],
                E3_TOT_UPS_LOAD = (decimal)reader["E3_TOT_UPS_LOAD"],
                E3_HVAC_INT = (decimal)reader["E3_HVAC_INT"],
                E3_CCR_HVAC_INT = (decimal)reader["E3_CCR_HVAC_INT"],
                E3_OTHER_LT_LOADS = (decimal)reader["E3_OTHER_LT_LOADS"],
                E3_TOT_AMM_PWR_CONSP = (decimal)reader["E3_TOT_AMM_PWR_CONSP"],
                E3_TOT_UR_PWR_CONSP = (decimal)reader["E3_TOT_UR_PWR_CONSP"],
                E3_AMM_415_V_PMCC_1_INT_DIFF = (decimal)reader["E3_AMM_415_V_PMCC_1_INT_DIFF"],
                E3_AMM_415_V_PMCC_2_INT_DIFF = (decimal)reader["E3_AMM_415_V_PMCC_2_INT_DIFF"],
                E3_UR_TA_PMCC_FEEDER_1_INT_DIFF = (decimal)reader["E3_UR_TA_PMCC_FEEDER_1_INT_DIFF"],
                E3_UR_TA_PMCC_FEEDER_2_INT_DIFF = (decimal)reader["E3_UR_TA_PMCC_FEEDER_2_INT_DIFF"],
                E3_UR_TB_PMCC_FEEDER_1_INT_DIFF = (decimal)reader["E3_UR_TB_PMCC_FEEDER_1_INT_DIFF"],
                E3_UR_TB_PMCC_FEEDER_2_INT_DIFF = (decimal)reader["E3_UR_TB_PMCC_FEEDER_2_INT_DIFF"],
                E3_LIGHTING_TRANSFMR_1_INT_DIFF = (decimal)reader["E3_LIGHTING_TRANSFMR_1_INT_DIFF"],
                E3_LIGHTING_TRANSFMR_2_INT_DIFF = (decimal)reader["E3_LIGHTING_TRANSFMR_2_INT_DIFF"],
                E3_UPS_FEEDER_1_INT_DIFF = (decimal)reader["E3_UPS_FEEDER_1_INT_DIFF"],
                E3_UPS_FEEDER_2_INT_DIFF = (decimal)reader["E3_UPS_FEEDER_2_INT_DIFF"],
                E3_HVAC_INT_DIFF = (decimal)reader["E3_HVAC_INT_DIFF"],
                E3_CCR_HVAC_INT_DIFF = (decimal)reader["E3_CCR_HVAC_INT_DIFF"],
                E3_SUPPLY_TO_PSA_MOTORS = (decimal)reader["E3_SUPPLY_TO_PSA_MOTORS"],

                E3_11_KV_SUPPLY_TO_MP_7801C_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_MP_7801C_INT"],
                E3_11_KV_SUPPLY_TO_MP_7808C_INT = (decimal)reader["E3_11_KV_SUPPLY_TO_MP_7808C_INT"],
                E3_SUPPLY_TO_415V_TRANSFMR_1_INT = (decimal)reader["E3_SUPPLY_TO_415V_TRANSFMR_1_INT"],
                E3_SUPPLY_TO_415V_TRANSFMR_2_INT = (decimal)reader["E3_SUPPLY_TO_415V_TRANSFMR_2_INT"],
                E3_11_KV_TOT_415V_AVAILABLE = (decimal)reader["E3_11_KV_TOT_415V_AVAILABLE"],
                E3_11_KV_CT_UNACCOUNTED = (decimal)reader["E3_11_KV_CT_UNACCOUNTED"],

                E3_3_3_KV_SUPPLY_TO_MP_7601B_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_MP_7601B_INT"],
                E3_3_3_KV_SUPPLY_TO_MP_7811A_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_MP_7811A_INT"],
                E3_3_3_KV_SUPPLY_TO_MP_7811B_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_MP_7811B_INT"],
                E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT"],
                E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT"],
                E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT"],
                E3_TOT_SUPPLY_TO_UTIL = (decimal)reader["E3_TOT_SUPPLY_TO_UTIL"],
                E3_3_3_KV_SUPPLY_TO_FAN_A_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_FAN_A_INT"],
                E3_3_3_KV_SUPPLY_TO_FAN_B_INT = (decimal)reader["E3_3_3_KV_SUPPLY_TO_FAN_B_INT"],
                E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT = (decimal)reader["E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT"],
                E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT = (decimal)reader["E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT"],
                E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT = (decimal)reader["E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT"],
                E3_415_KV_TOT_3_3_KV_SUPPLY = (decimal)reader["E3_415_KV_TOT_3_3_KV_SUPPLY"],
                E3_ONU_UNACCOUNTED = (decimal)reader["E3_ONU_UNACCOUNTED"],

                E3_TO_MAIN_AIR_COMP_INT = (decimal)reader["E3_TO_MAIN_AIR_COMP_INT"],
                E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT = (decimal)reader["E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT"],
                E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT = (decimal)reader["E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT"],
                E3_UTIL_UNACCOUNTED = (decimal)reader["E3_UTIL_UNACCOUNTED"],
                E3_UTIL_TOT_415V_AVAILABLE = (decimal)reader["E3_UTIL_TOT_415V_AVAILABLE"],
                E3_RW_RESERVOIR_FEEDER_1_INT = (decimal)reader["E3_RW_RESERVOIR_FEEDER_1_INT"],
                E3_DM4_CONSP = (decimal)reader["E3_DM4_CONSP"],
                E3_WPT3_CONSP = (decimal)reader["E3_WPT3_CONSP"],
                E3_ETP_CONSP = (decimal)reader["E3_ETP_CONSP"],
                E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_MP_7801C_INT_DIFF"],
                E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF = (decimal)reader["E3_11_KV_SUPPLY_TO_MP_7808C_INT_DIFF"],
                E3_SUPPLY_TO_415V_TRANSFMR_1_INT_DIFF = (decimal)reader["E3_SUPPLY_TO_415V_TRANSFMR_1_INT_DIFF"],
                E3_SUPPLY_TO_415V_TRANSFMR_2_INT_DIFF = (decimal)reader["E3_SUPPLY_TO_415V_TRANSFMR_2_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_MP_7601B_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_MP_7601B_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_MP_7811A_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_MP_7811A_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_MP_7811B_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_MP_7811B_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_FAN_A_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_FAN_A_INT_DIFF"],
                E3_3_3_KV_SUPPLY_TO_FAN_B_INT_DIFF = (decimal)reader["E3_3_3_KV_SUPPLY_TO_FAN_B_INT_DIFF"],
                E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT_DIFF = (decimal)reader["E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT_DIFF"],
                E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF = (decimal)reader["E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF"],
                E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF = (decimal)reader["E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF"],
                E3_TO_MAIN_AIR_COMP_INT_DIFF = (decimal)reader["E3_TO_MAIN_AIR_COMP_INT_DIFF"],
                E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF = (decimal)reader["E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT_DIFF"],
                E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF = (decimal)reader["E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT_DIFF"],
                E3_RW_RESERVOIR_FEEDER_1_INT_DIFF = (decimal)reader["E3_RW_RESERVOIR_FEEDER_1_INT_DIFF"],
                E3_RW_RESERVOIR_FEEDER_2_INT = (decimal)reader["E3_RW_RESERVOIR_FEEDER_2_INT"],
                E3_RW_RESERVOIR_FEEDER_2_INT_DIFF = (decimal)reader["E3_RW_RESERVOIR_FEEDER_2_INT_DIFF"],
                E3_RW_RESERVOIR_CONSP = (decimal)reader["E3_RW_RESERVOIR_CONSP"],
                ENTERED_BY = reader["ENTERED_BY"].ToString(),
                MODIFIED_BY = reader["MODIFIED_BY"].ToString(),
                ENTERED_DATETIME = reader["ENTERED_DATETIME"].ToString(),
                MODIFY_DATETIME = reader["MODIFY_DATETIME"].ToString(),

                // Previous Day Fields
                PRV_E3_GAS_TURBINE_GEN_INT = (decimal)reader["PRV_E3_GAS_TURBINE_GEN_INT"],

                PRV_E3_RECEIPT_FROM_JVVNL_GRID_INT = (decimal)reader["PRV_E3_RECEIPT_FROM_JVVNL_GRID_INT"],
                PRV_E3_11_KV_BUS_A_TO_ISBL_INT = (decimal)reader["PRV_E3_11_KV_BUS_A_TO_ISBL_INT"],
                PRV_E3_11_KV_BUS_B_TO_ISBL_INT = (decimal)reader["PRV_E3_11_KV_BUS_B_TO_ISBL_INT"],
                PRV_E3_CT_FEEDER_1_INT = (decimal)reader["PRV_E3_CT_FEEDER_1_INT"],
                PRV_E3_CT_FEEDER_2_INT = (decimal)reader["PRV_E3_CT_FEEDER_2_INT"],
                PRV_E3_11_KV_SUPPLY_TO_UPH_1_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_UPH_1_INT"],
                PRV_E3_11_KV_SUPPLY_TO_UPH_2_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_UPH_2_INT"],

                PRV_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_1_INT"],
                PRV_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_UPH_3_FEEDER_2_INT"],
                PRV_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_1_INT"],
                PRV_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_ROZLD_FEEDER_2_INT"],

                PRV_E3_AMM_415_V_PMCC_1_INT = (decimal)reader["PRV_E3_AMM_415_V_PMCC_1_INT"],
                PRV_E3_AMM_415_V_PMCC_2_INT = (decimal)reader["PRV_E3_AMM_415_V_PMCC_2_INT"],
                PRV_E3_UR_TA_PMCC_FEEDER_1_INT = (decimal)reader["PRV_E3_UR_TA_PMCC_FEEDER_1_INT"],
                PRV_E3_UR_TA_PMCC_FEEDER_2_INT = (decimal)reader["PRV_E3_UR_TA_PMCC_FEEDER_2_INT"],
                PRV_E3_UR_TB_PMCC_FEEDER_1_INT = (decimal)reader["PRV_E3_UR_TB_PMCC_FEEDER_1_INT"],
                PRV_E3_UR_TB_PMCC_FEEDER_2_INT = (decimal)reader["PRV_E3_UR_TB_PMCC_FEEDER_2_INT"],

                PRV_E3_LIGHTING_TRANSFMR_1_INT = (decimal)reader["PRV_E3_LIGHTING_TRANSFMR_1_INT"],
                PRV_E3_LIGHTING_TRANSFMR_2_INT = (decimal)reader["PRV_E3_LIGHTING_TRANSFMR_2_INT"],
                PRV_E3_UPS_FEEDER_1_INT = (decimal)reader["PRV_E3_UPS_FEEDER_1_INT"],
                PRV_E3_UPS_FEEDER_2_INT = (decimal)reader["PRV_E3_UPS_FEEDER_2_INT"],
                PRV_E3_HVAC_INT = (decimal)reader["PRV_E3_HVAC_INT"],
                PRV_E3_CCR_HVAC_INT = (decimal)reader["PRV_E3_CCR_HVAC_INT"],

                PRV_E3_11_KV_SUPPLY_TO_MP_7801C_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_MP_7801C_INT"],
                PRV_E3_11_KV_SUPPLY_TO_MP_7808C_INT = (decimal)reader["PRV_E3_11_KV_SUPPLY_TO_MP_7808C_INT"],
                PRV_E3_SUPPLY_TO_415V_TRANSFMR_1_INT = (decimal)reader["PRV_E3_SUPPLY_TO_415V_TRANSFMR_1_INT"],
                PRV_E3_SUPPLY_TO_415V_TRANSFMR_2_INT = (decimal)reader["PRV_E3_SUPPLY_TO_415V_TRANSFMR_2_INT"],

                PRV_E3_3_3_KV_SUPPLY_TO_MP_7601B_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_MP_7601B_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_MP_7811A_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_MP_7811A_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_MP_7811B_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_MP_7811B_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_GTG_MOTOR_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_1_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_UTIL_FEEDER_2_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_FAN_A_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_FAN_A_INT"],
                PRV_E3_3_3_KV_SUPPLY_TO_FAN_B_INT = (decimal)reader["PRV_E3_3_3_KV_SUPPLY_TO_FAN_B_INT"],
                PRV_E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT = (decimal)reader["PRV_E3_FROM_UNIT_1_2_TO_HRSG_FAN_INT"],
                PRV_E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT = (decimal)reader["PRV_E3_ONU_SUPPLY_TO_415V_TRANSMR_1_INT"],
                PRV_E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT = (decimal)reader["PRV_E3_ONU_SUPPLY_TO_415V_TRANSMR_2_INT"],

                PRV_E3_TO_MAIN_AIR_COMP_INT = (decimal)reader["PRV_E3_TO_MAIN_AIR_COMP_INT"],
                PRV_E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT = (decimal)reader["PRV_E3_UTIL_SUPPLY_TO_415V_TRANSMR_1_INT"],
                PRV_E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT = (decimal)reader["PRV_E3_UTIL_SUPPLY_TO_415V_TRANSMR_2_INT"],
                PRV_E3_RW_RESERVOIR_FEEDER_1_INT = (decimal)reader["PRV_E3_RW_RESERVOIR_FEEDER_1_INT"],
                PRV_E3_RW_RESERVOIR_FEEDER_2_INT = (decimal)reader["PRV_E3_RW_RESERVOIR_FEEDER_2_INT"],

                PRV_E3_PDG_T7 = (decimal)reader["PRV_E3_PDG_T7"],
                PRV_E3_PDG_T8 = (decimal)reader["PRV_E3_PDG_T8"],
                PRV_E3_PDI11_T8 = (decimal)reader["PRV_E3_PDI11_T8"],
                PRV_E3_PDI11_T9 = (decimal)reader["PRV_E3_PDI11_T9"],
            };
        }
    }
}
