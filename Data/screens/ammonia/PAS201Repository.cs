using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS201Repository
    {
        private readonly string _connectionString;
        public PAS201Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS201Model MapToValue(SqlDataReader reader)
        {
            return new PAS201Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_NG_TOT_AMM2_INT = (dynamic)reader["A2_NG_TOT_AMM2_INT"],
                A2_NG_TOT_AMM2_INT_DIFF = (dynamic)reader["A2_NG_TOT_AMM2_INT_DIFF"],
                A2_NG_TOT_CONSP_AMM2 = (dynamic)reader["A2_NG_TOT_CONSP_AMM2"],
                A2_PRS_NG_FUEL_AB_INT = (dynamic)reader["A2_PRS_NG_FUEL_AB_INT"],
                A2_PRS_NG_FUEL_AB_INT_DIFF = (dynamic)reader["A2_PRS_NG_FUEL_AB_INT_DIFF"],
                A2_TEMP_NG_FUEL_AB_INT = (dynamic)reader["A2_TEMP_NG_FUEL_AB_INT"],
                A2_TEMP_NG_FUEL_AB_INT_DIFF = (dynamic)reader["A2_TEMP_NG_FUEL_AB_INT_DIFF"],
                A2_NG_FUEL_AB_INT = (dynamic)reader["A2_NG_FUEL_AB_INT"],
                A2_NG_FUEL_AB_INT_DIFF = (dynamic)reader["A2_NG_FUEL_AB_INT_DIFF"],
                A2_NG_CONSP_AB = (dynamic)reader["A2_NG_CONSP_AB"],
                A2_NG_FEED_AMM2_INT = (dynamic)reader["A2_NG_FEED_AMM2_INT"],
                A2_NG_FEED_AMM2_INT_DIFF = (dynamic)reader["A2_NG_FEED_AMM2_INT_DIFF"],
                A2_NG_CONSP_FEED_AMM2 = (dynamic)reader["A2_NG_CONSP_FEED_AMM2"],
                A2_PRS_TOT_NG_FUEL_INT = (dynamic)reader["A2_PRS_TOT_NG_FUEL_INT"],
                A2_PRS_TOT_NG_FUEL_INT_DIFF = (dynamic)reader["A2_PRS_TOT_NG_FUEL_INT_DIFF"],
                A2_TEMP_TOT_NG_FUEL_INT = (dynamic)reader["A2_TEMP_TOT_NG_FUEL_INT"],
                A2_TEMP_TOT_NG_FUEL_INT_DIFF = (dynamic)reader["A2_TEMP_TOT_NG_FUEL_INT_DIFF"],
                A2_TOT_NG_FUEL_INT = (dynamic)reader["A2_TOT_NG_FUEL_INT"],
                A2_TOT_NG_FUEL_INT_DIFF = (dynamic)reader["A2_TOT_NG_FUEL_INT_DIFF"],
                A2_TOT_CONSP_NG_FUEL = (dynamic)reader["A2_TOT_CONSP_NG_FUEL"],
                A2_PRS_NG_SH_BURN_INT = (dynamic)reader["A2_PRS_NG_SH_BURN_INT"],
                A2_PRS_NG_SH_BURN_INT_DIFF = (dynamic)reader["A2_PRS_NG_SH_BURN_INT_DIFF"],
                A2_TEMP_NG_SH_BURN_INT = (dynamic)reader["A2_TEMP_NG_SH_BURN_INT"],
                A2_TEMP_NG_SH_BURN_INT_DIFF = (dynamic)reader["A2_TEMP_NG_SH_BURN_INT_DIFF"],
                A2_NG_FUEL_SH_BURN_INT = (dynamic)reader["A2_NG_FUEL_SH_BURN_INT"],
                A2_NG_FUEL_SH_BURN_INT_DIFF = (dynamic)reader["A2_NG_FUEL_SH_BURN_INT_DIFF"],
                A2_BAL_NG_FUEL_SH_BURNER = (dynamic)reader["A2_BAL_NG_FUEL_SH_BURNER"],
                A2_PRS_NG_FUEL_TBURNER_INT = (dynamic)reader["A2_PRS_NG_FUEL_TBURNER_INT"],
                A2_PRS_NG_FUEL_TBURNER_INT_DIFF = (dynamic)reader["A2_PRS_NG_FUEL_TBURNER_INT_DIFF"],
                A2_TEMP_NG_FUEL_TBURNER_INT = (dynamic)reader["A2_TEMP_NG_FUEL_TBURNER_INT"],
                A2_TEMP_NG_FUEL_TBURNER_INT_DIF = (dynamic)reader["A2_TEMP_NG_FUEL_TBURNER_INT_DIF"],
                A2_NG_FUEL_TBURNER_INT = (dynamic)reader["A2_NG_FUEL_TBURNER_INT"],
                A2_NG_FUEL_TBURNER_INT_DIFF = (dynamic)reader["A2_NG_FUEL_TBURNER_INT_DIFF"],
                A2_NG_FUEL_TBURNER = (dynamic)reader["A2_NG_FUEL_TBURNER"],
                A2_PRS_NG_FUEL_BA101_INT = (dynamic)reader["A2_PRS_NG_FUEL_BA101_INT"],
                A2_PRS_NG_FUEL_BA101_INT_DIFF = (dynamic)reader["A2_PRS_NG_FUEL_BA101_INT_DIFF"],
                A2_TEMP_NG_FUEL_BA101_INT = (dynamic)reader["A2_TEMP_NG_FUEL_BA101_INT"],
                A2_TEMP_NG_FUEL_BA101_INT_DIFF = (dynamic)reader["A2_TEMP_NG_FUEL_BA101_INT_DIFF"],
                A2_NG_FUEL_BA101_INT = (dynamic)reader["A2_NG_FUEL_BA101_INT"],
                A2_NG_FUEL_BA101_INT_DIFF = (dynamic)reader["A2_NG_FUEL_BA101_INT_DIFF"],
                A2_NG_FUEL_BA101 = (dynamic)reader["A2_NG_FUEL_BA101"],
                A2_PRS_NG_FUEL_BA102_INT = (dynamic)reader["A2_PRS_NG_FUEL_BA102_INT"],
                A2_PRS_NG_FUEL_BA102_INT_DIFF = (dynamic)reader["A2_PRS_NG_FUEL_BA102_INT_DIFF"],
                A2_TEMP_NG_FUEL_BA102_INT = (dynamic)reader["A2_TEMP_NG_FUEL_BA102_INT"],
                A2_TEMP_NG_FUEL_BA102_INT_DIFF = (dynamic)reader["A2_TEMP_NG_FUEL_BA102_INT_DIFF"],
                A2_NG_FUEL_BA102_INT = (dynamic)reader["A2_NG_FUEL_BA102_INT"],
                A2_NG_FUEL_BA102_INT_DIFF = (dynamic)reader["A2_NG_FUEL_BA102_INT_DIFF"],
                A2_NG_FUEL_BA102 = (dynamic)reader["A2_NG_FUEL_BA102"],
                A2_NG_FUEL_ABURNER = (dynamic)reader["A2_NG_FUEL_ABURNER"],
                A2_PRS_FUEL_FLARE_INT = (dynamic)reader["A2_PRS_FUEL_FLARE_INT"],
                A2_PRS_FUEL_FLARE_INT_DIFF = (dynamic)reader["A2_PRS_FUEL_FLARE_INT_DIFF"],
                A2_TEMP_FUEL_FLARE_INT = (dynamic)reader["A2_TEMP_FUEL_FLARE_INT"],
                A2_TEMP_FUEL_FLARE_INT_DIFF = (dynamic)reader["A2_TEMP_FUEL_FLARE_INT_DIFF"],
                A2_NG_FUEL_FLARE_INT = (dynamic)reader["A2_NG_FUEL_FLARE_INT"],
                A2_NG_FUEL_FLARE_INT_DIFF = (dynamic)reader["A2_NG_FUEL_FLARE_INT_DIFF"],
                A2_NG_FUEL_FLARE = (dynamic)reader["A2_NG_FUEL_FLARE"],
                A2_NG_EXPORTT_GP1_INT = (dynamic)reader["A2_NG_EXPORTT_GP1_INT"],
                A2_NG_EXPORTT_GP1_INT_DIFF = (dynamic)reader["A2_NG_EXPORTT_GP1_INT_DIFF"],
                A2_NG_EXPORTT_UNIT1_SSP = (dynamic)reader["A2_NG_EXPORTT_UNIT1_SSP"],
                A2_NG_SYNTH_GAS_INT = (dynamic)reader["A2_NG_SYNTH_GAS_INT"],
                A2_NG_SYNTH_GAS_INT_DIFF = (dynamic)reader["A2_NG_SYNTH_GAS_INT_DIFF"],
                A2_SYNTH_GAS_EXPTT_GP1_INT = (dynamic)reader["A2_SYNTH_GAS_EXPTT_GP1_INT"],
                A2_SYNTH_GAS_EXPTT_GP1_INT_DIFF = (dynamic)reader["A2_SYNTH_GAS_EXPTT_GP1_INT_DIFF"],
                A2_NG_EXPORTT_UNIT1 = (dynamic)reader["A2_NG_EXPORTT_UNIT1"],
                A2_NG_EXPORTT_SSP = (dynamic)reader["A2_NG_EXPORTT_SSP"],
                A2_RIL_SCH_ENG_GCV = (dynamic)reader["A2_RIL_SCH_ENG_GCV"],
                A2_GAIL_METER_ONLINE = reader["A2_GAIL_METER_ONLINE"].ToString(),
                A2_RIL_GAS_ENERGY_ACTL_GCV = (dynamic)reader["A2_RIL_GAS_ENERGY_ACTL_GCV"],
                A2_RIL_GAS_ENERGY = (dynamic)reader["A2_RIL_GAS_ENERGY"],
                A2_RIL_SCH_GAS = (dynamic)reader["A2_RIL_SCH_GAS"],
                A2_RIL_GAS_RECEIPT_ACTL_GCV = (dynamic)reader["A2_RIL_GAS_RECEIPT_ACTL_GCV"],
                A2_RIL_GAS_RECEIPT_ACTL_LCV = (dynamic)reader["A2_RIL_GAS_RECEIPT_ACTL_LCV"],
                A2_RLNG_SCH_ENG_GCV = (dynamic)reader["A2_RLNG_SCH_ENG_GCV"],
                A2_RLNG_GAS_ENERGY_ACTL_GCV = (dynamic)reader["A2_RLNG_GAS_ENERGY_ACTL_GCV"],
                A2_IOC_RLNG_ALLOCATION = (dynamic)reader["A2_IOC_RLNG_ALLOCATION"],
                A2_RLNG_IOC_RECEIPT = (dynamic)reader["A2_RLNG_IOC_RECEIPT"],
                A2_IOC_RLNG_RECEIPT = (dynamic)reader["A2_IOC_RLNG_RECEIPT"],
                A2_SG_IOCL_SCH_ENG_GCV = (dynamic)reader["A2_SG_IOCL_SCH_ENG_GCV"],
                A2_SG_IOCL_ENERGY_ACTL_GCV = (dynamic)reader["A2_SG_IOCL_ENERGY_ACTL_GCV"],
                A2_IOC_RLNG_LCV = (dynamic)reader["A2_IOC_RLNG_LCV"],
                A2_SPOTGAS_IOCL_ALLOC = (dynamic)reader["A2_SPOTGAS_IOCL_ALLOC"],
                A2_SPOTGAS_IOCL_RECEIPT = (dynamic)reader["A2_SPOTGAS_IOCL_RECEIPT"],
                A2_IOC_RLNG_GCV = (dynamic)reader["A2_IOC_RLNG_GCV"],
                A2_SG_GAIL_SCH_ENG_GCV = (dynamic)reader["A2_SG_GAIL_SCH_ENG_GCV"],
                A2_SG_GAIL_ENERGY_ACTL_GCV = (dynamic)reader["A2_SG_GAIL_ENERGY_ACTL_GCV"],
                A2_MOL_WT_NG = (dynamic)reader["A2_MOL_WT_NG"],
                A2_SPOTGAS_GAIL_ALLOC = (dynamic)reader["A2_SPOTGAS_GAIL_ALLOC"],
                A2_SPOTGAS_GAIL_RECEIPT = (dynamic)reader["A2_SPOTGAS_GAIL_RECEIPT"],
                A2_NG_CARBON_NO = (dynamic)reader["A2_NG_CARBON_NO"],
                A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV = (dynamic)reader["A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV"],
                A2_GAIL_LT_RLNG_RE_ENG_ACT_GCV = (dynamic)reader["A2_GAIL_LT_RLNG_RE_ENG_ACT_GCV"],
                A2_NG_LIMITATION_FLG = reader["A2_NG_LIMITATION_FLG"].ToString(),
                A2_GAIL_LT_RLNG_RE_ALLOC = (dynamic)reader["A2_GAIL_LT_RLNG_RE_ALLOC"],
                A2_GAIL_LT_RLNG_RE_RECEIPT = (dynamic)reader["A2_GAIL_LT_RLNG_RE_RECEIPT"],
                A2_SG_GSPC_SCH_ENG_GCV = (dynamic)reader["A2_SG_GSPC_SCH_ENG_GCV"],
                A2_SPOTGAS_GSPC_ALLOC = (dynamic)reader["A2_SPOTGAS_GSPC_ALLOC"],
                A2_SPOTGAS_GSPC_RECEIPT = (dynamic)reader["A2_SPOTGAS_GSPC_RECEIPT"],
                A2_SG_GSPC_ENERGY_ACTL_GCV = (dynamic)reader["A2_SG_GSPC_ENERGY_ACTL_GCV"],
                A2_NG_IMPORTF_UNIT1 = (dynamic)reader["A2_NG_IMPORTF_UNIT1"],
                A2_SG_OTH_SCH_ENG_GCV = (dynamic)reader["A2_SG_OTH_SCH_ENG_GCV"],
                A2_SG_OTH_ENERGY_ACTL_GCV = (dynamic)reader["A2_SG_OTH_ENERGY_ACTL_GCV"],
                A2_NG_FEED_BYBAL_TO_AMM2 = (dynamic)reader["A2_NG_FEED_BYBAL_TO_AMM2"],
                A2_SPOTGAS_OTH_ALLOC = (dynamic)reader["A2_SPOTGAS_OTH_ALLOC"],
                A2_SPOTGAS_OTH_RECEIPT = (dynamic)reader["A2_SPOTGAS_OTH_RECEIPT"],
                A2_RLNG_EXPORTT_SSP = (dynamic)reader["A2_RLNG_EXPORTT_SSP"],
                A2_GAIL_RLNG5_SCH_ENG_GCV = (dynamic)reader["A2_GAIL_RLNG5_SCH_ENG_GCV"],
                A2_GAIL_RLNG5_ENG_ACTL_GCV = (dynamic)reader["A2_GAIL_RLNG5_ENG_ACTL_GCV"],
                A2_SPOT_EXPORTT_SSP = (dynamic)reader["A2_SPOT_EXPORTT_SSP"],
                A2_GAIL_RLNG5_SCH_GAS = (dynamic)reader["A2_GAIL_RLNG5_SCH_GAS"],
                A2_GAIL_RLNG5_RECEIPT_ACTL_GCV = (dynamic)reader["A2_GAIL_RLNG5_RECEIPT_ACTL_GCV"],
                A2_GAIL_RLNG19_SCH_ENG_GCV = (dynamic)reader["A2_GAIL_RLNG19_SCH_ENG_GCV"],
                A2_GAIL_RLNG19_ENG_ACTL_GCV = (dynamic)reader["A2_GAIL_RLNG19_ENG_ACTL_GCV"],
                A2_GAIL_RLNG19_SCH_GAS = (dynamic)reader["A2_GAIL_RLNG19_SCH_GAS"],
                A2_GAIL_RLNG19_RECEIPT_ACTL_GCV = (dynamic)reader["A2_GAIL_RLNG19_RECEIPT_ACTL_GCV"],
                a_ng_importf_unit1 = (dynamic)reader["a_ng_importf_unit1"],

                // -------- GAS ALLOC PRIORITY-------------------
                A2_RIL_SCH_ENG_GCV_PRIORITY = reader["A2_RIL_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_RLNG_SCH_ENG_GCV_PRIORITY = reader["A2_RLNG_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_SG_IOCL_SCH_ENG_GCV_PRIORITY = reader["A2_SG_IOCL_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_SG_GAIL_SCH_ENG_GCV_PRIORITY = reader["A2_SG_GAIL_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV_PRIORITY = reader["A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_SG_GSPC_SCH_ENG_GCV_PRIORITY = reader["A2_SG_GSPC_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_SG_OTH_SCH_ENG_GCV_PRIORITY = reader["A2_SG_OTH_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_GAIL_RLNG5_SCH_ENG_GCV_PRIORITY = reader["A2_GAIL_RLNG5_SCH_ENG_GCV_PRIORITY"].ToString(),
                A2_GAIL_RLNG19_SCH_ENG_GCV_PRIORITY = reader["A2_GAIL_RLNG19_SCH_ENG_GCV_PRIORITY"].ToString(),

                PRIORITY_TAG1 = reader["PRIORITY_TAG1"].ToString(),
                PRIORITY_TAG2 = reader["PRIORITY_TAG2"].ToString(),
                PRIORITY_TAG3 = reader["PRIORITY_TAG3"].ToString(),
                PRIORITY_TAG4 = reader["PRIORITY_TAG4"].ToString(),
                PRIORITY_TAG5 = reader["PRIORITY_TAG5"].ToString(),
                PRIORITY_TAG6 = reader["PRIORITY_TAG6"].ToString(),
                PRIORITY_TAG7 = reader["PRIORITY_TAG7"].ToString(),
                PRIORITY_TAG8 = reader["PRIORITY_TAG8"].ToString(),
                PRIORITY_TAG9 = reader["PRIORITY_TAG9"].ToString(),

                // PRV
                PRV_A2_TRANS_DATE = (dynamic)reader["PRV_A2_TRANS_DATE"],
                PRV_A2_NG_TOT_AMM2_INT = (dynamic)reader["PRV_A2_NG_TOT_AMM2_INT"],
                PRV_A2_NG_TOT_AMM2_INT_DIFF = (dynamic)reader["PRV_A2_NG_TOT_AMM2_INT_DIFF"],
                PRV_A2_NG_TOT_CONSP_AMM2 = (dynamic)reader["PRV_A2_NG_TOT_CONSP_AMM2"],
                PRV_A2_PRS_NG_FUEL_AB_INT = (dynamic)reader["PRV_A2_PRS_NG_FUEL_AB_INT"],
                PRV_A2_PRS_NG_FUEL_AB_INT_DIFF = (dynamic)reader["PRV_A2_PRS_NG_FUEL_AB_INT_DIFF"],
                PRV_A2_TEMP_NG_FUEL_AB_INT = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_AB_INT"],
                PRV_A2_TEMP_NG_FUEL_AB_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_AB_INT_DIFF"],
                PRV_A2_NG_FUEL_AB_INT = (dynamic)reader["PRV_A2_NG_FUEL_AB_INT"],
                PRV_A2_NG_FUEL_AB_INT_DIFF = (dynamic)reader["PRV_A2_NG_FUEL_AB_INT_DIFF"],
                PRV_A2_NG_CONSP_AB = (dynamic)reader["PRV_A2_NG_CONSP_AB"],
                PRV_A2_NG_FEED_AMM2_INT = (dynamic)reader["PRV_A2_NG_FEED_AMM2_INT"],
                PRV_A2_NG_FEED_AMM2_INT_DIFF = (dynamic)reader["PRV_A2_NG_FEED_AMM2_INT_DIFF"],
                PRV_A2_NG_CONSP_FEED_AMM2 = (dynamic)reader["PRV_A2_NG_CONSP_FEED_AMM2"],
                PRV_A2_PRS_TOT_NG_FUEL_INT = (dynamic)reader["PRV_A2_PRS_TOT_NG_FUEL_INT"],
                PRV_A2_PRS_TOT_NG_FUEL_INT_DIFF = (dynamic)reader["PRV_A2_PRS_TOT_NG_FUEL_INT_DIFF"],
                PRV_A2_TEMP_TOT_NG_FUEL_INT = (dynamic)reader["PRV_A2_TEMP_TOT_NG_FUEL_INT"],
                PRV_A2_TEMP_TOT_NG_FUEL_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_TOT_NG_FUEL_INT_DIFF"],
                PRV_A2_TOT_NG_FUEL_INT = (dynamic)reader["PRV_A2_TOT_NG_FUEL_INT"],
                PRV_A2_TOT_NG_FUEL_INT_DIFF = (dynamic)reader["PRV_A2_TOT_NG_FUEL_INT_DIFF"],
                PRV_A2_TOT_CONSP_NG_FUEL = (dynamic)reader["PRV_A2_TOT_CONSP_NG_FUEL"],
                PRV_A2_PRS_NG_SH_BURN_INT = (dynamic)reader["PRV_A2_PRS_NG_SH_BURN_INT"],
                PRV_A2_PRS_NG_SH_BURN_INT_DIFF = (dynamic)reader["PRV_A2_PRS_NG_SH_BURN_INT_DIFF"],
                PRV_A2_TEMP_NG_SH_BURN_INT = (dynamic)reader["PRV_A2_TEMP_NG_SH_BURN_INT"],
                PRV_A2_TEMP_NG_SH_BURN_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_NG_SH_BURN_INT_DIFF"],
                PRV_A2_NG_FUEL_SH_BURN_INT = (dynamic)reader["PRV_A2_NG_FUEL_SH_BURN_INT"],
                PRV_A2_NG_FUEL_SH_BURN_INT_DIFF = (dynamic)reader["PRV_A2_NG_FUEL_SH_BURN_INT_DIFF"],
                PRV_A2_BAL_NG_FUEL_SH_BURNER = (dynamic)reader["PRV_A2_BAL_NG_FUEL_SH_BURNER"],
                PRV_A2_PRS_NG_FUEL_TBURNER_INT = (dynamic)reader["PRV_A2_PRS_NG_FUEL_TBURNER_INT"],
                PRV_A2_PRS_NG_FUEL_TBURNER_INT_DIFF = (dynamic)reader["PRV_A2_PRS_NG_FUEL_TBURNER_INT_DIFF"],
                PRV_A2_TEMP_NG_FUEL_TBURNER_INT = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_TBURNER_INT"],
                PRV_A2_TEMP_NG_FUEL_TBURNER_INT_DIF = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_TBURNER_INT_DIF"],
                PRV_A2_NG_FUEL_TBURNER_INT = (dynamic)reader["PRV_A2_NG_FUEL_TBURNER_INT"],
                PRV_A2_NG_FUEL_TBURNER_INT_DIFF = (dynamic)reader["PRV_A2_NG_FUEL_TBURNER_INT_DIFF"],
                PRV_A2_NG_FUEL_TBURNER = (dynamic)reader["PRV_A2_NG_FUEL_TBURNER"],
                PRV_A2_PRS_NG_FUEL_BA101_INT = (dynamic)reader["PRV_A2_PRS_NG_FUEL_BA101_INT"],
                PRV_A2_PRS_NG_FUEL_BA101_INT_DIFF = (dynamic)reader["PRV_A2_PRS_NG_FUEL_BA101_INT_DIFF"],
                PRV_A2_TEMP_NG_FUEL_BA101_INT = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_BA101_INT"],
                PRV_A2_TEMP_NG_FUEL_BA101_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_BA101_INT_DIFF"],
                PRV_A2_NG_FUEL_BA101_INT = (dynamic)reader["PRV_A2_NG_FUEL_BA101_INT"],
                PRV_A2_NG_FUEL_BA101_INT_DIFF = (dynamic)reader["PRV_A2_NG_FUEL_BA101_INT_DIFF"],
                PRV_A2_NG_FUEL_BA101 = (dynamic)reader["PRV_A2_NG_FUEL_BA101"],
                PRV_A2_PRS_NG_FUEL_BA102_INT = (dynamic)reader["PRV_A2_PRS_NG_FUEL_BA102_INT"],
                PRV_A2_PRS_NG_FUEL_BA102_INT_DIFF = (dynamic)reader["PRV_A2_PRS_NG_FUEL_BA102_INT_DIFF"],
                PRV_A2_TEMP_NG_FUEL_BA102_INT = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_BA102_INT"],
                PRV_A2_TEMP_NG_FUEL_BA102_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_NG_FUEL_BA102_INT_DIFF"],
                PRV_A2_NG_FUEL_BA102_INT = (dynamic)reader["PRV_A2_NG_FUEL_BA102_INT"],
                PRV_A2_NG_FUEL_BA102_INT_DIFF = (dynamic)reader["PRV_A2_NG_FUEL_BA102_INT_DIFF"],
                PRV_A2_NG_FUEL_BA102 = (dynamic)reader["PRV_A2_NG_FUEL_BA102"],
                PRV_A2_NG_FUEL_ABURNER = (dynamic)reader["PRV_A2_NG_FUEL_ABURNER"],
                PRV_A2_PRS_FUEL_FLARE_INT = (dynamic)reader["PRV_A2_PRS_FUEL_FLARE_INT"],
                PRV_A2_PRS_FUEL_FLARE_INT_DIFF = (dynamic)reader["PRV_A2_PRS_FUEL_FLARE_INT_DIFF"],
                PRV_A2_TEMP_FUEL_FLARE_INT = (dynamic)reader["PRV_A2_TEMP_FUEL_FLARE_INT"],
                PRV_A2_TEMP_FUEL_FLARE_INT_DIFF = (dynamic)reader["PRV_A2_TEMP_FUEL_FLARE_INT_DIFF"],
                PRV_A2_NG_FUEL_FLARE_INT = (dynamic)reader["PRV_A2_NG_FUEL_FLARE_INT"],
                PRV_A2_NG_FUEL_FLARE_INT_DIFF = (dynamic)reader["PRV_A2_NG_FUEL_FLARE_INT_DIFF"],
                PRV_A2_NG_FUEL_FLARE = (dynamic)reader["PRV_A2_NG_FUEL_FLARE"],
                PRV_A2_NG_EXPORTT_GP1_INT = (dynamic)reader["PRV_A2_NG_EXPORTT_GP1_INT"],
                PRV_A2_NG_EXPORTT_GP1_INT_DIFF = (dynamic)reader["PRV_A2_NG_EXPORTT_GP1_INT_DIFF"],
                PRV_A2_NG_EXPORTT_UNIT1_SSP = (dynamic)reader["PRV_A2_NG_EXPORTT_UNIT1_SSP"],
                PRV_A2_NG_SYNTH_GAS_INT = (dynamic)reader["PRV_A2_NG_SYNTH_GAS_INT"],
                PRV_A2_NG_SYNTH_GAS_INT_DIFF = (dynamic)reader["PRV_A2_NG_SYNTH_GAS_INT_DIFF"],
                PRV_A2_SYNTH_GAS_EXPTT_GP1_INT = (dynamic)reader["PRV_A2_SYNTH_GAS_EXPTT_GP1_INT"],
                PRV_A2_SYNTH_GAS_EXPTT_GP1_INT_DIFF = (dynamic)reader["PRV_A2_SYNTH_GAS_EXPTT_GP1_INT_DIFF"],
                PRV_A2_NG_EXPORTT_UNIT1 = (dynamic)reader["PRV_A2_NG_EXPORTT_UNIT1"],
                PRV_A2_NG_EXPORTT_SSP = (dynamic)reader["PRV_A2_NG_EXPORTT_SSP"],
                PRV_A2_RIL_SCH_ENG_GCV = (dynamic)reader["PRV_A2_RIL_SCH_ENG_GCV"],
                PRV_A2_GAIL_METER_ONLINE = reader["PRV_A2_GAIL_METER_ONLINE"].ToString(),
                PRV_A2_RIL_SCH_GAS = (dynamic)reader["PRV_A2_RIL_SCH_GAS"],
                PRV_A2_RLNG_SCH_ENG_GCV = (dynamic)reader["PRV_A2_RLNG_SCH_ENG_GCV"],
                PRV_A2_IOC_RLNG_ALLOCATION = (dynamic)reader["PRV_A2_IOC_RLNG_ALLOCATION"],
                PRV_A2_RLNG_IOC_RECEIPT = (dynamic)reader["PRV_A2_RLNG_IOC_RECEIPT"],
                PRV_A2_IOC_RLNG_RECEIPT = (dynamic)reader["PRV_A2_IOC_RLNG_RECEIPT"],
                PRV_A2_SG_IOCL_SCH_ENG_GCV = (dynamic)reader["PRV_A2_SG_IOCL_SCH_ENG_GCV"],
                PRV_A2_IOC_RLNG_LCV = (dynamic)reader["PRV_A2_IOC_RLNG_LCV"],
                PRV_A2_SPOTGAS_IOCL_RECEIPT = (dynamic)reader["PRV_A2_SPOTGAS_IOCL_RECEIPT"],
                PRV_A2_IOC_RLNG_GCV = (dynamic)reader["PRV_A2_IOC_RLNG_GCV"],
                PRV_A2_SG_GAIL_SCH_ENG_GCV = (dynamic)reader["PRV_A2_SG_GAIL_SCH_ENG_GCV"],
                PRV_A2_MOL_WT_NG = (dynamic)reader["PRV_A2_MOL_WT_NG"],
                PRV_A2_SPOTGAS_GAIL_RECEIPT = (dynamic)reader["PRV_A2_SPOTGAS_GAIL_RECEIPT"],
                PRV_A2_NG_CARBON_NO = (dynamic)reader["PRV_A2_NG_CARBON_NO"],
                PRV_A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV = (dynamic)reader["PRV_A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV"],
                PRV_A2_NG_LIMITATION_FLG = reader["PRV_A2_NG_LIMITATION_FLG"].ToString(),
                PRV_A2_GAIL_LT_RLNG_RE_RECEIPT = (dynamic)reader["PRV_A2_GAIL_LT_RLNG_RE_RECEIPT"],
                PRV_A2_SG_GSPC_SCH_ENG_GCV = (dynamic)reader["PRV_A2_SG_GSPC_SCH_ENG_GCV"],
                PRV_A2_SG_OTH_SCH_ENG_GCV = (dynamic)reader["PRV_A2_SG_OTH_SCH_ENG_GCV"],
                PRV_A2_SPOTGAS_OTH_RECEIPT = (dynamic)reader["PRV_A2_SPOTGAS_OTH_RECEIPT"],
                PRV_A2_GAIL_RLNG5_SCH_ENG_GCV = (dynamic)reader["PRV_A2_GAIL_RLNG5_SCH_ENG_GCV"],
                PRV_A2_GAIL_RLNG5_RECEIPT_ACTL_GCV = (dynamic)reader["PRV_A2_GAIL_RLNG5_RECEIPT_ACTL_GCV"],
                PRV_A2_GAIL_RLNG19_SCH_ENG_GCV = (dynamic)reader["PRV_A2_GAIL_RLNG19_SCH_ENG_GCV"],
                PRV_A2_GAIL_RLNG19_RECEIPT_ACTL_GCV = (dynamic)reader["PRV_A2_GAIL_RLNG19_RECEIPT_ACTL_GCV"],

                // DV
                G_CF_NM3_SM3 = (dynamic)reader["G_CF_NM3_SM3"],
                G_K_NG_FEED_REFMR = (dynamic)reader["G_K_NG_FEED_REFMR"],
                G_KE = (dynamic)reader["G_KE"],
                G_MF_NG_FLOW_TO_AMM2 = (dynamic)reader["G_MF_NG_FLOW_TO_AMM2"],
                G_MF_NG_FUEL_TO_AB = (dynamic)reader["G_MF_NG_FUEL_TO_AB"],
                G_MF_NG_TOTAL_FUEL = (dynamic)reader["G_MF_NG_TOTAL_FUEL"],
                G_DSGND_PRESSURE_CONST_NG = (dynamic)reader["G_DSGND_PRESSURE_CONST_NG"],
                G_DSGND_TEMP_CONST_NG = (dynamic)reader["G_DSGND_TEMP_CONST_NG"],
                G_MF_NG_FUEL_TO_SUPER_HEATER = (dynamic)reader["G_MF_NG_FUEL_TO_SUPER_HEATER"],
                G_MF_NG_FUEL_TO_TUNNEL_BURNER = (dynamic)reader["G_MF_NG_FUEL_TO_TUNNEL_BURNER"],
                G_MF_NG_FUEL_TO_BA101 = (dynamic)reader["G_MF_NG_FUEL_TO_BA101"],
                G_MF_NG_FUEL_TO_BA102 = (dynamic)reader["G_MF_NG_FUEL_TO_BA102"],
                G_MF_NG_FLARE = (dynamic)reader["G_MF_NG_FLARE"],
                G_MW_NG_DSGN = (dynamic)reader["G_MW_NG_DSGN"],
                G_MF_NG_FEED_TO_AMM2 = (dynamic)reader["G_MF_NG_FEED_TO_AMM2"]
            };
        }

        public async Task<PAS201Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_NG_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS201Model response = null;
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

        public async Task saveData(PAS201SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_NG_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_TOT_AMM2_INT", value.A2_NG_TOT_AMM2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_TOT_AMM2_INT_DIFF", value.A2_NG_TOT_AMM2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_TOT_CONSP_AMM2", value.A2_CF_NG_TOT_CONSP_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_TOT_CONSP_AMM2", value.A2_NG_TOT_CONSP_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BAL_NG_TOT_CONSP_AMM2", value.A2_BAL_NG_TOT_CONSP_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_AB_INT", value.A2_PRS_NG_FUEL_AB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_AB_INT_DIFF", value.A2_PRS_NG_FUEL_AB_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_AB_INT", value.A2_TEMP_NG_FUEL_AB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_AB_INT_DIFF  ", value.A2_TEMP_NG_FUEL_AB_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_AB_INT", value.A2_NG_FUEL_AB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_AB_INT_DIFF", value.A2_NG_FUEL_AB_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_CONSP_AB", value.A2_CF_NG_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_CONSP_AB", value.A2_NG_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FEED_AMM2_INT", value.A2_NG_FEED_AMM2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FEED_AMM2_INT_DIFF", value.A2_NG_FEED_AMM2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_FEED_AMM2", value.A2_CF_NG_FEED_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_CONSP_FEED_AMM2", value.A2_NG_CONSP_FEED_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_ABURNER_INT", value.A2_PRS_NG_FUEL_ABURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_ABURNER_INT_DIFF", value.A2_PRS_NG_FUEL_ABURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_ABURNER_INT", value.A2_TEMP_NG_FUEL_ABURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_ABURNER_INT_DIF", value.A2_TEMP_NG_FUEL_ABURNER_INT_DIF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_ABURNER_INT", value.A2_NG_FUEL_ABURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_ABURNER_INT_DIFF", value.A2_NG_FUEL_ABURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_FUEL_ABURNER", value.A2_CF_NG_FUEL_ABURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_ABURNER", value.A2_NG_FUEL_ABURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_TBURNER_INT", value.A2_PRS_NG_FUEL_TBURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_TBURNER_INT_DIFF", value.A2_PRS_NG_FUEL_TBURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_TBURNER_INT", value.A2_TEMP_NG_FUEL_TBURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_TBURNER_INT_DIF", value.A2_TEMP_NG_FUEL_TBURNER_INT_DIF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_TBURNER_INT", value.A2_NG_FUEL_TBURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_TBURNER_INT_DIFF", value.A2_NG_FUEL_TBURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_FUEL_TBURNER", value.A2_CF_NG_FUEL_TBURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_TBURNER", value.A2_NG_FUEL_TBURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_BA101_INT", value.A2_PRS_NG_FUEL_BA101_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_BA101_INT_DIFF", value.A2_PRS_NG_FUEL_BA101_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_BA101_INT", value.A2_TEMP_NG_FUEL_BA101_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_BA101_INT_DIFF", value.A2_TEMP_NG_FUEL_BA101_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_BA101_INT", value.A2_NG_FUEL_BA101_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_BA101_INT_DIFF", value.A2_NG_FUEL_BA101_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_FUEL_BA101", value.A2_CF_NG_FUEL_BA101));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_BA101", value.A2_NG_FUEL_BA101));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_BA102_INT", value.A2_PRS_NG_FUEL_BA102_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_FUEL_BA102_INT_DIFF", value.A2_PRS_NG_FUEL_BA102_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_BA102_INT", value.A2_TEMP_NG_FUEL_BA102_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_FUEL_BA102_INT_DIFF", value.A2_TEMP_NG_FUEL_BA102_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_BA102_INT", value.A2_NG_FUEL_BA102_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_BA102_INT_DIFF", value.A2_NG_FUEL_BA102_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_FUEL_BA102", value.A2_CF_NG_FUEL_BA102));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_BA102", value.A2_NG_FUEL_BA102));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BAL_NG_FUEL_SH_BURNER", value.A2_BAL_NG_FUEL_SH_BURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_GAIL_RECPT", value.A2_NG_GAIL_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_ALLOCATION", value.A2_NG_ALLOCATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_NET_CV", value.A2_NG_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_LIMITATION_FLG", value.A2_NG_LIMITATION_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MOL_WT_NG", value.A2_MOL_WT_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_CARBON_NO", value.A2_NG_CARBON_NO));
                    //  cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_SH_BURN_INT", value.A2_NG_FUEL_SH_BURN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_SH_BURN_INT_DIFF", value.A2_NG_FUEL_SH_BURN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_SH_BURN_INT", value.A2_PRS_NG_SH_BURN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_SH_BURN_INT_DIFF", value.A2_PRS_NG_SH_BURN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_SH_BURN_INT", value.A2_TEMP_NG_SH_BURN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_SH_BURN_INT_DIFF", value.A2_TEMP_NG_SH_BURN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_NG_FUEL_INT", value.A2_TOT_NG_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_NG_FUEL_INT_DIFF", value.A2_TOT_NG_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_CONSP_NG_FUEL", value.A2_TOT_CONSP_NG_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_FUEL_SH_BURN", value.A2_CF_NG_FUEL_SH_BURN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_SYNTH_GAS_INT", value.A2_NG_SYNTH_GAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_SYNTH_GAS_INT_DIFF", value.A2_NG_SYNTH_GAS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_TOT_NG_FUEL_INT", value.A2_PRS_TOT_NG_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_TOT_NG_FUEL_INT_DIFF", value.A2_PRS_TOT_NG_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_TOT_NG_FUEL_INT", value.A2_TEMP_TOT_NG_FUEL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_TOT_NG_FUEL_INT_DIFF", value.A2_TEMP_TOT_NG_FUEL_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_TOT_NG_FUEL", value.A2_CF_TOT_NG_FUEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_IMPORTF_UNIT1", value.A2_NG_IMPORTF_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_EXPORTT_UNIT1", value.A2_NG_EXPORTT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_FLARE_INT", value.A2_NG_FUEL_FLARE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_FLARE_INT_DIFF", value.A2_NG_FUEL_FLARE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_FUEL_FLARE_INT", value.A2_PRS_FUEL_FLARE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_FUEL_FLARE_INT_DIFF", value.A2_PRS_FUEL_FLARE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_FUEL_FLARE_INT", value.A2_TEMP_FUEL_FLARE_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_FUEL_FLARE_INT_DIFF", value.A2_TEMP_FUEL_FLARE_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_FUEL_FLARE", value.A2_CF_FUEL_FLARE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FUEL_FLARE", value.A2_NG_FUEL_FLARE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNTH_GAS_EXPTT_GP2_INT_DIFF", value.A2_SYNTH_GAS_EXPTT_GP2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNTH_GAS_EXPTT_GP2_INT", value.A2_SYNTH_GAS_EXPTT_GP2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNTH_GAS_EXPTT_GP1_INT_DIFF", value.A2_SYNTH_GAS_EXPTT_GP1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNTH_GAS_EXPTT_GP1_INT", value.A2_SYNTH_GAS_EXPTT_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IOC_RLNG_ALLOCATION", value.A2_IOC_RLNG_ALLOCATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IOC_RLNG_RECEIPT", value.A2_IOC_RLNG_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IOC_RLNG_GCV", value.A2_IOC_RLNG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IOC_RLNG_LCV", value.A2_IOC_RLNG_LCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_TRANSFER_INT", value.A2_PRS_NG_TRANSFER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PRS_NG_TRANSFER_INT_DIFF", value.A2_PRS_NG_TRANSFER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_TRANSFER_INT", value.A2_TEMP_NG_TRANSFER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TEMP_NG_TRANSFER_INT_DIFF", value.A2_TEMP_NG_TRANSFER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_EXPORTT_GP1_INT", value.A2_NG_EXPORTT_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_EXPORTT_GP1_INT_DIFF", value.A2_NG_EXPORTT_GP1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_IMPORTF_GP1_INT", value.A2_NG_IMPORTF_GP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_IMPORTF_GP1_INT_DIFF", value.A2_NG_IMPORTF_GP1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_FEED_BYBAL_TO_AMM2", value.A2_NG_FEED_BYBAL_TO_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CF_NG_TRANSFER", value.A2_CF_NG_TRANSFER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RLNG_ALLOC_ACTL_LCV", value.A2_RLNG_ALLOC_ACTL_LCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_IOCL_ALLOC", value.A2_SPOTGAS_IOCL_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_IOCL_RECEIPT", value.A2_SPOTGAS_IOCL_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_OTH_ALLOC", value.A2_SPOTGAS_OTH_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_OTH_RECEIPT", value.A2_SPOTGAS_OTH_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RLNG_IOC_RECEIPT", value.A2_RLNG_IOC_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_GAIL_ALLOC", value.A2_SPOTGAS_GAIL_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_GAIL_RECEIPT", value.A2_SPOTGAS_GAIL_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_GSPC_ALLOC", value.A2_SPOTGAS_GSPC_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOTGAS_GSPC_RECEIPT", value.A2_SPOTGAS_GSPC_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_GAS_ALLOC", value.A2_RIL_GAS_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_GAS_RECEIPT_ACTL_LCV", value.A2_RIL_GAS_RECEIPT_ACTL_LCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_GAS_ENERGY", value.A2_RIL_GAS_ENERGY));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_GAS_RECEIPT_ACTL_GCV", value.A2_RIL_GAS_RECEIPT_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_GAS_ENERGY_ACTL_GCV", value.A2_RIL_GAS_ENERGY_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_SCH_ENG_GCV", value.A2_RIL_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_SCH_GAS", value.A2_RIL_SCH_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RLNG_SCH_ENG_GCV", value.A2_RLNG_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RLNG_GAS_ENERGY_ACTL_GCV", value.A2_RLNG_GAS_ENERGY_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_IOCL_SCH_ENG_GCV", value.A2_SG_IOCL_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_IOCL_ENERGY_ACTL_GCV", value.A2_SG_IOCL_ENERGY_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_GAIL_SCH_ENG_GCV", value.A2_SG_GAIL_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_GAIL_ENERGY_ACTL_GCV", value.A2_SG_GAIL_ENERGY_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_GSPC_SCH_ENG_GCV", value.A2_SG_GSPC_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_GSPC_ENERGY_ACTL_GCV", value.A2_SG_GSPC_ENERGY_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_OTH_SCH_ENG_GCV", value.A2_SG_OTH_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SG_OTH_ENERGY_ACTL_GCV", value.A2_SG_OTH_ENERGY_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_EXPORTT_SSP", value.A2_NG_EXPORTT_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NG_EXPORTT_UNIT1_SSP", value.A2_NG_EXPORTT_UNIT1_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RLNG_EXPORTT_SSP", value.A2_RLNG_EXPORTT_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOT_EXPORTT_SSP", value.A2_SPOT_EXPORTT_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_METER_ONLINE", value.A2_GAIL_METER_ONLINE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_GAS_EXPORTT_UNIT1", value.A2_RIL_GAS_EXPORTT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IOCL_RLNG_EXPORTT_UNIT1", value.A2_IOCL_RLNG_EXPORTT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SPOT_RLNG_EXPORTT_UNIT1", value.A2_SPOT_RLNG_EXPORTT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_LT_RLNG_RE_ALLOC", value.A2_GAIL_LT_RLNG_RE_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_LT_RLNG_RE_RECEIPT", value.A2_GAIL_LT_RLNG_RE_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV", value.A2_GAIL_LT_RLNG_RE_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_LT_RLNG_RE_ENG_ACT_GCV", value.A2_GAIL_LT_RLNG_RE_ENG_ACT_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG5_SCH_ENG_GCV", value.A2_GAIL_RLNG5_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG5_ENG_ACTL_GCV", value.A2_GAIL_RLNG5_ENG_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG5_SCH_GAS", value.A2_GAIL_RLNG5_SCH_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG5_RECEIPT_ACTL_GCV", value.A2_GAIL_RLNG5_RECEIPT_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG19_SCH_ENG_GCV", value.A2_GAIL_RLNG19_SCH_ENG_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG19_ENG_ACTL_GCV", value.A2_GAIL_RLNG19_ENG_ACTL_GCV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG19_SCH_GAS", value.A2_GAIL_RLNG19_SCH_GAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_RLNG19_RECEIPT_ACTL_GCV", value.A2_GAIL_RLNG19_RECEIPT_ACTL_GCV));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
