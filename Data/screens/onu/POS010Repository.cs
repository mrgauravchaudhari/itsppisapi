using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS010Repository
    {
        private readonly string _connectionString;
        public POS010Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS010Model MapToValue(SqlDataReader reader)
        {
            return new POS010Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (dynamic)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_RW_RECPT_KSR_INT = (dynamic)reader["OU1_RW_RECPT_KSR_INT"],
                OU1_RW_RECPT_KSR_INT_DIFF = (dynamic)reader["OU1_RW_RECPT_KSR_INT_DIFF"],
                OU1_RW_RECPT_KSR_INT2 = (dynamic)reader["OU1_RW_RECPT_KSR_INT2"],
                OU1_RW_RECPT_KSR_INT2_DIFF = (dynamic)reader["OU1_RW_RECPT_KSR_INT2_DIFF"],
                OU1_RW_KST_32LINE_INT = (dynamic)reader["OU1_RW_KST_32LINE_INT"],
                OU1_RW_KST_32LINE_INT_DIFF = (dynamic)reader["OU1_RW_KST_32LINE_INT_DIFF"],
                OU1_RW_RECPT_KSR = (dynamic)reader["OU1_RW_RECPT_KSR"],
                OU1_RW_EXPORTT_UNIT3 = (dynamic)reader["OU1_RW_EXPORTT_UNIT3"],
                OU1_FW_CONSP_BW = (dynamic)reader["OU1_FW_CONSP_BW"],
                OU1_BACKWASH_WPT_GP3 = (dynamic)reader["OU1_BACKWASH_WPT_GP3"],
                OU1_RW_TOTAL_RECPT = (dynamic)reader["OU1_RW_TOTAL_RECPT"],
                OU1_RW_CONSP_WPT_INT = (dynamic)reader["OU1_RW_CONSP_WPT_INT"],
                OU1_RW_CONSP_WPT_INT_DIFF = (dynamic)reader["OU1_RW_CONSP_WPT_INT_DIFF"],
                OU1_RW_CONSP_WPT_INT_NEW = (dynamic)reader["OU1_RW_CONSP_WPT_INT_NEW"],
                OU1_RW_WPT_CONSP_INT_NEW_DIFF = (dynamic)reader["OU1_RW_WPT_CONSP_INT_NEW_DIFF"],
                OU1_RW_CONSP_WPT = (dynamic)reader["OU1_RW_CONSP_WPT"],
                OU1_RW_CONSP_GB = (dynamic)reader["OU1_RW_CONSP_GB"],
                OU1_RW_CONSP_GB_GP1 = (dynamic)reader["OU1_RW_CONSP_GB_GP1"],
                OU1_RW_CONSP_GB_GP2 = (dynamic)reader["OU1_RW_CONSP_GB_GP2"],
                OU1_RW_CONSP_DILUTION = (dynamic)reader["OU1_RW_CONSP_DILUTION"],
                OU1_RW_CONSP_DILUTION_GP1 = (dynamic)reader["OU1_RW_CONSP_DILUTION_GP1"],
                OU1_RW_CONSP_DILUTION_GP2 = (dynamic)reader["OU1_RW_CONSP_DILUTION_GP2"],
                OU1_RW_TOTAL_CONSP = (dynamic)reader["OU1_RW_TOTAL_CONSP"],
                OU1_RW_R2_TANK_LEVEL = (dynamic)reader["OU1_RW_R2_TANK_LEVEL"],
                OU1_RW_R2_TANK_STOCK = (dynamic)reader["OU1_RW_R2_TANK_STOCK"],
                OU1_RW_R3_TANK_LEVEL = (dynamic)reader["OU1_RW_R3_TANK_LEVEL"],
                OU1_RW_R3_TANK_STOCK = (dynamic)reader["OU1_RW_R3_TANK_STOCK"],
                OU1_RW_CALC_STOCK = (dynamic)reader["OU1_RW_CALC_STOCK"],
                OU1_RW_MEAS_STOCK = (dynamic)reader["OU1_RW_MEAS_STOCK"],
                OU1_REMARKS = reader["OU1_REMARKS"].ToString(),
                OU1_WPT_3_CONS = (dynamic)reader["OU1_WPT_3_CONS"],
                OU1_WPT_TOTAL = (dynamic)reader["OU1_WPT_TOTAL"],
                OU1_FW_TANK1_LEVEL = (dynamic)reader["OU1_FW_TANK1_LEVEL"],
                OU1_FW_TANK1_STOCK = (dynamic)reader["OU1_FW_TANK1_STOCK"],
                OU1_FW_TANK2_LEVEL = (dynamic)reader["OU1_FW_TANK2_LEVEL"],
                OU1_FW_TANK2_STOCK = (dynamic)reader["OU1_FW_TANK2_STOCK"],
                OU1_FW_TANK3_LEVEL = (dynamic)reader["OU1_FW_TANK3_LEVEL"],
                OU1_FW_TANK3_STOCK = (dynamic)reader["OU1_FW_TANK3_STOCK"],
                OU1_FW_TANK4_STOCK = (dynamic)reader["OU1_FW_TANK4_STOCK"],
                OU1_FW_STOCK = (dynamic)reader["OU1_FW_STOCK"],
                OU1_FW_CONSP_DW_INT2 = (dynamic)reader["OU1_FW_CONSP_DW_INT2"],
                OU1_FW_CONSP_DW_INT2_DIFF = (dynamic)reader["OU1_FW_CONSP_DW_INT2_DIFF"],
                OU1_FW_CONSP_DW = (dynamic)reader["OU1_FW_CONSP_DW"],
                OU1_FW_CONSP_DW_UNIT2 = (dynamic)reader["OU1_FW_CONSP_DW_UNIT2"],
                OU1_FW_CONSP_SW_INT = (dynamic)reader["OU1_FW_CONSP_SW_INT"],
                OU1_FW_CONSP_SW_DIFF = (dynamic)reader["OU1_FW_CONSP_SW_DIFF"],
                OU1_FW_CONSP_SW_GPIA = (dynamic)reader["OU1_FW_CONSP_SW_GPIA"],
                OU1_FW_CONSP_SSP = (dynamic)reader["OU1_FW_CONSP_SSP"],
                U2_FW_CONSP_SW_GPI_INT = (dynamic)reader["U2_FW_CONSP_SW_GPI_INT"],
                U2_FW_CONSP_SW_GPI_INT_DIFF = (dynamic)reader["U2_FW_CONSP_SW_GPI_INT_DIFF"],
                U2_FW_CONSP_SW_GPI = (dynamic)reader["U2_FW_CONSP_SW_GPI"],
                OU1_FW_CONSP_DW_SSP = (dynamic)reader["OU1_FW_CONSP_DW_SSP"],
                U2_FW_CONSP_SW_GPII_INT = (dynamic)reader["U2_FW_CONSP_SW_GPII_INT"],
                U2_FW_CONSP_SW_GPII_INT_DIFF = (dynamic)reader["U2_FW_CONSP_SW_GPII_INT_DIFF"],
                OU1_FW_EXPORTT_UNIT2 = (dynamic)reader["OU1_FW_EXPORTT_UNIT2"],
                OU1_DW_GP3_UE = (dynamic)reader["OU1_DW_GP3_UE"],
                OU1_FW_CONSP_SW = (dynamic)reader["OU1_FW_CONSP_SW"],
                OU1_SW_GP3_UE = (dynamic)reader["OU1_SW_GP3_UE"],
                OU1_FW_CONSP_UCT_INT = (dynamic)reader["OU1_FW_CONSP_UCT_INT"],
                OU1_FW_CONSP_UCT_INT_DIFF = (dynamic)reader["OU1_FW_CONSP_UCT_INT_DIFF"],
                OU1_FW_CONSP_UCT_GPI = (dynamic)reader["OU1_FW_CONSP_UCT_GPI"],
                OU1_FW_GP3_UE = (dynamic)reader["OU1_FW_GP3_UE"],
                OU1_FIRE_CONSP_UCT_GPI_INT = (dynamic)reader["OU1_FIRE_CONSP_UCT_GPI_INT"],
                OU1_FIRE_CONSP_UCT_GPI_INT_DIFF = (dynamic)reader["OU1_FIRE_CONSP_UCT_GPI_INT_DIFF"],
                OU1_FIRE_CONSP_UCT_GPI = (dynamic)reader["OU1_FIRE_CONSP_UCT_GPI"],
                OU1_FW_CONSP_UCT = (dynamic)reader["OU1_FW_CONSP_UCT"],
                OU1_FW_CONSP_ACT_INT = (dynamic)reader["OU1_FW_CONSP_ACT_INT"],
                OU1_FW_GP1_MEAS_ACT_MAKEUP = (dynamic)reader["OU1_FW_GP1_MEAS_ACT_MAKEUP"],
                OU1_FW_CONSP_ACT = (dynamic)reader["OU1_FW_CONSP_ACT"],
                OU1_FW_GP2_MEAS_ACT_MAKEUP = (dynamic)reader["OU1_FW_GP2_MEAS_ACT_MAKEUP"],
                OU1_SPG_CT_GP3 = (dynamic)reader["OU1_SPG_CT_GP3"],
                OU1_FW_CONSP_FIRE = (dynamic)reader["OU1_FW_CONSP_FIRE"],
                OU1_FW_CONSP_FIRE_UNIT2 = (dynamic)reader["OU1_FW_CONSP_FIRE_UNIT2"],
                OU1_FW_GP1_GP2_SINK = (dynamic)reader["OU1_FW_GP1_GP2_SINK"],
                OU1_FW_CONSP_DMP_INT1 = (dynamic)reader["OU1_FW_CONSP_DMP_INT1"],
                OU1_FW_CONSP_DMP_INT1_DIFF = (dynamic)reader["OU1_FW_CONSP_DMP_INT1_DIFF"],
                OU1_FW_CONSP_DMP_INT2 = (dynamic)reader["OU1_FW_CONSP_DMP_INT2"],
                OU1_FW_CONSP_DMP_INT2_DIFF = (dynamic)reader["OU1_FW_CONSP_DMP_INT2_DIFF"],
                OU1_FW_CONSP_DMP_GP1 = (dynamic)reader["OU1_FW_CONSP_DMP_GP1"],
                OU1_FW_CONSP_DMP_INT3 = (dynamic)reader["OU1_FW_CONSP_DMP_INT3"],
                OU1_FW_CONSP_DMP_INT3_DIFF = (dynamic)reader["OU1_FW_CONSP_DMP_INT3_DIFF"],
                OU1_FW_CONSP_DMP_GP2 = (dynamic)reader["OU1_FW_CONSP_DMP_GP2"],
                OU1_FW_CONSP_DMP_INT4 = (dynamic)reader["OU1_FW_CONSP_DMP_INT4"],
                OU1_FW_CONSP_DMP_INT4_DIFF = (dynamic)reader["OU1_FW_CONSP_DMP_INT4_DIFF"],
                OU1_FW_CONSP_DMP = (dynamic)reader["OU1_FW_CONSP_DMP"],
                OU1_FW_CONSP_BW_GPI = (dynamic)reader["OU1_FW_CONSP_BW_GPI"],
                OU1_FW_CONSP_BW_GPII = (dynamic)reader["OU1_FW_CONSP_BW_GPII"],
                OU1_FW_TOTAL_CONSP = (dynamic)reader["OU1_FW_TOTAL_CONSP"],
                OU1_DMW_PROD_INT1 = (dynamic)reader["OU1_DMW_PROD_INT1"],
                OU1_DMW_PROD_INT1_DIFF = (dynamic)reader["OU1_DMW_PROD_INT1_DIFF"],
                OU1_DMW_PROD_INT2 = (dynamic)reader["OU1_DMW_PROD_INT2"],
                OU1_DMW_PROD_INT2_DIFF = (dynamic)reader["OU1_DMW_PROD_INT2_DIFF"],
                OU1_DMW_PROD_INT3 = (dynamic)reader["OU1_DMW_PROD_INT3"],
                OU1_DMW_PROD_INT3_DIFF = (dynamic)reader["OU1_DMW_PROD_INT3_DIFF"],
                OU1_DMW_PROD = (dynamic)reader["OU1_DMW_PROD"],
                OU1_DMW_MAKEUP_GPII_INT = (dynamic)reader["OU1_DMW_MAKEUP_GPII_INT"],
                OU1_DMW_MAKEUP_GPII = (dynamic)reader["OU1_DMW_MAKEUP_GPII"],
                OU1_DMW_MAKEUP_GPI = (dynamic)reader["OU1_DMW_MAKEUP_GPI"],
                OU1_DMW_TANK1_LEVEL = (dynamic)reader["OU1_DMW_TANK1_LEVEL"],
                OU1_DMW_TANK1_STOCK = (dynamic)reader["OU1_DMW_TANK1_STOCK"],
                OU1_DMW_TANK2_LEVEL = (dynamic)reader["OU1_DMW_TANK2_LEVEL"],
                OU1_DMW_TANK2_STOCK = (dynamic)reader["OU1_DMW_TANK2_STOCK"],
                OU1_DMW_TANK3_STOCK = (dynamic)reader["OU1_DMW_TANK3_STOCK"],
                OU1_DMW_STOCK = (dynamic)reader["OU1_DMW_STOCK"],
                OU1_PW_TANK1_LEVEL = (dynamic)reader["OU1_PW_TANK1_LEVEL"],
                OU1_PW_TANK1_STOCK = (dynamic)reader["OU1_PW_TANK1_STOCK"],
                OU1_PW_TANK2_LEVEL = (dynamic)reader["OU1_PW_TANK2_LEVEL"],
                OU1_PW_TANK2_STOCK = (dynamic)reader["OU1_PW_TANK2_STOCK"],
                OU1_PW_TANK3_STOCK_GP3 = (dynamic)reader["OU1_PW_TANK3_STOCK_GP3"],
                OU1_PW_STOCK = (dynamic)reader["OU1_PW_STOCK"],
                OU1_APC_PROD_INT = (dynamic)reader["OU1_APC_PROD_INT"],
                OU1_APC_PROD_INT_DIFF = (dynamic)reader["OU1_APC_PROD_INT_DIFF"],
                OU1_APC_PROD = (dynamic)reader["OU1_APC_PROD"],
                OU1_UPC_PROD = (dynamic)reader["OU1_UPC_PROD"],
                OU1_UTC_PROD = (dynamic)reader["OU1_UTC_PROD"],
                OU1_ATC_PROD = (dynamic)reader["OU1_ATC_PROD"],
                OU1_USC_PROD = (dynamic)reader["OU1_USC_PROD"],
                OU1_CTTC_PROD = (dynamic)reader["OU1_CTTC_PROD"],
                OU1_COND_EXPORTT_UNIT2 = (dynamic)reader["OU1_COND_EXPORTT_UNIT2"],
                OU1_TC_TFRT_PW_UNIT1 = (dynamic)reader["OU1_TC_TFRT_PW_UNIT1"],
                OU1_CONDENSATE_DRAINED_GPI = (dynamic)reader["OU1_CONDENSATE_DRAINED_GPI"],
                OU1_NET_CONDENSATE = (dynamic)reader["OU1_NET_CONDENSATE"],
                OU1_PW_EXPORTT_UNIT2_TANK = (dynamic)reader["OU1_PW_EXPORTT_UNIT2_TANK"],
                OU1_PW_FEED_EXPORTT_UNIT2 = (dynamic)reader["OU1_PW_FEED_EXPORTT_UNIT2"],
                OU1_PW_FEED_UNIT1 = (dynamic)reader["OU1_PW_FEED_UNIT1"],
                OU1_PW_GP1_FEED_IMPORT_GP3 = (dynamic)reader["OU1_PW_GP1_FEED_IMPORT_GP3"],
                OU1_PW_GP1_FEED_EXPORT_GP3 = (dynamic)reader["OU1_PW_GP1_FEED_EXPORT_GP3"],
                OU1_REGN_LOSS_DMP_GP1 = (dynamic)reader["OU1_REGN_LOSS_DMP_GP1"],
                OU1_REGN_LOSS_MB_GP1 = (dynamic)reader["OU1_REGN_LOSS_MB_GP1"],
                OU1_PW_CONSP_MEEFOG_INT = (dynamic)reader["OU1_PW_CONSP_MEEFOG_INT"],
                OU1_PW_CONSP_MEEFOG = (dynamic)reader["OU1_PW_CONSP_MEEFOG"],
                OU1_PW_CONSP_SPG_INT = (dynamic)reader["OU1_PW_CONSP_SPG_INT"],
                OU1_PW_CONSP_SPG_WO_MEEFOG = (dynamic)reader["OU1_PW_CONSP_SPG_WO_MEEFOG"],
                OU1_PW_CONSP_SPG = (dynamic)reader["OU1_PW_CONSP_SPG"],
                OU1_PW_CONSP_UNIT1_INT = (dynamic)reader["OU1_PW_CONSP_UNIT1_INT"],
                OU1_PW_CONSP_UNIT1 = (dynamic)reader["OU1_PW_CONSP_UNIT1"],
                OU1_PW_CONSP_UREA = (dynamic)reader["OU1_PW_CONSP_UREA"],
                OU1_PW_CONSP_AMM = (dynamic)reader["OU1_PW_CONSP_AMM"],
                OU1_PW_EXPORTT_GPII = (dynamic)reader["OU1_PW_EXPORTT_GPII"],
                OU1_PW_IMPORTF_UNIT2 = (dynamic)reader["OU1_PW_IMPORTF_UNIT2"],
                OU1_PW_GP1_EXPORT_GP3 = (dynamic)reader["OU1_PW_GP1_EXPORT_GP3"],
                OU1_PW_GP1_IMPORT_GP3 = (dynamic)reader["OU1_PW_GP1_IMPORT_GP3"],
                OU1_TC_IMPORTF_UNIT2_INT = (dynamic)reader["OU1_TC_IMPORTF_UNIT2_INT"],
                OU1_TC_IMPORTF_UNIT2 = (dynamic)reader["OU1_TC_IMPORTF_UNIT2"],
                OU1_SC_IMPORTF_UNIT2_INT = (dynamic)reader["OU1_SC_IMPORTF_UNIT2_INT"],
                OU1_SC_IMPORTF_UNIT2 = (dynamic)reader["OU1_SC_IMPORTF_UNIT2"],
                OU1_APC_IMPORTF_UNIT2 = (dynamic)reader["OU1_APC_IMPORTF_UNIT2"],
                OU1_UPC_IMPORTF_UNIT2 = (dynamic)reader["OU1_UPC_IMPORTF_UNIT2"],
                OU1_COND_EXPORTT_UNIT1 = (dynamic)reader["OU1_COND_EXPORTT_UNIT1"],
                OU1_TC_TFRT_PW_UNIT2 = (dynamic)reader["OU1_TC_TFRT_PW_UNIT2"],
                OU1_CONDENSATE_DRAINED_GPII = (dynamic)reader["OU1_CONDENSATE_DRAINED_GPII"],
                OU1_NET_COND_GPII = (dynamic)reader["OU1_NET_COND_GPII"],
                OU1_PW_EXPORTT_UNIT1_TANK = (dynamic)reader["OU1_PW_EXPORTT_UNIT1_TANK"],
                OU1_PW_FEED_EXPORTT_UNIT1 = (dynamic)reader["OU1_PW_FEED_EXPORTT_UNIT1"],
                OU1_PW_FEED_UNIT2 = (dynamic)reader["OU1_PW_FEED_UNIT2"],
                OU1_PW_FEED_IMPORT_GP3 = (dynamic)reader["OU1_PW_FEED_IMPORT_GP3"],
                OU1_PW_GP2_FEED_EXPORT_GP3 = (dynamic)reader["OU1_PW_GP2_FEED_EXPORT_GP3"],
                OU1_REGN_LOSS_DMP_GP2 = (dynamic)reader["OU1_REGN_LOSS_DMP_GP2"],
                OU1_REGN_LOSS_MB_GP2 = (dynamic)reader["OU1_REGN_LOSS_MB_GP2"],
                OU1_PW_EXPORTT_UNIT2 = (dynamic)reader["OU1_PW_EXPORTT_UNIT2"],
                OU1_PW_IMPORT_GP3 = (dynamic)reader["OU1_PW_IMPORT_GP3"],
                OU1_PW_GP2_EXPORT_GP3 = (dynamic)reader["OU1_PW_GP2_EXPORT_GP3"],

                OU1_RW_EXPORTT_UNIT2 = (dynamic)reader["OU1_RW_EXPORTT_UNIT2"],
                OU1_FW_CONSP_DW_INT1 = (dynamic)reader["OU1_FW_CONSP_DW_INT1"],
                OU1_FW_IMPORTF_UNIT2_INT = (dynamic)reader["OU1_FW_IMPORTF_UNIT2_INT"],
                OU1_REGN_LOSS_DMP = (dynamic)reader["OU1_REGN_LOSS_DMP"],
                OU1_FW_CONSP_MISC_UNIT2 = (dynamic)reader["OU1_FW_CONSP_MISC_UNIT2"],

                TXT_CAL_R3_LEVEL = (dynamic)reader["TXT_CAL_R3_LEVEL"],
                TXT_WPT_RCPT = (dynamic)reader["TXT_WPT_RCPT"],
                TXT_FW_CONSP_ACT_GPII = (dynamic)reader["TXT_FW_CONSP_ACT_GPII"],
                TXT_FW_CONSP_UCT_GPII = (dynamic)reader["TXT_FW_CONSP_UCT_GPII"],
                TXT_DMW_STOCK_GP1 = (dynamic)reader["TXT_DMW_STOCK_GP1"],
                TXT_PW_STOCK_GP1 = (dynamic)reader["TXT_PW_STOCK_GP1"],
                TXT_TOT_COND_GPI = (dynamic)reader["TXT_TOT_COND_GPI"],
                TXT_COND_IMP_FROM_UNIT2 = (dynamic)reader["TXT_COND_IMP_FROM_UNIT2"],
                TXT_PW_EXPORTT_GP1_TANK = (dynamic)reader["TXT_PW_EXPORTT_GP1_TANK"],
                TXT_OU_PW_FEED_EXPORTT_UNIT1 = (dynamic)reader["TXT_OU_PW_FEED_EXPORTT_UNIT1"],
                TXT_DMW_STOCK_GPII = (dynamic)reader["TXT_DMW_STOCK_GPII"],
                TXT_PW_STOCK_GPII = (dynamic)reader["TXT_PW_STOCK_GPII"],
                TXT_TOT_COND_GPII = (dynamic)reader["TXT_TOT_COND_GPII"],
                TXT_COND_IMPORTF_UNIT1 = (dynamic)reader["TXT_COND_IMPORTF_UNIT1"],
                TXT_PW_TFRF_UNIT1 = (dynamic)reader["TXT_PW_TFRF_UNIT1"],
                TXT_PW_FEED_EXPORTT_UNIT2 = (dynamic)reader["TXT_PW_FEED_EXPORTT_UNIT2"],
                TXT_PW_EXPORTT_UNIT1 = (dynamic)reader["TXT_PW_EXPORTT_UNIT1"],
                TXT_PW_IMPORTF_UNIT1 = (dynamic)reader["TXT_PW_IMPORTF_UNIT1"],

                OU1_FW_GP1_SINK = (dynamic)reader["OU1_FW_GP1_SINK"],
                OU1_FW_GPII_SINK = (dynamic)reader["OU1_FW_GPII_SINK"],

                // ------------------------PRV----------------------
                PRV_OU_TRANS_DATE = (dynamic)reader["PRV_OU_TRANS_DATE"],
                PRV_OU_RW_RECPT_KSR_INT = (dynamic)reader["PRV_OU_RW_RECPT_KSR_INT"],
                PRV_OU_RW_RECPT_KSR_INT2 = (dynamic)reader["PRV_OU_RW_RECPT_KSR_INT2"],
                PRV_OU_RW_KST_32LINE_INT = (dynamic)reader["PRV_OU_RW_KST_32LINE_INT"],
                PRV_OU_FW_CONSP_BW = (dynamic)reader["PRV_OU_FW_CONSP_BW"],
                PRV_OU_RW_CONSP_WPT_INT = (dynamic)reader["PRV_OU_RW_CONSP_WPT_INT"],
                PRV_OU_RW_CONSP_WPT_INT_NEW = (dynamic)reader["PRV_OU_RW_CONSP_WPT_INT_NEW"],
                PRV_OU_RW_CONSP_GB = (dynamic)reader["PRV_OU_RW_CONSP_GB"],
                PRV_OU_RW_CONSP_DILUTION = (dynamic)reader["PRV_OU_RW_CONSP_DILUTION"],
                PRV_OU_RW_R2_TANK_LEVEL = (dynamic)reader["PRV_OU_RW_R2_TANK_LEVEL"],
                PRV_OU_RW_R3_TANK_LEVEL = (dynamic)reader["PRV_OU_RW_R3_TANK_LEVEL"],
                PRV_OU_REMARKS = reader["PRV_OU_REMARKS"].ToString(),
                PRV_OU_FW_TANK1_LEVEL = (dynamic)reader["PRV_OU_FW_TANK1_LEVEL"],
                PRV_OU_FW_TANK2_LEVEL = (dynamic)reader["PRV_OU_FW_TANK2_LEVEL"],
                PRV_OU_FW_TANK3_LEVEL = (dynamic)reader["PRV_OU_FW_TANK3_LEVEL"],
                PRV_OU_FW_CONSP_DW_INT2 = (dynamic)reader["PRV_OU_FW_CONSP_DW_INT2"],
                PRV_OU_FW_CONSP_SW_INT = (dynamic)reader["PRV_OU_FW_CONSP_SW_INT"],
                PRV_OU_FW_CONSP_UCT_INT = (dynamic)reader["PRV_OU_FW_CONSP_UCT_INT"],
                PRV_OU_FW_GP3_UE = (dynamic)reader["PRV_OU_FW_GP3_UE"],
                PRV_OU_FIRE_CONSP_UCT_GPI_INT = (dynamic)reader["PRV_OU_FIRE_CONSP_UCT_GPI_INT"],
                PRV_OU_FW_CONSP_ACT_INT = (dynamic)reader["PRV_OU_FW_CONSP_ACT_INT"],
                PRV_OU_FW_CONSP_FIRE = (dynamic)reader["PRV_OU_FW_CONSP_FIRE"],
                PRV_OU_FW_CONSP_FIRE_UNIT2 = (dynamic)reader["PRV_OU_FW_CONSP_FIRE_UNIT2"],
                PRV_OU_FW_CONSP_DMP_INT1 = (dynamic)reader["PRV_OU_FW_CONSP_DMP_INT1"],
                PRV_OU_FW_CONSP_DMP_INT2 = (dynamic)reader["PRV_OU_FW_CONSP_DMP_INT2"],
                PRV_OU_FW_CONSP_DMP_INT3 = (dynamic)reader["PRV_OU_FW_CONSP_DMP_INT3"],
                PRV_OU_FW_CONSP_DMP_INT4 = (dynamic)reader["PRV_OU_FW_CONSP_DMP_INT4"],
                PRV_OU_DMW_PROD_INT1 = (dynamic)reader["PRV_OU_DMW_PROD_INT1"],
                PRV_OU_DMW_PROD_INT2 = (dynamic)reader["PRV_OU_DMW_PROD_INT2"],
                PRV_OU_DMW_PROD_INT3 = (dynamic)reader["PRV_OU_DMW_PROD_INT3"],
                PRV_OU_DMW_MAKEUP_GPII_INT = (dynamic)reader["PRV_OU_DMW_MAKEUP_GPII_INT"],
                PRV_OU_DMW_TANK1_LEVEL = (dynamic)reader["PRV_OU_DMW_TANK1_LEVEL"],
                PRV_OU_DMW_TANK2_LEVEL = (dynamic)reader["PRV_OU_DMW_TANK2_LEVEL"],
                PRV_OU_PW_TANK1_LEVEL = (dynamic)reader["PRV_OU_PW_TANK1_LEVEL"],
                PRV_OU_PW_TANK2_LEVEL = (dynamic)reader["PRV_OU_PW_TANK2_LEVEL"],
                PRV_OU_APC_PROD_INT = (dynamic)reader["PRV_OU_APC_PROD_INT"],
                PRV_OU_COND_EXPORTT_UNIT2 = (dynamic)reader["PRV_OU_COND_EXPORTT_UNIT2"],
                PRV_OU_TC_TFRT_PW_UNIT1 = (dynamic)reader["PRV_OU_TC_TFRT_PW_UNIT1"],
                PRV_OU_CONDENSATE_DRAINED_GPI = (dynamic)reader["PRV_OU_CONDENSATE_DRAINED_GPI"],
                PRV_OU_PW_EXPORTT_UNIT2_TANK = (dynamic)reader["PRV_OU_PW_EXPORTT_UNIT2_TANK"],
                PRV_OU_PW_FEED_EXPORTT_UNIT2 = (dynamic)reader["PRV_OU_PW_FEED_EXPORTT_UNIT2"],
                PRV_OU_PW_GP1_FEED_IMPORT_GP3 = (dynamic)reader["PRV_OU_PW_GP1_FEED_IMPORT_GP3"],
                PRV_OU_PW_GP1_FEED_EXPORT_GP3 = (dynamic)reader["PRV_OU_PW_GP1_FEED_EXPORT_GP3"],
                PRV_OU_PW_CONSP_MEEFOG_INT = (dynamic)reader["PRV_OU_PW_CONSP_MEEFOG_INT"],
                PRV_OU_PW_CONSP_SPG_INT = (dynamic)reader["PRV_OU_PW_CONSP_SPG_INT"],
                PRV_OU_PW_CONSP_UNIT1_INT = (dynamic)reader["PRV_OU_PW_CONSP_UNIT1_INT"],
                PRV_OU_PW_EXPORTT_GPII = (dynamic)reader["PRV_OU_PW_EXPORTT_GPII"],
                PRV_OU_PW_IMPORTF_UNIT2 = (dynamic)reader["PRV_OU_PW_IMPORTF_UNIT2"],
                PRV_OU_PW_GP1_EXPORT_GP3 = (dynamic)reader["PRV_OU_PW_GP1_EXPORT_GP3"],
                PRV_OU_PW_GP1_IMPORT_GP3 = (dynamic)reader["PRV_OU_PW_GP1_IMPORT_GP3"],
                PRV_OU_TC_IMPORTF_UNIT2_INT = (dynamic)reader["PRV_OU_TC_IMPORTF_UNIT2_INT"],
                PRV_OU_SC_IMPORTF_UNIT2_INT = (dynamic)reader["PRV_OU_SC_IMPORTF_UNIT2_INT"],
                PRV_OU_COND_EXPORTT_UNIT1 = (dynamic)reader["PRV_OU_COND_EXPORTT_UNIT1"],
                PRV_OU_TC_TFRT_PW_UNIT2 = (dynamic)reader["PRV_OU_TC_TFRT_PW_UNIT2"],
                PRV_OU_CONDENSATE_DRAINED_GPII = (dynamic)reader["PRV_OU_CONDENSATE_DRAINED_GPII"],
                PRV_OU_PW_EXPORTT_UNIT1_TANK = (dynamic)reader["PRV_OU_PW_EXPORTT_UNIT1_TANK"],
                PRV_OU_PW_FEED_EXPORTT_UNIT1 = (dynamic)reader["PRV_OU_PW_FEED_EXPORTT_UNIT1"],
                PRV_OU_PW_FEED_IMPORT_GP3 = (dynamic)reader["PRV_OU_PW_FEED_IMPORT_GP3"],
                PRV_OU_PW_GP2_FEED_EXPORT_GP3 = (dynamic)reader["PRV_OU_PW_GP2_FEED_EXPORT_GP3"],
                PRV_OU_PW_IMPORT_GP3 = (dynamic)reader["PRV_OU_PW_IMPORT_GP3"],
                PRV_OU_PW_GP2_EXPORT_GP3 = (dynamic)reader["PRV_OU_PW_GP2_EXPORT_GP3"],

                // ------------------------DV----------------------
                PARM_G_MF_KSR_RCPT = (dynamic)reader["PARM_G_MF_KSR_RCPT"],
                DIS_OU1_HS_CONSP_CTT = (dynamic)reader["DIS_OU1_HS_CONSP_CTT"],
                PARM_G_MF_WPT_CONSP = (dynamic)reader["PARM_G_MF_WPT_CONSP"],
                PARM_G_MF_RW_R2 = (dynamic)reader["PARM_G_MF_RW_R2"],
                PARM_G_CONST_STOCK_R2 = (dynamic)reader["PARM_G_CONST_STOCK_R2"],
                PARM_G_MF_RW_R3 = (dynamic)reader["PARM_G_MF_RW_R3"],
                PARM_G_CONST_STOCK_FWT = (dynamic)reader["PARM_G_CONST_STOCK_FWT"],
                PARM_G_MF_DW_INT1 = (dynamic)reader["PARM_G_MF_DW_INT1"],
                PARM_G_MF_DW_INT2 = (dynamic)reader["PARM_G_MF_DW_INT2"],
                PARM_G_ADD_CHLRN_WTR = (dynamic)reader["PARM_G_ADD_CHLRN_WTR"],
                PARM_G_MF_SW = (dynamic)reader["PARM_G_MF_SW"],
                PARM_G_MF_DMW_TANK = (dynamic)reader["PARM_G_MF_DMW_TANK"],
                parm_hs_consp_ctt_ph = (dynamic)reader["parm_hs_consp_ctt_ph"],
                parm_hs_consp_uct_ph = (dynamic)reader["parm_hs_consp_uct_ph"],
                parm_rw_gb_consp_per_gpii = (dynamic)reader["parm_rw_gb_consp_per_gpii"],
                parm_rw_dil_consp_per_gpii = (dynamic)reader["parm_rw_dil_consp_per_gpii"],
                PARM_G_MF_SW_GPIA = (dynamic)reader["PARM_G_MF_SW_GPIA"],
                parm_G_MF_PW_MEEFOG = (dynamic)reader["parm_G_MF_PW_MEEFOG"],
                s_water_process_consp = (dynamic)reader["s_water_process_consp"],
                OU3_MAKEUP_SPG_CT_DIFF = (dynamic)reader["OU3_MAKEUP_SPG_CT_DIFF"],
                PARM_CALC_STK_PREV_DAY = (dynamic)reader["PARM_CALC_STK_PREV_DAY"],
                PARM_PW_TANK1_STK_PREV_DAY = (dynamic)reader["PARM_PW_TANK1_STK_PREV_DAY"],
                PARM_PW_TANK2_STK_PREV_DAY = (dynamic)reader["PARM_PW_TANK2_STK_PREV_DAY"],
                PARM_DMW_TANK1_STK_PREV_DAY = (dynamic)reader["PARM_DMW_TANK1_STK_PREV_DAY"],
                PARM_DMW_TANK2_STK_PREV_DAY = (dynamic)reader["PARM_DMW_TANK2_STK_PREV_DAY"],

                PARM_FW_STOCK_PREV_DAY = (dynamic)reader["PARM_FW_STOCK_PREV_DAY"],
                parm_dm1_int = (dynamic)reader["parm_dm1_int"],
            };
        }

        public async Task<POS010Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS010Model response = null;
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

        public async Task saveData(POS010SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_MEAS_STOCK", value.OU1_RW_MEAS_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CALC_STOCK", value.OU1_RW_CALC_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_RECPT_KSR_INT", value.OU1_RW_RECPT_KSR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_RECPT_KSR_INT_DIFF", value.OU1_RW_RECPT_KSR_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_RECPT_KSR", value.OU1_RW_RECPT_KSR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_IMPORTF_UNIT2_INT", value.OU1_RW_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_IMPORTF_UNIT2", value.OU1_RW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_TOTAL_RECPT", value.OU1_RW_TOTAL_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_WPT_INT", value.OU1_RW_CONSP_WPT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_WPT_INT_DIFF", value.OU1_RW_CONSP_WPT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_WPT", value.OU1_RW_CONSP_WPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_GB", value.OU1_RW_CONSP_GB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_DILUTION", value.OU1_RW_CONSP_DILUTION));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_EXPORTT_UNIT2_INT", value.OU1_RW_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_EXPORTT_UNIT2", value.OU1_RW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_TOTAL_CONSP", value.OU1_RW_TOTAL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_R2_TANK_LEVEL", value.OU1_RW_R2_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_R2_TANK_STOCK", value.OU1_RW_R2_TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_R3_TANK_LEVEL", value.OU1_RW_R3_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_R3_TANK_STOCK", value.OU1_RW_R3_TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK1_LEVEL", value.OU1_FW_TANK1_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK1_STOCK", value.OU1_FW_TANK1_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK2_LEVEL", value.OU1_FW_TANK2_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK2_STOCK", value.OU1_FW_TANK2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK3_LEVEL", value.OU1_FW_TANK3_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK3_STOCK", value.OU1_FW_TANK3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_STOCK", value.OU1_FW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_IMPORTF_UNIT2_INT", value.OU1_FW_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_IMPORTF_UNIT2", value.OU1_FW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TOTAL_RECPT", value.OU1_FW_TOTAL_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT1", value.OU1_FW_CONSP_DMP_INT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT1_DIFF", value.OU1_FW_CONSP_DMP_INT1_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT2", value.OU1_FW_CONSP_DMP_INT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT2_DIFF", value.OU1_FW_CONSP_DMP_INT2_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT3", value.OU1_FW_CONSP_DMP_INT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT3_DIFF", value.OU1_FW_CONSP_DMP_INT3_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP", value.OU1_FW_CONSP_DMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_ACT_INT", value.OU1_FW_CONSP_ACT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_ACT", value.OU1_FW_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_UCT_INT", value.OU1_FW_CONSP_UCT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_UCT_INT_DIFF", value.OU1_FW_CONSP_UCT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_UCT", value.OU1_FW_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW_INT1", value.OU1_FW_CONSP_DW_INT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW_INT1_DIFF", value.OU1_FW_CONSP_DW_INT1_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW_INT2", value.OU1_FW_CONSP_DW_INT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW_INT2_DIFF", value.OU1_FW_CONSP_DW_INT2_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW", value.OU1_FW_CONSP_DW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_SW_INT", value.OU1_FW_CONSP_SW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_SW_DIFF", value.OU1_FW_CONSP_SW_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_FIRE", value.OU1_FW_CONSP_FIRE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_SW", value.OU1_FW_CONSP_SW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_BW", value.OU1_FW_CONSP_BW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_EXPORTT_UNIT2_INT", value.OU1_FW_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_EXPORTT_UNIT2", value.OU1_FW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TOTAL_CONSP", value.OU1_FW_TOTAL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_TANK1_LEVEL", value.OU1_DMW_TANK1_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_TANK1_STOCK", value.OU1_DMW_TANK1_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_TANK2_LEVEL", value.OU1_DMW_TANK2_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_TANK2_STOCK", value.OU1_DMW_TANK2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_STOCK", value.OU1_DMW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REGN_LOSS_DMP", value.OU1_REGN_LOSS_DMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_INT1", value.OU1_DMW_PROD_INT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_INT1_DIFF", value.OU1_DMW_PROD_INT1_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_INT2", value.OU1_DMW_PROD_INT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_INT2_DIFF", value.OU1_DMW_PROD_INT2_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_INT3", value.OU1_DMW_PROD_INT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_INT3_DIFF", value.OU1_DMW_PROD_INT3_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD", value.OU1_DMW_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_IMPORTF_UNIT2_INT", value.OU1_DMW_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_IMPORTF_UNIT2", value.OU1_DMW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_NET_PROD", value.OU1_DMW_NET_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_APC_PROD_INT", value.OU1_APC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_APC_PROD", value.OU1_APC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CTTC_PROD", value.OU1_CTTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_APC_IMPORTF_UNIT2_INT", value.OU1_APC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_APC_IMPORTF_UNIT2", value.OU1_APC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ATC_IMPORTF_UNIT2_INT", value.OU1_ATC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ATC_IMPORTF_UNIT2", value.OU1_ATC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UPC_IMPORTF_UNIT2_INT", value.OU1_UPC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UPC_IMPORTF_UNIT2", value.OU1_UPC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UTC_IMPORTF_UNIT2_INT", value.OU1_UTC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UTC_IMPORTF_UNIT2", value.OU1_UTC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USC_IMPORTF_UNIT2_INT", value.OU1_USC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USC_IMPORTF_UNIT2", value.OU1_USC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CTTC_IMPORTF_UNIT2_INT", value.OU1_CTTC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CTTC_IMPORTF_UNIT2", value.OU1_CTTC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_CONDENSATE", value.OU1_TOTAL_CONDENSATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CONDENSATE_DRAINED", value.OU1_CONDENSATE_DRAINED));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NET_CONDENSATE", value.OU1_NET_CONDENSATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_FEED_MB", value.OU1_PW_FEED_MB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REGN_LOSS_MB", value.OU1_REGN_LOSS_MB));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_EXPORTT_UNIT2_INT", value.OU1_DMW_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_EXPORTT_UNIT2", value.OU1_DMW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_NET_CONSP", value.OU1_DMW_NET_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_TANK1_LEVEL", value.OU1_PW_TANK1_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_TANK1_STOCK", value.OU1_PW_TANK1_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_TANK2_LEVEL", value.OU1_PW_TANK2_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_TANK2_STOCK", value.OU1_PW_TANK2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_STOCK", value.OU1_PW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_IMPORTF_UNIT2_INT", value.OU1_PW_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_IMPORTF_UNIT2", value.OU1_PW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_NET_PROD", value.OU1_PW_NET_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_UNIT1_INT", value.OU1_PW_CONSP_UNIT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_UNIT1", value.OU1_PW_CONSP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_EXPORTT_UNIT2_INT", value.OU1_PW_EXPORTT_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_EXPORTT_UNIT2", value.OU1_PW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_PW_DISTRIBUTION", value.OU1_TOTAL_PW_DISTRIBUTION));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_AMM", value.OU1_PW_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_SPG_INT", value.OU1_PW_CONSP_SPG_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_SPG", value.OU1_PW_CONSP_SPG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REMARKS", value.OU1_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_EXPORTT_UNIT2_INT_DIFF", value.OU1_FW_EXPORTT_UNIT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW_UNIT2", value.OU1_FW_CONSP_DW_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_FIRE_UNIT2", value.OU1_FW_CONSP_FIRE_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_MISC_UNIT2", value.OU1_FW_CONSP_MISC_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_TOTL_UNIT2", value.OU1_FW_CONSP_TOTL_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_GB_GP1", value.OU1_RW_CONSP_GB_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_GB_GP2", value.OU1_RW_CONSP_GB_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_DILUTION_GP1", value.OU1_RW_CONSP_DILUTION_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_DILUTION_GP2", value.OU1_RW_CONSP_DILUTION_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_GP1", value.OU1_FW_CONSP_DMP_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_GP2", value.OU1_FW_CONSP_DMP_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REGN_LOSS_DMP_GP1", value.OU1_REGN_LOSS_DMP_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REGN_LOSS_DMP_GP2", value.OU1_REGN_LOSS_DMP_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TC_IMPORTF_UNIT2_INT", value.OU1_TC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TC_IMPORTF_UNIT2", value.OU1_TC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SC_IMPORTF_UNIT2_INT", value.OU1_SC_IMPORTF_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SC_IMPORTF_UNIT2", value.OU1_SC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REGN_LOSS_MB_GP1", value.OU1_REGN_LOSS_MB_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REGN_LOSS_MB_GP2", value.OU1_REGN_LOSS_MB_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT4", value.OU1_FW_CONSP_DMP_INT4));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DMP_INT4_DIFF", value.OU1_FW_CONSP_DMP_INT4_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_MAKEUP_GPII", value.OU1_DMW_MAKEUP_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_BW_GPII", value.OU1_FW_CONSP_BW_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_BW_GPI", value.OU1_FW_CONSP_BW_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CONDENSATE_DRAINED_GPII", value.OU1_CONDENSATE_DRAINED_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CONDENSATE_DRAINED_GPI", value.OU1_CONDENSATE_DRAINED_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_MAKEUP_GPI", value.OU1_DMW_MAKEUP_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_RECPT_KSR_INT2", value.OU1_RW_RECPT_KSR_INT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_RECPT_KSR_INT2_DIFF", value.OU1_RW_RECPT_KSR_INT2_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TC_TFRT_PW_UNIT1", value.OU1_TC_TFRT_PW_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TC_TFRT_PW_UNIT2", value.OU1_TC_TFRT_PW_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_COND_EXPORTT_UNIT2", value.OU1_COND_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_COND_EXPORTT_UNIT1", value.OU1_COND_EXPORTT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_APC_PROD_INT_DIFF", value.OU1_APC_PROD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_MAKEUP_GPII_INT", value.OU1_DMW_MAKEUP_GPII_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_EXPORTT_UNIT2_TANK", value.OU1_PW_EXPORTT_UNIT2_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_EXPORTT_UNIT1_TANK", value.OU1_PW_EXPORTT_UNIT1_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_EXPORTT_GPII", value.OU1_PW_EXPORTT_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_PW_CONSP_UNIT1", value.OU1_TOTAL_PW_CONSP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_PW_CONSP_UNIT2", value.OU1_TOTAL_PW_CONSP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_FEED_UNIT1", value.OU1_PW_FEED_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_FEED_UNIT2", value.OU1_PW_FEED_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NET_COND_GPII", value.OU1_NET_COND_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_FEED_EXPORTT_UNIT1", value.OU1_PW_FEED_EXPORTT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_FEED_EXPORTT_UNIT2", value.OU1_PW_FEED_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TEMP_TANK_LEVEL", value.OU1_FW_TEMP_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TEMP_TANK_STOCK", value.OU1_FW_TEMP_TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TEMP_TANK_CONSP", value.OU1_FW_TEMP_TANK_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_EFFL_CONSP_ACT", value.OU1_EFFL_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WTR_CONSP_ACT", value.OU1_WTR_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_SW_GPIA", value.OU1_FW_CONSP_SW_GPIA));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FIRE_CONSP_UCT_GPI", value.OU1_FIRE_CONSP_UCT_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FIRE_CONSP_UCT_GPI_INT", value.OU1_FIRE_CONSP_UCT_GPI_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FIRE_CONSP_UCT_GPI_INT_DIFF", value.OU1_FIRE_CONSP_UCT_GPI_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_UCT_GPI", value.OU1_FW_CONSP_UCT_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_MEEFOG_INT", value.OU1_PW_CONSP_MEEFOG_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_MEEFOG", value.OU1_PW_CONSP_MEEFOG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_CONSP_SPG_WO_MEEFOG", value.OU1_PW_CONSP_SPG_WO_MEEFOG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_CONSP_WPT_INT_NEW", value.OU1_RW_CONSP_WPT_INT_NEW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_WPT_CONSP_INT_NEW_DIFF", value.OU1_RW_WPT_CONSP_INT_NEW_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_WPT_CONSP_OLD_INT", value.OU1_RW_WPT_CONSP_OLD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_WPT_CONSP_NEW_INT", value.OU1_RW_WPT_CONSP_NEW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_GP1_GP2_SINK", value.OU1_FW_GP1_GP2_SINK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_GP1_MEAS_ACT_MAKEUP", value.OU1_FW_GP1_MEAS_ACT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_GP2_MEAS_ACT_MAKEUP", value.OU1_FW_GP2_MEAS_ACT_MAKEUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_GP1_SINK", value.OU1_FW_GP1_SINK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_GPII_SINK", value.OU1_FW_GPII_SINK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_SSP", value.OU1_FW_CONSP_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_CONSP_DW_SSP", value.OU1_FW_CONSP_DW_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_EXPORTT_UNIT3", value.OU1_RW_EXPORTT_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_IMPORT_GP3", value.OU1_PW_IMPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_TANK3_STOCK", value.OU1_DMW_TANK3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_TANK4_STOCK", value.OU1_FW_TANK4_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WPT_3_CONS", value.OU1_WPT_3_CONS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SPG_CT_GP3", value.OU1_SPG_CT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_GP1_FEED_EXPORT_GP3", value.OU1_PW_GP1_FEED_EXPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FW_GP3_UE", value.OU1_FW_GP3_UE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_GP1_FEED_IMPORT_GP3", value.OU1_PW_GP1_FEED_IMPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WPT_TOTAL", value.OU1_WPT_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SW_GP3_UE", value.OU1_SW_GP3_UE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_GP2_FEED_EXPORT_GP3", value.OU1_PW_GP2_FEED_EXPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_GP1_IMPORT_GP3", value.OU1_PW_GP1_IMPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DW_GP3_UE", value.OU1_DW_GP3_UE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BACKWASH_WPT_GP3", value.OU1_BACKWASH_WPT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_GP1_EXPORT_GP3", value.OU1_PW_GP1_EXPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_TANK3_STOCK_GP3", value.OU1_PW_TANK3_STOCK_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_GP2_EXPORT_GP3", value.OU1_PW_GP2_EXPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMW_PROD_GP3", value.OU1_DMW_PROD_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PW_FEED_IMPORT_GP3", value.OU1_PW_FEED_IMPORT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_KST_32LINE_INT", value.OU1_RW_KST_32LINE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RW_KST_32LINE_INT_DIFF", value.OU1_RW_KST_32LINE_INT_DIFF));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
